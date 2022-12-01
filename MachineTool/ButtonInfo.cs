using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MachineTool
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class ButtonInfo
    {
        private string _ID;
        [Description("控件id")]
        public string ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _Command1;
        [Description("命令1")]
        public string Command1
        {
            get { return _Command1; }
            set { _Command1 = value; }
        }

        private string _Command2;
        [Description("命令2")]
        public string Command2
        {
            get { return _Command2; }
            set { _Command2 = value; }
        }


        
    
    }
}
