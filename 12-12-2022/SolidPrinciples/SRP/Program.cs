namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string username = "eli123";
            string password = "Salam123";

            UserChecker checker = new UserChecker();
            User user = new User();

            if (checker.CheckUsername(username))
            {
                user.Username = username;
            }

            if (checker.CheckPassword(password))
            {
                user.Password = password;
            }

            UserCRUD userCRUD = new UserCRUD();

            userCRUD.Create(user);
            userCRUD.Create(new User
            {
                Username = "Reshad02",
                Password = "Reshad123"
            });


            foreach (User item in userCRUD.GetAllUsers())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }

            Console.WriteLine("=============================================");
            userCRUD.Delete(user);

            foreach (User item in userCRUD.GetAllUsers())
            {
                Console.WriteLine(item.Username + " " + item.Password);
            }



        }
    }
}