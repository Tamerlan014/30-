using System;
using System.Collections.Generic;
using System.Linq;

namespace OOPPractice
{
    public class Program
    {
        public static void Main()
        {
            DemoTask1();
            DemoTask2();
            DemoTask3();
            DemoTask4();
            DemoTask5();
            DemoTask6();
            DemoTask7();
            DemoTask8();
            DemoTask9();
            DemoTask10();
            DemoTask11();
            DemoTask12();
            DemoTask13();
            DemoTask14();
            DemoTask15();
            DemoTask16();
            DemoTask17();
            DemoTask18();
            DemoTask19();
            DemoTask20();
            DemoTask21();
            DemoTask22();
            DemoTask23();
            DemoTask24();
            DemoTask25();
            DemoTask26();
            DemoTask27();
            DemoTask28();
            DemoTask29();
            DemoTask30();
        }

        static void DemoTask1()
        {
            Console.WriteLine("=== 1. Животные ===");
            Animal dog = new Dog();
            Animal cat = new Cat();
            Console.WriteLine($"Dog: {dog.Speak()}");
            Console.WriteLine($"Cat: {cat.Speak()}");
        }

        static void DemoTask2()
        {
            Console.WriteLine("\n=== 2. Транспорт ===");
            Vehicle car = new Car { Brand = "BMW", Speed = 220, NumberOfDoors = 4 };
            Vehicle bike = new Motorcycle { Brand = "Yamaha", Speed = 180, EngineVolume = 600 };
            Console.WriteLine($"Car: {car.Brand}, {car.Speed} km/h");
            Console.WriteLine($"Motorcycle: {bike.Brand}, {bike.Speed} km/h");
        }

        static void DemoTask3()
        {
            Console.WriteLine("\n=== 3. Человек и студент ===");
            Student student = new Student { Name = "Анна", Age = 20, Specialty = "Информатика", Course = 2 };
            Console.WriteLine(student);
        }

        static void DemoTask4()
        {
            Console.WriteLine("\n=== 4. Сотрудники ===");
            Manager manager = new Manager { Name = "Иван", Salary = 120000m, Department = "Продажи", TeamSize = 8 };
            Developer developer = new Developer { Name = "Мария", Salary = 150000m, Stack = ".NET", Experience = 5 };
            Console.WriteLine(manager);
            Console.WriteLine(developer);
        }

        static void DemoTask5()
        {
            Console.WriteLine("\n=== 5. Фигуры ===");
            Shape rectangle = new Rectangle(5, 4);
            Shape circle = new Circle(3);
            Console.WriteLine($"Rectangle area = {rectangle.GetArea()}");
            Console.WriteLine($"Circle area = {circle.GetArea()}");
        }

        static void DemoTask6()
        {
            Console.WriteLine("\n=== 6. Транспорт с методом движения ===");
            Vehicle car = new Car { Brand = "Tesla", Speed = 200, NumberOfDoors = 4 };
            Vehicle bus = new Bus { Brand = "Mercedes", Speed = 90, PassengerCapacity = 40 };
            Vehicle train = new Train { Brand = "Siemens", Speed = 300, Carriages = 12 };
            Console.WriteLine(car.Move());
            Console.WriteLine(bus.Move());
            Console.WriteLine(train.Move());
        }

        static void DemoTask7()
        {
            Console.WriteLine("\n=== 7. Работник магазина ===");
            Worker cashier = new Cashier { Name = "Ольга", Position = "Кассир" };
            Worker seller = new Seller { Name = "Петр", Position = "Продавец" };
            Console.WriteLine(cashier);
            Console.WriteLine(seller);
        }

        static void DemoTask8()
        {
            Console.WriteLine("\n=== 8. Компьютеры ===");
            Computer laptop = new Laptop { Processor = "Intel i7", RAM = 16, Screen = 15.6 };
            Computer desktop = new Desktop { Processor = "AMD Ryzen 7", RAM = 32, CaseType = "Tower" };
            Console.WriteLine(laptop);
            Console.WriteLine(desktop);
        }

