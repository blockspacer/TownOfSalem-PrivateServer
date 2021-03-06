﻿using System.Collections.Generic;
using System.IO;
using System.Text;
using TownOfSalem_Networking.Structs;

namespace TownOfSalem_Networking.Server
{
    public class FriendListMessage : BaseMessage
    {
        public List<Friend> Friends;

        public FriendListMessage(List<Friend> friends) : base(MessageType.FriendList)
        {
            Friends = friends;
        }

        protected override void SerializeData(BinaryWriter writer)
        {
            for (var i = 0; i < Friends.Count; i++)
            {
                var friend = Friends[i];

                writer.Write(Encoding.UTF8.GetBytes(friend.UserName));
                writer.Write(',');
                writer.Write(Encoding.UTF8.GetBytes(friend.AccountId.ToString()));
                writer.Write(',');
                writer.Write((byte)friend.Status);
                writer.Write(',');
                writer.Write((byte)(friend.OwnsCoven ? 2 : 1));

                if (i < Friends.Count - 1)
                {
                    writer.Write('*');
                }
            }
        }
    }
}
