

using ManyToOneRelation;

User u = new User() {UserID = 1, UserName= "user1" , UserEmail="user1@gmail.com", UserPhone="113322443" };
User u1 = new User() { UserID = 2, UserName = "user2", UserEmail = "user2@gmail.com", UserPhone = "113322443" };
User u2 = new User() { UserID = 3, UserName = "user3", UserEmail = "user3@gmail.com", UserPhone = "113322443" };
User u3 = new User() { UserID = 4, UserName = "user4", UserEmail = "user4@gmail.com", UserPhone = "113322443" };

Cart c = new Cart() { CartName = "My cart"};
u.cart = c;
u1.cart= c; u2.cart= c;u3.cart= c;
Console.WriteLine(u.UserID + " " + u.UserName + " " + u.UserEmail + " " + u.UserPhone +" " + u.cart.CartName);
Console.WriteLine(u1.UserID + " " + u1.UserName + " " + u1.UserEmail + " " + u1.UserPhone + " " + u1.cart.CartName);
Console.WriteLine(u2.UserID + " " + u2.UserName + " " + u2.UserEmail + " " + u2.UserPhone + " " + u2.cart.CartName);
Console.WriteLine(u3.UserID + " " + u3.UserName + " " + u3.UserEmail + " " + u3.UserPhone +" " + u3.cart.CartName);