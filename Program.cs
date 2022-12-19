//Задача 1
/*Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.*/

Console.Write("Ведите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine() );

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine() );

if (num1 > num2){
Console.WriteLine($"{num1} Большее число" );
}else{
Console.WriteLine($"{num2} Большее число" );
};

//===========================================================================


//Задача 2
/*Напишите программу которая на вход принимает три числа и выдает максимальное из этих чисел */

Console.Write("Ведите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine() );

Console.Write("Введите второе число ");
int numb2 = Convert.ToInt32(Console.ReadLine() );

Console.Write("Ведите третье число: ");
int numb3 = Convert.ToInt32(Console.ReadLine() );

int maxInt = numb1;

if (numb2 >= maxInt && numb2 >= numb3){
maxInt = numb2;
 }else if (numb3 >= maxInt && numb3 >= numb2){
   maxInt = numb3;
};

Console.WriteLine($"{maxInt} Наибольшее число из {numb1}, {numb2}, {numb3}" );

//==============================================


//Задача 3
/*Напишите программу, которая на вход принимает число и выдает, является ли число четным (делиться ли она на два без остатка).*/

Console.WriteLine("Введите число для проверки на четность: ");
int number = Convert.ToInt32(Console.ReadLine() );

if (number % 2 == 0){
Console.WriteLine($"{number} является ЧЕТНЫМ (Even)");
}else{
Console.WriteLine($"{number} НЕЧЕТНОЕ(odd) ");
};

//===============================================================


//Задача 4
/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.*/

Console.Write("Введите нмер: ");
int integer = Convert.ToInt32(Console.ReadLine() );

int count = 1;

while(count <= integer){
if (count %2 == 0){
    Console.WriteLine($"Число {count} ЧЕТНОЕ из {integer} чисел");  
};
count++;
};

