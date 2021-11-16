namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Жених и невеста
    /// </summary>
    public class BrideAndGroom : Person
    {
        /// <summary>
        ///     Конструктор жениха или невесты
        /// </summary>
        /// <param name="fullName">Полное имя</param>
        /// <param name="gender">Пол</param>
        /// <param name="ownProperties">Собственные свойства</param>
        /// <param name="desiredProperties">Свойства, которые хотелось бы иметь у партнёра</param>
        public BrideAndGroom(string email,
            string password,
            string fullName,
            Gender gender,
            Properties ownProperties,
            Properties desiredProperties) : base(fullName,
            gender)
        {
            Email = email;
            Password = password;
            OwnProperties = ownProperties;
            DesiredProperties = desiredProperties;
        }

        public string Email { get; set; }
        public string Password { get; set; }

        /// <summary>
        ///     Собственные свойства
        /// </summary>
        public Properties OwnProperties { get; }

        /// <summary>
        ///     Свойства, которые хотелось бы иметь у партнёра
        /// </summary>
        public Properties DesiredProperties { get; set; }
    }
}
