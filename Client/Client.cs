using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using static CitizenFX.Core.Native.API;

namespace Client
{
    public class Client : BaseScript
    {
        public Client()
        {
            EventHandlers["onClientResourceStart"] += new Action<string>(OnClientResourceStart);
        }
        private void OnClientResourceStart(string resourceName)
        {

        }
    }
}
