HashSet<string> set = new();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));

foreach (string p in set)
{
    Console.WriteLine(p);
}

SortedSet<int> a = new() { 6, 2, 3, 5, 1 };
SortedSet<int> b = new() { 7, 2, 3, 4, 6 };

//union
SortedSet<int> ab = new(a);
ab.UnionWith(b);
PrintCollection(ab);

//intersection
SortedSet<int> d = new(a);
d.IntersectWith(b);
PrintCollection(d);

//difference
SortedSet<int> e = new(a);
e.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}