using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnketTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Я провожу анкетирование пользователей данной программы. Просим вас ответить на" +
                "ряд вопросов.\nПервый вопрос: как вас зовут?");
            var yourName = Console.ReadLine();
            Console.WriteLine("Отлично! Мы узнали ваше имя. Можете назвать вашу фамилию?");
            var yourSurname = Console.ReadLine();
            Console.WriteLine("Итак, мы узнали ваше имя и фамилию. Теперь стоит узнать ваш возраст - сколько вам лет?" +
                "\nПросим вас использовать только числа до 255, или мы будем вынуждены попросить вас снова ввести возраст.");
            byte yourAge; bool ageIsCorrect, dateIsCorrect;
            DateTime yourDate;
            do
            { ageIsCorrect = byte.TryParse(Console.ReadLine(), out yourAge); } //проверяем корректность ввода
            while (!ageIsCorrect); //при некорректном вводе производиться повторная попытка
            Console.WriteLine("Прекрасно! Осталось совсем немного до последнего вопроса: назовите дату вашего рождения в формате" +
                " дд.мм.гггг.\nПри вводе некорректных значений - ввод начнётся заново!");
            do 
            { dateIsCorrect = DateTime.TryParse(Console.ReadLine(), out yourDate); }
            while (!dateIsCorrect); //похож на предыдущий цикл, но производится проверка даты
            if ((DateTime.Now.Month > yourDate.Month) && (DateTime.Now.Year - yourDate.Year == yourAge))
                Console.WriteLine("Спасибо за честный ответ! Если бы вы соврали - данное предложение было бы иным... \nА теперь перейдём к последнему вопросу!");
            else Console.WriteLine("Жаль, что вы не совсем честно ответили... \nНо давате перейдём к последнему вопросу!");
            Console.WriteLine("Очевидно, что вы из потока CDEV, но какой у него номер?");
            var streamNum = Convert.ToInt32(Console.ReadLine());
            var shortYourDate = yourDate.ToShortDateString(); //для корректного обозначения даты, без времени
            Console.WriteLine($"\nИтак, итог нашей анкеты: вас зовут {yourName} {yourSurname}, вам {yourAge} год(а)/лет" +
                $", вы родились {shortYourDate}. На данный момент вы проходите обучение в SkillFactory на потоке CDEV-{streamNum}.");
            Console.WriteLine("\nСпасибо вам за прохождение анкеты!");
            Console.ReadKey();
        }
    }
}
