Console.Write("Забьем какое-нибудь число: ");
int intNumber = Convert.ToInt32(Console.ReadLine());
string intNumberText = Convert.ToString(intNumber);
if(intNumberText.Length > 2)
{
  Console.WriteLine("Третья цифра: " + intNumberText[2]);
}
else {
  Console.WriteLine("Третьей цифры нету...");
}