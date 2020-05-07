namespace WindowsFormsApp1
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.passTextBox = new System.Windows.Forms.TextBox();
            this.loginBttn = new System.Windows.Forms.Button();
            this.clearLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(129, 47);
            this.userTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(164, 20);
            this.userTextBox.TabIndex = 2;
            // 
            // passTextBox
            // 
            this.passTextBox.Location = new System.Drawing.Point(129, 88);
            this.passTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passTextBox.Name = "passTextBox";
            this.passTextBox.Size = new System.Drawing.Size(164, 20);
            this.passTextBox.TabIndex = 3;
            this.passTextBox.UseSystemPasswordChar = true;
            this.passTextBox.TextChanged += new System.EventHandler(this.passTextBox_TextChanged);
            // 
            // loginBttn
            // 
            this.loginBttn.Location = new System.Drawing.Point(192, 172);
            this.loginBttn.Margin = new System.Windows.Forms.Padding(2);
            this.loginBttn.Name = "loginBttn";
            this.loginBttn.Size = new System.Drawing.Size(101, 41);
            this.loginBttn.TabIndex = 4;
            this.loginBttn.Text = "Log In";
            this.loginBttn.UseVisualStyleBackColor = true;
            this.loginBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearLogin
            // 
            this.clearLogin.Location = new System.Drawing.Point(29, 172);
            this.clearLogin.Margin = new System.Windows.Forms.Padding(2);
            this.clearLogin.Name = "clearLogin";
            this.clearLogin.Size = new System.Drawing.Size(101, 41);
            this.clearLogin.TabIndex = 5;
            this.clearLogin.Text = "Clear";
            this.clearLogin.UseVisualStyleBackColor = true;
            this.clearLogin.Click += new System.EventHandler(this.cancelLogin_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginBttn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 239);
            this.Controls.Add(this.clearLogin);
            this.Controls.Add(this.loginBttn);
            this.Controls.Add(this.passTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.TextBox passTextBox;
        private System.Windows.Forms.Button loginBttn;
        private System.Windows.Forms.Button clearLogin;
    }
}