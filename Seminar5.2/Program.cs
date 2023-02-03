int checkNum = getVar();
Sit [] chekerNumsArr = generateArr (10, 0, 5);
int count = checkArr (checkNum, chekerNumsArr);

System.Console.writeLine($"Число {checkNum} в массиве {arroStr(chekerNumsArr)} встречается {count} paз");


int getvar(){
    int varvalue = 0;
    bool isNumeric = false;

    while (!isNumeric) {
        Console.Write($"Введите проверяемое число от 0 до 5: ");
        isNumeric = int. TryParse(Console. ReadLine(), out varValue);
        varValue = Math.Abs (varValue);
        
        if (varvalue < 0) {
            isNumeric = false;
        }
    }        
    return varValue;
}

int checkArr(int checkNum, int[] checkNumsArr) {
    int count = 0;
    foreach (var item in chekerNumsArr) {
        if (item == checkNum) {
            ++count;
        }
    }

    return count;
}

int[] generateArr(int n, int min, int max) {
    int[] arrNum = new int [n];

    Random rnd = new Random();
    for (int i = 0; i < arrNum.Length; arrNum[i++] = rnd.Next(min, max + 1)) { }

    return arrNum;
}

string arroStr(int[] nums){
    return $"[{String.Join(",", nums)}]";
}