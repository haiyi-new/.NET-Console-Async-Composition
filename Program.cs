namespace AsyncComposition;

class Program
{
    static async Task Main(string[] args)
    {
        var worker = new Worker();
        var data = await worker.CollectDataAsync(50);
        foreach (var item in data)
            Console.WriteLine(item);
    }
}
