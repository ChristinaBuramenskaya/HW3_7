// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
};

void Result(int[,] collection)
{
    Console.WriteLine("Введите строку элемента: ");
    int x = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите столбец элемента: ");
    int y = int.Parse(Console.ReadLine());
    int i = 0;
    int j = 0;
    if (x > i & y > j)
    {
        Console.WriteLine("Такого элемента нет");
    }
    else
    {

        for (i = 0; i <= x; i++)
        {
            for (j = 0; j <= y; j++)

            {

                if (i == x && j == y)
                {
                    Console.Write("Значение элемента в данной позиции = ");
                    Console.Write(collection[i, j]);
                }


            }
        }
    }

}

int[,] array = new int[3, 4]
{
    {1,2,3,4},
    {5,6,7,8},
    {9,10,11,12},
};
PrintArray(array);
Result(array);