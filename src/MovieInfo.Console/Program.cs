using MovieInfo.Data.Interfaces;
using MovieInfo.Data.Repositories;
using MovieInto.Domain.Configurations;
using MovieInto.Domain.Entities;

IUserRepository userRepository = new UserRepository();
//IEnumerable<User> users = await userRepository.ReadAllAsync(new PaginationParams { PageIndex = 1, PageSize = 10 });

//foreach (var user in users)
//{
//    Console.WriteLine($"{user.Id} {user.FirstName} {user.LastName} {user.BirthDate}");
//}

User user = new User()
{
    FirstName = "Oybarchin",
    LastName = "Bakirova",
    Gender = false,
    BirthDate = DateOnly.Parse("1996/01/01"),
    Email = "qwerqwe@gmail.com",
    PhoneNumber = "+998998844554",
    Login = "Oybarchin_77",
    Password = "Bakirova",
};
bool result = await userRepository.UpdateAsync(5, user);
if (result is true)
{
    Console.WriteLine(true);
}
