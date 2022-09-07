NewMethod();
static void NewMethod()
{

    //programm palub kasutajal sisestada oma eesnime;
    //programm kuvab kasutaja eesnime pikkuse

    Console.WriteLine("Sisesta oma eesnimi:");
    string firstName = Console.ReadLine();

    int firstNameLength = firstName.Length;
    Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");
}