        static void DemoTask9()
        {
            Console.WriteLine("\n=== 9. Книги ===");
            Book paper = new PaperBook { Title = "Война и мир", Author = "Лев Толстой", Pages = 1400 };
            Book ebook = new EBook { Title = "Программирование на C#", Author = "Иванов", Format = "PDF" };
            Console.WriteLine(paper);
            Console.WriteLine(ebook);
        }

        static void DemoTask10()
        {
            Console.WriteLine("\n=== 10. Домашние животные ===");
            Pet dog = new DogPet { Name = "Шарик" };
            Pet cat = new CatPet { Name = "Мурка" };
            Pet parrot = new Parrot { Name = "Кеша" };
            Console.WriteLine(dog.Eat());
            Console.WriteLine(cat.Eat());
            Console.WriteLine(parrot.Eat());
        }

        static void DemoTask11()
        {
            Console.WriteLine("\n=== 11. Банковские счета ===");
            SavingsAccount savings = new SavingsAccount { Balance = 1000m, InterestRate = 0.07m };
            CreditAccount credit = new CreditAccount { Balance = 0m, CreditLimit = 5000m, InterestRate = 0.12m };
            savings.Deposit(500m);
            savings.Withdraw(200m);
            credit.Deposit(1500m);
            credit.Withdraw(2000m);
            Console.WriteLine(savings);
            Console.WriteLine(credit);
        }

        static void DemoTask12()
        {
            Console.WriteLine("\n=== 12. Транспортная компания ===");
            List<Transport> transports = new List<Transport>
            {
                new CarTransport { Name = "Car-1", BaseFare = 200d },
                new TruckTransport { Name = "Truck-1", BaseFare = 500d },
                new BusTransport { Name = "Bus-1", BaseFare = 350d }
            };

            foreach (var transport in transports)
            {
                Console.WriteLine($"{transport.Name}: cost = {transport.CalculateCost():F2}");
            }
        }

        static void DemoTask13()
        {
            Console.WriteLine("\n=== 13. Работники компании ===");
            Employee programmer = new Programmer { Name = "Дмитрий", Salary = 200000m, BonusRate = 0.15m };
            Employee designer = new Designer { Name = "Елена", Salary = 180000m, BonusRate = 0.1m };
            Employee manager = new ManagerEmployee { Name = "Сергей", Salary = 260000m, BonusRate = 0.2m };
            Console.WriteLine($"Programmer: {programmer.GetSalary()}");
            Console.WriteLine($"Designer: {designer.GetSalary()}");
            Console.WriteLine($"Manager: {manager.GetSalary()}");
        }

        static void DemoTask14()
        {
            Console.WriteLine("\n=== 14. Система образования ===");
            GraduateStudent graduate = new GraduateStudent
            {
                Name = "Виктор",
                Age = 24,
                Specialty = "Математика",
                Course = 5,
                ThesisTopic = "Машинное обучение"
            };
            Console.WriteLine(graduate.GetFullInfo());
        }

        static void DemoTask15()
        {
            Console.WriteLine("\n=== 15. Военная техника ===");
            MilitaryVehicle tank = new Tank();
            MilitaryVehicle helicopter = new Helicopter();
            MilitaryVehicle armoredCar = new ArmoredCar();
            Console.WriteLine(tank.Attack());
            Console.WriteLine(helicopter.Attack());
            Console.WriteLine(armoredCar.Attack());
        }

        static void DemoTask16()
        {
            Console.WriteLine("\n=== 16. Игровые персонажи ===");
            Character warrior = new Warrior { Name = "Воин", Health = 120, Damage = 25 };
            Character mage = new Mage { Name = "Маг", Health = 80, Damage = 40 };
            Character archer = new Archer { Name = "Лучник", Health = 100, Damage = 30 };
            Console.WriteLine(warrior.Attack());
            Console.WriteLine(mage.Attack());
            Console.WriteLine(archer.Attack());
        }

