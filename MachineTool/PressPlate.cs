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
            int width = this.Width-1 ;
            int height = this.Height-1 ;
            int w1 = width;
            int h1 = height;
            Rectangle r1 = new Rectangle(1, 1, w1, h1);
            r1.Inflate(-4, -4);
            GraphicsPath gp=  CreateRoundedRectanglePath(r1, 5);
            MGrap.DrawPath(new Pen(ThemeColor, 4), gp);
            HatchBrush hbrush1 = new HatchBrush(LinesHor? HatchStyle.Horizontal: HatchStyle.Vertical,
            GetStatusColor(), this.BackColor);
            MGrap.FillPath(hbrush1, gp);

            //------------------------------------

            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    
    }
}
