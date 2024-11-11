using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Название файла: ");
            string fileName = Console.ReadLine();
            FileManager mgr = new FileManager();



            if (mgr.FindFullWay(fileName) != null)
            {
                Console.WriteLine($"Полный путь до файла {fileName}: {mgr.FindFullWay(fileName)}" );
            }
            else
            {
                Console.WriteLine("неверный путь до файла или название файла");
            }

        }
    }
}
