Random diceRoller = new Random();

int dice1 = diceRoller.Next(1, 7);
int dice2 = diceRoller.Next(1, 7);
int dice3 = diceRoller.Next(1, 7);

int totalPoints = dice1 + dice2 + dice3;

Console.WriteLine("Dice 1: " + dice1);
Console.WriteLine("Dice 2: " + dice2);
Console.WriteLine("Dice 3: " + dice3);

if (dice1 == dice2 && dice2 == dice3)
{ 
    Console.WriteLine("Triple rolled!");
    totalPoints += 6;
}
else if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
{
    Console.WriteLine("Double rolled!");
    totalPoints += 2;
}

Console.WriteLine("Total Points: " + totalPoints);

if (totalPoints >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("You lose!");
}