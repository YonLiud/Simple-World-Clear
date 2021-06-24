using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.UI;
using static CitizenFX.Core.Native.API;

namespace Client
{
    public class Client : BaseScript
    {
        public Client()
        {
            EventHandlers["onClientResourceStart"] += new Action<string>(OnClientResourceStart);
            EventHandlers["onWorldClear"] += new Action(OnWorldClear);

        }
        private void OnClientResourceStart(string resourceName)
        {
            RegisterCommand("pclear", new Action<int, List<object>, string>((source, args, raw) =>
            {
                TriggerServerEvent("requestWorldClear");
            }), false);
        }
        public void OnWorldClear()
        {
            for(int i = 0; i < 10; i++)
            {
                Screen.ShowNotification("~r~ WORLD CLEAR!");
            }
            Prop[] allProps = World.GetAllProps();
            Pickup[] allPickups = World.GetAllPickups();
            foreach(Prop prop in allProps)
            {
                prop.Delete();
            }
            foreach(Pickup pickup in allPickups)
            {
                pickup.Delete();
            }
        }

    }
}
