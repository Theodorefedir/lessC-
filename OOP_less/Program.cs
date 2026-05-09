namespace OOP_less
{
    internal class Program
    {

        class Worker {
            public string Name { get; set; }
            public string Surname { get; set; }
            private int age;
            public int Age { 
                get { return age; }
                set
                {
                    if (value < 80 && value > 18)
                    {
                        age = value;
                    }
                    else {
                        throw new Exception("wrong age");
                    }
                     
                }
            }
            private int salary;
            public int Salary
            {
                get { return salary; }
                set {
                    if (value < 25000 && value > 4806) { 
                        salary = value;
                    }
                    else
                    {
                        throw new Exception("wrong salary min salary might be 4806 zl and it couldnt be higher then 25000");
                    }
                }
            }
            private DateTime date;
            public DateTime Date { 
                get { return date; }
                set {
                    if (value <= DateTime.Today)
                    {
                        date = value;
                    }
                    else {
                        throw new Exception("wrong time");
                    }
                }
            }
            public string GetFullName()
            {
                return $"{Surname} {Name}";
            }
            public int GetExperience()
            {
                DateTime today = DateTime.Today;
                int experience = today.Year - date.Year;
                return experience;
            }


        }
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[5];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Worker {i + 1}:");

                try
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Surname: ");
                    string surname = Console.ReadLine();

                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Salary: ");
                    int salary = int.Parse(Console.ReadLine());

                    Console.Write("Date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    Worker worker = new Worker
                    {
                        Name = name,
                        Surname = surname,
                        Age = age,
                        Salary = salary,
                        Date = date
                    };

                    workers[i] = worker;
                    Console.WriteLine("Correct\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex.Message}\n");
                    i--;
                }
            }

            Console.WriteLine("Enter worker experience: ");
            int exp;
            while (!int.TryParse(Console.ReadLine(), out exp))
            {
                Console.Write("Error");
            }
            for (int i = 0; i < workers.Length; i++) {
                if (workers[i].GetExperience() == exp)
                {
                    Console.WriteLine(workers[i].GetFullName());
                }
            }
        }
    }
}
