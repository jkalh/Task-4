using System;

namespace CompanyQ
{
    public class Company
    {
        public string Name { get; set; }
        public int Income { get; set; }
        public int Rating { get; set; }

        public Company(string name, int income, int rating)
        {
            Name = name;
            Income = income;
            Rating = rating;
        }

        public int CalculateQ()
        {
            return Income * Rating;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Company Name: {Name}");
            Console.WriteLine($"Income: {Income}k $");
            Console.WriteLine($"Rating: {Rating}");
            Console.WriteLine($"Quality: {CalculateQ()}");
        }
    }

    public class InvestedCompany : Company
    {
        public int Investment { get; set; }

        public InvestedCompany(string name, int income, int rating, int investment) : base(name, income, rating)
        {
            Investment = investment;
        }

        public int CalculateQp()
        {
            return (int)(Math.Pow(Investment, 3) + CalculateQ());
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Investment: {Investment}k $");
            Console.WriteLine($"Quality with investment: {CalculateQp()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов класса Company
            Company company1 = new Company("Pyaterocka", 100, 8);
            Company company2 = new Company("Apple", 200, 6);

            // Вывод информации об объектах класса Company
            company1.DisplayInfo();
            company2.DisplayInfo();

            // Создание объектов класса InvestedCompany
            InvestedCompany investedCompany1 = new InvestedCompany("Porshe", 150, 9, 50);
            InvestedCompany investedCompany2 = new InvestedCompany("Microsoft", 180, 7, 70);

            // Вывод информации об объектах класса InvestedCompany
            investedCompany1.DisplayInfo();
            investedCompany2.DisplayInfo();
        }
    }
}
