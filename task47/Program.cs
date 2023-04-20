// See https://aka.ms/new-console-template for more information
Console.WriteLine("task47");

/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9*/

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
            Console.Write($"{array[i,j]:f1} ");
        }
        Console.WriteLine();
    }
}

Console.Write("enter M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("enter N = ");
int N = int.Parse(Console.ReadLine());
printArray(generateArray(M, N));