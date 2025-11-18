// Coin flip challenge

//Random coinFlip = new Random();
//int flipResult = coinFlip.Next(0,2);

//flipResult == 0 ? 
//    Console.WriteLine("Heads"): 
//    Console.WriteLine("Tails");

//Console.WriteLine((flipResult == 0) ? "Heads" : "Tails");

string permission = "Admin|Manager";
int level = 56;

if (permission.Contains("Admin"))
{
    Console.WriteLine((level > 55) ? 
        "Welcome, Super Admin user" : 
        "Welcome, Admin user");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level >=20) ? 
        "Contact an Admin for access" : 
        "You do not have sufficient privileges");
}
else
{
    Console.WriteLine("You do not have sufficient privileges");
}
