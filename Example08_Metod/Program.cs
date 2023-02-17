int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 12;
int b1 = 21;
int c1 = 34;
int a2 = 419333;
int b2 = 15;
int c2 = 65;
int a3 = 2333327;
int b3 = 83;
int c3 = 19;




// if (b1 > max) max = b1; //1 метод
// if (c1 > max) max = c1; 
// if (a2 > max) max = a2; 
// if (b2 > max) max = b2; 
// if (c2 > max) max = c2; 
// if (a3 > max) max = a3; 
// if (b3 > max) max = b3; 
// if (c3 > max) max = c3;

// int max1 = Max(a1, b1, c1); //2 метод
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max  = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3)); // 3 метод

Console.WriteLine(max);