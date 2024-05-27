using Entities;
using Microsoft.EntityFrameworkCore;
namespace Repository
{
    public class UserRepository:IUserRepository
    {
        _214346710DbContext userContext;
        public UserRepository(_214346710DbContext userContext)
        {
            this.userContext = userContext;
        }
        public async Task<User> Register(User user)
        {
            try
            {
                User u =await userContext.Users.FirstOrDefaultAsync(e => e.UserName.Equals(user.UserName));
                if (u != null)
                    return null;
                await userContext.Users.AddAsync(user);
                await userContext.SaveChangesAsync();
                return user;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<User> Update(int id, User user)
        {
            try
            {
                List<User> users = await userContext.Users.ToListAsync();
                User foundUser = await userContext.Users.FirstOrDefaultAsync(uu => uu.Id == id);
                foundUser.UserName = user.UserName;
                foundUser.FirstName = user.FirstName;
                foundUser.LastName = user.LastName;
                foundUser.Password = user.Password;
                foundUser.Email = user.Email;
                await userContext.SaveChangesAsync();
                return foundUser;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<User> Login(User user)
        {
            User userFound = await userContext.Users.FirstOrDefaultAsync(u => u.UserName.Equals(user.UserName.TrimEnd()));
            if (userFound != null)
            {
                if (userFound.Password.TrimEnd().Equals(user.Password))
                {
                    return userFound;
                }
            }
            return null;
        }
    }
}
