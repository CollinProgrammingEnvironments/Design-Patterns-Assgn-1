using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_and_Factory_Method
{
    public delegate void TwinsStateChangedEventhandler(object sender, EventArgs e);
    
    public class Twins
    {
        public string Song = "Thank God For The Sinners";
        public string Volume = "50";
        public string RPM = "33 1/3";
       
       
    }
}
