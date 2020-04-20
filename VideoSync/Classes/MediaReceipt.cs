using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSync.Classes
{
    class MediaReceipt
    {
        public string recipient = "";
        public string tickcode = "";

        public MediaReceipt(string s)
        {
            string[] parts = s.Split(':');
            recipient = parts[2];
            tickcode = parts[3];

        }
        public MediaReceipt(string s, string tick)
        {
            recipient = s;
            tickcode = tick;
        }
        public override string ToString()
        {
            return "!:PlayerReceipt:" + recipient + ":" + tickcode;
        }
    }
}
