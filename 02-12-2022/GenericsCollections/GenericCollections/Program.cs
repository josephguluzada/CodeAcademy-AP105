namespace GenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "Azer", "Habib"};
            List<string> list = new List<string>();
            Console.WriteLine(list.Capacity);

            list.Add("Yusif");
            list.Add("Rasul");
            list.Add("Jafar");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //list.Sort();
            Console.WriteLine(list.Count);
            //list.Clear();
            //Console.WriteLine(list.Count);
            //list.Remove("Yusif");
            //list.RemoveAt(1);
            list.AddRange(strings);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}