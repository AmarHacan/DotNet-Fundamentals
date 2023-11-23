
using _00AccessModifierLibrary;

//it automatically converts implicitly converts the char into coresponding
// base ascii number like 97

AllModifiers constructorWithNoParam = new AllModifiers();
AllModifiers constructorWithStringParam = new AllModifiers("StringCall");

AllModifiers constructorWithIntParam = new AllModifiers('a');

AllModifiers test = new AllModifiers();

test.PublicMethod();


//Not accessible
//test.PrivateMethod();


test.TestPublic();

ChildOfAllModifiers childOfAllModifiers = new ChildOfAllModifiers();
//childOfAllModifiers.Protected();

//allModifiers.
//getType, tostring,  gethashcode, equal are object methods which are available to all object



