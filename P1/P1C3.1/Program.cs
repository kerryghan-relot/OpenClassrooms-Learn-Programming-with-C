int numerator = 10;
int denominator = 4;

// TODO: Change the statement below so that answer holds a decimal value
decimal answer = (decimal)numerator / denominator;

// Display the result 
Console.WriteLine(numerator + " / " + denominator + " = " + answer);

// Now, time for my little tests !

// Difference in roundings
float length1 = 10.238786281F;
float length2 = 10.238786211F;
Console.WriteLine($"Difference in roundings:\n\n" +
                  $"  10.238786281F = {length1}\n" +
                  $"  10.238786211F = {length2}\n\n"); // Interestingly, both floating point numbers are not rounded the same way???

// Chaining explicit conversion
float length3 = (float)(decimal)10; // As you can see, we can chain explicit conversions
Console.WriteLine($"Chaining explicit conversion :\n\n" +
                  $"  {length3}\n\n");

// Difference between rounding
float a = 1876.79797657765609870978709780987F;
double b = 1876.79797657765609870978709780987;
decimal c = 1876.79797657765609870978709780987M;
Console.WriteLine($"Difference between rounding:\n\n  a: {a}\n  b: {b}\n  c: {c}\n\n");

double d = 454545; 
Console.WriteLine($"Working with doubles:\n\n  (double)d = {d}");
d /= 2;
Console.WriteLine($"  (double)d / 2 = {d}\n\n");

// All the different possible ways of initializing variables
int w = 5;
float x1 = 5, x2 = 5.0F;
double y1 = 5, y2 = 5F, y3 = 5.0, y4 = 5.0F, y5 = 5D, y6 = 5.0D;
decimal z1 = 5M, z2 = 5.0M;
Console.WriteLine($"All the different possible ways of initializing variables :\n\n" +
                  $"  int     : w  = {w}\n" +
                  $"  float   : x1 = {x1}, x2 = {x2}\n" +
                  $"  double  : y1 = {y1}, y2 = {y2}, y3 = {y3}, y4 = {y4}, y5 = {y5}, y6 = {y6}\n" +
                  $"  decimal : z1 = {z1}, z2 = {z2}\n\n");
