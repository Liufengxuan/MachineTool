
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MachineTool
{

    [ToolboxItem(false)]
    public partial class BaseControl : UserControl
    {
        public BaseControl()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MouseEnter += Base_MouseEnter;
            this.MouseLeave += Base_MouseLeave;
            this.MouseDown += Base_MouseDown;
            this.MouseUp += Base_MouseUp;
           
        }
        #region MyRegion
        private string _drillNumber = "00";
        private Color _EnterColor = Color.Peru;
        private Color _PressColor = Color.Gold;
        private Color _ActColor = Color.Lime;
        private static Color _ThemeColor = Color.Black;
        private Color _MainColor = Color.Black;
        private bool _UseThemeColor = true;
        private bool _IsActivate = false;
        private bool _AntiAliasing = true;
        private ButtonInfo _Info ;
       [Description("开启抗锯齿"), Category("MTCommon"), Browsable(true)]
        public bool AntiAliasing
        {
            get { return _AntiAliasing; }
            set { _AntiAliasing = value; Invalidate(); }
        }
        [Description("激活状态"), Category("MTCommon"), Browsable(true)]
        public bool IsActivate
        {
            get { return _IsActivate; }
            set { _IsActivate = value; Invalidate(); }
        }

        [Description("是否使用全局主题颜色"), Category("MTCommon"), Browsable(true)]
        public bool UseThemeColor
        {
            get
            {
                return _UseThemeColor;
            }
            set { _UseThemeColor = value; Invalidate(); }
        }
        [Description("主题颜色"), Category("MTCommon"), Browsable(true)]
        public  Color ThemeColor
        {
            get { 
                
                return _ThemeColor; 
            
            }
            set {
                    _ThemeColor = value;
                Invalidate();
            }
        }
        [Description("控件脱离主题颜色时的颜色"), Category("MTCommon"), Browsable(true)]
        public Color MainColor
        {
            get { return _MainColor; }
            set { _MainColor = value; Invalidate(); }
        }

        [Description("钻头编号"), Category("MTCommon"), Browsable(true), DefaultValue("00")]
        public string DrillNumber
        {
            get { return _drillNumber; }
            set { _drillNumber = value; }
        }
        [Description("鼠标按下时的颜色"), Category("MTCommon"), Browsable(true)]
        public Color PressColor
        {
            get { return _PressColor; }
            set { _PressColor = value; Invalidate(); }
        }
        [Description("激活时的颜色"), Category("MTCommon"), Browsable(true)]
        public Color ActColor
        {
            get { return _ActColor; }
            set { _ActColor = value; Invalidate(); }
        }



        [Description("鼠标指向时的颜色"), Category("MTCommon"), Browsable(true)]
        public Color EnterColor
        {
            get { return _EnterColor; }
            set { _EnterColor = value; Invalidate(); }
        }

        [Description("按钮信息"), Category("MTCommon"), Browsable(true)]
        public ButtonInfo Info
        {
            get {
                if (_Info == null)
                {
                    _Info = new ButtonInfo();
                }
                _Info.ID = this.Name;
                return _Info;
            }

            set {

                _Info = value;
            }
         
        }

        public static SizeF GetFontSize(Graphics g, Font f, string s)
        {
            SizeF sizeF = g.MeasureString(s, f);
            return sizeF;
        }
        #endregion

        /// <summary>
        /// 用于画图纸的Graphics
        /// </summary>
        public Graphics MGrap = null;
        /// <summary>
        /// 用于画图纸的Image
        /// </summary>
        public Bitmap MImage = null;
        private void Base_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterStatus = true;
            Invalidate();
        }

        private void Base_MouseLeave(object sender, EventArgs e)
        {
            MouseEnterStatus = false;
            Invalidate();
        }

        private void Base_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressStatus = true;
            Invalidate();
        }

        private void Base_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressStatus = false;
            Invalidate();
        }
    

        public bool MousePressStatus = false;
        public bool MouseEnterStatus = false;

        public Color GetStatusColor()
        {
            if (MousePressStatus)
            {
                return PressColor;
            }
            if (MouseEnterStatus)
            {
              return EnterColor;
            }
         
            if (IsActivate)
            {
                return ActColor;
            }
            return UseThemeColor? ThemeColor:MainColor;
        }
        public Color GetMainColor()
        {
            return UseThemeColor ? ThemeColor : MainColor;
        }
        internal static GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }
    }
}
