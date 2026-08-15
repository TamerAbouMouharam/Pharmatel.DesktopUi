namespace Pharmatel.DesktopUi.Presentation
{
    partial class Dashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            exitElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnMax = new Guna.UI2.WinForms.Guna2Button();
            btnMin = new Guna.UI2.WinForms.Guna2Button();
            maxElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            minElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            dashboardElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            dashboardContent = new Guna.UI2.WinForms.Guna2TabControl();
            medicinePage = new TabPage();
            medicineList = new ListView();
            prescriptionPage = new TabPage();
            contentElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            medicinePageElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            prescriptionPageElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            medicineListElipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            label1 = new Label();
            dashboardContent.SuspendLayout();
            medicinePage.SuspendLayout();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.FromArgb(10, 126, 164);
            btnExit.Font = new Font("Segoe UI", 15F);
            btnExit.ForeColor = Color.White;
            btnExit.HoverState.FillColor = Color.FromArgb(40, 156, 194);
            btnExit.Location = new Point(12, 12);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(70, 70);
            btnExit.TabIndex = 1;
            btnExit.Text = "X";
            btnExit.Click += btnExit_Click;
            // 
            // exitElipse
            // 
            exitElipse.BorderRadius = 8;
            exitElipse.TargetControl = btnExit;
            // 
            // btnMax
            // 
            btnMax.CustomizableEdges = customizableEdges3;
            btnMax.DisabledState.BorderColor = Color.DarkGray;
            btnMax.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMax.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMax.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMax.FillColor = Color.Gray;
            btnMax.Font = new Font("Segoe UI", 15F);
            btnMax.ForeColor = Color.White;
            btnMax.HoverState.FillColor = Color.Silver;
            btnMax.Location = new Point(88, 12);
            btnMax.Name = "btnMax";
            btnMax.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnMax.Size = new Size(70, 70);
            btnMax.TabIndex = 2;
            btnMax.Text = "O";
            btnMax.Click += btnMax_Click;
            // 
            // btnMin
            // 
            btnMin.BackColor = SystemColors.ControlLight;
            btnMin.CustomizableEdges = customizableEdges5;
            btnMin.DisabledState.BorderColor = Color.DarkGray;
            btnMin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMin.FillColor = Color.Silver;
            btnMin.Font = new Font("Segoe UI", 15F);
            btnMin.ForeColor = Color.White;
            btnMin.HoverState.FillColor = Color.FromArgb(224, 224, 224);
            btnMin.Location = new Point(164, 12);
            btnMin.Name = "btnMin";
            btnMin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMin.Size = new Size(70, 70);
            btnMin.TabIndex = 3;
            btnMin.Text = "-";
            // 
            // maxElipse
            // 
            maxElipse.BorderRadius = 8;
            maxElipse.TargetControl = btnMax;
            // 
            // minElipse
            // 
            minElipse.BorderRadius = 8;
            minElipse.TargetControl = btnMin;
            // 
            // dashboardElipse
            // 
            dashboardElipse.BorderRadius = 20;
            dashboardElipse.TargetControl = this;
            // 
            // dashboardContent
            // 
            dashboardContent.Alignment = TabAlignment.Left;
            dashboardContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dashboardContent.Controls.Add(medicinePage);
            dashboardContent.Controls.Add(prescriptionPage);
            dashboardContent.ItemSize = new Size(180, 40);
            dashboardContent.Location = new Point(12, 88);
            dashboardContent.Name = "dashboardContent";
            dashboardContent.SelectedIndex = 0;
            dashboardContent.Size = new Size(1322, 647);
            dashboardContent.TabButtonHoverState.BorderColor = Color.Empty;
            dashboardContent.TabButtonHoverState.FillColor = Color.FromArgb(40, 52, 70);
            dashboardContent.TabButtonHoverState.Font = new Font("Segoe UI Semibold", 10F);
            dashboardContent.TabButtonHoverState.ForeColor = Color.White;
            dashboardContent.TabButtonHoverState.InnerColor = Color.FromArgb(40, 52, 70);
            dashboardContent.TabButtonIdleState.BorderColor = Color.Empty;
            dashboardContent.TabButtonIdleState.FillColor = Color.FromArgb(40, 156, 194);
            dashboardContent.TabButtonIdleState.Font = new Font("Segoe UI Semibold", 10F);
            dashboardContent.TabButtonIdleState.ForeColor = Color.White;
            dashboardContent.TabButtonIdleState.InnerColor = Color.FromArgb(40, 156, 194);
            dashboardContent.TabButtonSelectedState.BorderColor = Color.Empty;
            dashboardContent.TabButtonSelectedState.FillColor = Color.FromArgb(20, 136, 174);
            dashboardContent.TabButtonSelectedState.Font = new Font("Segoe UI Semibold", 10F);
            dashboardContent.TabButtonSelectedState.ForeColor = Color.White;
            dashboardContent.TabButtonSelectedState.InnerColor = Color.FromArgb(40, 156, 194);
            dashboardContent.TabButtonSize = new Size(180, 40);
            dashboardContent.TabIndex = 4;
            dashboardContent.TabMenuBackColor = Color.FromArgb(10, 126, 164);
            // 
            // medicinePage
            // 
            medicinePage.BackColor = Color.White;
            medicinePage.Controls.Add(medicineList);
            medicinePage.Location = new Point(184, 4);
            medicinePage.Name = "medicinePage";
            medicinePage.Padding = new Padding(3);
            medicinePage.Size = new Size(1134, 639);
            medicinePage.TabIndex = 0;
            medicinePage.Text = "الأدوية";
            // 
            // medicineList
            // 
            medicineList.BackColor = SystemColors.ButtonFace;
            medicineList.BorderStyle = BorderStyle.None;
            medicineList.Dock = DockStyle.Fill;
            medicineList.Location = new Point(3, 3);
            medicineList.Name = "medicineList";
            medicineList.Size = new Size(1128, 633);
            medicineList.TabIndex = 0;
            medicineList.UseCompatibleStateImageBehavior = false;
            // 
            // prescriptionPage
            // 
            prescriptionPage.BackColor = Color.White;
            prescriptionPage.Location = new Point(184, 4);
            prescriptionPage.Name = "prescriptionPage";
            prescriptionPage.Padding = new Padding(3);
            prescriptionPage.Size = new Size(1134, 639);
            prescriptionPage.TabIndex = 1;
            prescriptionPage.Text = "الوصفات";
            // 
            // contentElipse
            // 
            contentElipse.BorderRadius = 8;
            contentElipse.TargetControl = dashboardContent;
            // 
            // medicinePageElipse
            // 
            medicinePageElipse.BorderRadius = 8;
            medicinePageElipse.TargetControl = medicinePage;
            // 
            // prescriptionPageElipse
            // 
            prescriptionPageElipse.BorderRadius = 8;
            prescriptionPageElipse.TargetControl = prescriptionPage;
            // 
            // medicineListElipse
            // 
            medicineListElipse.BorderRadius = 8;
            medicineListElipse.TargetControl = medicineList;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(1084, 12);
            label1.Name = "label1";
            label1.Size = new Size(250, 57);
            label1.TabIndex = 5;
            label1.Text = "lblPharmacy";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1346, 747);
            Controls.Add(label1);
            Controls.Add(dashboardContent);
            Controls.Add(btnMin);
            Controls.Add(btnMax);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Dashboard";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            dashboardContent.ResumeLayout(false);
            medicinePage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Elipse exitElipse;
        private Guna.UI2.WinForms.Guna2Button btnMax;
        private Guna.UI2.WinForms.Guna2Button btnMin;
        private Guna.UI2.WinForms.Guna2Elipse maxElipse;
        private Guna.UI2.WinForms.Guna2Elipse minElipse;
        private Guna.UI2.WinForms.Guna2Elipse dashboardElipse;
        private Guna.UI2.WinForms.Guna2TabControl dashboardContent;
        private TabPage medicinePage;
        private TabPage prescriptionPage;
        private Guna.UI2.WinForms.Guna2Elipse contentElipse;
        private Guna.UI2.WinForms.Guna2Elipse medicinePageElipse;
        private Guna.UI2.WinForms.Guna2Elipse prescriptionPageElipse;
        private ListView medicineList;
        private Guna.UI2.WinForms.Guna2Elipse medicineListElipse;
        private Label label1;
    }
}