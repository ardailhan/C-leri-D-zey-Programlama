#region Action
Action action1 = () => Console.WriteLine("Action");
Action<bool> action2 = (b) => Console.WriteLine("Action<T>");
Action<bool, int, int> action3 = (b, i1, i2) => Console.WriteLine("Action<T>");
#endregion
#region Func
Func<int> func = () => 3;
//Son parametre geri dönüş tipini belirler.
Func<int, char, bool> func2 = (i, c) => true;
//Geriye (int, char) -tuple dönen ve parametre olarak byte,int, string alan Func delegate'i
Func<byte, int, string, (int, char)> func3 = (b, i, s) => (3, 'a');
#endregion
#region Predicate
Predicate<bool> predicate1 = b => b;
Predicate<int> predicate2 = i => i < 10;
#endregion

#region Lambda Discard Parameters
Func<int, int, string, char> func4 = (_, _, s) => 'a';
#endregion