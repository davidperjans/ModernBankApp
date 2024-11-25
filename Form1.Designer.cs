namespace ModernBankApp
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
            headerPanel = new Panel();
            label1 = new Label();
            minimizeBtn = new Label();
            maximizeBtn = new Label();
            exitBtn = new Label();
            login_username = new TextBox();
            label2 = new Label();
            login_password = new TextBox();
            label3 = new Label();
            login_showpassword = new CheckBox();
            login_btn = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            headerPanel.SuspendLayout();
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
            headerPanel.Size = new Size(411, 29);
            headerPanel.TabIndex = 0;
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
            minimizeBtn.Location = new Point(348, 5);
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
            maximizeBtn.Location = new Point(369, 2);
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
            exitBtn.Location = new Point(389, 7);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(17, 15);
            exitBtn.TabIndex = 0;
            exitBtn.Text = "✕";
            exitBtn.Click += exitBtn_Click;
            exitBtn.MouseEnter += exitBtn_MouseEnter;
            exitBtn.MouseLeave += exitBtn_MouseLeave;
            // 
            // login_username
            // 
            login_username.BackColor = Color.FromArgb(62, 65, 71);
            login_username.BorderStyle = BorderStyle.None;
            login_username.ForeColor = Color.White;
            login_username.Location = new Point(111, 115);
            login_username.Name = "login_username";
            login_username.PlaceholderText = "Your username...";
            login_username.Size = new Size(189, 16);
            login_username.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(111, 87);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // login_password
            // 
            login_password.BackColor = Color.FromArgb(62, 65, 71);
            login_password.BorderStyle = BorderStyle.None;
            login_password.ForeColor = Color.White;
            login_password.Location = new Point(111, 178);
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.PlaceholderText = "Your password...";
            login_password.Size = new Size(189, 16);
            login_password.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(111, 150);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // login_showpassword
            // 
            login_showpassword.AutoSize = true;
            login_showpassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            login_showpassword.ForeColor = Color.Gray;
            login_showpassword.Location = new Point(194, 200);
            login_showpassword.Name = "login_showpassword";
            login_showpassword.Size = new Size(109, 19);
            login_showpassword.TabIndex = 3;
            login_showpassword.Text = "Show Password";
            login_showpassword.UseVisualStyleBackColor = true;
            login_showpassword.CheckedChanged += login_showpassword_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(62, 65, 71);
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            login_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            login_btn.ForeColor = Color.Gray;
            login_btn.Location = new Point(158, 235);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(94, 32);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(108, 288);
            label4.Name = "label4";
            label4.Size = new Size(195, 25);
            label4.TabIndex = 0;
            label4.Text = "Have no account yet?";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.DodgerBlue;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SteelBlue;
            linkLabel1.Location = new Point(168, 324);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register here";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(127, 32);
            label5.Name = "label5";
            label5.Size = new Size(157, 30);
            label5.TabIndex = 0;
            label5.Text = "Login Account";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(411, 367);
            Controls.Add(label5);
            Controls.Add(linkLabel1);
            Controls.Add(login_btn);
            Controls.Add(login_showpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(login_password);
            Controls.Add(label2);
            Controls.Add(login_username);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            Shown += Form1_Shown;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerPanel;
        private Label label1;
        private Label minimizeBtn;
        private Label maximizeBtn;
        private Label exitBtn;
        private TextBox login_username;
        private Label label2;
        private TextBox login_password;
        private Label label3;
        private CheckBox login_showpassword;
        private Button login_btn;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label5;
    }
}
