using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Domain.User
{
    public class User : Entity
    {
        
        public string Name { get; set; }
        public string Login { get; set; }
        public string  Password { get; set; }
        public string ConfirmPassword { get; set; }

       
        public void SetPassword(string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new Exception("Senha Inválida");
            }
            if (!string.Equals(password, confirmPassword))
            {
                throw new Exception("As Senhas não conferem");
            }

            this.Password = password;
            this.ConfirmPassword = confirmPassword;
        }


        public static string Encrypt(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }
    }
}
