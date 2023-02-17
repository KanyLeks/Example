/* int[] array = { 1, 22, 13, 34, 35, 64, 17, 34 };

int n = array.Length;
int find = 34;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
} */

void FillArray(int[] collection)  //метод1
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++; //index = index + 1;
    }

}

void PrintArray(int[] col)  //метод2
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[]Collection, int find)  //метод3
{
    int count = Collection.Length;
    int index = 0;
    int position = -1; // хитрость, для поиска неверного значения 444
    while (index < count)
    {
        if(Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];  //длина массива

FillArray(array);    //вывод в терминал 
PrintArray(array);   //вывод в терминал 
Console.WriteLine();

int pos = IndexOf(array, 444);  //поиск числа в массиве
Console.WriteLine(pos);
