using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace titipodierd
{
    class MS
    {
        static void Main(string[] args)
        {
            /*
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string birthdaydate = Console.ReadLine();
            string adress = Console.ReadLine();
            string country = Console.ReadLine();
            char sex = (char)Console.Read();
            
            string drank = "Yamchbl3";
            string points = "44";
            string countoflessensperweek = "4";
            string teacher = "Bobkov";
            Console.WriteLine($"Информация о студенте:\n Имя: {name} \n Фамилия: {surname} \n Дата рождения: {birthdaydate} \n Адрес: {adress} \n Пол: {sex} \n Страна: {country}\nCourse Information:\n Название курса: {drank} \n Баллы: {points} \n Количество занятий в неделю: {countoflessensperweek} \n Преподаватель: {teacher}");
            Console.ReadKey(); 

            int FirstNum = int.Parse(Console.ReadLine());
            double SecondNum = int.Parse(Console.ReadLine());
            double avg = (FirstNum + SecondNum) / 2;
            Console.WriteLine(avg);
            Console.ReadKey();*/

            Console.WriteLine("Введите сторону треугольника:\n ");
            double stor = int.Parse(Console.ReadLine());
            double sqrt = Math.Sqrt(3);

            Console.WriteLine($"Периметр: {stor * 3}");
            Console.WriteLine($"Площадь: {(stor * stor * sqrt) / 4}");
            Console.ReadKey();

        }
    }
}
