int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.Write($"Bin {bin} has {items} items.");
    Console.WriteLine($" Current running total: {sum}");
}
Console.WriteLine($"Total inventory items: {sum}");