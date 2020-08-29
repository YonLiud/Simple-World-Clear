using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Server
{
    public class Server : BaseScript
    {
        
        public Server()
        {
            EventHandlers["requestWorldClear"] += new Action(WorldClear);
        }
        public void WorldClear()
        {
            TriggerClientEvent("onWorldClear");
        }
    }
}
