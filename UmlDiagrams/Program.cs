using System;

namespace UmlDiagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("hello@world.de", "MySecurePassword123");
            Account account2 = new Account("hans.maier@gmail.de", "password", "Hans", "Maier");
            Account account3 = new Account("gt@", "123456", "Giesela", "Thomas", phone: "0127483943");

            CheckEmail(account1);
            CheckEmail(account2);
            CheckEmail(account3);

            account1.ResetPassword("MySecurePassword123", "MyNewPassword");
            account2.ResetPassword("password", "MyNewPassword");
            try { account3.ResetPassword("password", "MyNewPassword"); } catch { Console.WriteLine("Wow. Echt nicht?"); }

            account1.EncodePassword();
            Console.WriteLine("Account 1 Password Hash: {0}", account1.Password);
            account2.EncodePassword();
            Console.WriteLine("Account 2 Password Hash: {0}", account2.Password);
            account3.EncodePassword();
            Console.WriteLine("Account 3 Password Hash: {0}", account3.Password);

            Call(account1);
            Call(account2);
            Call(account3);
        }

        public static void Call(Account account)
        {
            if(account.Phone == null)
            {
                Console.WriteLine("Account hat keine Telefonnummer");
            }
            else
            {
                Console.WriteLine("Wähle '{0}'. Peeeeeeeeeep. Geht keiner ran.", account.Phone);
            }
        }

        public static void CheckEmail(Account account)
        {
            if (account.CheckEmail())
            {
                Console.WriteLine("Email '{0}' ist valide", account.EmailAddress);
            }
            else
            {
                Console.WriteLine("Email '{0}' ist nicht valide", account.EmailAddress);
            }
        }
    }
}
