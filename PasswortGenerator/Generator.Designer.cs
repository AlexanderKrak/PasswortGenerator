namespace PasswortGenerator
{
    partial class frmGenerator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkSymbols = new System.Windows.Forms.CheckBox();
            this.checkNumbers = new System.Windows.Forms.CheckBox();
            this.checkLowerLetters = new System.Windows.Forms.CheckBox();
            this.checkUpperLetters = new System.Windows.Forms.CheckBox();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYourPassword = new System.Windows.Forms.TextBox();
            this.btnCopyPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnCopyPassword);
            this.panel1.Controls.Add(this.checkSymbols);
            this.panel1.Controls.Add(this.checkNumbers);
            this.panel1.Controls.Add(this.checkLowerLetters);
            this.panel1.Controls.Add(this.checkUpperLetters);
            this.panel1.Controls.Add(this.btnGeneratePassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPasswordLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtYourPassword);
            this.panel1.Location = new System.Drawing.Point(235, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 410);
            this.panel1.TabIndex = 0;
            // 
            // checkSymbols
            // 
            this.checkSymbols.AutoSize = true;
            this.checkSymbols.Location = new System.Drawing.Point(219, 283);
            this.checkSymbols.Name = "checkSymbols";
            this.checkSymbols.Size = new System.Drawing.Size(15, 14);
            this.checkSymbols.TabIndex = 10;
            this.checkSymbols.UseVisualStyleBackColor = true;
            this.checkSymbols.CheckedChanged += new System.EventHandler(this.checkSymbols_CheckedChanged);
            // 
            // checkNumbers
            // 
            this.checkNumbers.AutoSize = true;
            this.checkNumbers.Location = new System.Drawing.Point(219, 242);
            this.checkNumbers.Name = "checkNumbers";
            this.checkNumbers.Size = new System.Drawing.Size(15, 14);
            this.checkNumbers.TabIndex = 9;
            this.checkNumbers.UseVisualStyleBackColor = true;
            this.checkNumbers.CheckedChanged += new System.EventHandler(this.checkNumbers_CheckedChanged);
            // 
            // checkLowerLetters
            // 
            this.checkLowerLetters.AutoSize = true;
            this.checkLowerLetters.Location = new System.Drawing.Point(219, 198);
            this.checkLowerLetters.Name = "checkLowerLetters";
            this.checkLowerLetters.Size = new System.Drawing.Size(15, 14);
            this.checkLowerLetters.TabIndex = 8;
            this.checkLowerLetters.UseVisualStyleBackColor = true;
            this.checkLowerLetters.CheckedChanged += new System.EventHandler(this.checkLowerLetters_CheckedChanged);
            // 
            // checkUpperLetters
            // 
            this.checkUpperLetters.AutoSize = true;
            this.checkUpperLetters.Location = new System.Drawing.Point(219, 154);
            this.checkUpperLetters.Name = "checkUpperLetters";
            this.checkUpperLetters.Size = new System.Drawing.Size(15, 14);
            this.checkUpperLetters.TabIndex = 1;
            this.checkUpperLetters.UseVisualStyleBackColor = true;
            this.checkUpperLetters.CheckedChanged += new System.EventHandler(this.checkUpperLetters_CheckedChanged);
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGeneratePassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGeneratePassword.ForeColor = System.Drawing.Color.White;
            this.btnGeneratePassword.Location = new System.Drawing.Point(18, 335);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(256, 36);
            this.btnGeneratePassword.TabIndex = 7;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = false;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Include Symbols";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Include Numbers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Include Lowercase Letters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Include Uppercase Letters";
            // 
            // txtPasswordLength
            // 
            this.txtPasswordLength.Location = new System.Drawing.Point(219, 107);
            this.txtPasswordLength.Name = "txtPasswordLength";
            this.txtPasswordLength.Size = new System.Drawing.Size(55, 23);
            this.txtPasswordLength.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Length";
            // 
            // txtYourPassword
            // 
            this.txtYourPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtYourPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYourPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYourPassword.ForeColor = System.Drawing.Color.White;
            this.txtYourPassword.Location = new System.Drawing.Point(18, 25);
            this.txtYourPassword.Name = "txtYourPassword";
            this.txtYourPassword.Size = new System.Drawing.Size(256, 29);
            this.txtYourPassword.TabIndex = 0;
            // 
            // btnCopyPassword
            // 
            this.btnCopyPassword.BackColor = System.Drawing.Color.CadetBlue;
            this.btnCopyPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopyPassword.ForeColor = System.Drawing.Color.White;
            this.btnCopyPassword.Location = new System.Drawing.Point(18, 60);
            this.btnCopyPassword.Name = "btnCopyPassword";
            this.btnCopyPassword.Size = new System.Drawing.Size(256, 36);
            this.btnCopyPassword.TabIndex = 11;
            this.btnCopyPassword.Text = "Copy to Clipboard";
            this.btnCopyPassword.UseVisualStyleBackColor = false;
            this.btnCopyPassword.Click += new System.EventHandler(this.btnCopyPassword_Click);
            // 
            // frmGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmGenerator";
            this.Text = "Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnGeneratePassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtPasswordLength;
        private Label label1;
        private TextBox txtYourPassword;
        private CheckBox checkSymbols;
        private CheckBox checkNumbers;
        private CheckBox checkLowerLetters;
        private CheckBox checkUpperLetters;
        private Button btnCopyPassword;
    }
}