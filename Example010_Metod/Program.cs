int[] arroy = { 11, 25, 31, 45, 22, 15, 74, 31, 22 };

int n = arroy.Length;
int find = 22;

int index = 0;

while (index < n)
{
    if (arroy[index] == find)
    {
        Console.WriteLine(index);
        break;
    }


        index++;
}
