using System;
using System.Collections.Generic;


List<City> cities = new List<City>
{
    new City { Id = 1, Name = "New York" },
    new City { Id = 2, Name = "Los Angeles" },
    new City { Id = 3, Name = "Chicago" },
    new City { Id = 4, Name = "Houston" }
};

List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "John Doe", Age = 10, CityId = 1, City = cities[0] },
    new Person { Id = 2, Name = "Jane Smith", Age = 25, CityId = 2, City = cities[1] },
    new Person { Id = 3, Name = "Michael Brown", Age = 40, CityId = 3, City = cities[2] },
    new Person { Id = 4, Name = "Emily Davis", Age = 35, CityId = 4, City = cities[3] }
};



//TASK 1
//Найдите всех людей старше 25 лет и
//спроецируйте их имена и возраст на новый анонимный тип.

// var query1= people.Where(p => p.Age >= 25).Select(p=>new
// {
//     Name = p.Name,
//     Age = p.Age,
// });
// foreach (var i in query1)
// {
//     Console.WriteLine($"Name: {i.Name}, Age: {i.Age}, City: {i.Name}");
// }

//TASK2
//Упорядочите людей по возрасту, а затем по именам
//в алфавитном порядке в пределах одного возраста.
// var query2=people.OrderBy(g=>g.Age).ThenBy(g=>g.Name).ToList();
// foreach (var i in query2)
// {
//     Console.WriteLine($"Name: {i.Name}, Age: {i.Age}, City: {i.Name}");
// }



//TASK3
//Выберите первую букву имени каждого человека и
//сгруппируйте людей по этой букве.

// var query3 = people.GroupBy(p => p.Name[0]).ToList();
// foreach (var i in query3)
// {
//     Console.WriteLine($"{i.Key}"); // Ключ группы — первая буква имени
//     foreach (var o in i)
//     {
//         Console.WriteLine($"  {o.Name}, Age: {o.Age}");
//     }
// }


//TASK 4
//Предположим, что существует еще один список объектов City.
//Присоединяйтесь к людям с городами на основе общего CityId и спроектируйте
//новый анонимный тип с именами людей и названиями городов.


//
// var query4= people.Join(people,p=>p.CityId, c => c.CityId, (p, c) => new
// {
//     Person=p.Name,
//     City= c.Name
// });
//Task 5 
//Вычислите общий возраст всех людей, имена
//которых начинаются с гласной.
// List<char> vowels = ['A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'];
//
//  var query5 = people
//      .Where(p=>vowels.Contains(p.Name[0]))
//      .Sum(p=>p.Age);
//  
//  Console.WriteLine(query5);

//TASK6
//Сгруппируйте людей по первой букве имени и посчитайте,
//сколько человек попадает в каждую группу.

// var query6=persons.GroupBy(p=>p.Name[0]). ToList();

// foreach (var item in task6_method)
// {
//     System.Console.WriteLine(item);
// }



// Task 7
//Select the city that have max people
//Выберите город, в котором максимальное количество людей

//var task7_method=persons.Join(cities p=>p.CityId, c=>c.Id ,(p,c)=> new {max=})



//ask 8
//Select all children between 2 and 7 years old living in any city whose name begins with the letter "a".
  //  Выберите всех детей от 2 до 7 лет, проживающих в любом городе, название которого начинается с буквы «а».
// var task8_method=persons.Where(p=>p.Age>=20 && p.Age<=30 && p.Name[0]=='A')
// .Join(cities, p=>p.CityId, c=>c.Id, (p,c)=> new {name=p.Name, age=p.Age}).ToList();

// var task8_query =(from p in persons 
// join c in cities on p.CityId equals c.Id 
// where p.Age<=20 && p.Age>=30 && p.Name[0]=='A'
// select new {name=p.Name , age = p.Age}).ToList();

// foreach (var item in task8_query)
// {
//     System.Console.WriteLine(item.name+ "   " +item.age);
// }
 var query6 = people.GroupBy(p => p.Name[0]).ToList();
 foreach (var i in query6)
 {
     Console.WriteLine($"{i.Key}: {i.Count()} people");
 }


public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int CityId { get; set; }
    public City City { get; set; } // Navigation property
}