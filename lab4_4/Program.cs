using System;

namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string userkey;
            string username;
            int userage;

            System.Console.Write("Enter your name: ");
            username = Convert.ToString(Console.ReadLine());
            System.Console.Write("Enter your age: ");
            userage = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Enter key: ");
            userkey = Convert.ToString(Console.ReadLine());

            Applicense al = new Applicense(username, userage);
            switch (userkey){
                case "pro":
                al.AllowPro();
                ProLicense user = new ProLicense(username, userage);
                user.can_i_smoke();
                break;
                case "free":
                al.AllowCommon();
                FreeLicense free = new FreeLicense(username, userage);
                free.can_i_smoke();
                break;
                case "trial":
                al.AllowTrial();
                Trial trial = new Trial(username, userage);
                trial.can_i_smoke();
                break;
                default:
                System.Console.WriteLine("Something went wrong...");
                Console.ReadKey();
                Environment.Exit(0);
                break;
                
            }
            

        }
    }
}
