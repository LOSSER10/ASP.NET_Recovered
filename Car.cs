using System;

namespace CarAssignment
{
    // Task 1: Create a Car Class
    class Car
    {
        
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }

        public void Drive(int kilometers)
        {
            Mileage += kilometers; 
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km.");
        }

        //Task 3: Show Car Information
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Task 2: Create Objects of the Class

           
            Car car1 = new Car();
            car1.Brand = "Toyota";
            car1.Model = "Corolla";
            car1.Year = 2020;
            car1.Mileage = 0; 

        
            Car car2 = new Car();
            car2.Brand = "Tesla";
            car2.Model = "Model 3";
            car2.Year = 2022;
            car2.Mileage = 0;

           
            car1.Drive(50);
            car2.Drive(120);
            car1.Drive(30);

            Console.WriteLine(); 

          
            car1.ShowCarInfo();
            car2.ShowCarInfo();

            Console.ReadLine(); 
        }
    }
}
