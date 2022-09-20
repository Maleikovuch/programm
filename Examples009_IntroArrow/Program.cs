int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] arroy = { 11, 23, 43, 74, 590, 26, 17, 38, 91 };


int result = Max(Max(arroy[0], arroy[1], arroy[2]),Max(arroy[3], arroy[4], arroy[5]),Max(arroy[6], arroy[7], arroy[8]));
Console.WriteLine(result);
