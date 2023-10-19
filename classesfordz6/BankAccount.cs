using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesfordz6
{
    /* Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, 
    тип банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
    доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
    вывести информацию об объекте класса на печать.
    */
    public class BankAccount
    {
        private int balance;
        public int IdOfBankAccount { get; set; }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }
        public enum TypeOfBankAccount
        {
            Текущий,
            Сберегательный
        }
        public TypeOfBankAccount AccountType { get; set; }  
        public void PrintInfo()
        {
            Console.WriteLine($"номер счета: {IdOfBankAccount} | тип счета: {AccountType} | баланс: {Balance} ");
        }
        /* Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
        счет.Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
        положительного результата изменяет баланс. */
        public void WithdrawFromTheAccount(int Balance, int sum)
        {
            if (Balance > sum) 
            {
                if (sum >= 0)
                {
                    Console.WriteLine("Деньги снять можно");
                    int balance = Balance - sum;
                    Console.WriteLine($"Текущий баланс: {balance}");
                }
                else
                {
                    Console.WriteLine("Вы ввели отрицательное число.");
                }
            }
            else 
            {
                Console.WriteLine("Деньги снять невозможно. Баланс меньше взятой суммы");
            }
        }
    }
    /*
        Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
        номер счета генерировался сам и был уникальным. Для этого надо создать в классе
        статическую переменную и метод, который увеличивает значение этого переменной.
    */
    public class Bank_Account
    {
        private int balance;
        private int id;
        Random random = new Random();
        public int IdOfBankAccount 
        { 
            get { return id; }
            set
            {
                value = random.Next(1000,9999);
            }
        }
        public int Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }
        public enum TypeOfBankAccount
        {
            Текущий,
            Сберегательный
        }
        public TypeOfBankAccount AccountType { get; set; }
        public void PrintInfo()
        {
            Console.WriteLine($"номер счета: {IdOfBankAccount} | тип счета: {AccountType} | баланс: {Balance} ");
        }
    }
    /*
    Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
    высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
    предусмотреть методы для заполнения полей и получения значений полей для печати.
    Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
    квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
    генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
    хранило последний использованный номер здания, и предусмотреть метод, который
    увеличивал бы значение этого поля.
     */
}
