using Home_task3;
using System;
using System.Threading.Channels;

Month month = new Month();
String[] name = Enum.GetNames(typeof(Month));
int[] number = (int[])Enum.GetValues(typeof(Month));


Console.WriteLine("Hozirgi oyni nomini olish");
Console.WriteLine("Hozirdan boshlap oylarni nomini chikarish");
Console.WriteLine("Tugilgan oyni topib berish");
Console.Write("comand: ");
int comand = Convert.ToInt32(Console.ReadLine());



if (comand == 1)
{
	for (int i = 0; i < number.Length; i++)
	{
		if (DateTime.Now.Month == number[i])
		{
			Console.WriteLine(name[i]);
        }

	} 

}

Console.WriteLine();

if (comand == 2)
{ 
	int nowMonth = DateTime.Now.Month;
	for (int i = 0; i < number.Length; i++)
	{
        Console.WriteLine(Enum.GetName(typeof(Month), i)); 
    }
}
		
if (comand == 3)
{
    Console.WriteLine("Yil/Oy/Kun : "); 
	string? birthDate = Console.ReadLine();
	string[]? date = birthDate.Split('/');
	for (int i = 0;i < number.Length; i++)
	{
		if (Convert.ToInt32(date[1]) == number[i])
		
		{
            Console.WriteLine($"Siz tugulgan oy : {name[i]}");
        }
	}
}
