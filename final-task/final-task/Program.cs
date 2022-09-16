int itemMaxLength = 3;
string[] inputArray = {"Hello", "2", "world", ":-)"};
string[] filteredArray = FilterArray(inputArray, itemMaxLength);

Console.WriteLine($"{StringifyArray(inputArray)} -> {StringifyArray(filteredArray)}");

string[] FilterArray(string[] array, int itemMaxLength)
{
    var filteredArraySize = GetFilteredArraySize(array, itemMaxLength);

    string[] filteredArray = new string[filteredArraySize];
    
    int filteredArrayIndex = 0;
    foreach (string item in array)
    {
        if (item.Length <= itemMaxLength)
        {
            filteredArray[filteredArrayIndex] = item;
            filteredArrayIndex += 1;
        }
    }

    for (int i = 0; i < array.Length; i++)
    {
        i++;
    }

    return filteredArray;
}

int GetFilteredArraySize(string[] strings, int itemMaxLength)
{
    int filteredArraySize = 0;
    foreach (string item in strings)
    {
        if (item.Length <= itemMaxLength)
        {
            filteredArraySize += 1;
        }
    }

    return filteredArraySize;
}

string StringifyArray(string[] array)
{
    return $"[{string.Join(", ", array)}]";
}