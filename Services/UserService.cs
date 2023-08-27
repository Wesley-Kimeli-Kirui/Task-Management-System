using System.Linq;
using TaskManagementApp.Data;
using TaskManagementApp.Models;

namespace TaskManagementApp.Services {
    public class UserService {
        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context){
            _context = context;
        }

        public User GetUserByUsername(string username) {
            return _context.Users.FirstOrDefault(u => u.Username == username);
        }

        public void CreateUser (UserService user) {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void EditUser (UserService user) {
           var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
           if (existingUser != null){
            existingUser.Username = user.Username;
            existingUser.Password = user.Password;
            _context.SaveChanges();
           }
        }
        public void DeleteUser (UserService user) {
            var userToremove = _context.Users.FirstOrDefault(u => u.Id == userId);
            if(userToRemove != null){
                _context.Users.Remove(userToRemove);
                _context.SaveChanges();
            }
        }
        
    }
}