        static void DemoTask17()
        {
            Console.WriteLine("\n=== 17. Электронные устройства ===");
            Device phone = new Phone();
            Device computer = new ComputerDevice();
            Device tv = new Television();
            Console.WriteLine(phone.TurnOn());
            Console.WriteLine(computer.TurnOff());
            Console.WriteLine(tv.TurnOn());
        }

        static void DemoTask18()
        {
            Console.WriteLine("\n=== 18. Платежи ===");
            Payment cash = new CashPayment();
            Payment card = new CardPayment();
            Payment online = new OnlinePayment();
            Console.WriteLine(cash.Pay(250.0));
            Console.WriteLine(card.Pay(500.0));
            Console.WriteLine(online.Pay(1000.0));
        }

        static void DemoTask19()
        {
            Console.WriteLine("\n=== 19. Сотрудники с бонусами ===");
            EmployeeWithBonus manager = new ManagerEmployeeBonus { Name = "Руководитель", Salary = 200000m, BonusPercent = 25m };
            EmployeeWithBonus developer = new DeveloperEmployeeBonus { Name = "Разработчик", Salary = 180000m, BonusPercent = 15m };
            EmployeeWithBonus sales = new SalesManager { Name = "Менеджер по продажам", Salary = 170000m, BonusPercent = 20m };
            Console.WriteLine($"Manager salary with bonus = {manager.GetTotalSalary()}");
            Console.WriteLine($"Developer salary with bonus = {developer.GetTotalSalary()}");
            Console.WriteLine($"Sales salary with bonus = {sales.GetTotalSalary()}");
        }

        static void DemoTask20()
        {
            Console.WriteLine("\n=== 20. Животные зоопарка ===");
            List<Animal> zoo = new List<Animal>
            {
                new Lion(),
                new Elephant(),
                new Tiger(),
                new Giraffe(),
                new Zebra()
            };

            foreach (var animal in zoo)
            {
                Console.WriteLine(animal.MakeSound());
            }
        }

        static void DemoTask21()
        {
            Console.WriteLine("\n=== 21. Абстрактные фигуры ===");
            ShapeAbstract[] shapes =
            {
                new CircleShape(3),
                new RectangleShape(4, 5),
                new TriangleShape(3, 4),
                new SquareShape(6)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name}: {shape.GetArea():F2}");
            }
        }

        static void DemoTask22()
        {
            Console.WriteLine("\n=== 22. Интернет-магазин ===");
            Product electronics = new Electronics { Name = "Телефон", Price = 50000m, TaxRate = 0.2m };
            Product clothing = new Clothing { Name = "Футболка", Price = 1500m, Discount = 10m };
            Product food = new Food { Name = "Яблоки", Price = 120m, TaxRate = 0.05m };
            Console.WriteLine($"Electronics final = {electronics.GetFinalPrice()}");
            Console.WriteLine($"Clothing final = {clothing.GetFinalPrice()}");
            Console.WriteLine($"Food final = {food.GetFinalPrice()}");
        }

        static void DemoTask23()
        {
            Console.WriteLine("\n=== 23. Система транспорта ===");
            List<Transport> fleet = new List<Transport>
            {
                new CarTransport { Name = "Car", BaseFare = 250d },
                new TruckTransport { Name = "Truck", BaseFare = 600d },
                new BusTransport { Name = "Bus", BaseFare = 400d },
                new MotorcycleTransport { Name = "Motorcycle", BaseFare = 180d }
            };

            foreach (var item in fleet)
            {
                Console.WriteLine($"{item.Name}: move = {item.Move()}, fuel = {item.GetFuelConsumption():F2}");
            }
        }

        static void DemoTask24()
        {
            Console.WriteLine("\n=== 24. Больница ===");
            MedicalWorker doctor = new Doctor();
            MedicalWorker nurse = new Nurse();
            MedicalWorker surgeon = new Surgeon();
            Console.WriteLine(doctor.Work());
            Console.WriteLine(nurse.Work());
            Console.WriteLine(surgeon.Work());
        }

