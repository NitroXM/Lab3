using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose which task you want to execute:\n1.Task 1\n2.Task 2\n3.Task 3\n4.Task 4");
        int choise = int.Parse(Console.ReadLine());
        switch (choise)
        {
            case 1:
                Task1();
                break;
                case 2:
                Task2();
                break; 
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
        }

        void Task1()
        {
            Console.WriteLine("Enter side1");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Now enter side2");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(side1, side2);
            Console.WriteLine($"Area of a given Rectange is: {rect.Area}");
            Console.WriteLine($"Perimeter of a given Rectange is: {rect.Perimeter}");
        }
        void Task2()
        {
            var book = new Book();

            BookProperty[] props = { new Title("Book of Luke"), new Author("Luke"), new Content("Many have undertaken to draw up an account of +" +
                " the things that have been fulfilled among us,") };

            foreach (var property in props)
            {
                book.AddProperty(property);
            }

            book.Show();
        }
        void Task3()
        {
            var figure = new Figure(new Point(1.3, 2.2), new Point(3.2, 3.6), new Point(4.4, 6.9), new Point(6.3, 3.4));

            Console.WriteLine(figure.Name);
            Console.WriteLine(figure.PerimeterCalculator());
        }
        void Task4()
        {
            Console.WriteLine("Please enter the account: ");
            int account = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the customer: ");
            string customer = Console.ReadLine();
            Console.WriteLine("Please enter the provider: ");
            string provider = Console.ReadLine();
            Invoice invoice1 = new Invoice(account, customer, provider);
            Console.WriteLine("Please enter the article: ");
            invoice1.Article = Console.ReadLine();
            Console.WriteLine("Please enter the quantity: ");
            invoice1.Quantity = int.Parse(Console.ReadLine());
            invoice1.calc(account);

        }

    }
}


