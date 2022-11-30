using Tools;

namespace ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the username: ");
            string usrname = Console.ReadLine();

            string password;

            do
            {
                Console.WriteLine("Enter the password: ");
                password = Console.ReadLine();

            } while (!Helpers.CheckPassword(password));
            //                 !false -> true


            User user = new User(usrname, password);
            Console.WriteLine($"Id: {user.Id} Username: {user.UserName} Password: {user.Password}");
        }
    }
}