        static void DemoTask25()
        {
            Console.WriteLine("\n=== 25. Система сотрудников с уровнями наследования ===");
            Director director = new Director
            {
                Name = "Геннадий",
                Age = 52,
                Salary = 500000m,
                Department = "Руководство",
                TeamSize = 12,
                Bonus = 150000m,
                CompanyName = "ООО " + "Soft" 
            };
            Console.WriteLine(director.GetInfo());
            Console.WriteLine(director.GetBonusInfo());
        }

        static void DemoTask26()
        {
            Console.WriteLine("\n=== 26. Игра: персонажи ===");
            CharacterGame[] characters =
            {
                new WarriorGame { Name = "Warrior", Health = 120, Damage = 25 },
                new MageGame { Name = "Mage", Health = 80, Damage = 35 },
                new ArcherGame { Name = "Archer", Health = 90, Damage = 28 }
            };

            foreach (var character in characters)
            {
                Console.WriteLine(character.Attack());
                Console.WriteLine(character.Defend());
                Console.WriteLine(character.SpecialAttack());
            }
        }

        static void DemoTask27()
        {
            Console.WriteLine("\n=== 27. Файлы ===");
            FileBase text = new TextFile { Name = "notes.txt", Size = 120 };
            FileBase image = new ImageFile { Name = "photo.png", Size = 2048 };
            FileBase video = new VideoFile { Name = "movie.mp4", Size = 120000 };
            Console.WriteLine(text.Open());
            Console.WriteLine(image.Open());
            Console.WriteLine(video.Open());
        }

        static void DemoTask28()
        {
            Console.WriteLine("\n=== 28. Система оплаты зарплаты ===");
            List<EmployeeAbstract> staff = new List<EmployeeAbstract>
            {
                new HourlyEmployee { Name = "Кирилл", HourlyRate = 500m, HoursWorked = 160 },
                new SalariedEmployee { Name = "Алексей", MonthlySalary = 75000m },
                new CommissionEmployee { Name = "Марина", BaseSalary = 40000m, Sales = 120000m, CommissionRate = 0.05m }
            };

            decimal total = 0m;
            foreach (var employee in staff)
            {
                var amount = employee.CalculateSalary();
                total += amount;
                Console.WriteLine($"{employee.Name}: {amount}");
            }

            Console.WriteLine($"Total payroll: {total}");
        }

        static void DemoTask29()
        {
            Console.WriteLine("\n=== 29. Полиморфизм + наследование ===");
            List<Animal> animals = new List<Animal>
            {
                new Dog2(),
                new Cat2(),
                new Wolf(),
                new Rabbit(),
                new Bird()
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }
        }

