Console.WriteLine("Input string:");
Console.Write(">> ");
string user_string = Console.ReadLine();

string Encrypt(string text, int key)
{
    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    var full_alfabet = alfabet + alfabet.ToLower();

    string result = "";

    foreach (var letter in text)
    {
        if (letter == ' ') result += ' ';
        else result += full_alfabet[(full_alfabet.IndexOf(letter) + key) % full_alfabet.Length];
    }
    return result;
}

string Decrypt(string text, int key)
{
    const string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    var full_alfabet = alfabet + alfabet.ToLower();

    string result = "";

    foreach (var letter in text)
    {
        if (letter == ' ') result += ' ';
        else result += full_alfabet[(full_alfabet.IndexOf(letter) - key) % full_alfabet.Length];
    }
    return result;
}

Console.WriteLine(Encrypt(user_string, 3));
Console.WriteLine(Decrypt(Encrypt(user_string, 3), 3));




