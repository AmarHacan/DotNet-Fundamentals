using DemoLibrary;


Console.WriteLine("Enter your First Name");
string? firstName = Console.ReadLine();
Console.WriteLine("Enter your Last Name");
string? lastName = Console.ReadLine();

//Person objPerson = new Person();
string fullName= Person.GetFullName(firstName,lastName);
Console.WriteLine("Welcome on Board Mr "+fullName);
