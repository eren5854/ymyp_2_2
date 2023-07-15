using System.Reflection.Metadata;

namespace ymyp_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            string name = "Eren";
            string name2 = name;
            name2 = "İhsan";
            Console.WriteLine(name);
            Console.WriteLine(name2);
            User user = new();
            User user2 = user;
            user2.Name = "Emirhan";
            Console.WriteLine(user.Name);
        }
    }
}
class User
{
    public string Name = "Delibas";
}