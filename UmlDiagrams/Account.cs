using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace UmlDiagrams
{
    public class Account
    {
        public string Forename { get; private set; }
        public string LastName { get; private set; }
        public string ZipCode { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Phone { get; private set; }
        public string MobilePhone { get; private set; }
        public string EmailAddress { get; private set; }
        public string Password { get; private set; }

        private string plainPasword;
        private string PasswordPlaintext { get { return plainPasword; } set { plainPasword = value; EncodePassword(); } }

        public Account(): this("", "") { }
        public Account(string email, string password, string forename = null, string lastname = null, string city = null, string street = null, string zipcode = null, string phone = null, string mobilephone = null) {
            Forename = forename;
            LastName = lastname;
            ZipCode = zipcode;
            Street = street;
            City = city;
            Phone = phone;
            MobilePhone = mobilephone;
            EmailAddress = email;
            PasswordPlaintext = password;
        }
        public bool CheckEmail()
        {
            Regex emailRegex = new Regex("(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|\"(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21\\x23-\\x5b\\x5d-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])*\")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\\x01-\\x08\\x0b\\x0c\\x0e-\\x1f\\x21-\\x5a\\x53-\\x7f]|\\\\[\\x01-\\x09\\x0b\\x0c\\x0e-\\x7f])+)\\])");
            return emailRegex.IsMatch(EmailAddress);
        }
        public void EncodePassword()
        {
            MD5 hasher = MD5.Create();
            byte[] hash = hasher.ComputeHash(Encoding.UTF8.GetBytes(PasswordPlaintext));
            Password = Encoding.ASCII.GetString(hash);
        }
        public void ResetPassword(string oldPassword, string newPassword)
        {
            if(oldPassword == PasswordPlaintext)
            {
                PasswordPlaintext = oldPassword;
            }
            else
            {
                throw new System.Exception("Lol kennst du dein altes passwort nicht mehr? get REKT! n00b l2p!!");
            }
        }
    }
}