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
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(call[position]);
        position++;
    }
}

int indexOF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position =0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = indexOF(array, 4);
Console.WriteLine(pos);