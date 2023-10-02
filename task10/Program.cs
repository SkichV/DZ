Console.WriteLine("Введите трехзначное число: ");  
int num = Convert.ToInt32(Console.ReadLine());  
if (num > 100 && num < 1000) 
{  
    int secondDigit = num / 10 % 10;  
    Console.WriteLine("Вторая цифра числа: " + secondDigit);  
}
else   
{  
    {  
    Console.WriteLine("Число не трехзначное");     
    }  
}