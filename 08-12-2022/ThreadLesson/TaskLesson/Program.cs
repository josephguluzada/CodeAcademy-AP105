namespace TaskLesson
{
    internal class Program
    {
        static  async Task Main(string[] args)
        {
            //var task = Task.Run(() =>
            //{
            //    Console.WriteLine("Salam, AB102");
            //});


            var data = await GetStringDataAsync();
            Console.WriteLine(data);
            Console.WriteLine("Salamlar her kese");
            Console.WriteLine("Sagolun");
            Console.WriteLine("Millet");
            
            Console.WriteLine("Finished");
            //var data = GetStringData();
            //Console.WriteLine(data);

            //while (!data.IsCompleted)
            //{
            //    Console.WriteLine("Waiting...");
            //}
            //Console.WriteLine("Finished");
        }

        static async Task<string> GetStringDataAsync()
        {
            HttpClient client = new HttpClient();
            return await client.GetStringAsync("https://github.com");
        }

        static string GetStringData()
        {
            HttpClient client = new HttpClient();
            string data = client.GetStringAsync("https://google.com").Result;
            return data;
        }
    }
}