using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Diagnostics;
using GoldBunny.wind1s;

namespace GoldBunny.basedata
{
    public class Config
    {
        public string patchAppExe =
            System.IO.Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        public struct configMainApp
        {
            public bool ch_1;
            public bool ch_2;
            public bool ch_3;
            public bool ch_4;
            public bool ch_2_1;
            public bool ch_2_2;
            public bool ch_2_3;
            public bool ch_2_4;
            public bool ch_2_5;
            public bool ch_2_6;
            public bool ch_2_7; 
            public bool ch_2_8;
            public bool ch_2_9;
        }
        public configMainApp savDat = new configMainApp();
        
        
    }
}
