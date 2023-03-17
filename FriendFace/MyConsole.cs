using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class MyConsole
    {
        public static void PrintChoices()
        {
            Console.WriteLine(
                "Choose one of the following options (any other input exits the program):\n\n" +
                "Add friend: 1\n" +
                "Remove friend: 2\n" +
                "List all friends: 3\n" +
                "Show a friend's profile information: 4\n"
            );
        }
        public static string AskForInput(string prompt)
        {
            Console.Write(prompt);

            var userInput = Console.ReadLine();

            return userInput;
        }
        public static void PrintUsersFriends(List<string> friendsList)
        {
            Console.WriteLine();
            Console.WriteLine("You are friends with:");

            foreach (var friend in friendsList)
            {
                Console.WriteLine(friend);
            }
            Console.WriteLine();
        }
        public static void PrintUsersProfileInformation(User user)
        {
            Console.WriteLine();
            Console.WriteLine($"{user.username}'s profile details are:");

            Console.WriteLine($"Name: {user.username}");
            Console.WriteLine($"Age: {user.age}");
            Console.WriteLine($"Gender: {user.gender}");
            Console.WriteLine($"Friends: {user.friends.Count}");
            Console.WriteLine();
        }
    }
}