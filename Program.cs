using System.Text.RegularExpressions;

string[] a = new string[] { "не 1", "не 2", "это 3", "а это 4", "это не 5"};

for(int i= 0; i<a.Length; i++)
    if (Regex.IsMatch(a[i].ToLower(), "не"))
    {
        Console.WriteLine(a[i]);
    }
    else
    {}
