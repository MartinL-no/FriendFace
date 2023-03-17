using System;
using System.Collections.Generic;
using System.Linq;

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
            if (this.friends.Contains(requestedFriend.username))
            {
                Console.WriteLine($"you are already friends with {requestedFriend.username}");
                Console.WriteLine();
            }
            else
            {
                this.friends.Add(requestedFriend.username);
                requestedFriend.AcceptFriendRequest(this);

                Console.WriteLine($"you are now friends with {requestedFriend.username}");
                Console.WriteLine();
            }
        }
        public void AcceptFriendRequest(User userSendingFriendRequest)
        {
            if (this.friends.Contains(userSendingFriendRequest.username))
            {
                Console.WriteLine($"{this.username} is already friends with you");
                Console.WriteLine();
            }
            else
            {
                this.friends.Add(userSendingFriendRequest.username);
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