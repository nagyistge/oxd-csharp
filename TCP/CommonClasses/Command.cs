﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCP.Classes
{
    class Command 
    {
        [JsonProperty("command")]
        private dynamic commandType;
        [JsonProperty("params")]
        private dynamic param;
        public Command(dynamic p_command)
        {
            this.commandType = p_command;
        }

        public void setParamsObject(dynamic parm)
        {
            this.param = parm;
            //RegisterSiteParams tes = new RegisterSiteParams();
        }
    }
}