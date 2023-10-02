Console.WriteLine("Ведите число: "); 
int anyNum = Convert.ToInt32(Console.ReadLine()); 
string anyNumText = Convert.ToString(anyNum); 
if (anyNumText.Length > 2) 
{ 
    Console.WriteLine("Третье число: " + anyNumText[2]); 
} 
else 
{ 
    Console.WriteLine("Третьей цифры нет"); 
}