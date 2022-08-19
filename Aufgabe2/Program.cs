Console.Write("a = ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("b = ");
int number2 = Convert.ToInt32(Console.ReadLine());
int maxnumber = number1;
if (number2 > maxnumber)
{
  maxnumber = number2;
  System.Console.WriteLine("max = " + maxnumber);  
}
else
{
   maxnumber = number1; 
System.Console.WriteLine("max = " + maxnumber);
}