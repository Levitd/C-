
/*
using System;
string text = "Здесь первый операнд (то есть условие) представляет выражение x < y. Если оно равно true, то возвращается второй операнд - (x+y), "
+"то есть результат операции сложения. Если условие равно false, то возвращается третий операнд - (x-y)."
+"Результат тернарной операции (то есть второй или третий операнд в зависимости от условия) присваивается переменной z.";

string Replace (string text, char oldValue, char newValue){

    string result = String.Empty;

    int length = text.Length;
    for( int i =0; i<length; i++){
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
*/
using System;
using static System.Console;

Clear();

int[] arr = { 5, 7, 2, 5, 7, 6, 3, 2, 5, 6, 5 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Write($"{array[i]} ");
    }
    WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j=i+1; j<array.Length;j++){
            if(array[j] <array[minPosition]) minPosition=j;
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);