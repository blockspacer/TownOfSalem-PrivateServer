﻿namespace TownOfSalem_Networking.Server
{
    public class SuccessfulAccountCreationMessage : BaseMessage
    {
        public SuccessfulAccountCreationMessage() : base(MessageType.SuccessfulAccountCreation)
        {
        }
    }
}
