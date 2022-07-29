string? inputOne = Console.ReadLine();
string? inputTwo = Console.ReadLine();

if(inputOne != null && inputTwo != null);
    int inputNunOne = int.Parse(inputOne);
    int inputNumTwo = int.Parse(inputTwo);

    int diver = inputNunOne%inputNumTwo;
        if(diver == 0)
        {
            Console.WriteLine("Да, делится нацело");
        }
            else
            {
                Console.WriteLine(diver);
            }