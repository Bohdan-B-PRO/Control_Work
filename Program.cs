
string[] ChangeArrray(string[] array)
{
    string[] str = new string[array.Length];
    for(int i = 0; i < str.Length; i++)
    {
        if(array[i].Length <= 3)
          str[i] = array[i];  
    }
    return str;
}

void ShowArray(string [] array)
{
    for(int i = 0; i < array.Length; i++)
    Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] array = {"Hello", "2", "world", ":-)"};
string[] str = ChangeArrray(array);
ShowArray(array);
ShowArray(str);
