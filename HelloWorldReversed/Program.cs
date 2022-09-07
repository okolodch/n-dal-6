NewMethod();
static void NewMethod()
{

    //programm kuvab lauset "Hello, World!" tagurpidi

    string helloWorld = "Hello, World!";

    for (int i = helloWorld.Length - 1; i >= 0; i--)
    {
        Console.Write(helloWorld[i]);
    }
}