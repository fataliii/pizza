

using System.Text.RegularExpressions;

namespace Yaver.Validations
{
    public class UserValidations
    {
        public static bool CheckName(string name)
        {
            string regex = "^[a-z -']+$";
            Regex regex1 = new Regex(regex);
            if(regex1.IsMatch(name)&&name.Length<=5&&name.Length>=20)
            {
            return true;
            }
            else 
            {
                Console.WriteLine("duzgun yaz");
                return false;
            }
        }
        public static bool CheckPassword(string password) 
        {
            string regex = "@\"^(.{0,7}|[^0-9]*|[^A-Z])$";
            Regex regex2 = new Regex(regex);
            if(regex2.IsMatch(password)) 
            {
                return true;
            }
            else
            {
                Console.WriteLine("Duzgun yaz");
                return false;
            }
        }
        public static bool CheckEmail(string email) 
        {
        string regex= "@\"^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$\"";
            Regex regex3 = new Regex(regex);
            if(regex3.IsMatch(email)) 
            {
                return true;

            }
            else
            {
                Console.WriteLine("Duzgun yaz");
                return false;
            }
        }
        public static bool CheckSurname(string surname) 
        {
            string regex = "^[a-z -']+$";
            Regex regex4= new Regex(regex);
            if(regex4.IsMatch(surname)&&surname.Length<=5&&surname.Length>=20)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Duzgun yaz");
                return false;
            }
        }

    }
}
