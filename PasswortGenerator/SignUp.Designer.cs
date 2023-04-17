namespace PasswortGenerator
{
    partial class frmSignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.signUpUserName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.signUpPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpUserName
            // 
            this.signUpUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUpUserName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpUserName.Location = new System.Drawing.Point(69, 84);
            this.signUpUserName.Name = "signUpUserName";
            this.signUpUserName.PlaceholderText = "Username";
            this.signUpUserName.Size = new System.Drawing.Size(352, 33);
            this.signUpUserName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.signUpPassword);
            this.panel1.Controls.Add(this.signUpUserName);
            this.panel1.Location = new System.Drawing.Point(138, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 324);
            this.panel1.TabIndex = 1;
            // 
            // signUpPassword
            // 
            this.signUpPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signUpPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpPassword.Location = new System.Drawing.Point(69, 134);
            this.signUpPassword.Name = "signUpPassword";
            this.signUpPassword.PlaceholderText = "Password";
            this.signUpPassword.Size = new System.Drawing.Size(352, 33);
            this.signUpPassword.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(69, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Password Again";
            this.textBox1.Size = new System.Drawing.Size(352, 33);
            this.textBox1.TabIndex = 2;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(69, 235);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(352, 36);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(157, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create an account";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmSignUp";
            this.Text = "SignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox signUpUserName;
        private Panel panel1;
        private Button btnSignUp;
        private TextBox textBox1;
        private TextBox signUpPassword;
        private Label label1;
    }
}