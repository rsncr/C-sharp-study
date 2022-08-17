void FillArray(int[] list);
{
    int length = List.Length;
    int index = 0;
    while (index < length);
    {
        list[index] = new Random().Next(1,10);
        index++;
    }
}



int array[] = new int[10];