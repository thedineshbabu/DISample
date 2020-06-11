namespace DISample 
{
    public class DataAccess : IDataAccess
    {
        public void Store(string UserName, string Password)
        {
            //logic to store inside DB
        }
    }

    public interface IDataAccess
    {
        public void Store(string UserName, string Password);
    }
}