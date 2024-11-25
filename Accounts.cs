using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModernBankApp.Classes.BankFolder;
using ModernBankApp.Classes.UserFolder;

namespace ModernBankApp
{
    public partial class Accounts : UserControl
    {
        private User user;
        private BankAccount selectedAccount;
        public Accounts()
        {
            InitializeComponent();
        }

        public void InitializeData(User user)
        {
            this.user = user;
            RefreshAccountsGrid();
        }

        private void LoadAccounts()
        {
            dataGridViewAccounts.DataSource = null; // Rensa befintlig koppling
            dataGridViewAccounts.DataSource = GetUserBankAccount(); // Ladda ny data
            dataGridViewAccounts.ClearSelection(); // Ingen rad markerad
            deleteBtn.Enabled = false;
            deleteBtn.Cursor = Cursors.Default;
            editBtn.Enabled = false;
            editBtn.Cursor = Cursors.Default;
        }

        // Anpassa datagridens design
        private void CustomizeAccountsGrid()
        {
            if (dataGridViewAccounts.Columns.Count > 0)
            {
                dataGridViewAccounts.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                // Gör alla kolumner ReadOnly, förutom "Name"
                foreach (DataGridViewColumn column in dataGridViewAccounts.Columns)
                {
                    column.ReadOnly = true;
                }
                dataGridViewAccounts.Columns["Name"].ReadOnly = true;
            }

            // Gör att hela raden markeras vid klick
            dataGridViewAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Förhindra att användaren markerar flera rader
            dataGridViewAccounts.MultiSelect = false;
        }

        // Uppdatera och anpassa datagridens data och design
        private void RefreshAccountsGrid()
        {
            LoadAccounts();
            CustomizeAccountsGrid();
        }

        // Hämta användarens konton
        private List<BankAccount> GetUserBankAccount()
        {
            return user?.Accounts ?? new List<BankAccount>();
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Be användaren om kontonamn
            string accountName = Prompt.ShowDialog("Ange ett namn för det nya kontot:", "Skapa Nytt Konto");

            if (!string.IsNullOrWhiteSpace(accountName))
            {
                // Skapa ett nytt konto
                var newAccount = new BankAccount(accountName, GenerateAccountNumber(), 0);

                // Lägg till kontot till användarens lista
                user.Accounts.Add(newAccount);

                // Uppdatera datagriden
                RefreshAccountsGrid();
            }
            else
            {
                MessageBox.Show("Kontonamnet får inte vara tomt.", "Ogiltigt Namn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private string GenerateAccountNumber()
        {
            // Generera ett unikt kontonummer
            return Guid.NewGuid().ToString().Substring(0, 10).Replace("-", "").ToUpper();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {

            if (selectedAccount != null)
            {
                if (selectedAccount.Balance == 0)
                {
                    user.Accounts.Remove(selectedAccount); // Ta bort kontot
                    selectedAccount = null; // Återställ val
                    RefreshAccountsGrid(); // Uppdatera datagriden
                }
                else
                {
                    MessageBox.Show("Konto innehåller pengar, du måste överföra pengarna innan du kan ta bort kontot!");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett konto att ta bort.");
            }
        }
        private void Accounts_Load(object sender, EventArgs e)
        {
        }
        private void dataGridViewAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ignorera header-raden
            {
                selectedAccount = dataGridViewAccounts.Rows[e.RowIndex].DataBoundItem as BankAccount;
            }
        }
        private void dataGridViewAccounts_SelectionChanged(object sender, EventArgs e)
        {
            // Kontrollera om det finns en markerad rad
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                deleteBtn.Enabled = true; // Aktivera Delete-knappen
                deleteBtn.Cursor = Cursors.Hand;
                editBtn.Enabled = true;
                editBtn.Cursor = Cursors.Hand;
            }
            else
            {
                deleteBtn.Enabled = false; // Inaktivera Delete-knappen
                deleteBtn.Cursor = Cursors.Default;
                editBtn.Enabled = false;
                editBtn.Cursor = Cursors.Default;

            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedAccount != null)
            {
                // Be användaren om ett nytt namn
                string newName = Prompt.ShowDialog("Ange ett nytt namn för kontot:", "Redigera Kontonamn");

                if (!string.IsNullOrWhiteSpace(newName))
                {
                    // Uppdatera kontots namn
                    selectedAccount.Name = newName;

                    // Uppdatera datagriden
                    RefreshAccountsGrid();

                    // Återställ vald rad
                    selectedAccount = null;
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett konto att redigera.");
            }
        }
        private void transferBtn_Click(object sender, EventArgs e)
        {
            var result = TransferPrompt.ShowDialog(user.Accounts, "Överför Pengar");

            if (result.FromAccount != null && result.ToAccount != null && result.Amount > 0)
            {
                Console.WriteLine($"Från konto: {result.FromAccount.Name}, Till konto: {result.ToAccount.Name}, Belopp: {result.Amount}");

                try
                {
                    // Kontrollera saldo och genomför överföring
                    if (result.FromAccount.Balance >= result.Amount)
                    {
                        Console.WriteLine("Tillräckligt saldo, genomför överföring.");
                        result.FromAccount.Balance -= result.Amount;
                        result.ToAccount.Balance += result.Amount;

                        MessageBox.Show("Överföringen lyckades!", "Bekräftelse", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Uppdatera datagriden
                        RefreshAccountsGrid();
                    }
                    else
                    {
                        MessageBox.Show("Otillräckligt saldo på avsändarkontot.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ett fel uppstod: {ex.Message}", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Överföringen avbröts eller ogiltiga data angavs.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
