namespace C__Hw_6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IValidator passwordValidator = new PasswordValidator();
            IValidator emailValidator = new EmailValidator();

            Console.WriteLine("Перевірка пароля 'Test1234': " + passwordValidator.Validate("Test1234"));
            Console.WriteLine("Перевірка email 'test@example.com': " + emailValidator.Validate("test@example.com"));
        } 

        public interface IValidator
        {
            bool Validate(string input);
        }

        public class PasswordValidator : IValidator
        {
            public bool Validate(string input)
            {
                bool hasUpper = false, hasDigit = false;
                if (input.Length < 8) return false;

                foreach (char lol1 in input)
                {
                    if (char.IsUpper(lol1)) hasUpper = true;
                    if (char.IsDigit(lol1)) hasDigit = true;
                }

                return hasUpper && hasDigit;
            }
        }

        public class EmailValidator : IValidator
        {
            public bool Validate(string input)
            {
                if (string.IsNullOrWhiteSpace(input) || !input.Contains("@")) return false;

                string[] parts = input.Split('@');
                if (parts.Length != 2 || string.IsNullOrWhiteSpace(parts[0]) || string.IsNullOrWhiteSpace(parts[1]))
                    return false;

                return parts[1].Contains(".");
            }
        }
    }
}
