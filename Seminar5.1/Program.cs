int [] GenerateArr(int n, int min, int max)
{
    int[] arrNum = new int[n];

    Random rnd = new Random();

    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
} 

int[] ReverseSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i ++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

void PrintArray(int[] array1)
{
    System.Console.Write($"[{String.Join(",", array1)}]\n");
}

int[] array = GenerateArr(4, -9, 9);
PrintArray(array);
int[] reversedArray = ReverseSign(array);
PrintArray(reversedArray);