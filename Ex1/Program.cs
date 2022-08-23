// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int CountEven()
{
    Console.WriteLine ("Введите числа через пробел");
    string numbers = Console.ReadLine();
    int [] array = Array.ConvertAll(numbers.Split(),int.Parse);
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array [i] > 0)
        {
            count++;
        }
    }
    return count;
}
int count = CountEven();
Console.WriteLine ($"Количество чисел больше нуля = {count}");

