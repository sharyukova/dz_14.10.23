using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classesfordz6;

namespace Проект___Лагерь_для_беженцев_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adults person = new Adults();
            person.Age = 25;
            person.Name = "Макс";
            person.Surname = "Вандебург";
            person.Gender = "мужской";
            person.PassportSeries = 1234;
            person.PassportNumber = 567891011;
            person.NumberOfChildren = 0;
            person.Nationality = "еврей";
            person.PrintInformation();
            person.Reason = "Холокост в Германии";
            person.PrintReasonOfStaying();
            // вызываем медицинских работников
            Console.WriteLine();
            Medicine medicine = new Medicine(); 
            medicine.ShowTypeOfHelp(); 
            person.AskForHelp(medicine);
            // вызываем полицию
            Console.WriteLine();
            Police police = new Police();
            police.ShowTypeOfHelp();
            person.AskForHelp(police);
            // вызываем грузовик с продовольствием
            Console.WriteLine();
            FoodClothesEtc foodClothesEtc = new FoodClothesEtc();
            foodClothesEtc.ShowTypeOfHelp();
            foodClothesEtc.FoodName = "гороховый суп";
            foodClothesEtc.FoodCount = 1;
            foodClothesEtc.ClothesName = "Куртка зимняя";
            foodClothesEtc.ClothesCount = 1;
            foodClothesEtc.PrintWhatPersonNeed();
            person.AskForHelp(foodClothesEtc);
            //
            Console.WriteLine();
            person.LeaveTheCamp();
        }
    }
}
