
namespace DemoLibrary;

public static class Person
{
    public static string GetFullName(string firstName="firstName",string lastName="lastName")
    {
        string fullName =string.Concat(firstName," ",lastName);
        return fullName;
    }
}
