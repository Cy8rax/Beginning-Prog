int[]array={1,235,234,8756,234,6745,43,5754};

int n=array.Length;

int find = 5754;

int index = 0;

while(index<n)
{
    if(array[index]==find)
    {
        Console.WriteLine("Position of the Number");
        Console.WriteLine(index);
    }
    index++;
}