namespace DISample 
{
    public class Business: IBusiness 
    {
        private readonly IDataAccess _dataAccess;
        public Business(IDataAccess dataAccess)
        {
            _dataAccess = new DataAccess();
        }
        public void Signup(string Username, string Password)
        {
            _dataAccess.Store(Username, Password);
        }
    }

    public interface IBusiness 
    {
        public void Signup(string Username, string Password);
    }
}