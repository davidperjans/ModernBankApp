namespace ModernBankApp
{
    partial class RegisterForm
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
            headerPanel = new Panel();
            label1 = new Label();
            minimizeBtn = new Label();
            maximizeBtn = new Label();
            exitBtn = new Label();
            label5 = new Label();
            register_linkLabel = new LinkLabel();
            register_btn = new Button();
            register_showpassword = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            register_password = new TextBox();
            label2 = new Label();
            register_username = new TextBox();
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
            label1.Location = new Point(6, 8);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(114, 45);
            label5.Name = "label5";
            label5.Size = new Size(182, 30);
            label5.TabIndex = 2;
            label5.Text = "Register Account";
            // 
            // register_linkLabel
            // 
            register_linkLabel.ActiveLinkColor = Color.DodgerBlue;
            register_linkLabel.AutoSize = true;
            register_linkLabel.LinkColor = Color.SteelBlue;
            register_linkLabel.Location = new Point(174, 325);
            register_linkLabel.Name = "register_linkLabel";
            register_linkLabel.Size = new Size(63, 15);
            register_linkLabel.TabIndex = 13;
            register_linkLabel.TabStop = true;
            register_linkLabel.Text = "Login here";
            register_linkLabel.LinkClicked += register_linkLabel_LinkClicked;
            // 
            // register_btn
            // 
            register_btn.BackColor = Color.FromArgb(62, 65, 71);
            register_btn.FlatAppearance.BorderSize = 0;
            register_btn.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            register_btn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            register_btn.FlatStyle = FlatStyle.Flat;
            register_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            register_btn.ForeColor = Color.Gray;
            register_btn.Location = new Point(158, 236);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(94, 32);
            register_btn.TabIndex = 12;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = false;
            register_btn.Click += register_btn_Click;
            // 
            // register_showpassword
            // 
            register_showpassword.AutoSize = true;
            register_showpassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            register_showpassword.ForeColor = Color.Gray;
            register_showpassword.Location = new Point(194, 201);
            register_showpassword.Name = "register_showpassword";
            register_showpassword.Size = new Size(109, 19);
            register_showpassword.TabIndex = 11;
            register_showpassword.Text = "Show Password";
            register_showpassword.UseVisualStyleBackColor = true;
            register_showpassword.CheckedChanged += register_showpassword_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(90, 289);
            label4.Name = "label4";
            label4.Size = new Size(230, 25);
            label4.TabIndex = 6;
            label4.Text = "Already have an account?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(111, 151);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // register_password
            // 
            register_password.BackColor = Color.FromArgb(62, 65, 71);
            register_password.BorderStyle = BorderStyle.None;
            register_password.ForeColor = Color.White;
            register_password.Location = new Point(111, 179);
            register_password.Name = "register_password";
            register_password.PasswordChar = '*';
            register_password.PlaceholderText = "Your password...";
            register_password.Size = new Size(189, 16);
            register_password.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(111, 88);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 8;
            label2.Text = "Username";
            // 
            // register_username
            // 
            register_username.BackColor = Color.FromArgb(62, 65, 71);
            register_username.BorderStyle = BorderStyle.None;
            register_username.ForeColor = Color.White;
            register_username.Location = new Point(111, 116);
            register_username.Name = "register_username";
            register_username.PlaceholderText = "Your username...";
            register_username.Size = new Size(189, 16);
            register_username.TabIndex = 9;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            ClientSize = new Size(411, 367);
            Controls.Add(register_linkLabel);
            Controls.Add(register_btn);
            Controls.Add(register_showpassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(register_password);
            Controls.Add(label2);
            Controls.Add(register_username);
            Controls.Add(label5);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
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
        private Label label5;
        private LinkLabel register_linkLabel;
        private Button register_btn;
        private CheckBox register_showpassword;
        private Label label4;
        private Label label3;
        private TextBox register_password;
        private Label label2;
        private TextBox register_username;
    }
}