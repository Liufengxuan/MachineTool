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
    [ToolboxItem(true)]
    public partial class PressPlate : BaseControl
    {
        public PressPlate()
        {
            InitializeComponent();
        }



        private bool _LinesHor=true;


        [Description("左右纹路"), Category("MT"), Browsable(true)]
        public bool LinesHor
        {
            get { return _LinesHor; }
            set { _LinesHor= value; }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            if (MImage == null)
            {
                MImage = new Bitmap(this.Width, this.Height);
                MGrap = Graphics.FromImage(MImage);
            }
            else if (MImage.Width != this.Width || MImage.Height != this.Height)
            {
                MGrap.Dispose();
                MImage.Dispose();
                MImage = new Bitmap(this.Width - 1, this.Height - 1);
                MGrap = Graphics.FromImage(MImage);
            }

            //------------------------------------
            MGrap.Clear(this.BackColor);
            if (AntiAliasing)
                MGrap.SmoothingMode = SmoothingMode.AntiAlias;
            int width = this.Width ;
            int height = this.Height ;
            int w1 = width;
            int h1 = height;
            Rectangle r1 = new Rectangle(-1, -1, w1, h1);
            r1.Inflate(0, 0);
            GraphicsPath gp = CreateRoundedRectanglePath(r1, 10);
            this.Region = new Region(gp);


            r1.Inflate(-2, -2);
             gp=  CreateRoundedRectanglePath(r1, 5);
            MGrap.DrawPath(new Pen(ThemeColor, 2), gp);

            //Color tColor = GetStatusColor();
            //if (tColor == ThemeColor) tColor = this.BackColor;
            //LinearGradientBrush lgb = new LinearGradientBrush(r1, tColor, Color.Black, LinearGradientMode.Vertical);
           // MGrap.FillPath(lgb, gp);
           // HatchBrush hbrush1 = new HatchBrush(LinesHor? HatchStyle.Horizontal: HatchStyle.Vertical,GetStatusColor(), this.BackColor);
            HatchBrush hbrush1 = new HatchBrush(LinesHor ? HatchStyle.LightHorizontal : HatchStyle.LightVertical, GetStatusColor(), this.BackColor);
            MGrap.FillPath(hbrush1, gp);

            //------------------------------------

            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    
    }
}
