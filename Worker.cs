namespace AsyncComposition
{
    public class Worker
    {
        // public IEnumerable<int> CollectData(int numberPoints)
        // {
        //     var data = new List<int>();
        //     int pointsRead = 0;
        //     while (pointsRead < numberPoints)
        //     {
        //         var buffer = ReadPage();
        //         for (int i = 0; i <  10; i++)
        //         data.Add(buffer[i]);
        //         pointsRead += 10;
        //     }
        //     return data;
        // }
        public async Task<IEnumerable<int>> CollectDataAsync(int numberPoints)
        {
            var data = new List<int>();
            int pointsRead = 0;
            while (pointsRead < numberPoints)
            {
                var buffer = await ReadPageAsync();
                for (int i = 0; i < 10; i++)
                data.Add(buffer[i]);
                pointsRead += 10;
            }

            return data;
        }
        private async Task<int[]> ReadPageAsync()
        {
            // Your code to asynchronously read a page and return the buffer goes here
            // Replace this with your actual implementation
            await Task.Delay(100); // Simulating an asynchronous operation
            return new int[10];
        }
    }
}