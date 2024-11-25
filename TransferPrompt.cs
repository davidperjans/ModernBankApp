using ModernBankApp.Classes.BankFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernBankApp
{
    public static class TransferPrompt
    {
        public static (BankAccount FromAccount, BankAccount ToAccount, decimal Amount) ShowDialog(
        List<BankAccount> accounts, string caption)
        {
            Form prompt = new Form()
            {
                Width = 400,
                Height = 300,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };

            Label fromLabel = new Label() { Left = 20, Top = 20, Text = "Från konto:", AutoSize = true };
            ComboBox fromComboBox = new ComboBox() { Left = 20, Top = 50, Width = 350 };
            fromComboBox.DataSource = accounts;
            fromComboBox.DisplayMember = "Name"; // Visa kontonamn
            fromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            Label toLabel = new Label() { Left = 20, Top = 90, Text = "Till konto:", AutoSize = true };
            ComboBox toComboBox = new ComboBox() { Left = 20, Top = 120, Width = 350 };
            toComboBox.DataSource = accounts.Where(a => a != fromComboBox.SelectedItem).ToList(); // Exkludera valda
            toComboBox.DisplayMember = "Name";
            toComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            fromComboBox.SelectedIndexChanged += (sender, e) =>
            {
                toComboBox.DataSource = accounts.Where(a => a != fromComboBox.SelectedItem).ToList();
            };

            Label amountLabel = new Label() { Left = 20, Top = 160, Text = "Belopp:", AutoSize = true };
            TextBox amountTextBox = new TextBox() { Left = 20, Top = 190, Width = 350 };

            Button confirmation = new Button() { Text = "Överför", Left = 270, Width = 100, Top = 230, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(fromLabel);
            prompt.Controls.Add(fromComboBox);
            prompt.Controls.Add(toLabel);
            prompt.Controls.Add(toComboBox);
            prompt.Controls.Add(amountLabel);
            prompt.Controls.Add(amountTextBox);
            prompt.Controls.Add(confirmation);

            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK
                && decimal.TryParse(amountTextBox.Text, out decimal amount) && amount > 0
                ? ((BankAccount)fromComboBox.SelectedItem, (BankAccount)toComboBox.SelectedItem, amount)
                : (null, null, 0);
        }
    }
}
