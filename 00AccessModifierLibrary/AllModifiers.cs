
using System.Runtime.CompilerServices;

namespace _00AccessModifierLibrary;

public class AllModifiers
{
    private readonly int variable;

    //it is accessible to all instance of this class and value changed
    // for this will be affected for all of the instances
    public string varString;
    //static class does not have constructor

    //overloading concept in constructors where names of the 
    // methods are same but having different parameters

    public AllModifiers() { }
    public AllModifiers(string strVar) {

        varString = strVar;
        TestPublic();
        Console.WriteLine("string Param Constructor :" + varString);

    }
    public AllModifiers(int intVar) {
        this.variable = intVar;
        varString = variable.ToString();
        Console.WriteLine("Int Param Constructor :" + varString);
    }

    #region //public methods with overloading
    public void PublicMethod()
    {
        Console.WriteLine("This is accessible anywhere" +
            " where class in accessible : " + varString);
    }
    public void PublicMethod(string name)
    {
        Console.WriteLine();
        //AllModifiers allModifiers = new AllModifiers();
        //allModifiers.PrivateMethod();
    }
    #endregion

    private void PrivateMethod()
    {
        Console.WriteLine("Only accessible within the same scope" +
            "like its parent curly braces only like only in current class");
    }
    private string PrivateMethod(string name)
    {
        Console.WriteLine("Only accessible within the same scope" +
            "like its parent curly braces only like only in current class");
        return "PrivateMethodReturned";
    }

    protected void Protected(){

        Console.WriteLine("Protect Called" +
            " From Privatestring");
    }

    public void TestPublic()
    {
        PrivateMethod();
        Protected();
    }
   protected internal  void ProtectedInternal() { }
    private protected virtual void PrivateProtected() { }
}
public class RandomClass
{
    RandomClass()
    {
        //Protected();
        //PrivateProtected();
        //ProtectedInternal();
    }
}
public class ChildOfAllModifiers : AllModifiers
{
    public ChildOfAllModifiers()
    {
        Protected();
        PrivateProtected();
        ProtectedInternal();

        //Error Private MEthod
        //PrivateMethod();
    }
    private protected override void PrivateProtected() { }

    //protected void Protected()
    //{
    //    Console.WriteLine("Protect Called" +
    //        " From Privatestring");
    //}


}

