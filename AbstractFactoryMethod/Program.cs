using AbstractFactoryMethod.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Cient businessMan = new Cient(new FormalClothesFactory());
            Console.WriteLine($"BusinessMan: {businessMan.DescribeYourClothes()}");
            Cient Student = new Cient(new CasualClothesFactory());
            Student.DescribeYourClothes();
            Console.WriteLine($"Student: {Student.DescribeYourClothes()}");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
