namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Animal lion = new Lion();
            Animal eagle = new Eagle();
            Animal[] animals = { animal, lion, eagle };

            foreach (Animal anm in animals)
            {
                if(anm is Lion)
                {
                    Lion lion1 = (Lion)anm; // anm as Lion
                    lion1.Destroy();
                }
                if(anm is Eagle)
                {
                    Eagle eagle1 = (Eagle)anm;
                    eagle1.Fly();
                }
            }

            //Lion lion1 = (Lion)lion;
            //lion1.Destroy();

            //Eagle eagle1 = (Eagle)eagle;
            //eagle1.Fly();

            //Lion lion2 = (Lion)eagle;
            //Lion lion2 = lion as Lion;


            //if(lion2 == null)
            //{
            //    Console.WriteLine("Cevire bilmedim");
            //}
            //else
            //{
            //    Console.WriteLine("Cevirdim");
            //}



        }
    }

    class Animal
    {
        public string Name { get; set; }
    }

    class Lion : Animal
    {
        public void Destroy()
        {
            Console.WriteLine("Lion destroys");
        }
    }

    class Eagle : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Eagle Flying");
        }
    }
}