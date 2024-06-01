namespace VisitorDemo;

public abstract record PersonalName()
{
    public abstract T Accept<T>(IPersonalNameVisitor<T> visitor);
}

public record SimpleName(string FirstName, string LastName) : PersonalName
{
    public override T Accept<T>(IPersonalNameVisitor<T> visitor) => visitor.Visit(this);
}

public record Mononym(string Name) : PersonalName
{
    public override T Accept<T>(IPersonalNameVisitor<T> visitor) => visitor.Visit(this);
}

public record CompoundName(string FirstName, string MiddleNames, string LastName) : PersonalName
{
    public override T Accept<T>(IPersonalNameVisitor<T> visitor) => visitor.Visit(this);
}
