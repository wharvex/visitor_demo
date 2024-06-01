namespace VisitorDemo.NameFormatters;

public class AcademicNameFormatter : IPersonalNameVisitor<string>
{
    public string Visit(SimpleName name) => $"{name.LastName}, {name.FirstName[..1]}.";

    public string Visit(Mononym name) => name.Name;

    public string Visit(CompoundName name) =>
        $"{name.LastName}, {name.FirstName[..1]}. {name.MiddleNames[..1]}.";
}
