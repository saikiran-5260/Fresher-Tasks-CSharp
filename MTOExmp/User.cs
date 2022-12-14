
namespace ManyToOneRelation
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }

        public Cart cart { get; set; }

    }
}
