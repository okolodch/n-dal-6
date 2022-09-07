NewMethod();
static void NewMethod()
{

    //programm asendab lauses "Hello World!" kõik 'o' tähed tärniga (*)

    string helloW = "Hello World!";

    helloW = helloW.Replace('o', '*');
    helloW = helloW.Replace('!', '1');
    Console.WriteLine(helloW);
}