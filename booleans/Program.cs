// Coin flip challenge

Random coinFlip = new Random();
int flipResult = coinFlip.Next(0,2);

//flipResult == 0 ? 
//    Console.WriteLine("Heads"): 
//    Console.WriteLine("Tails");

Console.WriteLine((flipResult == 0) ? "Heads" : "Tails");