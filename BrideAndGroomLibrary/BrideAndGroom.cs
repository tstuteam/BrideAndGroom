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
        public BrideAndGroom(string fullName,
            Gender gender,
            Properties ownProperties,
            Properties desiredProperties) : base(fullName,
            gender)
        {
            OwnProperties = ownProperties;
            DesiredProperties = desiredProperties;
        }

        /// <summary>
        ///     Собственные свойства
        /// </summary>
        public Properties OwnProperties { get; }

        /// <summary>
        ///     Свойства, которые хотелось бы иметь у партнёра
        /// </summary>
        public Properties DesiredProperties { get; }
    }
}
