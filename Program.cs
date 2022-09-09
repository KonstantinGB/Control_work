string[] LessThanThreeCharacters ( string[] array)
{
    int count = 0;
    for( int i =0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3) count ++; 
    }

    string [] newArray = new string[count];

    for(int i = 0, k = 0; i < array.Length; i ++)
    {
        if( array[i].Length <= 3)
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;

}

void ShowArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] array = {"1234", "1567", "-2", "computer science"};

string[] newArray = LessThanThreeCharacters(array);
ShowArray(newArray);