        static void DemoTask30()
        {
            Console.WriteLine("\n=== 30. Итоговое задание — система автопарка ===");
            List<Vehicle> fleet = new List<Vehicle>
            {
                new Car { Brand = "Audi", Speed = 220, FuelConsumption = 8.5, Price = 5000000m, NumberOfDoors = 4 },
                new Truck { Brand = "Volvo", Speed = 120, FuelConsumption = 20.0, Price = 9000000m, LoadCapacity = 12 },
                new Bus { Brand = "Mercedes", Speed = 100, FuelConsumption = 17.5, Price = 7000000m, PassengerCapacity = 50 },
                new ElectricCar { Brand = "Tesla", Speed = 240, FuelConsumption = 0.0, Price = 8500000m, BatteryCapacity = 90 },
                new Motorcycle { Brand = "Harley", Speed = 190, FuelConsumption = 6.2, Price = 3500000m, EngineVolume = 1200 }
            };

            foreach (var vehicle in fleet)
            {
                Console.WriteLine(vehicle.GetInfo());
            }

            var fastest = fleet.OrderByDescending(v => v.Speed).First();
            var expensive = fleet.OrderByDescending(v => v.Price).First();
            Console.WriteLine($"Самый быстрый: {fastest.Brand} ({fastest.Speed} km/h)");
            Console.WriteLine($"Самый дорогой: {expensive.Brand} ({expensive.Price:C})");
        }
    }

    public class Animal
    {
        public virtual string Speak() => "Animal speaks";
        public virtual string Eat() => "Animal eats";
        public virtual string MakeSound() => "Animal makes a sound";
    }

    public class Dog : Animal
    {
        public override string Speak() => "Гав-гав";
    }

    public class Cat : Animal
    {
        public override string Speak() => "Мяу";
    }

    public class Vehicle
    {
        public string Brand { get; set; } = string.Empty;
        public double Speed { get; set; }
        public double FuelConsumption { get; set; }
        public decimal Price { get; set; }

        public virtual string Move() => $"{Brand} is moving";
        public virtual string Move(string message) => $"{Brand} {message}";
        public virtual double GetFuelConsumption() => FuelConsumption;
        public virtual double CalculateCost() => FuelConsumption * 50;

        public virtual string GetInfo() => $"Brand: {Brand}, Speed: {Speed} km/h, Fuel: {FuelConsumption} l/100km, Price: {Price:C}";
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        public override string Move() => $"{Brand} drives along the road";
        public override string Move(string message) => $"{Brand} drives {message}";
    }

    public class Motorcycle : Vehicle
    {
        public int EngineVolume { get; set; }
        public override string Move() => $"{Brand} rides quickly";
    }

    public class Bus : Vehicle
    {
        public int PassengerCapacity { get; set; }
        public override string Move() => $"{Brand} carries passengers around the city";
    }

    public class Train : Vehicle
    {
        public int Carriages { get; set; }
        public override string Move() => $"{Brand} moves on rails";
    }

    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        public override string Move() => $"{Brand} transports cargo";
    }

    public class ElectricCar : Vehicle
    {
        public int BatteryCapacity { get; set; }
        public override string Move() => $"{Brand} moves silently";
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }

    public class Student : Person
    {
        public string Specialty { get; set; } = string.Empty;
        public int Course { get; set; }

        public override string ToString() => $"Name: {Name}, Age: {Age}, Specialty: {Specialty}, Course: {Course}";
    }

    public class GraduateStudent : Student
    {
        public string ThesisTopic { get; set; } = string.Empty;
        public string GetFullInfo() => $"Name: {Name}, Age: {Age}, Specialty: {Specialty}, Course: {Course}, Thesis: {ThesisTopic}";
    }

    public abstract class Employee : Person
    {
        public decimal Salary { get; set; }
        public virtual decimal GetSalary() => Salary;
        public abstract decimal CalculateSalary();
    }

    public class Manager : Employee
    {
        public string Department { get; set; } = string.Empty;
        public int TeamSize { get; set; }
        public override decimal CalculateSalary() => Salary;
        public override string ToString() => $"Name: {Name}, Salary: {Salary:C}, Department: {Department}, Team: {TeamSize}";
    }

    public class Developer : Employee
    {
        public string Stack { get; set; } = string.Empty;
        public int Experience { get; set; }
        public override decimal CalculateSalary() => Salary;
        public override string ToString() => $"Name: {Name}, Salary: {Salary:C}, Stack: {Stack}, Experience: {Experience} years";
    }

    public class Shape
    {
        public virtual double GetArea() => 0;
    }

    public class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea() => Width * Height;
    }

    public class Circle : Shape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class Worker
    {
        public string Name { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;

        public override string ToString() => $"Name: {Name}, Position: {Position}";
    }

    public class Cashier : Worker { }
    public class Seller : Worker { }

    public class Computer
    {
        public string Processor { get; set; } = string.Empty;
        public int RAM { get; set; }

        public override string ToString() => $"Processor: {Processor}, RAM: {RAM} GB";
    }

    public class Laptop : Computer
    {
        public double Screen { get; set; }
        public override string ToString() => $"Processor: {Processor}, RAM: {RAM} GB, Screen: {Screen} inches";
    }

    public class Desktop : Computer
    {
        public string CaseType { get; set; } = string.Empty;
        public override string ToString() => $"Processor: {Processor}, RAM: {RAM} GB, Case: {CaseType}";
    }

    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public override string ToString() => $"Title: {Title}, Author: {Author}";
    }

    public class PaperBook : Book
    {
        public int Pages { get; set; }
        public override string ToString() => $"Title: {Title}, Author: {Author}, Pages: {Pages}";
    }

    public class EBook : Book
    {
        public string Format { get; set; } = string.Empty;
        public override string ToString() => $"Title: {Title}, Author: {Author}, Format: {Format}";
    }

    public class Pet
    {
        public string Name { get; set; } = string.Empty;
        public virtual string Eat() => "Pet eats";
    }

    public class DogPet : Pet
    {
        public override string Eat() => $"{Name} eats dog food";
    }

    public class CatPet : Pet
    {
        public override string Eat() => $"{Name} eats cat food";
    }

    public class Parrot : Pet
    {
        public override string Eat() => $"{Name} eats seeds";
    }

    public class BankAccount
    {
        public decimal Balance { get; set; }

        public virtual void Deposit(decimal amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance >= amount)
                Balance -= amount;
        }

        public override string ToString() => $"Balance: {Balance:C}";
    }

    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }

        public override void Deposit(decimal amount)
        {
            base.Deposit(amount);
            Balance += Balance * InterestRate;
        }
    }

    public class CreditAccount : BankAccount
    {
        public decimal CreditLimit { get; set; }
        public decimal InterestRate { get; set; }

        public override void Withdraw(decimal amount)
        {
            if (Balance + CreditLimit >= amount)
            {
                Balance -= amount;
                Balance -= Balance * InterestRate;
            }
        }
    }

    public abstract class Transport
    {
        public string Name { get; set; } = string.Empty;
        public abstract double CalculateCost();
        public abstract string Move();
        public abstract double GetFuelConsumption();
    }

    public class CarTransport : Transport
    {
        public double BaseFare { get; set; }
        public override double CalculateCost() => BaseFare * 1.2;
        public override string Move() => "Car moves on road";
        public override double GetFuelConsumption() => 8.5;
    }

    public class TruckTransport : Transport
    {
        public double BaseFare { get; set; }
        public override double CalculateCost() => BaseFare * 1.8;
        public override string Move() => "Truck moves with cargo";
        public override double GetFuelConsumption() => 18.0;
    }

    public class BusTransport : Transport
    {
        public double BaseFare { get; set; }
        public override double CalculateCost() => BaseFare * 1.5;
        public override string Move() => "Bus moves between stops";
        public override double GetFuelConsumption() => 14.0;
    }

    public class MotorcycleTransport : Transport
    {
        public double BaseFare { get; set; }
        public override double CalculateCost() => BaseFare * 1.1;
        public override string Move() => "Motorcycle moves fast";
        public override double GetFuelConsumption() => 6.5;
    }

    public class Programmer : Employee
    {
        public decimal BonusRate { get; set; }
        public override decimal GetSalary() => Salary + Salary * BonusRate;
        public override decimal CalculateSalary() => Salary + Salary * BonusRate;
    }

    public class Designer : Employee
    {
        public decimal BonusRate { get; set; }
        public override decimal GetSalary() => Salary + Salary * BonusRate;
        public override decimal CalculateSalary() => Salary + Salary * BonusRate;
    }

    public class ManagerEmployee : Employee
    {
        public string Department { get; set; } = string.Empty;
        public int TeamSize { get; set; }
        public decimal BonusRate { get; set; }
        public override decimal GetSalary() => Salary + Salary * BonusRate;
        public override decimal CalculateSalary() => Salary + Salary * BonusRate;
    }

    public class MilitaryVehicle
    {
        public virtual string Attack() => "Military vehicle attacks";
    }

    public class Tank : MilitaryVehicle
    {
        public override string Attack() => "Tank fires a shell";
    }

    public class Helicopter : MilitaryVehicle
    {
        public override string Attack() => "Helicopter launches rockets";
    }

    public class ArmoredCar : MilitaryVehicle
    {
        public override string Attack() => "Armored car shoots from turret";
    }

    public abstract class Character
    {
        public string Name { get; set; } = string.Empty;
        public int Health { get; set; }
        public int Damage { get; set; }
        public abstract string Attack();
        public virtual string Defend() => $"{Name} defends";
        public abstract string SpecialAttack();
    }

    public class Warrior : Character
    {
        public override string Attack() => $"{Name} strikes with a sword for {Damage} damage";
        public override string Defend() => $"{Name} raises shield";
        public override string SpecialAttack() => $"{Name} performs a heavy blow";
    }

    public class Mage : Character
    {
        public override string Attack() => $"{Name} casts fireball for {Damage} damage";
        public override string Defend() => $"{Name} creates a magic barrier";
        public override string SpecialAttack() => $"{Name} uses arcane explosion";
    }

    public class Archer : Character
    {
        public override string Attack() => $"{Name} shoots an arrow for {Damage} damage";
        public override string Defend() => $"{Name} dodges and takes cover";
        public override string SpecialAttack() => $"{Name} performs a critical shot";
    }

    public abstract class Device
    {
        public virtual string TurnOn() => "Device is turned on";
        public virtual string TurnOff() => "Device is turned off";
    }

    public class Phone : Device
    {
        public override string TurnOn() => "Phone boots up";
        public override string TurnOff() => "Phone shuts down";
    }

    public class ComputerDevice : Device
    {
        public override string TurnOn() => "Computer starts";
        public override string TurnOff() => "Computer stops";
    }

    public class Television : Device
    {
        public override string TurnOn() => "TV screen turns on";
        public override string TurnOff() => "TV screen turns off";
    }

    public abstract class Payment
    {
        public abstract string Pay(double amount);
    }

    public class CashPayment : Payment
    {
        public override string Pay(double amount) => $"Cash payment completed: {amount:C}";
    }

    public class CardPayment : Payment
    {
        public override string Pay(double amount) => $"Card payment completed: {amount:C}";
    }

    public class OnlinePayment : Payment
    {
        public override string Pay(double amount) => $"Online payment completed: {amount:C}";
    }

    public class EmployeeWithBonus
    {
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public decimal BonusPercent { get; set; }
        public virtual decimal GetTotalSalary() => Salary + Salary * BonusPercent / 100m;
    }

    public class ManagerEmployeeBonus : EmployeeWithBonus { }
    public class DeveloperEmployeeBonus : EmployeeWithBonus { }
    public class SalesManager : EmployeeWithBonus { }

    public class Lion : Animal
    {
        public override string MakeSound() => "Lion roars";
    }

    public class Elephant : Animal
    {
        public override string MakeSound() => "Elephant trumpets";
    }

    public class Tiger : Animal
    {
        public override string MakeSound() => "Tiger growls";
    }

    public class Giraffe : Animal
    {
        public override string MakeSound() => "Giraffe hums";
    }

    public class Zebra : Animal
    {
        public override string MakeSound() => "Zebra neighs";
    }

    public abstract class ShapeAbstract
    {
        public abstract double GetArea();
    }

    public class CircleShape : ShapeAbstract
    {
        public double Radius { get; }
        public CircleShape(double radius) => Radius = radius;
        public override double GetArea() => Math.PI * Radius * Radius;
    }

    public class RectangleShape : ShapeAbstract
    {
        public double Width { get; }
        public double Height { get; }
        public RectangleShape(double width, double height) { Width = width; Height = height; }
        public override double GetArea() => Width * Height;
    }

    public class TriangleShape : ShapeAbstract
    {
        public double Base { get; }
        public double Height { get; }
        public TriangleShape(double baseLength, double height) { Base = baseLength; Height = height; }
        public override double GetArea() => 0.5 * Base * Height;
    }

    public class SquareShape : ShapeAbstract
    {
        public double Side { get; }
        public SquareShape(double side) => Side = side;
        public override double GetArea() => Side * Side;
    }

    public abstract class Product
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public abstract decimal GetFinalPrice();
    }

    public class Electronics : Product
    {
        public decimal TaxRate { get; set; }
        public override decimal GetFinalPrice() => Price + Price * TaxRate;
    }

    public class Clothing : Product
    {
        public decimal Discount { get; set; }
        public override decimal GetFinalPrice() => Price - Price * Discount / 100m;
    }

    public class Food : Product
    {
        public decimal TaxRate { get; set; }
        public override decimal GetFinalPrice() => Price + Price * TaxRate;
    }

    public class MedicalWorker
    {
        public virtual string Work() => "Medical worker works";
    }

    public class Doctor : MedicalWorker
    {
        public override string Work() => "Doctor treats patients";
    }

    public class Nurse : MedicalWorker
    {
        public override string Work() => "Nurse helps patients";
    }

    public class Surgeon : MedicalWorker
    {
        public override string Work() => "Surgeon performs operation";
    }

    public class Director : ManagerEmployee
    {
        public string CompanyName { get; set; } = string.Empty;
        public decimal Bonus { get; set; }
        public string GetInfo() => $"Name: {Name}, Age: {Age}, Department: {Department}, Company: {CompanyName}, Team: {TeamSize}";
        public string GetBonusInfo() => $"Bonus: {Bonus:C}";
    }

    public abstract class CharacterGame
    {
        public string Name { get; set; } = string.Empty;
        public int Health { get; set; }
        public int Damage { get; set; }
        public abstract string Attack();
        public abstract string Defend();
        public abstract string SpecialAttack();
    }

    public class WarriorGame : CharacterGame
    {
        public override string Attack() => $"{Name} attacks with sword for {Damage}";
        public override string Defend() => $"{Name} blocks the attack";
        public override string SpecialAttack() => $"{Name} performs a devastating slash";
    }

    public class MageGame : CharacterGame
    {
        public override string Attack() => $"{Name} launches a bolt for {Damage}";
        public override string Defend() => $"{Name} creates a shield";
        public override string SpecialAttack() => $"{Name} casts a super spell";
    }

    public class ArcherGame : CharacterGame
    {
        public override string Attack() => $"{Name} shoots an arrow for {Damage}";
        public override string Defend() => $"{Name} moves aside and dodges";
        public override string SpecialAttack() => $"{Name} uses a critical shot";
    }

    public abstract class FileBase
    {
        public string Name { get; set; } = string.Empty;
        public double Size { get; set; }
        public abstract string Open();
    }

    public class TextFile : FileBase
    {
        public override string Open() => $"Opening text file: {Name} ({Size} KB)";
    }

    public class ImageFile : FileBase
    {
        public override string Open() => $"Opening image file: {Name} ({Size} KB)";
    }

    public class VideoFile : FileBase
    {
        public override string Open() => $"Opening video file: {Name} ({Size} KB)";
    }

    public abstract class EmployeeAbstract
    {
        public string Name { get; set; } = string.Empty;
        public abstract decimal CalculateSalary();
    }

    public class HourlyEmployee : EmployeeAbstract
    {
        public decimal HourlyRate { get; set; }
        public decimal HoursWorked { get; set; }
        public override decimal CalculateSalary() => HourlyRate * HoursWorked;
    }

    public class SalariedEmployee : EmployeeAbstract
    {
        public decimal MonthlySalary { get; set; }
        public override decimal CalculateSalary() => MonthlySalary;
    }

    public class CommissionEmployee : EmployeeAbstract
    {
        public decimal BaseSalary { get; set; }
        public decimal Sales { get; set; }
        public decimal CommissionRate { get; set; }
        public override decimal CalculateSalary() => BaseSalary + Sales * CommissionRate;
    }

    public class Dog2 : Animal
    {
        public override string MakeSound() => "Dog barks";
    }

    public class Cat2 : Animal
    {
        public override string MakeSound() => "Cat meows";
    }

    public class Wolf : Animal
    {
        public override string MakeSound() => "Wolf howls";
    }

    public class Rabbit : Animal
    {
        public override string MakeSound() => "Rabbit squeaks";
    }

    public class Bird : Animal
    {
        public override string MakeSound() => "Bird chirps";
    }
}
