using System;

namespace Tricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = GetCityByPlateCodeV1("03");
            Console.WriteLine(city + " V1");

            city = GetCityByPlateCodeV2("03");
            Console.WriteLine(city + " V2");

            city = GetCityByPlateCodeV3("03");
            Console.WriteLine(city + " V3");

            var f = GetFruit(5);
            Console.WriteLine($"Fruit 1 : {f}");
            f = GetFruit(1);
            Console.WriteLine($"Fruit 1 : {f}");

            Console.ReadLine();
        }

        private static string GetCityByPlateCodeV1(string plateCode)
        {
            var city = string.Empty;
            if (plateCode == "01")
            {
                city = "Adana";
            }
            if (plateCode == "02")
            {
                city = "Adıyaman";
            }
            if (plateCode == "03")
            {
                city = "Afyon";
            }
            if (plateCode == "04")
            {
                city = "Ağrı";
            }
            if (plateCode == "05")
            {
                city = "Amasya";
            }
            if (plateCode == "06")
            {
                city = "Ankara";
            }
            else
            {
                city = "Tanımsız";
            }
            return city;
        }

        private static string GetCityByPlateCodeV2(string plateCode)
        {
            var city = string.Empty;
            if (plateCode == "01")
            {
                city = "Adana";
            }
            else if (plateCode == "02")
            {
                city = "Adıyaman";
            }
            else if (plateCode == "03")
            {
                city = "Afyon";
            }
            else if (plateCode == "04")
            {
                city = "Ağrı";
            }
            else if (plateCode == "05")
            {
                city = "Amasya";
            }
            else if (plateCode == "06")
            {
                city = "Ankara";
            }
            else
            {
                city = "Tanımsız";
            }
            return city;
        }

        private static string GetCityByPlateCodeV3(string plateCode)
        {
            var city = string.Empty;
            switch (plateCode)
            {
                case "01":
                    city = "Adana";
                    break;
                case "02":
                    city = "Adıymana";
                    break;
                case "03":
                    city = "Adana";
                    break;
                case "04":
                    city = "Adıymana";
                    break;
                case "05":
                    city = "Adana";
                    break;
                case "06":
                    city = "Adıymana";
                    break;
                default:
                    city = "Tanımsız";
                    break;
            }
            return city;
        }

        private static string GetFruit(int number)
        {
            //Ternery if
            var fruit = number == 1 ? "Apple" : "Grape";
            return fruit;

            if (number == 1)
            {
                fruit = "Apple";
            }
            else
            {
                fruit = "Grape";
            }

            // var city = number == 1 ? "Adana" : 5; => HATA
        }

        private static void InfinteLoops()
        {
            while (true)
            {

            }

            do
            {

            } while (true);

            for(; ; )
            {

            }
        }
    }
}
