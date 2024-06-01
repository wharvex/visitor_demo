namespace VisitorDemo.NameFormatters;

public class FullNameFormatter : IPersonalNameVisitor<string>
{
    public string Visit(SimpleName name) => $"{name.FirstName} {name.LastName}";

    public string Visit(Mononym name) => name.Name;

    public string Visit(CompoundName name) =>
        $"{name.FirstName} {name.MiddleNames} {name.LastName}";
}
