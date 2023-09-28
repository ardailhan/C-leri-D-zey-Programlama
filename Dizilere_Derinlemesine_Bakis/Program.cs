int[] d1 = (int[])Array.CreateInstance(typeof(int), 2);
int[,,] d2 = (int[,,])Array.CreateInstance(typeof(int), 2, 3, 4);

(string s, int i, bool b)[] d3 = new (string s, int i, bool b)[] {("asdasd", 123, true), ("asdasd213", 123, true), ("asda", 123, false) };

Console.WriteLine();