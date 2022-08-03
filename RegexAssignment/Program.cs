using RegexAssignment;
Console.WriteLine("Welcome to User Registratuiuon Program");

Patterns patterns = new Patterns();
Console.WriteLine("Enter the Last name");
string lastname = Console.ReadLine();
patterns.Validation(lastname);