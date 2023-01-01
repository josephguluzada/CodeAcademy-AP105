using System.Collections;

namespace CollectionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arrayList = new ArrayList();

            //arrayList.Add(5);
            //arrayList.Add("AB102");
            //arrayList.Add(true);
            //arrayList.Add(new Teacher { Fullname = "Rasul Rustemli", Age = 15 });

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.RemoveAt(3);
            //Console.WriteLine("After reverse");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region SortedList
            //SortedList sortedList = new SortedList();

            //sortedList.Add("a", "Murad");
            //sortedList.Add("b", 6);
            //sortedList.Add("c", "Eli");

            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Queue

            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //Console.WriteLine("First in First out");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Siradaki: ");
            //Console.WriteLine(queue.Peek());
            //queue.Dequeue();

            //Console.WriteLine("Siradaki: ");
            //Console.WriteLine(queue.Peek());

            //Console.WriteLine("========================================");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Stack

            // LIFO Last in First Out
            //Stack stack = new Stack();

            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(stack.Peek());

            //stack.Pop();
            //Console.WriteLine("=========================");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(stack.Peek());

            #endregion

            #region HashTable
            Hashtable hashtable = new Hashtable();

            hashtable.Add(1, "Akif");
            hashtable.Add(2, "Ali");
            hashtable.Add(3, "Arif");
            hashtable.Add(4, "Maarif");


            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key +" " + item.Value);
            }
            #endregion
        }
    }
}