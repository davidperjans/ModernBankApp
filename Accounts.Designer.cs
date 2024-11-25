namespace ModernBankApp
{
    partial class Accounts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            transferBtn = new Button();
            dataGridViewAccounts = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).BeginInit();
            SuspendLayout();
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(37, 37, 37);
            addBtn.Cursor = Cursors.Hand;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.Gray;
            addBtn.Location = new Point(19, 327);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 44);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add Account";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.FromArgb(37, 37, 37);
            editBtn.FlatAppearance.BorderSize = 0;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.ForeColor = Color.Gray;
            editBtn.Location = new Point(19, 377);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(112, 44);
            editBtn.TabIndex = 1;
            editBtn.Text = "Edit Account";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(37, 37, 37);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.ForeColor = Color.Gray;
            deleteBtn.Location = new Point(19, 427);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(112, 44);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete Account";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // transferBtn
            // 
            transferBtn.BackColor = Color.FromArgb(37, 37, 37);
            transferBtn.Cursor = Cursors.Hand;
            transferBtn.FlatAppearance.BorderSize = 0;
            transferBtn.FlatStyle = FlatStyle.Flat;
            transferBtn.ForeColor = Color.Gray;
            transferBtn.Location = new Point(234, 327);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(112, 44);
            transferBtn.TabIndex = 1;
            transferBtn.Text = "Transfer";
            transferBtn.UseVisualStyleBackColor = false;
            transferBtn.Click += transferBtn_Click;
            // 
            // dataGridViewAccounts
            // 
            dataGridViewAccounts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAccounts.Location = new Point(59, 28);
            dataGridViewAccounts.Name = "dataGridViewAccounts";
            dataGridViewAccounts.Size = new Size(781, 243);
            dataGridViewAccounts.TabIndex = 2;
            dataGridViewAccounts.CellClick += dataGridViewAccounts_CellClick;
            dataGridViewAccounts.SelectionChanged += dataGridViewAccounts_SelectionChanged;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 63);
            Controls.Add(dataGridViewAccounts);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(transferBtn);
            Controls.Add(addBtn);
            Name = "Accounts";
            Size = new Size(872, 571);
            Load += Accounts_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAccounts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addBtn;
        private Button editBtn;
        private Button deleteBtn;
        private Button transferBtn;
        private DataGridView dataGridViewAccounts;
    }
}
