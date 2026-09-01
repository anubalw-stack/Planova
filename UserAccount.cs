using System;
using System.Globalization;
using System.IO;

namespace tech_titans
{
    public class UserAccount
    {
        public string Email { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }

        // Kept private: only used to verify the entered password on Login().
        private string password;

        public UserAccount(string email, string name, DateTime birthDate, string password)
        {
            Email = email;
            Name = name;
            BirthDate = birthDate;
            this.password = password;
        }

        /// <summary>
        /// Checks the entered password against this account's stored password.
        /// On success, marks this account as the active session user.
        /// </summary>
        public bool Login(string enteredPassword)
        {
            if (password == enteredPassword)
            {
                Session.CurrentUser = this;
                return true;
            }

            return false;
        }

        public string GetUserDetails()
        {
            return $"Name: {Name}{Environment.NewLine}" +
                   $"Email: {Email}{Environment.NewLine}" +
                   $"Birth Date: {BirthDate:dd/MM/yyyy}";
        }

        public void Logout()
        {
            Session.Logout();
        }

        /// <summary>
        /// Reads the CSV file and returns the UserAccount matching the given email,
        /// or null if no matching row is found.
        /// CSV row format: email,name,birthDate,password
        /// </summary>
        public static UserAccount FindByEmail(string email, string csvFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) ||
                    line.StartsWith("Email,", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                string[] data = line.Split(',');

                if (data.Length < 4)
                {
                    continue;
                }

                string csvEmail = data[0].Trim();

                if (csvEmail.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    string csvName = data[1].Trim();
                    string csvBirthDate = data[2].Trim();
                    string csvPassword = data[3].Trim();

                    DateTime.TryParseExact(
                        csvBirthDate,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out DateTime birthDate);

                    return new UserAccount(csvEmail, csvName, birthDate, csvPassword);
                }
            }

            return null;
        }

        /// <summary>
        /// Updates the stored password for the given email in the CSV file.
        /// Returns true if a matching row was found and updated.
        /// </summary>
        public static bool UpdatePassword(string email, string newPassword, string csvFilePath)
        {
            string[] lines = File.ReadAllLines(csvFilePath);
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                if (string.IsNullOrWhiteSpace(line) ||
                    line.StartsWith("Email,", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                string[] data = line.Split(',');

                if (data.Length < 4)
                {
                    continue;
                }

                if (data[0].Trim().Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    lines[i] = $"{data[0].Trim()},{data[1].Trim()},{data[2].Trim()},{newPassword}";
                    updated = true;
                    break;
                }
            }

            if (updated)
            {
                File.WriteAllLines(csvFilePath, lines);
            }

            return updated;
        }
    }
}