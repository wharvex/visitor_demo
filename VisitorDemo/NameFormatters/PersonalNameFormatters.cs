using System.Diagnostics;

namespace VisitorDemo.NameFormatters;

public static class PersonalNameFormatters
{
    /// <summary>
    /// The `this' in the params list means this is an "extension method."
    /// It means we can call
    /// string s = simpleName.CommonName();
    /// where simpleName is an instance of SimpleName which extends CommonName;
    /// rather than
    /// string s = CommonName(simpleName);
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public static string CommonName(this PersonalName name) =>
        name switch
        {
            Mononym mononym => mononym.Name,
            SimpleName simple => $"{simple.FirstName} {simple.LastName}",
            CompoundName compound => $"{compound.FirstName} {compound.LastName}",
            _ => throw new UnreachableException()
        };

    public static string FullName(this PersonalName name) =>
        name switch
        {
            Mononym mononym => mononym.Name,
            SimpleName simple => $"{simple.FirstName} {simple.LastName}",
            CompoundName compound
                => $"{compound.FirstName} {compound.MiddleNames} {compound.LastName}",
            _ => throw new UnreachableException()
        };

    public static string AcademicName(this PersonalName name) =>
        name switch
        {
            Mononym mononym => mononym.Name,
            SimpleName simple => $"{simple.LastName}, {simple.FirstName[..1]}.",
            CompoundName compound
                => $"{compound.LastName}, {compound.FirstName[..1]}. {compound.MiddleNames[..1]}.",
            _ => throw new UnreachableException()
        };
}
