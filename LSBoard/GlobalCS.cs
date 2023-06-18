using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace LSBoard
{
    public class GlobalCS
    {
        public static bool CheckUser()
        {
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\')[1];            
            if (user == "ijung") return true;
            else return false;
        }
    }
}