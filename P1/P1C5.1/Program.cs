// TODO: Declare a variable named colors of an array of string of length 5
string[] colors = new string[5];

// TODO: Fill the array with the requested colors: red, yellow, orange, green, blue
colors = [ "red", "green", "blue", "orange", "yellow" ];  // We're not really filling the array here to be honest

// TODO: Replace green with emerald in the array
colors[3] = "emerald";

// Display the contents of the array
foreach (string color in colors)
{
    Console.WriteLine(color);
}

// Different ways to create and initialize the same array
// I wonder what differences there are. I guess it must be something like you can change the size of b and c but not the size of a, or something like that.
int[] a = new int[5] { 1, 2, 3, 4, 5 };
int[] b = new int[] { 1, 2, 3, 4, 5 }; // Interstingly, this way of writing is not showed in Microsoft doc.
int[] c = [1, 2, 3, 4, 5];
int[] d = {1, 2, 3, 4, 5};

/// Here is what the Microsoft doc says about arrays :
/// (https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/arrays#single-dimensional-arrays)

// Declare a single-dimensional array of 5 integers.
int[] array1 = new int[5];
// Declare and set array element values.
int[] array2 = [1, 2, 3, 4, 5, 6];

/* Many of the examples in this article use collection expressions (which use square brackets) to initialize the arrays. 
 * Collection expressions were first introduced in C# 12, which shipped with .NET 8. If you can't ugrade to C# 12 yet, 
 * use { and } to initialize the arrays instead.*/
// Collection expressions:
int[] array3 = [1, 2, 3, 4, 5, 6];
// Alternative syntax:
int[] array4 = { 1, 2, 3, 4, 5, 6 };

// Interestingly, I noticed that you can change the size of array like follow:
a = [1, 2, 3, 4, 5, 6, 7];
b = [1, 2, 3, 4, 5, 6, 7];
array2 = [1, 2, 3, 4, 5, 6, 7];
array4 = [1, 2, 3, 4, 5, 6, 7];
// That shows that arrays in C# are refference type, so we're not really changing the size of the array, we're just making the variable points to another object.