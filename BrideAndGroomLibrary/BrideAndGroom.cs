using System;
using System.Text;
using System.Security.Cryptography;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Жених и невеста
    /// </summary>
    public class BrideAndGroom : Person
    {
        private static readonly SHA1 hasher = SHA1.Create();

        /// <summary>
        ///     Конструктор жениха или невесты
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="ownProperties">Собственные свойства</param>
        /// <param name="desiredProperties">Свойства, которые хотелось бы иметь у партнёра</param>
        public BrideAndGroom(string email,
            string passwordHash,
            string fullName,
            Gender gender,
            Properties ownProperties,
            Properties desiredProperties) : base(fullName,
            gender)
        {
            Email = email;
            PasswordHash = passwordHash;
            OwnProperties = ownProperties;
            DesiredProperties = desiredProperties;
        }

        public string Email { get; set; }
        public string PasswordHash { get; set; }

        /// <summary>
        ///     Собственные свойства
        /// </summary>
        public Properties OwnProperties { get; }

        /// <summary>
        ///     Свойства, которые хотелось бы иметь у партнёра
        /// </summary>
        public Properties DesiredProperties { get; set; }

        public static string HashString(string str)
		{
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            byte[] hash = hasher.ComputeHash(bytes);
            string hexHash = Convert.ToHexString(hash);

            return hexHash;
		}
    }
}
