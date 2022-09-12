using Project0.Models;

namespace Project0
{
    internal class Users : User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Username { get; internal set; }
    }
}