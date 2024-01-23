class Program { 
    static void Main(string[] args) {
        var list = new List<int>(2);
        Console.WriteLine("First Version of list Count: " + list.Count());
        list.Add(1);
        list.Add(1);
        list.Add(1);

        Console.WriteLine("Second Version of List Count:" + list.Count());

    }

}