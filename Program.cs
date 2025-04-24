using System.ComponentModel.DataAnnotations;

string[] arr = { "ABFCACDB", "ACBBD" };

foreach (string str in arr)
{
    Console.WriteLine($"The min length of {str} is {MinLengthRec(str)} recursively");
    Console.WriteLine($"The min length of {str} is {MinLengthIter(str)} iteratively");
}

int MinLengthRec(string s)
{
    for (int i = 0; i < s.Length - 1; i++)
    {
        if (s[i] == 'A' && s[i + 1] == 'B')
        {
            return MinLengthRec(s.Replace("AB", ""));
        }
        if (s[i] == 'C' && s[i + 1] == 'D')
        {
            return MinLengthRec(s.Replace("CD", ""));
        }
    }
    return s.Length;
}

int MinLengthIter(string s)
{
    while(s.Contains("AB") || s.Contains("CD"))
    {
        s = s.Replace("AB", "");
        s = s.Replace("CD", "");
    }
    return s.Length;
}