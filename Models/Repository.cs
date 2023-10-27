namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new();

        static Repository()
        {
            _users.Add(new UserInfo() { Id =1,Name = "Ali", Email="abc@gmail.com", Phone = "11141", WillAttend=false});
            _users.Add(new UserInfo() { Id=2,Name = "Deniz", Email="abcd@gmail.com", Phone = "134111", WillAttend=true});
            _users.Add(new UserInfo() { Id = 3,Name = "Emine", Email="abce@gmail.com", Phone = "11781", WillAttend=true});
            
        }
        public static List<UserInfo> Users 
        {
            get
            {
                return _users;
            }
        }
        public static void CreateUser(UserInfo user) 
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }

        public static UserInfo? GetById(int id)
        {
            //her userin idsine bakar eğer metoda gönderilen id ile eşleşiyosa bulduğu ilk kaydı doğrudan geriye gönderir, bulamazsa da null
            return _users.FirstOrDefault(user => user.Id == id );
        }
    }
}