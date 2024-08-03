namespace P3C2;

public class Animal
{
    private static int count = 0;

    public void Increment()
    {
        Animal.count += 1;
    }

    public static void PrintName()
    {
        String name = "Rocky";
        Console.WriteLine(name);
    }
}