using System.Text;

List<string> forbiddenWords = new List<string> {"die","hello"};

Console.WriteLine("Введите текст:");
string inputText = Console.ReadLine();

string censoredText = CensorText(inputText, forbiddenWords);

Console.WriteLine("\nОтредактированный текст:");
Console.WriteLine(censoredText);

Console.WriteLine("\nСтатистика:");
Console.WriteLine($"Заменено {GetReplacementCount(inputText, forbiddenWords)} недопустимых слов.");

Console.ReadLine();

static string CensorText(string text, List<string> forbiddenWords)
{
    StringBuilder censoredText = new StringBuilder(text);

    foreach (var word in forbiddenWords)
    {
        censoredText.Replace(word, new string('*', word.Length));
    }

    return censoredText.ToString();
}

static int GetReplacementCount(string text, List<string> forbiddenWords)
{
    int count = 0;

    foreach (var word in forbiddenWords)
    {
        count += text.Split(' ').Count(w => w.Equals(word, StringComparison.OrdinalIgnoreCase));
    }

    return count;
}