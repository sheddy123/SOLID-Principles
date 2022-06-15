using LiskovSubstitutionPrinciple;
using OpenClosedPrinciple;
using SingleResponsibilityPrinciple.LoginHandler;
using System;

namespace SOLID_Principles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle" + Environment.NewLine);
            EmailHandler emailHandler = new EmailHandler();
            User user = new User(emailHandler);
            user.Register("mercy@jane.com", "P@ssw0rd");
            Console.WriteLine("=============================================" + Environment.NewLine);
            Console.WriteLine("Open Closed Principle" + Environment.NewLine);
            Rectangle rectangle = new Rectangle()
            {
                Height = 20,
                Width = 40
            };
            Circle circle = new Circle()
            {
                Radius = 22.34
            };
            AreaCalculator areaCalculator = new AreaCalculator();
            areaCalculator.CalculateTotalArea(rectangle);
            areaCalculator.CalculateTotalArea(circle);
            Console.WriteLine("=============================================" + Environment.NewLine);
            Console.WriteLine("Liskov Substitution Principle" + Environment.NewLine);
            BMW _bmw = new BMW();
            VolksWagen _volkswagen = new VolksWagen();
            _bmw.GetColor();
            _volkswagen.GetColor();
            Console.ReadLine();
        }
    }
}

