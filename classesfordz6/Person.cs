using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace classesfordz6
{
    public class Person
    {
        private int age;
        public string Name { get; set; }
        public int Age 
        {
            get {  return age; }
            set
            {
                if (age >= 0)
                { 
                age = value;
                }
            }
        }
        public string Surname { get; set; } // предположим, что у беженца есть фамилия
        public string Gender { get; set; }
        public string Nationality { get; set; } 
        public virtual void PrintInformation()
        {
            Console.WriteLine($"Имя: {Name} | Фамилия: {Surname} | Возраст: {Age} | Пол: {Gender} | Национальность {Nationality}");
        }
        public string Reason { get; set; }
        public void PrintReasonOfStaying()
        {
            Console.WriteLine($"Причина пребывания в лагере: {Reason}");
        }
        /// <summary>
        /// метод реализует просьбу о помощи беженца. 
        /// Т.е. помощь прибудет как можно скорее
        /// </summary>
        /// <param name="help"></param>
        public void AskForHelp(Help help) /* С помощью абстрактного класса "Help" и его
                                            наследников мы можем реализовать метод в за-
                                            висимости от того, какую помощь требуется пре-
                                            доставить */
        {
            help.AskForHelp();
        }
        public void LeaveTheCamp()
        {
            Console.WriteLine($"Житель {Name} {Surname} покидает лагерь");
        }
    }
    public class Adults : Person
    {
        public int PassportSeries { get; set; } // предположим, что у беженца есть доступ к паспорту
        public int PassportNumber { get; set; }
        private int numberofchildren;
        public int NumberOfChildren
        {
            get { return numberofchildren; }
            set
            {
                if (numberofchildren >= 0)
                {
                    numberofchildren = value;
                }
            }
        }
        public override void PrintInformation() // используем полиморфизм 
        {
           Console.WriteLine($"Имя: {Name} | Фамилия: {Surname} | Возраст: {Age} | Пол: {Gender} | Национальность {Nationality} | Серия {PassportSeries} Номер {PassportNumber} паспорта | Количество детей: {NumberOfChildren}");
        }         
    }
    // Создадим абстрактный метод, который предоставит виды гуманитарной помощи
    public abstract class Help
    {
        public abstract void AskForHelp();
        public void ShowTypeOfHelp()
        {
            Console.WriteLine(GetType().Name);
        }
    }
    public class Medicine : Help
    {
        public override void AskForHelp()
        {
            Console.WriteLine("Медицинские работники уже спешат на помощь!");
        }
    }
    public class Police : Help
    {
        public override void AskForHelp()
        {
            Console.WriteLine("Полиция скоро будет на вашем месте!");
        }
    }
    public class FoodClothesEtc : Help
    {
        private int foodcount;
        private int clothescount;
        public string FoodName {  get; set; }
        public int FoodCount
        {
            get { return foodcount; }
            set
            {
                if (foodcount >= 0)
                {
                    foodcount = value;
                }
            }
        }
        public string ClothesName { get; set; }
        public int ClothesCount
        {
            get { return clothescount; }
            set
            {
                if (clothescount >= 0)
                {
                    clothescount = value;
                }
            }
        }
        public void PrintWhatPersonNeed()
        {
            Console.WriteLine($"Выбранная еда: {FoodName} | Количество еды: {FoodCount} | Одежда: {ClothesName} | Количество: {ClothesCount}");
        }
        public override void AskForHelp()
        {
            Console.WriteLine("Грузовик с продовольствием скоро будет на Вашем месте!");
        }
    }
}
