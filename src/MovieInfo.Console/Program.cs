using MovieInfo.Data.Interfaces;
using MovieInfo.Data.Repositories;
using MovieInto.Domain.Configurations;
using MovieInto.Domain.Entities;

internal class Program
{
    public static async Task Main(string[] args)
    {
        IUserRepository userRepository = new UserRepository();
        User user = new User()
        {
            FirstName = "MuhammadAli",
            LastName = "Maxamadzoidov",
            Gender = true,
            BirthDate = DateOnly.Parse("2004/01/19"),
            Email = "MuhammadAli@gmail.com",
            Login = "muhammadAli007",
            Password = "MuhammadAli",
            PhoneNumber = "+998909427881"
        };
        await userRepository.UpdateAsync(6, user);
    }
}