using System.Security.Cryptography;

namespace Mohamed_Abdullah_sun_wed_8pm_C__OOP_02
{

    #region Q = > 1 
    //1 - Design and implement a Class for the employees in a company:
    class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public float Salary { get; set; }

        public Gender Gender;

        public Privilege SecurityLevel;

        public HiringDate? HireDate;

        public Employee(int  _id , string _name , float _salary , Gender _gender , Privilege _SecurityLevel , HiringDate _HireDate) 
        {
            Id = _id ;
            Name = _name ;
            Salary = _salary ;
            Gender = _gender ;
            SecurityLevel = _SecurityLevel ;
            HireDate = _HireDate ;
        }


        public override string ToString()
        {
            return $@"Employee Information :
                      ID             => {Id} 
                      Name           => {Name} 
                      Salary         => {Salary:C}
                      Gender         => {Gender}
                      Security Level => {SecurityLevel}
                      HireDate       => {HireDate}";
        }
    }

    #endregion

    #region Q = > 2  
    // 2 - Develop a Class to represent the Hiring Date Data:
    class HiringDate
    {
        byte Day { get; set; }
        byte Month { get; set; }
         int Year { get; set; }

        public HiringDate(byte day, byte month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }
    #endregion

    #region Q = > 3
    // 3 - We need to restrict the Gender field to be only M or F [Male or Female] 
    enum Gender : byte 
    {
        M = 0,
        m = 0,
        Male = 0 ,
        F  = 1,
        f = 1,
        Female = 1,
    }
    #endregion

    #region Q = > 4  
    // 4 - Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum 
    [Flags]
    enum Privilege : byte
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
        All = guest | Developer | secretary | DBA,
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];


            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"===== Enter Please Information Employee: ( {i + 1} ) =====\n");
                Console.Write($"Enter ID Employee : ");
                string InputId = Console.ReadLine() ?? "";

                if (!int.TryParse(InputId, out int id))
                {
                    Console.WriteLine("The entry must be integer");
                    return;
                }
                Console.Write($"Enter Name Employee : ");
                string InputName = Console.ReadLine() ?? "";


                Console.Write($"Enter Salary Employee : ");
                string InputSalary = Console.ReadLine() ?? "";

                if(!(float.TryParse(InputSalary , out float salary) && salary >= 1000))
                {
                    Console.WriteLine("\nThe entry must be integer Or Decimal And Not be less than $1000");
                    return;
                }

                Console.Write($"Enter Gender Employee ( (Male || M) Or (Female || F) ): ");
                string InputGender = Console.ReadLine() ?? "";
                if (!Enum.TryParse(InputGender, out Gender gender))
                {
                    Console.WriteLine("\nInvalid gender input ");
                    return;
                }

                Privilege privilege = Privilege.All;

                if (i < 2)
                {
                    Console.Write($"Enter Privilege Employee ( DBA || guest || secretary || Developer) : ");
                    string InputPrivilege = Console.ReadLine() ?? "";
                    if (!Enum.TryParse(InputPrivilege, out privilege))
                    {
                        Console.WriteLine("\nInvalid Privilege input");
                        return; 
                    }
                }


                Console.WriteLine($"Enter Hire Date Employee : ");

                Console.Write($"\n\tEnter Day From (1) To (31) : ");

                string InputDay = Console.ReadLine() ?? "";
                if (!(byte.TryParse(InputDay, out byte day) && day > 0 && day <= 31) )
                {
                    Console.WriteLine("\nThe entry must be Between integer From 1 To 31");
                    return;
                }


                Console.Write($"\n\tEnter Month From (1) To (12) : ");
                string InputMonth = Console.ReadLine() ?? "";
                if (!(byte.TryParse(InputMonth, out byte month) && month > 0 && month <= 12))
                {
                    Console.WriteLine("\nThe entry must be Between integer From 1 To 12 ");
                    return;
                }


                Console.Write($"\n\tEnter Year : ");
                string InputYear = Console.ReadLine() ?? "";
                if (!(int.TryParse(InputYear, out int year) && year > DateTime.Now.Year - 20 && year <= DateTime.Now.Year))
                {
                    Console.WriteLine($"\nThe entry must be integer Greater Then {DateTime.Now.Year - 20} And the year is younger than or equal to {DateTime.Now.Year}");
                    return;
                }

                employees[i] = new Employee(id, InputName, salary, gender, privilege, new HiringDate(day, month, year));
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.ToString()} \n");
            }
        }
    }
}
