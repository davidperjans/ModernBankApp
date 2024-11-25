using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernBankApp.Classes.UserFolder;

namespace ModernBankApp.Classes.JSON
{
    public static class DataManager
    {
        // Metod för att spara användare till en JSON-fil
        public static void SaveUsersToFile(List<User> users)
        {
            try
            {
                string filePath = "users.json";
                string json = JsonConvert.SerializeObject(users, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel vid filskrivning
                MessageBox.Show($"Error saving users to file: {ex.Message}");
            }
        }

        // Metod för att ladda användare från en JSON-fil (om du vill läsa tillbaka)
        public static List<User> LoadUsersFromFile()
        {
            try
            {
                string filePath = "users.json";
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<List<User>>(json) ?? new List<User>();
                }
                return new List<User>(); // Returnera en tom lista om filen inte finns
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users from file: {ex.Message}");
                return new List<User>();
            }
        }
    }
}
