namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ak47 ak47 = new Ak47();

            ak47.MaximumCapacity = 30;
            ak47.BulletCount = 15;

            ak47.CountyName = "Russia";

            ak47.Reload();
            ak47.Fire();
            ak47.Shoot();

            Deagle deagle = new Deagle();

            deagle.MaximumCapacity = 7;
            deagle.BulletCount = 2;

            deagle.Reload();

            deagle.Shoot();

            Glock18 glock18 = new Glock18();

            glock18.Shoot();
            glock18.Fire();
        }
    }
}