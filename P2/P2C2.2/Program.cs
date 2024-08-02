using P2C2._2;

Color selectedColor = Color.Green;

// TODO: Replace the if/else sequence with an equivalent switch statement that operates according to the value of the selectedColor variable
switch (selectedColor)
{
    case Color.Blue:
        Console.WriteLine("The color is blue");
        break;
    case Color.Green:
        Console.WriteLine("The color is green");
        break;
    case Color.Red:
        Console.WriteLine("The color is red");
        break;
    case Color.Yellow:
        Console.WriteLine("The color is yellow");
        break;
    default:
        Console.WriteLine("We do not know the color!");
        break;
}