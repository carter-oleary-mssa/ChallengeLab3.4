using System.ComponentModel.DataAnnotations;

string[] arr = { "ABFCACDB", "ACBBD" };

foreach (string str in arr)
{
    Console.WriteLine(MinLength(str));
}

int MinLength(string s)
{
    for (int i = 0; i < s.Length - 1; i++)
    {
        if (s[i] == 'A' && s[i+1] == 'B')
        {
            return MinLength(s.Replace("AB", ""));
        }
        if (s[i] == 'C' && s[i + 1] == 'D')
        {
            return MinLength(s.Replace("CD", ""));
        }
    }
    return s.Length;
}