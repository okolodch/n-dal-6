NewMethod();
static void NewMethod()
{

    //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga;
    //programm asendab samas lauses kõik 'a' tähed 4-ga

    string dontPanic = "Don't panic";

    dontPanic = dontPanic.Replace('o', '0');
    dontPanic = dontPanic.Replace('a', '4');
    Console.WriteLine(dontPanic);
}