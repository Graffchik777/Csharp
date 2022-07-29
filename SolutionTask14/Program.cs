Console.WriteLine("Введите число: ");
string? inputOne = Console.ReadLine();
Console.WriteLine(reminderSearcher(inputOne));

string reminderSearcher(string? str)
{
    if(str != null);
    {
        try
        {
            string answer;
            int num = int.Parse(str);
            if (((num%7) == 0) && ((num%23) == 0))
            {
                answer = " Это число делится и на 7 и на 23";
            }
            else 
            {
                answer = " Это число не делится на 23 и 7 сразу и без остатка ";
            }
            return answer;
        }
        catch(Exception e)
        {
            return " Возникло какое то исключение:" + e.Message;

        }
    }
    return "";

}


