using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoSync.Classes
{
    class MediaCommand
    {
        string command = "";
        double timecode = 0;
        string actionTime = "";

        public MediaCommand(string s)
        {
            string[] parts = s.Split(':');
            actionTime = parts[2];
            command = parts[3];
            timecode = Double.Parse(parts[4]);

        }
        public MediaCommand(string s, double tick,string actionTime)
        {
            command = s;
            timecode = tick;

        }
        public override string ToString()
        {
            return "!:Player:" + actionTime+":"+ command + ":" + timecode;
        }
    }
}
