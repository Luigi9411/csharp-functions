using System;

int[] Array = { 2, 6, 7, 5, 3, 9 };
printArray(Array);
int[] squaredArray = RaiseToSquare(Array);
printArray(squaredArray);
int somma = ArraySum(Array);
Console.WriteLine("La somma totale degli elementi dell'array è: " + somma);
int sumSquare = ArraySum(squaredArray);
Console.WriteLine("La somma totale degli elementi dell'array è: " + sumSquare);


void printArray(int[] array)
{
    Console.WriteLine(arrayToString(array));
}

string arrayToString(int[] array)
{
    var result = "[";

    for (int i = 0; i < array.Length; i++)
    {
        result += array[i].ToString();

        if (i < array.Length - 1)
        {
            result += ", ";
        }
    }

    result += "]";

    return result;
}

//funzione per il quadrato

int square(int number)
{
    int square = number * number;
    return square;
}

int[] RaiseToSquare(int[] array)
{
    int[] squaredArray = (int[])array.Clone();

    for (int i = 0; i < squaredArray.Length; i++)
    {
        squaredArray[i] = squaredArray[i] * squaredArray[i];
    }

    return squaredArray;
}

//funzione somma

int ArraySum(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }

    return somma;
}



