using AutomationPractice.Models;
using AutomationPractice.Pages.SignUp;
using AutomationPractice.Utils;
using NUnit.Framework.Internal;

namespace AutomationPractice.Factories
{
    public static class SignUpFactory
    {
        private static readonly DataGenerator _generator = new DataGenerator();

        public static SignUpModel CreateUserData()
        {
            Randomizer rand = new Randomizer(); 

            return new SignUpModel
            {
                FirstName = _generator.GenerateRandomStringName(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH)),
                LastName = _generator.GenerateRandomStringName(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH)),
                Password = _generator.GenerateRandomString(rand.Next(SignUpPage.PASSWORD_MIN_LENGTH, SignUpPage.PASSWORD_MAX_LENGTH)),
                Address = _generator.GenerateRandomString(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH))
                            + " "
                            + _generator.GenerateRandomStringNumber(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH))
                            + " "
                            + _generator.GenerateRandomString(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH)),
                PhoneNumber = _generator.GenerateRandomPhoneNumber(),
                City = _generator.GenerateRandomString(rand.Next(SignUpPage.NAME_MIN_LENGTH, SignUpPage.NAME_MAX_LENGTH)),
                PostalCode = _generator.GenerateRandomStringNumber(SignUpPage.POSTAL_CODE_LENGTH)
            };
        }
    }
}
