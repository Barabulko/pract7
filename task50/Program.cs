// See https://aka.ms/new-console-template for more information
Console.WriteLine("task50");

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1, 7 -> такого числа в массиве нет*/

double[,] generateArray(int m, int n) {
    Random random = new Random();
    
    double[,] myArray = new double[m,n];
    for(int i=0; i<myArray.GetLength(0); i++){
        for(int j=0; j<myArray.GetLength(1); j++){
            myArray[i,j] = random.NextDouble()*10;
        }
    }
    return myArray;
}

void printArray(double[,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]:f0} ");
        }
        Console.WriteLine();
    }
}

double[,] myArray = new double[3,4];
myArray = generateArray(3, 4);
Console.WriteLine("your array:");
printArray(myArray);

Console.Write("enter M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("enter N = ");
int N = int.Parse(Console.ReadLine());

if ((M<myArray.GetLength(0)) && (N<myArray.GetLength(1))) {
    Console.WriteLine($"array[{M},{N}] = {myArray[M,N]:f0}");
} else {
    Console.WriteLine("Такого числа в массиве нет");
}
