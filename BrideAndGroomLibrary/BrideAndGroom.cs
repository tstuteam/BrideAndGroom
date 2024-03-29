using System;
using System.Security.Cryptography;
using System.Text;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Жених и невеста
    /// </summary>
    public class BrideAndGroom : Person
    {
        private static readonly SHA1 Hasher = SHA1.Create();

        /// <summary>
        ///     Конструктор жениха или невесты
        /// </summary>
        /// <param name="passwordHash"></param>
        /// <param name="fullName">Полное имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="ownProperties">Собственные свойства</param>
        /// <param name="desiredProperties">Свойства, которые хотелось бы иметь у партнёра</param>
        /// <param name="email"></param>
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
            var bytes = Encoding.UTF8.GetBytes(str);
            var hash = Hasher.ComputeHash(bytes);
            var hexHash = Convert.ToHexString(hash);

            return hexHash;
        }
    }
}
