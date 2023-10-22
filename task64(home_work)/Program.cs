void RoadOfN(int number)
{
for (int i = number; i >= 1; i--) 
{ 
Console.Write(i + " "); 
} 
}
System.Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
RoadOfN(number);