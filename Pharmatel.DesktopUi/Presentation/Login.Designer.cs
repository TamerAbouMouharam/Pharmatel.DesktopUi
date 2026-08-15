namespace Pharmatel.DesktopUi.Presentation
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            loginElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            exitElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            btnSignup = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // loginElipse
            // 
            loginElipse.BorderRadius = 20;
            loginElipse.TargetControl = this;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.None;
            btnExit.CustomizableEdges = customizableEdges9;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.FromArgb(10, 126, 164);
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = Color.White;
            btnExit.HoverState.FillColor = Color.FromArgb(40, 156, 194);
            btnExit.Location = new Point(641, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnExit.Size = new Size(70, 70);
            btnExit.TabIndex = 0;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // exitElipse
            // 
            exitElipse.BorderRadius = 8;
            exitElipse.TargetControl = btnExit;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.BorderRadius = 8;
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges7;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(10, 126, 164);
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(10, 126, 164);
            txtUsername.Location = new Point(120, 227);
            txtUsername.Margin = new Padding(4, 7, 4, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "اسم المستخدم";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtUsername.Size = new Size(482, 80);
            txtUsername.TabIndex = 1;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.BorderRadius = 8;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges5;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(10, 126, 164);
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(10, 126, 164);
            txtPassword.Location = new Point(120, 358);
            txtPassword.Margin = new Padding(4, 7, 4, 7);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "كلمة المرور";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPassword.Size = new Size(482, 80);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(10, 126, 164);
            label1.Location = new Point(181, 77);
            label1.Name = "label1";
            label1.Size = new Size(360, 89);
            label1.TabIndex = 3;
            label1.Text = "Pharmatel";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 8;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(10, 126, 164);
            btnLogin.Font = new Font("Segoe UI", 10F);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverState.FillColor = Color.FromArgb(40, 156, 194);
            btnLogin.Location = new Point(249, 483);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.Size = new Size(225, 56);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "تسجيل الدخول";
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.BorderColor = Color.FromArgb(10, 126, 164);
            btnSignup.BorderRadius = 8;
            btnSignup.BorderThickness = 1;
            btnSignup.CustomizableEdges = customizableEdges1;
            btnSignup.DisabledState.BorderColor = Color.DarkGray;
            btnSignup.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSignup.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSignup.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSignup.FillColor = Color.White;
            btnSignup.Font = new Font("Segoe UI", 10F);
            btnSignup.ForeColor = Color.FromArgb(10, 126, 164);
            btnSignup.HoverState.FillColor = Color.FromArgb(60, 176, 214);
            btnSignup.HoverState.ForeColor = Color.White;
            btnSignup.Location = new Point(249, 576);
            btnSignup.Name = "btnSignup";
            btnSignup.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSignup.Size = new Size(225, 56);
            btnSignup.TabIndex = 5;
            btnSignup.Text = "إنشاء حساب";
            btnSignup.Click += btnSignup_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(723, 709);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmatel";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse loginElipse;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse exitElipse;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignup;
    }
}