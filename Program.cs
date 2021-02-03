using System;

namespace ConsoleApp12
{
    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Birthday { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string name, string surname, string birthday, string position, int experience)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
            this.Position = position;
            this.Experience = experience;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name {Name}");
            Console.WriteLine($"Surname {Surname}");
            Console.WriteLine($"Date of Birth {Birthday}");
            Console.WriteLine($"Position {Position}");
            Console.WriteLine($"Experience {Experience}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name = ");
            string Name = Convert.ToString(Console.ReadLine());
            Console.Write("Surname = ");
            string Surname = Convert.ToString(Console.ReadLine());
            Console.Write("Date of Birth(for ex: 1995-05-25):  = ");
            var Birthday = Convert.ToString(Console.ReadLine());
            Console.Write("Position = ");
            string Position = Convert.ToString(Console.ReadLine());
            Console.Write("Experience = ");
            var Experience = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee(Name, Surname, Birthday, Position, Experience);
            employee.ShowInfo();
        }
    }
}