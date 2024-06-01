namespace VisitorDemo;

public class Publication
{
    public string Title { get; }
    public IEnumerable<PersonalName> Authors => AuthorsList;
    private List<PersonalName> AuthorsList { get; }

    public Publication(string title, params PersonalName[] authors)
    {
        Title = title;
        AuthorsList = [..authors];
    }

    public string ToString(IPersonalNameVisitor<string> formatter) =>
        AuthorsList.Count == 0
            ? Title
            : $"{string.Join(", ", Authors.Select(a => a.Accept(formatter)))}, {Title}";

    public string ToString(Func<PersonalName, string> nameFormatter) =>
        AuthorsList.Count == 0
            ? Title
            : $"{string.Join(", ", Authors.Select(nameFormatter))}, {Title}";

    public override string ToString() =>
        AuthorsList.Count == 0 ? Title : $"{Title} by {string.Join(", ", Authors)}";
}
