string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    string lineN = "";
    string lineNN = string.Empty;
    int s = 1;
    while (s <= numberN)
    {
        lineN = lineN + s + "  ";
        lineNN = lineNN + (s * s).ToString() + "  ";
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
    
}
// int outNumber = (int)Math.Pow(inputLineN,2);
// Console.WriteLine(outNamber);




// class A
// {
//     virtual void Foo()
//     {
//         Console.Write("Class A");
//     }
// }
// class B: A
// {
//     override void Foo()
//     {
//         Console.Write("Class B");
//     }
// }

