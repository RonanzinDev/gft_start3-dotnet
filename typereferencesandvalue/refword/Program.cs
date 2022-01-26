using static System.Console;

public class Program
{
    static void Demo1()
    {
        int a = 2;
        Add20(ref a);
    }
    static void Add20(ref int a) => a += 20;
    static void Main()
    {

    }
}