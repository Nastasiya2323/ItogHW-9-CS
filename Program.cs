﻿

string[] array1 = new string[8] {"98754", "11", "super", "kross", "peas", "F2q", "17fa55", "5"};
string[] array2 = new string[array1.Length];

void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}