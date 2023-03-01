string[,] table = new string[2, 5];
// table [0,0]  table [0,1] table [0,2] table [0,4]  
// table [1,1]  table [1,1] table [1,2] table [1,4]


// table[1, 2] = "слово";


// for (int rows = 0; rows < 2; rows++) // кол - во строк
// {
//     for (int columns = 0; columns < 5; columns++) // кол - во столбцов
//     {
//         Console.WriteLine($"{table[rows, columns]}--");
//     }
// }






void PrintArray(int[,] matr) // структура массива
{
    for (int i = 0; i < matr.GetLength(0); i++) // внешний цикл, щелкающие строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // внутренний цикл, щелкающие столбцы
        { // matrix.GetLength - длина массива new int [0=3, 1=4]. 
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


void FillArray(int[,] matr) // заполнение массив случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);  // генератор псевдослучайных чисел
        }
    }

}

int[,] matrix = new int[3, 4];

PrintArray(matrix); // инициализируем 
FillArray(matrix); // аргумент 
Console.WriteLine();
PrintArray(matrix);