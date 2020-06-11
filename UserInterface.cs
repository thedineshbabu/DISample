using System;
namespace DISample 
{
    public class UserInterface : IUserInterface 
    {
        private readonly IBusiness _business;
        public UserInterface(IBusiness business)
        {
            _business = business;
        }
        public void GetData() 
        {
            Console.WriteLine("Enter the UserName:");
            var UserName = Console.ReadLine();
            Console.WriteLine("Enter the PassWord:");
            var PassWord = Console.ReadLine();

            _business.Signup(UserName, PassWord);
        }
    }

    public interface IUserInterface 
    {
        public void GetData();
    }
}