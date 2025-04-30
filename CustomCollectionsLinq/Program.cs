// See https://aka.ms/new-console-template for more information

using CustomCollectionsLinq;
using CustomCollectionsLinq.excercises._1;
using System.Linq;

MyIntCollection myIntCollection = new MyIntCollection(new[] { 1, 2, 3 });

foreach (var element in myIntCollection)
{
   Console.WriteLine(element); 
}

Console.WriteLine("DataAwfulGenerator");
for (int i = 0; i < DataAwfulGenerator.GetPersons().Count()-1; i++)
{
    
        string message = $"Odczyt: {DataAwfulGenerator.GetPersons().ElementAt(i)}";
        Console.WriteLine(message);
    
}

var persons = DataAwfulGenerator.GetPersons().Take(2);

IEnumerable<Person> enumerable = DataBetterGenerator.GetPersons().Take(2);

foreach (var e in enumerable)
{
    Console.WriteLine(e);
}

foreach (var p in persons)
{
    Console.WriteLine(p);
}


SimpleCustomCollection<int> collection = new SimpleCustomCollection<int>();
collection.Add(1);
collection.Add(2);
collection.Add(3);
collection.Add(23);
collection.Add(13);
collection.Add(8);


List<Student> students = new List<Student>();
students.Add(new Student("Anna", 20, 3));
students.Add(new Student("Jan", 22, 3.5));
students.Add(new Student("Piotr", 20, 4));
students.Add(new Student("Ewa", 22, 4));
students.Add(new Student("Marek", 21, 5));

students.GroupBy(s => s.Age)
    .Select(g => new
    {
        Age = g.Key,
        NajlepszyStudent = g.OrderByDescending(s => s.Grade).First()
    })
    .ToList().ForEach(x => Console.WriteLine(x));

students.GroupBy(s => s.Age)
    .Select(g => new 
    {
        Wiek = g.Key,
        NajlepszyStudent = g.OrderByDescending(s => s.Grade).First()
    }).ToList().ForEach(x => Console.WriteLine(x));


collection.Where(x => x > 10).ToList().ForEach(x => Console.WriteLine(x));
collection.Where(x =>x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));
collection.Select(x => x > 2).ToList().ForEach(x => Console.WriteLine(x));

List<string> names = [ "Anna", "Krzysztof", "Jan", "Aleksandra", "Tomek" ];

names.Where(name => name.Contains("an")).ToList().ForEach(name => Console.WriteLine(name));


List<int> liczby = [15, 42, 7, 89, 23, 56, 12, 78];
liczby.OrderDescending().Take(3).ToList().ForEach(x => Console.WriteLine(x));
liczby.OrderByDescending(x => x % 2 == 0).Take(3).ToList().ForEach(x => Console.WriteLine(x));




foreach (int item in collection)
{
    Console.WriteLine(item);
}

CustomCollections<int> collection2 = new CustomCollections<int>{1, 2, 3};

 //stare podejscie
 List<int> listInt = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
 IEnumerator<int> enumerator = new CustomEnumerator<int>(listInt);
 while (enumerator.MoveNext())
 {
     Console.WriteLine(enumerator.Current);
 }



 foreach (var el in collection2)
 {
     Console.WriteLine(el);
 }

 Console.WriteLine("DataAwfulGenerator");
 foreach (var person in DataAwfulGenerator.GetPersons())
 {
     string message = $"Odczyt: {person}";
     Console.ForegroundColor = ConsoleColor.Green;
     Console.WriteLine(message);
     Console.ForegroundColor = ConsoleColor.Gray;

 }

 Console.WriteLine("DataBetterGenerator");
 foreach (var person in DataBetterGenerator.GetPersons())
 {
     string message = $"Odczyt: {person}";
     Console.ForegroundColor = ConsoleColor.Red;
     Console.WriteLine(message);
 }

 IEnumerable<Person> peopleV1 = DataAwfulGenerator.GetPersons().Take(1);
 IEnumerable<Person> peopleV2 = DataBetterGenerator.GetPersons().Take(1);

 foreach (var p in peopleV1)
 {
     Console.WriteLine(p);
 }

 Console.WriteLine("-------");

 foreach (var p2 in peopleV2)
 {
     Console.WriteLine(p2);
 }


//ex.1
 var intCollection = new MyIntCollection(new int[] {1, 2, 3, 4, 5});
 foreach (var num in intCollection)
 {
     Console.WriteLine(num);
 }


//LINQ
 List<Student> studentList = new List<Student>();
 studentList.Add(new Student ( "Anna", 20, 4.5 ));
 studentList.Add(new Student ("Jan",22, 3.8 ));
 studentList.Add(new Student ("Piotr",  20, 4.2 ));
 studentList.Add(new Student ("Ewa", 22,  4.8 ));
 studentList.Add( new Student  ("Marek",  21,  3.5 ));


 var enumerableVar = studentList.GroupBy(s => s.Age).Select(s => new
 {
     Age = s.Key,
     BestStudent = s.OrderByDescending(g => g.Grade).First()
 });

 foreach (var s in enumerableVar)
 {
     Console.WriteLine(s);
 }

 studentList.GroupBy(s => s.Age).Select(el => new
 {
     Age = el.Key,
     Count = el.Count()
 });