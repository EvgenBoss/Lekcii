void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random() .Next(1, 10); 
        index++;
    }
}

void PrintArray(int[] call)
{
    int count = call.Length;
    int pos = 0;
    while(pos < count)
    {
        Console.WriteLine(call[pos]);
        pos++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);