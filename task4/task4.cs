void FillArray(int[] collection) // void - это метод, который ничего не возвращает и мы не используем return.
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

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

int [] array = new int [10]; // Создай новый массив, который будет заполнен 10-ю элементами. 
                             // По умолчанию это будут нули.

FillArray(array); // Метод заполнения массива 
array[4] = 4;
array [6] = 4;

PrintArray(array); // Метод печати на экран 
Console.WriteLine();

int pos =IndexOf(array, 444);
Console.WriteLine(pos);