namespace MyApp.Services
{
    public interface IUserRepository
    {
        User GetUserById(int id);
    }


    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class UserService
    {
        private readonly IUserRepository _repository;


        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }


        public string GetUserName(int id)
        {
            var user = _repository.GetUserById(id);
            return user?.Name ?? "Unknown User";
        }
    }
}
