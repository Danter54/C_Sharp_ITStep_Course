using System.IO.IsolatedStorage;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Input string:");
Console.Write(">> ");
string user_string = Console.ReadLine();

string FirstLetterToUpper(string str)
{
    string[] punctuators = { "?", "!", ",", "-", ":", ";", "." };
    for (int i = 0; i < 7; i++)
    {
        int pos = str.IndexOf(punctuators[i]);
        while (pos != -1)
        {
            str = str.Insert(pos + 2, char.ToUpper(str[pos + 2]).ToString());
            str = str.Remove(pos + 3, 1);
            pos = str.IndexOf(punctuators[i], pos + 1);
        }
    }
    return str;
}

Console.WriteLine(FirstLetterToUpper(user_string));