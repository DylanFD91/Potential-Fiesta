using PracticeForInterview.CompositePattern;
using PracticeForInterview.DecoratorPattern;
using PracticeForInterview.DependencyInjection;
using PracticeForInterview.FactoryPattern;
using PracticeForInterview.ObserverPattern;
using PracticeForInterview.ProxyPattern;
using PracticeForInterview.FacadePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using PracticeForInterview.DependencyInjection.AnotherExample;

namespace PracticeForInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Factory Pattern ////

            //FordFiestaFactory factory = new FordFiestaFactory();
            //Car whiteFiesta = factory.CreateACar("White");
            //Car blackFiesta = factory.CreateACar("Black");
            //Console.WriteLine("Make: {0} \nModel: {1} \nColor: {2}", whiteFiesta.Make, whiteFiesta.Model, whiteFiesta.Color);
            //Console.ReadLine();

            //// Observer Pattern ////

            //YouTubeChannel devCodeCampChannel = new YouTubeChannel();

            //ISubscriber Heinisch = new User("Heinisch");
            //ISubscriber Jakuwbowski = new User("Jakubowski");
            //ISubscriber Terrill = new Moderator("Terrill");

            //devCodeCampChannel.Subscribe(Heinisch);
            //devCodeCampChannel.Subscribe(Jakuwbowski);
            //devCodeCampChannel.Subscribe(Terrill);
            //devCodeCampChannel.Upload();

            //devCodeCampChannel.Unsubscribe(Heinisch);
            //devCodeCampChannel.Upload();
            //Console.ReadKey();

            ////Facade Pattern ////
            //PizzaFacade organizedRestaurant = new PizzaFacade("BBQ", "Onions", "Gouda");
            //organizedRestaurant.MakePizza();


            //Dough dough = new Dough();
            //Sauce sauce = new Sauce("Tomato");
            //FacadePattern.Topping greenPepper = new FacadePattern.Topping("Green Peppers");
            //Cheese mozzarella = new Cheese("Mozzarella");
            //Oven oven = new Oven();

            //PizzaFacade unorganizedRestaurant = new PizzaFacade("Tomato", "Green Peppers", "Mozzarella");
            //dough.AddSauce(sauce);
            //dough.AddCheese(mozzarella);
            //dough.AddTopping(greenPepper);
            //oven.SetTemperature(425);
            //oven.SetTimer(20);
            //oven.Cook(dough);

            //Console.ReadLine();

            //// Composite Pattern ////

            Worker Matt = new Worker("Matt", "Worker", 80);
            Supervisor Angela = new Supervisor("Angela", "CFO", 90);
            Supervisor Mike = new Supervisor("Mike", "CEO", 100);
            Supervisor Tory = new Supervisor("Tory", "Head of Marketing", 90);
            Worker Steve = new Worker("Steve", "Worker", 85);

            Angela.AddEmployee(Matt); //Matt works for Angela
            Mike.AddEmployee(Angela); //Angela works for Mike
            Mike.AddEmployee(Tory); //Tory works for Mike
            Tory.AddEmployee(Steve); //Steve works for Tory

            Mike.DisplayStatus();
            Console.ReadLine();

            //// Dependency Injection ////

            //DeepDish deepDish = new DeepDish();
            //StuffedCrust stuffedCrust = new StuffedCrust();
            //ThinCrust thin = new ThinCrust();

            //Pizzeria pizzeria = new Pizzeria(stuffedCrust);
            //pizzeria.AddFood();
            //pizzeria.PrepareFood();

            //PowerSupply electric = new PowerSupply(10);
            //CoffeeMaker coffeeMaker = new CoffeeMaker(electric);
            //coffeeMaker.Use();

            //// Proxy Pattern ////

            //ComponentPriceProxy componentPriceProxy = new ComponentPriceProxy();
            //componentPriceProxy.RunProxy();

            ////Server Software of Proxy Pattern
            //var ip = IPAddress.Parse("127.0.0.1");
            //var listener = new TcpListener(ip, 8080);

            //while (true)
            //{
            //    listener.Start();
            //    Console.WriteLine("Waiting for a connection...");

            //    using (var socket = listener.AcceptSocket())
            //    {
            //        Console.WriteLine("Client Connected.");

            //        var data = new byte[15];
            //        socket.Receive(data);
            //        var input = Encoding.Default.GetString(data).TrimEnd('\0');
            //        Console.WriteLine("Clinet Requested: {0}", input);

            //        var prices = new StoredComponentPrices();
            //        var price = 0m;

            //        switch (input)
            //        {
            //            case "cpu":
            //                price = prices.CpuPrice;
            //                break;
            //            case "ram":
            //                price = prices.RamPrice;
            //                break;
            //            case "ssd":
            //                price = prices.SsdPrice;
            //                break;
            //        }
            //        var responseValue = Convert.ToString(price);
            //        var response = Encoding.Default.GetBytes(responseValue);

            //        socket.Send(response);
            //        Console.WriteLine("Response sent to Client: {0}", responseValue);
            //        Console.WriteLine("");
            //    }

            //    listener.Stop();
            //}

            //// Decorator Pattern ////
            //IceCream chocolateIceCream = new Chocolate();
            //chocolateIceCream = new Sprinkle(chocolateIceCream);
            //chocolateIceCream = new Fudge(chocolateIceCream);

            //Console.WriteLine(chocolateIceCream.Cost());
            //Console.ReadKey();

            Console.ReadLine();
        }
    }
}
