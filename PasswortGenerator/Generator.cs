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
    public partial class frmGenerator : Form
    {
        public frmGenerator()
        {
            InitializeComponent();
        }

        string charSet = string.Empty;
        Random rnd = new Random();
        

        private static string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string numbers = "1234567890";
        private static string symbols = "!§$%&/()=?{[]}";

        private static bool useUpper = false;
        private static bool useLower = false;
        private static bool useNumber = false;
        private static bool useSymbol = false;
        


        
        
        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            int passwordLength = Convert.ToInt32(txtPasswordLength.Text);
            char[] password = new char[passwordLength];

            if (useUpper) charSet += upper;
            if (useLower) charSet += upper.ToLower();
            if (useNumber) charSet += numbers;
            if (useSymbol) charSet += symbols;

            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = charSet[rnd.Next(charSet.Length - 1)];
            }

            string myPassword = new string(password);
            txtYourPassword.Text = myPassword;
        }

        private void checkUpperLetters_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUpperLetters.Checked == true)
            {
                useUpper = true;
            }
        }

        private void checkLowerLetters_CheckedChanged(object sender, EventArgs e)
        {
            if(checkLowerLetters.Checked == true)
            {
                useLower = true;
            }
        }

        private void checkNumbers_CheckedChanged(object sender, EventArgs e)
        {
            if(checkNumbers.Checked == true)
            {
                useNumber = true;    
            }
        }

        private void checkSymbols_CheckedChanged(object sender, EventArgs e)
        {
            if(checkSymbols.Checked == true) 
            {
                useSymbol = true;
            }
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            if(txtYourPassword.Text != string.Empty) 
            {
                Clipboard.SetText(txtYourPassword.Text);
                MessageBox.Show("Password copied to clipboard");
            }
        }
    }
}
