string[] a = {"2", "hello", "wfd", "(+_+)", "(:':", "6785", ":)"};

string[] d = new string[a.Length];

for (int i = 0; i < a.Length; i++)
{
  if (a[i].Length <= "000".Length)
{
    d[i] = a[i];
}
}

for (int j = 0; j < d.Length; j++)
{
    Console.Write(d[j] + "  ");
}