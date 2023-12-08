using System.Dynamic;

dynamic person = new ExpandoObject();
person.Name = "Arda";
person.Surname = "İlhan";
person.Age = "32";
person.YearOfBirth = new Func<int>(() => DateTime.UtcNow.Year - person.Age);