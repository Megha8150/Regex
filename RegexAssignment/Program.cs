using RegexAssignment;
Console.WriteLine("Welcome to User Registratuiuon Program");

Patterns patterns = new Patterns();
Console.WriteLine("Enter the password");
string password = Console.ReadLine();
patterns.Validation(password);