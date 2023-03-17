using System;

Console.WriteLine("Inserisci il numero di numeri che vuoi inserire:");
int n = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[n];

Console.WriteLine("Inserisci " + n + " numeri:");

for (int i = 0; i < n; i++)
{
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
//int[] Array = { 2, 6, 7, 5, 3, 9 };
printArray(Array);
int[] squaredArray = RaiseToSquare(Array);
printArray(squaredArray);
int sum = ArraySum(Array);
Console.WriteLine("La somma dell'array è: " + sum);
int sumSquare = ArraySum(squaredArray);
Console.WriteLine("La somma dell'array elevato al quadrato è: " + sumSquare);




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



