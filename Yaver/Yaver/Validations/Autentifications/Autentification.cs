

namespace Yaver.Validations.Autentifications
{
    public class Autentification:UserValidations
    {
        public static void Register()
        {
            string name = GetName();
            string surname = GetSurname();
            string email = GetEmail();
            string password = GetPassword();

            if (UserValidations.CheckName(name) & UserValidations.CheckSurname(surname) & UserValidations.CheckPassword(password) & UserValidations.CheckEmail(email))
            {

            }
        }
        public static string GetName()
        {
            Console.WriteLine("Ad daxil edin");
                string name = Console.ReadLine();
            while (UserValidations.CheckName(name)) 
            {
                Console.WriteLine("Duzgun daxil et");
                name = Console.ReadLine();
            }
            return name;

         }
        public static string GetSurname()
        {
            Console.WriteLine("Soyad daxil edin");
            string surname = Console.ReadLine();
            while (!UserValidations.CheckName(surname))
            {
                Console.WriteLine("Duzgun daxil et");
                surname = Console.ReadLine();
            }
            return surname;


        }
        public static string GetEmail()
        {
            Console.WriteLine("Email daxil edin");
            string email = Console.ReadLine();
            while (!UserValidations.CheckName(email))
            {
                Console.WriteLine("Duzgun daxil et");
                    email = Console.ReadLine();
            }
            return email;

        }
        public static string GetPassword()
        {
            Console.WriteLine("Parol daxil edin");
            string password = Console.ReadLine();
            string confirmpassword = Console.ReadLine();
            while (!UserValidations.CheckName(password))
            {
                Console.WriteLine("Duzgun daxil et");
                password = Console.ReadLine();
            }
            return password;
        }
    }
}
