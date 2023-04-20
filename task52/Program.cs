// See https://aka.ms/new-console-template for more information
Console.WriteLine("task52");

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] generateArray(int m, int n) {
    Random random = new Random();
    
    int[,] myArray = new int[m,n];
    for(int i=0; i<myArray.GetLength(0); i++){
        for(int j=0; j<myArray.GetLength(1); j++){
            myArray[i,j] = random.Next(10);
        }
    }
    return myArray;
}

void printArray(int[,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"  {array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("enter M = ");
int M = int.Parse(Console.ReadLine());
Console.Write("enter N = ");
int N = int.Parse(Console.ReadLine());
int[,] myArray = new int[M, N];
myArray = generateArray(M, N);
printArray(myArray);

Console.WriteLine();
double summ = 0;
for(int j=0; j<myArray.GetLength(1); j++) {
    summ = 0;
    for(int i=0; i<myArray.GetLength(0); i++) {
        summ+=myArray[i,j];    
    }
    Console.Write($"{summ/myArray.GetLength(0):f1} ");
}