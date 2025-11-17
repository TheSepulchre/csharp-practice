/*  Learning Objectives
Choose a descriptive name for variables that describe their purpose and intent.
Use code comments to temporarily instruct the compiler to ignore lines of code.
Use code comments to describe higher-level requirements or purpose for a passage of code.
Write code that effectively uses whitespace to convey the relationship of lines of code.
*/


// DESCRIPTIVE VARIABLE NAMES EXAMPLE
string firstName = "Bob";
int widgetsSold = 7;
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/


// COMMENTS EXAMPLE

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
Better Comments

  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/


// WHITE SPACE EXAMPLES

// Example 1:
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!");

// Example 3:

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } else {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

// EXAMPLE 3 (reformatted for readability):

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    }
     else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}


// CHALLENGE EXERCISE

/* The following code takes a string, reverses it, counts the number of times
the letter 'o' appears in the string, then prints out the reversed string and the count.
Reformat the code to improve its readability. */

string str = "The quick brown fox jumps over the lazy dog.";

char[] message = str.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message) 
{
    if (letter == 'o') 
    {   
        letterCount++; 
    } 
}

string newMessage = new String(message);
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");