using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCar
{
    class Car
    {
        public int CarID { get; set; }
        public string Manufacture { get; set; }
        public string Type { get; set; }
        public Int32 Year { get; set; }
        public double Price { get; set; }

    }

    class MyCars
    {
        List<Car> mycars = new List<Car>();
        public bool RemoveCar(int RegNo)
        {
            
            bool result = false;
            foreach(Car car in mycars)
            {
                if(car.CarID==RegNo)
                {
                    mycars.Remove(car);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public Car AddCar()
        {
            Car c = new Car();

            Console.WriteLine("Enter CarID");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Manufacture name : ");
            string m = Console.ReadLine();

            Console.WriteLine("Enter  Car Type : ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter price : ");
            double p = Convert.ToDouble(Console.ReadLine());

            c.CarID = id;
            c.Manufacture = m;
            c.Type = type;
            c.Year = year;
            c.Price = p;
            mycars.Add(c);

            return c;
        }

        public void Modify(int regNo)
        {
            foreach (Car car in mycars)
            {
                if (car.CarID == regNo)
                {
                    Console.WriteLine("Please enter Price of The car : ");
                    double p = Convert.ToDouble(Console.ReadLine());
                    car.Price = p;
                    break;
                }
            }
        }

        public void SearchCar(int regNo)
        {
            foreach (Car car in mycars)
            {
                if (car.CarID == regNo)
                {
                    Console.WriteLine("{0} {1} {2} {3} {4}",car.CarID,car.Manufacture,car.Price,car.Type,car.Year);
                    break;
                }
            }
        }

        public void Display()
        {
            foreach (Car car in mycars)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", car.CarID, car.Manufacture, car.Price, car.Type, car.Year);
            }
        }
        
        static void Main(string[] args)
        {
            //List<Car> mycars = new List<Car>();
            MyCars mycar = new MyCars();
            bool flag;
            while (true)
            {
                flag = false;
                Console.WriteLine("Enter 1.Add 2.Modify 3.Search 4.Display 5.Delete 6.Quit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        
                        mycar.AddCar();
                        break;


                    case 2:
                        Console.WriteLine("Please enter reg no:");
                        int r = Convert.ToInt32(Console.ReadLine());
                        mycar.Modify(r);
                        break;

                    case 3:
                        Console.WriteLine("Please enter reg no:");
                        int r1 = Convert.ToInt32(Console.ReadLine());
                        mycar.SearchCar(r1);
                        break;

                    case 4:
                        mycar.Display();
                        break;
                        

                    case 5:
                        Console.WriteLine("Please enter reg no:");
                        int r2 = Convert.ToInt32(Console.ReadLine());
                        mycar.RemoveCar(r2);
                        break;

                    case 6:
                        flag = true;
                        break;
                        

                    default:
                        Console.WriteLine("You entered wrong choice!!!");
                        break;
                }
                if (flag == true) break;

            }
        }
    }
}
