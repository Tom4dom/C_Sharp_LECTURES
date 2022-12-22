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

//       index   0   1   2  3  4   5   6    7     8 
int[] array = { 35, 34, 33, 4, 55, 6, 4995, 4, 36464659 };

int max = Max(array[0], array[1], array[2], array[3], array[4], array[5], array[6], array[7], array[8]);

Console.WriteLine(max);

