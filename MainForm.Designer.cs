namespace ModernBankApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            headerPanel = new Panel();
            label1 = new Label();
            minimizeBtn = new Label();
            maximizeBtn = new Label();
            exitBtn = new Label();
            panel1 = new Panel();
            homeBtn = new Button();
            panel7 = new Panel();
            accountsBtn = new Button();
            panel6 = new Panel();
            settingsBtn = new Button();
            panel5 = new Panel();
            logoutBtn = new Button();
            panel2 = new Panel();
            welcomeUserLabel = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            settings1 = new Settings();
            accounts1 = new Accounts();
            home1 = new Home();
            headerPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(37, 37, 37);
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(minimizeBtn);
            headerPanel.Controls.Add(maximizeBtn);
            headerPanel.Controls.Add(exitBtn);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1100, 29);
            headerPanel.TabIndex = 1;
            headerPanel.MouseDown += headerPanel_MouseDown;
            headerPanel.MouseMove += headerPanel_MouseMove;
            headerPanel.MouseUp += headerPanel_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(6, 7);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Bank Application";
            // 
            // minimizeBtn
            // 
            minimizeBtn.AutoSize = true;
            minimizeBtn.ForeColor = Color.Gray;
            minimizeBtn.Location = new Point(1037, 7);
            minimizeBtn.Name = "minimizeBtn";
            minimizeBtn.Size = new Size(19, 15);
            minimizeBtn.TabIndex = 0;
            minimizeBtn.Text = "🗕";
            minimizeBtn.Click += minimizeBtn_Click;
            minimizeBtn.MouseEnter += minimizeBtn_MouseEnter;
            minimizeBtn.MouseLeave += minimizeBtn_MouseLeave;
            // 
            // maximizeBtn
            // 
            maximizeBtn.AutoSize = true;
            maximizeBtn.Font = new Font("Segoe UI", 12F);
            maximizeBtn.ForeColor = Color.Gray;
            maximizeBtn.Location = new Point(1058, 4);
            maximizeBtn.Name = "maximizeBtn";
            maximizeBtn.Size = new Size(20, 21);
            maximizeBtn.TabIndex = 0;
            maximizeBtn.Text = "□";
            maximizeBtn.Click += maximizeBtn_Click;
            maximizeBtn.MouseEnter += maximizeBtn_MouseEnter;
            maximizeBtn.MouseLeave += maximizeBtn_MouseLeave;
            // 
            // exitBtn
            // 
            exitBtn.AutoSize = true;
            exitBtn.ForeColor = Color.Gray;
            exitBtn.Location = new Point(1078, 9);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(17, 15);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "✕";
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseEnter += exitBtn_MouseEnter;
            exitBtn.MouseLeave += exitBtn_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(homeBtn);
            panel1.ForeColor = Color.Coral;
            panel1.Location = new Point(0, 152);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 48);
            panel1.TabIndex = 3;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(57, 59, 64);
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            homeBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.Gray;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageAlign = ContentAlignment.MiddleLeft;
            homeBtn.Location = new Point(-3, -11);
            homeBtn.Margin = new Padding(3, 15, 3, 3);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(236, 70);
            homeBtn.TabIndex = 0;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            homeBtn.MouseEnter += homeBtn_MouseEnter;
            homeBtn.MouseLeave += homeBtn_MouseLeave;
            // 
            // panel7
            // 
            panel7.BackColor = Color.IndianRed;
            panel7.Controls.Add(accountsBtn);
            panel7.ForeColor = Color.Coral;
            panel7.Location = new Point(0, 200);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(233, 48);
            panel7.TabIndex = 3;
            // 
            // accountsBtn
            // 
            accountsBtn.BackColor = Color.FromArgb(57, 59, 64);
            accountsBtn.FlatAppearance.BorderSize = 0;
            accountsBtn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            accountsBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            accountsBtn.FlatStyle = FlatStyle.Flat;
            accountsBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountsBtn.ForeColor = Color.Gray;
            accountsBtn.Image = (Image)resources.GetObject("accountsBtn.Image");
            accountsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            accountsBtn.Location = new Point(-3, -11);
            accountsBtn.Margin = new Padding(3, 15, 3, 3);
            accountsBtn.Name = "accountsBtn";
            accountsBtn.Size = new Size(236, 70);
            accountsBtn.TabIndex = 0;
            accountsBtn.Text = "Accounts";
            accountsBtn.UseVisualStyleBackColor = false;
            accountsBtn.Click += accountsBtn_Click;
            accountsBtn.MouseEnter += accountsBtn_MouseEnter;
            accountsBtn.MouseLeave += accountsBtn_MouseLeave;
            // 
            // panel6
            // 
            panel6.BackColor = Color.IndianRed;
            panel6.Controls.Add(settingsBtn);
            panel6.ForeColor = Color.Coral;
            panel6.Location = new Point(0, 248);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(233, 48);
            panel6.TabIndex = 3;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.FromArgb(57, 59, 64);
            settingsBtn.FlatAppearance.BorderSize = 0;
            settingsBtn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            settingsBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            settingsBtn.ForeColor = Color.Gray;
            settingsBtn.Image = (Image)resources.GetObject("settingsBtn.Image");
            settingsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            settingsBtn.Location = new Point(-3, -11);
            settingsBtn.Margin = new Padding(3, 15, 3, 3);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(236, 70);
            settingsBtn.TabIndex = 0;
            settingsBtn.Text = "Settings";
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            settingsBtn.MouseEnter += settingsBtn_MouseEnter;
            settingsBtn.MouseLeave += settingsBtn_MouseLeave;
            // 
            // panel5
            // 
            panel5.BackColor = Color.IndianRed;
            panel5.Controls.Add(logoutBtn);
            panel5.ForeColor = Color.Coral;
            panel5.Location = new Point(0, 296);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(233, 48);
            panel5.TabIndex = 3;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(57, 59, 64);
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            logoutBtn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.Gray;
            logoutBtn.Image = (Image)resources.GetObject("logoutBtn.Image");
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(-3, -11);
            logoutBtn.Margin = new Padding(3, 15, 3, 3);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(236, 70);
            logoutBtn.TabIndex = 0;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            logoutBtn.MouseEnter += logoutBtn_MouseEnter;
            logoutBtn.MouseLeave += logoutBtn_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(47, 49, 54);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(welcomeUserLabel);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 29);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 571);
            panel2.TabIndex = 3;
            // 
            // welcomeUserLabel
            // 
            welcomeUserLabel.AutoSize = true;
            welcomeUserLabel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeUserLabel.ForeColor = Color.Gray;
            welcomeUserLabel.Location = new Point(26, 93);
            welcomeUserLabel.Name = "welcomeUserLabel";
            welcomeUserLabel.Size = new Size(76, 20);
            welcomeUserLabel.TabIndex = 0;
            welcomeUserLabel.Text = "Welcome:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(64, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(settings1);
            panel3.Controls.Add(accounts1);
            panel3.Controls.Add(home1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(228, 29);
            panel3.Name = "panel3";
            panel3.Size = new Size(872, 571);
            panel3.TabIndex = 4;
            // 
            // settings1
            // 
            settings1.BackColor = Color.FromArgb(54, 57, 63);
            settings1.Location = new Point(0, 0);
            settings1.Name = "settings1";
            settings1.Size = new Size(872, 571);
            settings1.TabIndex = 2;
            // 
            // accounts1
            // 
            accounts1.BackColor = Color.FromArgb(54, 57, 63);
            accounts1.Location = new Point(0, 0);
            accounts1.Name = "accounts1";
            accounts1.Size = new Size(872, 571);
            accounts1.TabIndex = 1;
            // 
            // home1
            // 
            home1.BackColor = Color.FromArgb(54, 57, 63);
            home1.Location = new Point(0, 0);
            home1.Name = "home1";
            home1.Size = new Size(872, 571);
            home1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label label1;
        private Label minimizeBtn;
        private Label maximizeBtn;
        private Label exitBtn;
        private Panel panel1;
        private Button homeBtn;
        private Panel panel7;
        private Button accountsBtn;
        private Panel panel6;
        private Button settingsBtn;
        private Panel panel5;
        private Button logoutBtn;
        private Panel panel2;
        private Label welcomeUserLabel;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Settings settings1;
        private Accounts accounts1;
        private Home home1;
    }
}