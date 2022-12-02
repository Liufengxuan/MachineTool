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

        private string _Command3;
        [Description("命令3")]
        public string Command3
        {
            get { return _Command3; }
            set { _Command3 = value; }
        }

        private string _Command4;
        [Description("命令4")]
        public string Command4
        {
            get { return _Command4; }
            set { _Command4 = value; }
        }

        private string _Command5;
        [Description("命令5")]
        public string Command5
        {
            get { return _Command5; }
            set { _Command5 = value; }
        }


        private string _Command6;
        [Description("命令5")]
        public string Command6
        {
            get { return _Command6; }
            set { _Command6 = value; }
        }
    }
}
