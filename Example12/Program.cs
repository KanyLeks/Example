// Цикл FOR


string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count; i++)   // ВОТ ЭТО!!!


    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);


// ЦИКЛ В ЦИКЛЕ 

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}