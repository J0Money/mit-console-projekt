using System.Diagnostics.CodeAnalysis;
using System.Linq;
namespace mit_console_projekt;

public class modul2
{
    Person[] people = new Person[]
    {
        new Person { Name = "Jens Hansen", Age = 45, Phone = "+4512345678" },
        new Person { Name = "Jane Olsen", Age = 22, Phone = "+4543215687" },
        new Person { Name = "Tor Iversen", Age = 35, Phone = "+4587654322" },
        new Person { Name = "Sigurd Nielsen", Age = 31, Phone = "+4512345673" },
        new Person { Name = "Viggo Nielsen", Age = 28, Phone = "+4543217846" },
        new Person { Name = "Rosa Jensen", Age = 23, Phone = "+4543217846" },
    };

    public class Person {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
    }


    public void SamletAlder()
    {
        var totalAge = people.Aggregate(0,(sum, person) => sum + person.Age);
        Console.WriteLine($"Den samlede alder: {totalAge}");
    }

    public void CountNielsen()
    {
        var totalNielsens = people
            .Where(Person => Person.Name.Contains("Nielsen"))
            .Count();
        Console.WriteLine($"Antal personer med Nielsen: {totalNielsens}");
        
    }

    public void FindÆdste()
    {
        var ÆldstePerson = people
            .Max(person => person.Age);
        Console.WriteLine($"Den ældste person er: {ÆldstePerson} ");
    }

    public void FindPersonFraNummer()
    {
        var person = people
            .First(person => person.Phone == "+4543215687");
        Console.WriteLine($"Person med nummer: {person.Phone}: {person.Name} ");
    }

    public void FindOver30()
    {
        var PersonerOver30 = people
            .Where(person => person.Age > 30);
        
        Console.WriteLine("Alle som er over 30år:");
        foreach (var person in PersonerOver30)
        {
            Console.WriteLine($"{person.Name} : {person.Age} år");
        }
        
    }

    public void FjernLandeKode()
    {
        var personerUdenLadekode = people
            .Select(person => new Person 
            {
                Name = person.Name,
                Age = person.Age,
                Phone = person.Phone.Replace("+45", ""),
            })
            .ToArray();
        Console.WriteLine("Personers Uden Ladekode:");
        foreach (var person in personerUdenLadekode)
        {
            Console.WriteLine($"{person.Name}: {person.Phone} ");
        }
        
        /* Uden Foreach Loop
        Console.WriteLine(
            "Personer uden landekode: " +
            string.Join(" | ", personerUdenLandekode.Select(p => $"{p.Name}: {p.Phone}"))
            */
    }

    public void YngreEnd30()
    {
        var result = string.Join(",", people
        .Where(person => person.Age < 30)
        .Select(person => $"{person.Name}: {person.Phone}"));
        Console.WriteLine(result);
    }

    public Func<string, string> CreateWordFilterFn(string[] badWords = null)
    {
        badWords ??= new string[] { "lort", "fuck" };

        return text =>
        {
            var allWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var filteredWords = allWords
                .Where(word => !badWords.Contains(word));
            return string.Join(" ", filteredWords);
        };
    }

    public Func<string, string> CreateWordReplacerFn(string[] words, string replacementWord)
    {
        return text =>
        {
            var allWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            var replacedWords = allWords
                .Select(word => words.Contains(word) ? replacementWord : word);
            return string.Join(" ", replacedWords);
        };
    }
}