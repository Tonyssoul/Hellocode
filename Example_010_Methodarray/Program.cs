int[] array = { 11, 21, 32, 43, 86, 52, 63, 74, 86 };

int n = array.Length;
int find = 86;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}