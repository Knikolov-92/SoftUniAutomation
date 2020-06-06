using AutomationPractice.Utils;

namespace AutomationPractice.Pages.SignUp
{
    public partial class SignUpPage : BasePage
    {
        //constants
        public static readonly int NAME_MIN_LENGTH = 1;
        public static readonly int NAME_MAX_LENGTH = 10;
        public static readonly int PASSWORD_MIN_LENGTH = 5;
        public static readonly int PASSWORD_MAX_LENGTH = 10;
        public static readonly int POSTAL_CODE_LENGTH = 5;
        public static readonly int PHONE_MIN_LENGTH = 1;
        public static readonly int PHONE_MAX_LENGTH = 10;

        //-------------------------ENUMS-------------------------------------------------------------------
        //Attribute used to get the string

        //STATE VALUES (DropDownMenu)
        public enum UnitedStates
        {
            [EnumStringAttribute("Alabama")]
            Alab = 1,
            [EnumStringAttribute("Alaska")]
            Alas = 2,
            [EnumStringAttribute("Arizona")]
            Ari = 3,
            [EnumStringAttribute("Arkansas")]
            Ark = 4,
            [EnumStringAttribute("California")]
            Cal = 5,
            [EnumStringAttribute("Colorado")]
            Col = 6,
            [EnumStringAttribute("Connecticut")]
            Conn = 7,
            [EnumStringAttribute("Delaware")]
            Del = 8,
            [EnumStringAttribute("Florida")]
            Flo = 9,
            [EnumStringAttribute("Georgia")]
            Geo = 10,

            [EnumStringAttribute("Hawaii")]
            Haw = 11,
            [EnumStringAttribute("Idaho")]
            Ida = 12,
            [EnumStringAttribute("Illinois")]
            Ill = 13,
            [EnumStringAttribute("Indiana")]
            Ind = 14,
            [EnumStringAttribute("Iowa")]
            Iow = 15,
            [EnumStringAttribute("Kansas")]
            Kan = 16,
            [EnumStringAttribute("Kentucky")]
            Ken = 17,
            [EnumStringAttribute("Louisiana")]
            Lou = 18,
            [EnumStringAttribute("Maine")]
            Mai = 19,
            [EnumStringAttribute("Maryland")]
            Mar = 20,

            [EnumStringAttribute("Massachusetts")]
            Mas = 21,
            [EnumStringAttribute("Michigan")]
            Mic = 22,
            [EnumStringAttribute("Minnesota")]
            Min = 23,
            [EnumStringAttribute("Mississippi")]
            Mis = 24,
            [EnumStringAttribute("Missouri")]
            Miss = 25,
            [EnumStringAttribute("Montana")]
            Mon = 26,
            [EnumStringAttribute("Nebraska")]
            Neb = 27,
            [EnumStringAttribute("Nevada")]
            Nev = 28,
            [EnumStringAttribute("New Hampshire")]
            NHAM = 29,
            [EnumStringAttribute("New Jersey")]
            NJE = 30,

            [EnumStringAttribute("New Mexico")]
            NME = 31,
            [EnumStringAttribute("New York")]
            NY = 32,
            [EnumStringAttribute("North Carolina")]
            NCA = 33,
            [EnumStringAttribute("North Dakota")]
            NDA = 34,
            [EnumStringAttribute("Ohio")]
            Oh = 35,
            [EnumStringAttribute("Oklahoma")]
            Okl = 36,
            [EnumStringAttribute("Oregon")]
            Ore = 37,
            [EnumStringAttribute("Pennsylvania")]
            Pen = 38,
            [EnumStringAttribute("Rhode Island")]
            RIS = 39,
            [EnumStringAttribute("South Carolina")]
            SCA = 40,

            [EnumStringAttribute("South Dakota")]
            SDA = 41,
            [EnumStringAttribute("Tennessee")]
            Ten = 42,
            [EnumStringAttribute("Texas")]
            Tex = 43,
            [EnumStringAttribute("Utah")]
            Ut = 44,
            [EnumStringAttribute("Vermont")]
            Ver = 45,
            [EnumStringAttribute("Virginia")]
            Vir = 46,
            [EnumStringAttribute("Washington")]
            Was = 47,
            [EnumStringAttribute("West Virginia")]
            WVi = 48,
            [EnumStringAttribute("Wisconsin")]
            Wis = 49,
            [EnumStringAttribute("Wyoming")]
            Wyo = 50,

            [EnumStringAttribute("Puerto Rico")]
            PUR = 51,
            [EnumStringAttribute("US Virgin Islands")]
            VIS = 52,
            [EnumStringAttribute("District of Columbia")]
            DOC = 53
        }

        //SignUp Errors - validations
        public enum Errors
        {
            [EnumStringAttribute("firstname is required.")]
            emptyFirstName = 1,
            [EnumStringAttribute("passwd is required.")]
            emptyPassword = 2,
            [EnumStringAttribute("You must register at least one phone number.")]
            emptyPhone = 3,
            [EnumStringAttribute("This country requires you to choose a State.")]
            emptyState = 4,
            [EnumStringAttribute("The Zip/Postal code you've entered is invalid. It must follow this format: 00000")]
            invalidPostalCode = 5,
            [EnumStringAttribute("firstname is invalid.")]
            invalidFirstName = 6,
            [EnumStringAttribute("passwd is invalid.")]
            invalidPassword = 7,
            [EnumStringAttribute("phone_mobile is invalid.")]
            invalidPhone = 8,
            [EnumStringAttribute("lastname is required.")]
            emptyLastName = 9,
            [EnumStringAttribute("email is required.")]
            emptyEmail = 10,
            [EnumStringAttribute("id_country is required.")]
            emptyCountry = 11,
            [EnumStringAttribute("alias is required.")]
            emptyAlias = 12,
            [EnumStringAttribute("address1 is required.")]
            emptyAddress = 13,
            [EnumStringAttribute("city is required.")]
            emptyCity = 14,
            [EnumStringAttribute("Country cannot be loaded with address->id_country")]
            missingCountryID = 15,
            [EnumStringAttribute("Country is invalid")]
            invalidCountry = 16,
        }
        //-------------------------enums-END------------------------------------------------------------------
    }
}
