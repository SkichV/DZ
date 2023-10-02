Console.WriteLine("Введите номер дня недели: "); 
int dayNum = Convert.ToInt32(Console.ReadLine()); 
if (dayNum > 0 && dayNum < 6 ) 
{ 
    Console.WriteLine("Это будний день."); 
} 
else if (dayNum == 6 || dayNum == 7) 
{ 
    Console.WriteLine("Выходной день."); 
} 
else 
{ 
    Console.WriteLine("Такого дня недели не существует!"); 
}