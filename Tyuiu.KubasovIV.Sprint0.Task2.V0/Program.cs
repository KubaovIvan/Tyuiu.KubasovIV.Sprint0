using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubasovIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KubasovIV.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов класса DataService и метода GetMessage
            //Из библеотеки Tyuiu.KubasovIV.Sprint0.Task2.V0.Lib
            Console.WriteLine(DataService.GetMessage("Иван"));
            Console.ReadKey();
        }
    }
}
