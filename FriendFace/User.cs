using System;
using System.Collections.Generic;

namespace FriendFace
{
    public class User
    {
        public string username { get; private set; }
        public int age { get; private set; }
        public string gender { get; private set; }
        public List<string> friends { get; private set; }

        public User(string username, int age, string gender)
        {
            friends = new List<string>();
            this.username = username;
            this.age = age;
            this.gender = gender;
        }
        public void AddFriend(User requestedFriend)
        {
            try
            {
                this.friends.Add(requestedFriend.username);
                requestedFriend.AcceptFriendRequest(this);

                Console.WriteLine($"you are now friends with {requestedFriend.username}");
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine($"you are already friends with {requestedFriend.username}");
                Console.WriteLine();
            }
        }
        public void AcceptFriendRequest(User userSendingFriendRequest)
        {
            try
            {
                this.friends.Add(userSendingFriendRequest.username);
            }
            catch
            {
                Console.WriteLine($"{this.username} is already friends with you");
                Console.WriteLine();
            }
        }
        public void RemoveFriend(User friendToRemove)
        {
            friendToRemove.RemoveUserRequestingAsFriend(this);
            this.friends.Remove(friendToRemove.username);

            Console.WriteLine($"you are not friends with {friendToRemove.username}");
            Console.WriteLine();
        }
        public void RemoveUserRequestingAsFriend(User friendToRemove)
        {
            this.friends.Remove(friendToRemove.username);
        }
    }
}