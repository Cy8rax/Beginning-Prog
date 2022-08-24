void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        Console.WriteLine(collection[index]);
        index++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int position = -1; //-1 для того чтобы подчеркнуть что такого числа нет, те за пределами
    int index = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int []array=new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array,44);
Console.WriteLine(pos);