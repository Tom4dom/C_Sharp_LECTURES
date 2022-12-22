// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }


int Max(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
{
    int result = arg0;
    if (arg1 > result) result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    if (arg4 > result) result = arg4;
    if (arg5 > result) result = arg5;
    if (arg6 > result) result = arg6;
    if (arg7 > result) result = arg7;
    if (arg8 > result) result = arg8;
    return result;
}

int a1 = 135;
int b1 = 2526;
int c1 = 3;
int a2 = 8;
int b2 = 4;
int c2 = 5;
int a3 = 6;
int b3 = 7;
int c3 = 9;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max  = Max(max1, max2, max3);

// int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
int max = Max(a1, b1, c1, a2, b2, c2, a3, b3, c3);


// int max = a1
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

Console.WriteLine(max);

