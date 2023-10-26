string s = "Привет";
Console.WriteLine(s[5]);
Console.WriteLine(s[s.Length - 1]);
Console.WriteLine();

for (int k=0; k < s.Length; k++)
{
    Console.WriteLine(s[k]);
}
Console.WriteLine();

foreach (char item in s)
{
    Console.WriteLine(item);
}