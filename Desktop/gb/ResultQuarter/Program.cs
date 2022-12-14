// Задача: Написать программу,которая из имеющегося массива строк формирует новый
//массив из строк, длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на 
//старте выполнения алгоритма. При решении не рекомендуется 
//пользоваться коллекциями, лучше обойтись исключительно массивами.

/*Примеры:
["Hello", "2", "world", ":-)"] → ["2", ":-)"]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []
*/

string[] NewArray(string[] array1)
{
    string[] array2=new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}

void PrintArray(string[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        Console.Write($" {mas[i]} ");
    }
    Console.WriteLine();
}

//string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array1 = new string[4] {"1234", "1567", "-2", "computer science"};
//string[] array1 = new string[3] {"Russia", "Denmark", "Kazan"};

string [] arrayFinal=NewArray(array1);
PrintArray(arrayFinal);