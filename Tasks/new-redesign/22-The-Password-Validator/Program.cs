namespace LevelTask.Task22
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string password;

            do
            {
                Console.WriteLine("Enter a password :");
                password = Console.ReadLine();

            } while (!PasswordValidator.ValidatePassword(password));

            Console.WriteLine("Password is valid.");
        }
    }

    class PasswordValidator
    {
        public static bool ValidatePassword(string password)
        {
            string warningMsj;
            if (password.Length > 13 && password.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 13 characters long.");
                return false; // Password must be at least 8 characters long
            }
            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;
            bool hasSpecialChar = false;
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                else if (char.IsLower(c)) hasLowerCase = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSpecialChar = true;
            }

            warningMsj = (hasUpperCase ? "" : "must contain an uppercase letter\n") +
                (hasLowerCase ? "" : "must contain a lowercase letter\n") +
                (hasDigit ? "" : "must contain a digit\n") +
                (hasSpecialChar ? "" : "must contain a special character\n") +
                ((password.Contains("T") || password.Contains("&") ? "Password cannot contain 'T' or '&'\n" : ""));
            Console.WriteLine(warningMsj);
            if (password.Contains("T") || password.Contains("&"))
            {
                return false;
            }
            return hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar;
        }
    }
}
