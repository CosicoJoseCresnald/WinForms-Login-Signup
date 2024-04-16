namespace Windows_Forms_Login_or_Signup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            loginUsernameTxt = new TextBox();
            loginPasswordTxt = new TextBox();
            loginUsernameLbl = new Label();
            loginPasswordLbl = new Label();
            loginBg = new PictureBox();
            loginLogoLbl = new Label();
            loginMottoLbl = new Label();
            loginBtn = new Button();
            signupBtn = new Button();
            cancelBtn = new Button();
            createaccountBtn = new Button();
            signupPasswordLbl = new Label();
            signupUsernameLbl = new Label();
            signupPasswordTxt = new TextBox();
            signupUsernameTxt = new TextBox();
            signupBg = new PictureBox();
            signupLogoLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)loginBg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)signupBg).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // loginUsernameTxt
            // 
            loginUsernameTxt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUsernameTxt.Location = new Point(748, 203);
            loginUsernameTxt.Name = "loginUsernameTxt";
            loginUsernameTxt.Size = new Size(115, 22);
            loginUsernameTxt.TabIndex = 1;
            // 
            // loginPasswordTxt
            // 
            loginPasswordTxt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPasswordTxt.Location = new Point(748, 236);
            loginPasswordTxt.Name = "loginPasswordTxt";
            loginPasswordTxt.Size = new Size(115, 22);
            loginPasswordTxt.TabIndex = 2;
            loginPasswordTxt.UseSystemPasswordChar = true;
            // 
            // loginUsernameLbl
            // 
            loginUsernameLbl.AutoSize = true;
            loginUsernameLbl.BackColor = SystemColors.Control;
            loginUsernameLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginUsernameLbl.Location = new Point(616, 203);
            loginUsernameLbl.Name = "loginUsernameLbl";
            loginUsernameLbl.Size = new Size(126, 17);
            loginUsernameLbl.TabIndex = 3;
            loginUsernameLbl.Text = "Username or E-mail: ";
            loginUsernameLbl.Click += label1_Click;
            // 
            // loginPasswordLbl
            // 
            loginPasswordLbl.AutoSize = true;
            loginPasswordLbl.BackColor = SystemColors.Control;
            loginPasswordLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginPasswordLbl.Location = new Point(641, 236);
            loginPasswordLbl.Name = "loginPasswordLbl";
            loginPasswordLbl.Size = new Size(69, 17);
            loginPasswordLbl.TabIndex = 4;
            loginPasswordLbl.Text = "Password: ";
            // 
            // loginBg
            // 
            loginBg.BackColor = SystemColors.Control;
            loginBg.BorderStyle = BorderStyle.FixedSingle;
            loginBg.Location = new Point(589, 125);
            loginBg.Name = "loginBg";
            loginBg.Size = new Size(296, 275);
            loginBg.TabIndex = 5;
            loginBg.TabStop = false;
            // 
            // loginLogoLbl
            // 
            loginLogoLbl.AutoSize = true;
            loginLogoLbl.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLogoLbl.ForeColor = Color.FromArgb(66, 103, 178);
            loginLogoLbl.Location = new Point(42, 184);
            loginLogoLbl.Name = "loginLogoLbl";
            loginLogoLbl.Size = new Size(203, 41);
            loginLogoLbl.TabIndex = 6;
            loginLogoLbl.Text = "PhaseBook";
            // 
            // loginMottoLbl
            // 
            loginMottoLbl.AutoSize = true;
            loginMottoLbl.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginMottoLbl.Location = new Point(42, 236);
            loginMottoLbl.Name = "loginMottoLbl";
            loginMottoLbl.Size = new Size(333, 44);
            loginMottoLbl.TabIndex = 7;
            loginMottoLbl.Text = "Connect with friends and the world\r\naround you on PhaseBook.\r\n";
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(66, 103, 178);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.FromArgb(66, 103, 178);
            loginBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(748, 309);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(115, 49);
            loginBtn.TabIndex = 8;
            loginBtn.Text = "Log-in";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // signupBtn
            // 
            signupBtn.BackColor = Color.FromArgb(66, 103, 178);
            signupBtn.Cursor = Cursors.Hand;
            signupBtn.FlatAppearance.BorderColor = Color.FromArgb(66, 103, 178);
            signupBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupBtn.ForeColor = Color.White;
            signupBtn.ImageAlign = ContentAlignment.MiddleLeft;
            signupBtn.Location = new Point(616, 309);
            signupBtn.Name = "signupBtn";
            signupBtn.Size = new Size(115, 49);
            signupBtn.TabIndex = 9;
            signupBtn.Text = "Sign-up\r\n";
            signupBtn.UseVisualStyleBackColor = false;
            signupBtn.Click += signupBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(66, 103, 178);
            cancelBtn.Cursor = Cursors.Hand;
            cancelBtn.FlatAppearance.BorderColor = Color.FromArgb(66, 103, 178);
            cancelBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(408, 366);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(115, 49);
            cancelBtn.TabIndex = 16;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Visible = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // createaccountBtn
            // 
            createaccountBtn.BackColor = Color.FromArgb(66, 103, 178);
            createaccountBtn.Cursor = Cursors.Hand;
            createaccountBtn.FlatAppearance.BorderColor = Color.FromArgb(66, 103, 178);
            createaccountBtn.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createaccountBtn.ForeColor = Color.White;
            createaccountBtn.Location = new Point(372, 311);
            createaccountBtn.Name = "createaccountBtn";
            createaccountBtn.Size = new Size(178, 49);
            createaccountBtn.TabIndex = 15;
            createaccountBtn.Text = "Create Account";
            createaccountBtn.UseVisualStyleBackColor = false;
            createaccountBtn.Visible = false;
            createaccountBtn.Click += createaccountBtn_Click;
            // 
            // signupPasswordLbl
            // 
            signupPasswordLbl.AutoSize = true;
            signupPasswordLbl.BackColor = SystemColors.Control;
            signupPasswordLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupPasswordLbl.Location = new Point(356, 236);
            signupPasswordLbl.Name = "signupPasswordLbl";
            signupPasswordLbl.Size = new Size(69, 17);
            signupPasswordLbl.TabIndex = 13;
            signupPasswordLbl.Text = "Password: ";
            signupPasswordLbl.Visible = false;
            signupPasswordLbl.Click += signupPasswordLbl_Click;
            // 
            // signupUsernameLbl
            // 
            signupUsernameLbl.AutoSize = true;
            signupUsernameLbl.BackColor = SystemColors.Control;
            signupUsernameLbl.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupUsernameLbl.Location = new Point(303, 203);
            signupUsernameLbl.Name = "signupUsernameLbl";
            signupUsernameLbl.Size = new Size(173, 17);
            signupUsernameLbl.TabIndex = 12;
            signupUsernameLbl.Text = "Chosen Username or E-mail: ";
            signupUsernameLbl.Visible = false;
            // 
            // signupPasswordTxt
            // 
            signupPasswordTxt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupPasswordTxt.Location = new Point(482, 238);
            signupPasswordTxt.Name = "signupPasswordTxt";
            signupPasswordTxt.Size = new Size(128, 22);
            signupPasswordTxt.TabIndex = 11;
            signupPasswordTxt.Visible = false;
            // 
            // signupUsernameTxt
            // 
            signupUsernameTxt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signupUsernameTxt.Location = new Point(482, 200);
            signupUsernameTxt.Name = "signupUsernameTxt";
            signupUsernameTxt.Size = new Size(128, 22);
            signupUsernameTxt.TabIndex = 10;
            signupUsernameTxt.Visible = false;
            // 
            // signupBg
            // 
            signupBg.BackColor = SystemColors.Control;
            signupBg.BorderStyle = BorderStyle.FixedSingle;
            signupBg.Location = new Point(279, 104);
            signupBg.Name = "signupBg";
            signupBg.Size = new Size(356, 347);
            signupBg.TabIndex = 14;
            signupBg.TabStop = false;
            signupBg.Visible = false;
            // 
            // signupLogoLbl
            // 
            signupLogoLbl.AutoSize = true;
            signupLogoLbl.BackColor = SystemColors.Control;
            signupLogoLbl.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupLogoLbl.ForeColor = Color.FromArgb(66, 103, 178);
            signupLogoLbl.Location = new Point(342, 146);
            signupLogoLbl.Name = "signupLogoLbl";
            signupLogoLbl.Size = new Size(224, 28);
            signupLogoLbl.TabIndex = 17;
            signupLogoLbl.Text = "PhaseBook Signup";
            signupLogoLbl.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(916, 545);
            Controls.Add(signupBtn);
            Controls.Add(loginBtn);
            Controls.Add(loginMottoLbl);
            Controls.Add(loginLogoLbl);
            Controls.Add(loginPasswordLbl);
            Controls.Add(loginUsernameLbl);
            Controls.Add(loginPasswordTxt);
            Controls.Add(loginUsernameTxt);
            Controls.Add(loginBg);
            Controls.Add(signupLogoLbl);
            Controls.Add(cancelBtn);
            Controls.Add(createaccountBtn);
            Controls.Add(signupPasswordLbl);
            Controls.Add(signupUsernameLbl);
            Controls.Add(signupPasswordTxt);
            Controls.Add(signupUsernameTxt);
            Controls.Add(signupBg);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PhaseBook Login or Signup";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)loginBg).EndInit();
            ((System.ComponentModel.ISupportInitialize)signupBg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TextBox loginUsernameTxt;
        private TextBox loginPasswordTxt;
        private Label loginUsernameLbl;
        private Label loginPasswordLbl;
        private PictureBox loginBg;
        private Label loginLogoLbl;
        private Label loginMottoLbl;
        private Button loginBtn;
        private Button signupBtn;
        private Button cancelBtn;
        private Button createaccountBtn;
        private Label signupPasswordLbl;
        private Label signupUsernameLbl;
        private TextBox signupPasswordTxt;
        private TextBox signupUsernameTxt;
        private PictureBox signupBg;
        private Label signupLogoLbl;
    }
}
