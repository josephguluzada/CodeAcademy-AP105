namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            //Human human = new Teacher();

            Lion lion = new Lion();
            Tiger tiger = new Tiger();
            tiger.HungryLevel = "Hungry";
            Cat cat = new Lion();
            Cat cat2 = new Tiger();
            Cat[] cats = { lion, tiger };

            //IWildAnimal wildAnimal1 = new Tiger();
            IWildAnimal wildAnimal2 = new Lion();

            IWildAnimal lion3 = new Lion();

            //IWildAnimal[] wildAnimals = { wildAnimal1, wildAnimal2 };
            //foreach (Cat item in wildAnimals)
            //{
            //    item.MakeSound();
            //}

            //X x = new Y();
            //x.MethodX();
            //Y y = new Y();
            //y.MethodX();
            //y.MethodY();


            //X z = new Z();

            //z.MethodX();
            //z.MethodY();
            //z.MethodZ();


        }
    }

    class X
    {
        public void MethodX()
        {
            Console.WriteLine("X");
        }
    }
    class Y : X
    {
        public void MethodY()
        {
            Console.WriteLine("Y");
        }
    }
    class Z : Y
    {
        public void MethodZ()
        {
            Console.WriteLine("Z");
        }
    }
}