// Написать программу, которая из имеющегося массива строк формирует массив из строк,
//  длина которых меньше либо равна 3 символа.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] arr1 = new string[5] {"ТРУД", "88", "МАЙ", "ДА", "ВЕСНА"};
string[] arr2 = new string[arr1.Length];
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arr1, arr2);
PrintArray(arr2);
