using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortGenerator
{
    public partial class frmSignUp : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PasswordGenerator;Integrated Security=True;Pooling=False");
        int counter = 0;

        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
            {
                conn.Open();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (signUpUserName.Text != string.Empty && signUpPassword.Text != string.Empty && signUpPasswordAgain.Text != string.Empty)
            {
                if (signUpPassword.Text == signUpPasswordAgain.Text)
                {
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM person WHERE username = '" + signUpUserName.Text + "'";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    counter = Convert.ToInt32(dt.Rows.Count.ToString()); 
                    if(counter == 0)
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "INSERT INTO person (username, password, passwordagain) VALUES ('" + signUpUserName.Text + "', '" + signUpPassword.Text + "', '" + signUpPasswordAgain.Text + "')"; ;
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Username already exist. Please choose another one.");
                    }
                }
                
            else
            {
                MessageBox.Show("The passwords are not the same");
            }
        }
            else
            {
                MessageBox.Show("Please enter value in all field");
            }

            

        }
    }
}
