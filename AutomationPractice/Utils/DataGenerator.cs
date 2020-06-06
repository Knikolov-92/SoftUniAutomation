using AutomationPractice.Pages.SignUp;
using System;

namespace AutomationPractice.Utils
{
    public class DataGenerator
    {
        public DataGenerator()
        {

        }

        public string GenerateRandomString(int stringLength)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);

            return finalString;
        }

        public string GenerateRandomStringNumber(int stringLength)
        {
            var chars = "0123456789";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var number = new String(stringChars);

            return number;
        }

        public string GenerateRandomStringName(int stringLength)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var stringChars = new char[stringLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var name = new String(stringChars);

            return name;
        }

        public string GenerateRandomPhoneNumber()
        {
            var chars = "0123456789";
            var stringChars = new char[SignUpPage.PHONE_MAX_LENGTH];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var number = new String(stringChars);

            return number;
        }

        
    }
}
