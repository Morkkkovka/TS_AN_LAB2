using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task_5_
{
    class User
    {
        public string login;
        public string name;
        public string surname;
        public int age;
        private DateTime date = DateTime.Today;

    }

    public void GetInfo()
    {
        Console.WriteLine($"Логін: {login} \nІм'я: {name} \nПрізвище: {surname} \nВік: {age} \nДата реєстрації: {date.ToString("D")}\n");
    }

    class Program

    {

        static void Main(string[] args)

        {

            User user = new User();

            user.login = "A.Tsipur.121.20@knute.edu.ua";

            user.name = "Анна";

            user.surname = "Ціпур";

            user.age = "18";

            user.GetInfo();

            Console.ReadKey();

        }
    }

}
