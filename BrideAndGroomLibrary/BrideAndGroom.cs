using System.Drawing;

namespace BrideAndGroomLibrary
{
    /// <summary>
    ///     Жених и невеста
    /// </summary>
    public class BrideAndGroom : Person
    {
        public Properties DesiredProperties { get; }

        public Properties OwnProperties { get; }

        public BrideAndGroom(int age,
            Color eyesColor,
            string fullName,
            Color hairColor,
            int height,
            Gender gender,
            Properties desiredProperties,
            Properties ownProperties) : base(age,
            eyesColor,
            fullName,
            hairColor,
            height,
            gender)
        {
            DesiredProperties = desiredProperties;
            OwnProperties = ownProperties;
        }
    }
}
