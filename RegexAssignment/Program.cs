using RegexAssignment;
Console.WriteLine("Welcome to User Registratuiuon Program");

Patterns patterns = new Patterns();
Console.WriteLine("Enter the phonenumber");
string phonenumber = Console.ReadLine();
patterns.Validation(phonenumber);