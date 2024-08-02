// See https://aka.ms/new-console-template for more information
/// I used that project to try things allong the chapter 1 in part 3. No real exercise here, just testing some stuff with constant, references, ...

const int c = 5;

Console.WriteLine(adder(c, 9));

int adder(int a, int b)
{
    a++;
    return a + b;
}