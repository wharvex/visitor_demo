namespace VisitorDemo;

public interface IPersonalNameVisitor<T>
{
    T Visit(SimpleName name);
    T Visit(Mononym name);
    T Visit(CompoundName name);
}
