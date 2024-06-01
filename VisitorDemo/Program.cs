using VisitorDemo.NameFormatters;

namespace VisitorDemo;

internal class Program
{
    public static void Main()
    {
        var publications = new Publication[]
        {
            new("One Thousand and One Nights"),
            new("Rhetoric", new Mononym("Aristotle")),
            new("The C++ Programming Language", new SimpleName("Bjarne", "Stroustrup")),
            new(
                "The C Programming Language",
                new SimpleName("Brian", "Kernighan"),
                new SimpleName("Dennis", "Ritchie")
            ),
        };
        Print(publications, new CommonNameFormatter());
        Print(publications, new AcademicNameFormatter());
    }

    private static void Print(
        IEnumerable<Publication> publications,
        IPersonalNameVisitor<string> formatter
    )
    {
        foreach (var publication in publications)
        {
            Console.WriteLine(publication.ToString(formatter));
        }
        Console.WriteLine(new string('-', 80));
        Console.WriteLine();
    }
}
