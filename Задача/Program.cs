string[] ArrayOne = new string[5] {"Hi","World","pass","computer","456"};
string[] ArrayTwo = new string[ArrayOne.Length];


void Sort(string[] ArrayOne, string[] ArrayTwo)
{
    int count = 0;
    for( int i = 0; i< ArrayOne.Length; i++)
    {
        if(ArrayOne[i].Length <= 3)
        {
            ArrayTwo[count] = ArrayOne[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for(int i = 0; i< array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

Sort(ArrayOne, ArrayTwo);
PrintArray(ArrayTwo);