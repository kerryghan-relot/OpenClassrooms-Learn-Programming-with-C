//TODO: Create a for and while loop that prints the sentence, "I am having so much fun!" 5 times.
int i = 0;
int b = 4;
for (;b < 5;)  // A fun way to make a for loop act as a while loop.
{
    Console.WriteLine("I am having so much fun!");
    i++;
    if (i == 5)
    { b = 6; }
}

Console.WriteLine("---------------");
double UPPER_LIMIT = 10e6;

int j = 0;
while (j < 5 && UPPER_LIMIT > 0)
{
    Console.WriteLine("I am having so much fun!" + UPPER_LIMIT);
    j++;
    UPPER_LIMIT--;
}