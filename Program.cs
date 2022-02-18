int[] numbers = { 2, 5, 6, 7, 3, 1, 4, 9, 8, 10 };
Console.WriteLine("Unsorted: [{0}]", string.Join(", ", numbers));
Console.WriteLine("Sorted: [{0}]", string.Join(", ", bubbleSort(numbers)));

int[] bubbleSort(int[] numbers)
{
    int t = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                t = numbers[j + 1];
                numbers[j + 1] = numbers[j];
                numbers[j] = t;
            }
        }
    }
    return numbers;
}
