int[] array = { 45, 12, 45, 45, 45, 8845, 345, 2432, 45, 435, 45, 45, 45, 45, 45 };

int n = array.Length;
int find = 45;

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