NewMethod();
static void NewMethod()
{

    //programm küsib kasutaja eesnime;
    //programm kuvab kasutaja eesnime tagurpidi

    Console.WriteLine("Sisesta oma eesnimi:");
    string firstName = Console.ReadLine();

    for (int i = firstName.Length - 1; i >= 0; i--)
    {
        Console.Write(firstName[i]);
    }
}