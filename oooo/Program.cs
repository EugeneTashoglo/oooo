using System;
using System.Collections.Generic;
using System.Linq;


namespace oooo
{
    enum CommodityType
    {
        ЗамороженныеТовары, Пища,ХимТовары,СтроительныеМатериалы,Концелярия
    }
    enum TransportType
    {
       Рефрежиратор,Железнодорожный,Самосвал,Автовоз,Инкубатор
    }
    enum DistanceSun:ulong
    {
        Солнце=0, Меркурий=57900000,Венера=10820000,
            Земля=1496000,Марс=2279000000,Юпитер=7783000000,
            Сатурн=142700000,Уран=287000000,Нептун=4496000000,
            Плутон=5946000000
    }
    public class Program
    {
        public  static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 5:");
            int number=int.Parse(Console.ReadLine());
            if(number>0&&number<6)
            {
                CommodityType commodity=(CommodityType)Enum.
                    GetValues(typeof(CommodityType)).GetValue(number - 1);
                TransportType transport = TransportType.Железнодорожный;
                switch(commodity)
                {
                    case CommodityType.ЗамороженныеТовары:
                        transport = TransportType.Рефрежиратор;
                        break;
                    case CommodityType.Пища:
                        transport = TransportType.Инкубатор;
                        break;
                    case CommodityType.ХимТовары:
                        transport = TransportType.Инкубатор;
                        break;
                    case CommodityType.Концелярия:
                        transport = TransportType.Самосвал;
                        break;
                    case CommodityType.СтроительныеМатериалы:
                        transport = TransportType.Автовоз;
                        break;
                }
                Console.WriteLine($"Для товара{commodity}"+
                   $"небходим транспорт{transport}");

            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
            string planet=Console.ReadLine();
            if(Enum.IsDefined(typeof(DistanceSun),planet))
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
            //Система счислений
            foreach (DistanceSun  item in Enum.GetValues(typeof(DistanceSun)))
            {
                Console.WriteLine(Enum.Format(typeof(DistanceSun), item, "G"));
                Console.WriteLine(Enum.Format(typeof(DistanceSun), item, "D"));
                Console.WriteLine(Enum.Format(typeof(DistanceSun), item, "X"));
            }
            //Все имена
            foreach (DistanceSun item in Enum.GetValues(typeof(DistanceSun)))
            {
                Console.WriteLine(item);
            }
        }
    }
}