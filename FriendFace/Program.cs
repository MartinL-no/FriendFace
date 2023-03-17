using System;
using System.Collections.Generic;

namespace FriendFace
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Users();

            users.Add(new User("terje", 40, "male"));
            users.Add(new User("bjorn", 23, "male"));
            users.Add(new User("thea", 26, "female"));

            var loggedInUser = users.GetUser("terje");

            Console.WriteLine($"Welcome to FriendFace {loggedInUser.username}\n");

            while (true)
            {
                MyConsole.PrintChoices();

                var choice = MyConsole.AskForInput("Enter the option you would like to select: ");

                if (choice.Equals("1"))
                {
                    var username = MyConsole.AskForInput("Enter the username of the person you would like to add as a friend: ");
                    var selectedUser = users.GetUser(username);

                    if (selectedUser != null)
                    {
                        loggedInUser.AddFriend(selectedUser);

                    }
                }
                else if (choice.Equals("2"))
                {
                    var username = MyConsole.AskForInput("Enter the username of the person you would like to remove as a friend: ");
                    var selectedUser = users.GetUser(username);

                    if (selectedUser != null)
                    {
                        loggedInUser.RemoveFriend(selectedUser);

                    }
                }
                else if (choice.Equals("3"))
                {
                    MyConsole.PrintUsersFriends(loggedInUser.friends);
                }
                else if (choice.Equals("4"))
                {
                    var username = MyConsole.AskForInput("Enter the username of the friend whose profile you would like to see: ");

                    var selectedUser = users.GetUser(username);

                    if (selectedUser != null && loggedInUser.friends.Contains(username))
                    {
                        MyConsole.PrintUsersProfileInformation(selectedUser);
                    }
                    else
                    {
                        Console.WriteLine($"You are not friends with someone with the username {username}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}