using RegexAssignment;
Console.WriteLine("Welcome to User Registratuiuon Program");

Patterns patterns = new Patterns();
Console.WriteLine("Enter the First name");
string n = Console.ReadLine();
if (patterns.Validation(n))
    Console.WriteLine(" Valid ");
else
    Console.WriteLine(" Invalid ");
