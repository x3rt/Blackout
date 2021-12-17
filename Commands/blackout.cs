using System;
using System.Linq;
using CommandSystem;
using Exiled.API.Enums;
using Exiled.API.Features;

namespace Blackout.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class Timer : ICommand
    {
        public string Command => "blackout";

        public string[] Aliases { get; } = {"079b"};

        public string Description => "Blackout the whole facility.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player ply = Player.Get((CommandSender) sender);
            
            if (ply.Role != RoleType.Scp079)
            {
                response = "You are not SCP-079!";
                return false;
            }
            if (Plugin.SharedConfig.MinimumTier > ply.Level + 1) 
            {
                response = "You are not a high enough Tier!";
                return false;
            }
            if (Plugin.SharedConfig.AuxillaryDrain > ply.Energy)
            {
                response = $"You do not have enough power! {Plugin.SharedConfig.AuxillaryDrain} required.";
                return false;
            }
            ply.Energy -= Plugin.SharedConfig.AuxillaryDrain;
            
            if (Plugin.SharedConfig.CassieAnnouncement != string.Empty)
                Cassie.Message(Plugin.SharedConfig.CassieAnnouncement, false, !Plugin.SharedConfig.CassieSilent);

            foreach (Room room in Map.Rooms)
            {
                if (room.Zone == ZoneType.Surface && !Plugin.SharedConfig.BlackoutSurface)
                    continue;
                if (Plugin.SharedConfig.LockDoors)
                    room.Blackout(Plugin.SharedConfig.BlackoutDuration, DoorLockType.Lockdown079);
                else 
                    room.TurnOffLights(Plugin.SharedConfig.BlackoutDuration);

            }
            response = "Blackout initiated!";
            return true;
        }
    }
}