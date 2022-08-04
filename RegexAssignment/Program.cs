using RegexAssignment;
Console.WriteLine("Welcome to User Registratuiuon Program");

Patterns patterns = new Patterns();
Console.WriteLine("Enter the emailsample");
string email = Console.ReadLine();
patterns.Validation(email);