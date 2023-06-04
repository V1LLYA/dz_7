// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] Create2DRandomArray(int rows, int colums, double minValue, double maxValue){
//     double[,] array = new double[rows, colums];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colums; j++){
//             array[i, j] = new Random().NextDouble(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент");
// double minValue = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент");
// double maxValue = Convert.ToDouble(Console.ReadLine());

// double[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] Create2DRandomArray(int rows, int colums, int minValue, int maxValue){
//     int[,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++){
//         for(int j = 0; j < colums; j++){
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// string IsThereNumber(int[,] array, int number){
//     string otvet = "";
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             if(number == array[i, j]){
//                 otvet = "В данном массиве есть данное число";
//             } else if(number != array[i, j]) {
//                 otvet = "В данном массиве нет данного числа";
//             }
//         }
//     }
//     return otvet;
// }

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите минимальный элемент");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите максимальный элемент");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число для проверки его нахождения в массиве");
// int number = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = Create2DRandomArray(rows, columns, minValue, maxValue);
// Print2DArray(myArray);
// Console.WriteLine(IsThereNumber(myArray, number));