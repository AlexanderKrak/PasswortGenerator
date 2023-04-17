using Microsoft.Data.SqlClient;
using System.Data;

namespace PasswortGenerator
{
    public partial class FrmLogin : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PasswordGenerator;Integrated Security=True;Pooling=False");
        int counter = 0;

        public FrmLogin()
        {
            InitializeComponent();
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.FlatAppearance.BorderSize = 0;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if(conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM person WHERE username = '" + txtUserName.Text + "' AND password = '" + txtPassword.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                counter = Convert.ToInt32(dt.Rows.Count.ToString());
                if (counter == 0)
                {
                    MessageBox.Show("username and password does not match");
                }
                else
                {
                    this.Hide();
                    frmGenerator generator = new frmGenerator();
                    generator.Show();
                }
            conn.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSignUp signUp = new frmSignUp();
            signUp.Show();
        }

        
    }
}