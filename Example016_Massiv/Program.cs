int[] arr = { 1, 5, 7, 4, 3, 6, 2, 1, 4, 2, };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSert(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i]) 
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }


    }
}

PrintArray(arr);
SelectionSert(arr);
PrintArray(arr);
