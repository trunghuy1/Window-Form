using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
	class Program
	{
		public class UserA
		{
			public int ID { get; set; }
			public string Name { get; set; }
			public string Address { get; set; }
			public string DOB { get; set; }
		}
		public class Car
		{
			public string NameCar { get; set; }
			public int Price { get; set; }
		}
		public class UserB
		{
			public string FirstName { get; set; }
			public string LastName { get; set; }
			public int Salary { get; set; }
		}
		static void Main(string[] args)
		{
			List<UserA> userA = new List<UserA>
			{
				new UserA {ID = 1,Name = "John",Address = "London",DOB = "2001-04-01" },
				new UserA {ID = 2,Name = "Lenny",Address = "New York",DOB = "1997-12-11" },
				new UserA {ID = 3,Name = "Andrew",Address = "Boston",DOB = "1987-02-22" },
				new UserA {ID = 4,Name = "Peter",Address = "Prague",DOB = "1936-03-24" },
				new UserA {ID = 5,Name = "Anna",Address = "Bratislava",DOB = "1973-11-18" },
				new UserA {ID = 6,Name = "Albert",Address = "Bratislava",DOB = "1940-12-11" },
				new UserA {ID = 7,Name = "Adam",Address = "Trnava",DOB = "1983-12-01" },
				new UserA {ID = 8,Name = "Robert",Address = "Bratislava",DOB = "1935-05-15" },
				new UserA {ID = 9,Name = "Robert",Address = "Prague",DOB = "1998-03-14" },
			};
			Console.WriteLine("Who live in Bratislava");
			var liveBratislava = from s in userA
								 where s.Address == "Bratislava"
								 select s;
			liveBratislava.ToList().ForEach(s => Console.WriteLine(s.Name));

			var car = new List<Car>
			{
				new Car{NameCar="Audi",Price=52642},
				new Car{NameCar="Mercedes",Price=57127},
				new Car{NameCar="Skoda",Price=9000},
				new Car{NameCar="Volvo",Price=29000},
				new Car{NameCar="Bentley",Price=350000},
				new Car{NameCar="Citroen",Price=21000},
				new Car{NameCar="Hummer",Price=41400},
				new Car{NameCar="Volkswagen",Price=21600},
			};
			Console.WriteLine("\nCar price between 30000 and 100000");
			var priceCar = from p in car
						   where p.Price > 30000 && p.Price < 100000
						   select p;
			priceCar.ToList().ForEach(p => Console.WriteLine(p.NameCar));

			List<UserB> userB = new List<UserB>
			{
				new UserB{ FirstName = "John", LastName = "Doe", Salary = 1230 },
				new UserB{ FirstName = "Lucy", LastName = "Novak", Salary = 670 },
				new UserB{ FirstName = "Ben", LastName = "Walter", Salary = 2050 },
				new UserB{ FirstName = "Robin", LastName = "Brown", Salary = 2300 },
				new UserB{ FirstName = "Amy", LastName = "Doe", Salary = 1250 },
				new UserB{ FirstName = "Joe", LastName = "Draker", Salary = 1190 },
				new UserB{ FirstName = "Janet", LastName = "Doe", Salary = 980 },
				new UserB{ FirstName = "Albert", LastName = "Novak", Salary = 1930 },
			};
			Console.WriteLine("\nSort ascending by Salary\n");
			var sortASCBySalary = from s in userB
								  orderby s.Salary ascending
								  select s;

			foreach (var item in sortASCBySalary)
			{
				Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Salary);
			}
			Console.WriteLine("\nSort ascending by LastName\n");
			var sortASCByLastname = from s in userB
									orderby s.LastName ascending
									select s;
			foreach (var item in sortASCByLastname)
			{
				Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Salary);
			}
			Console.WriteLine("\nUser have salary higher than 1500");
			var salaryHigher1500 = from s in userB
								   where s.Salary > 1500
								   select s;
			salaryHigher1500.ToList().ForEach(s => Console.WriteLine(s.FirstName));
			Console.ReadKey();
		}
	}
}