void printAnswer(int namber)
{
    if(namber == 1) Console.WriteLine(" Допустимо при Х>0 и Y>0");
    if(namber == 2) Console.WriteLine(" Допустимо при Х<0 и Y>0");
    if(namber == 3) Console.WriteLine(" Допустимо при Х<0 и Y<0");
    if(namber == 4) Console.WriteLine(" Допустимо при Х>0 и Y<0");

}

string? inputLine = Console.ReadLine();

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
  
    //int outNumber = (int)Math.Pow(inputNumber,2);
    //Console.WriteLine(outNamber);
    printAnswer(inputNumber);
}
