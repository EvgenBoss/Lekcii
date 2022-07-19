int[] array = {1,7,9,4,6,3,5,2,8,6}; 
void printarray(int[] arr)
{
    int length = arr.Length;
    for (int i = 0;i < length; i++ )
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void select(int[] arr)
{
    for (int i = 0;i < arr.Length - 1; i++ )
    {
        int min = i;
        for(int j = i + 1;j < arr.Length; j++ )
        {
            if(arr[j] < array[min]) min = j;
        }

        int temp = arr[i];
        arr[i] = arr[min];
        arr[min] = temp;
    }
}

printarray(array);
select(array);

printarray(array);