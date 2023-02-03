void PrintArray(int[] array)
{
    System.Console.Write($"[{String.Join(",", array)}]\n");
}

int[] GenerateArr(int n, int min, int max)
{
    int[] arrNum  = new int [n];

    Random rnd = new Random();
    
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) {}

    return arrNum; 
}

int SumPositiveElements(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0);
            result += array[i];
    }
    
    return result;
}

int SumNegativeElements(int[] array) {
    int result = 0;

    for (int i = 0; i < array.Length - 1; i++) {
        if (array[i] < 0);
            result += array[i];
    }
    return result;
}


int[] array = GenerateArr(12, -9, 9);
PrintArray(array);

int positiveSum = SumPositiveElements(array);
int negativeSum = SumPositiveElements(array);

Console.WriteLine($"Сумма положительных элементов в массивах: {positiveSum}");
Console.WriteLine($"Сумма отрицательных элементов в массивах:{negativeSum}");