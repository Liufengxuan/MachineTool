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
    public partial class PressWheel : BaseControl
    {
        public PressWheel()
        {
            InitializeComponent();
            C1 = GetMainColor();
        }

        private Color _C1 ;
        [Description("中心渐变色1"), Category("MT"), Browsable(true)]
        public Color C1
        {
            get { return _C1; }
            set { _C1 = value; }
        }

        private bool _IsHor=true;
        [Description("两轮在水平方向"), Category("MT"), Browsable(true)]
        public bool IsHor
        {
            get { return _IsHor; }
            set { _IsHor = value; }
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
            int width = this.Width -3;
            int height = this.Height -3;
            float w1 = width;
            float h1 = height;
            RectangleF r1 = new RectangleF(0, 0, w1, h1);

            if (IsHor)
            {
                w1 = width * 0.25f;
                h1 = height * 0.17f;
                r1.Inflate(-w1, -h1);

                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                pgb.CenterPoint = new PointF(r1.Left + r1.Width / 2, r1.Top + r1.Height / 2);
                pgb.FocusScales = new PointF(1f, 0f);
                pgb.SurroundColors = new Color[] { GetStatusColor() };
                Pen p1 = new Pen(GetStatusColor(), 2);
                MGrap.DrawPath(p1, gp);
                MGrap.FillPath(pgb, gp);

                HatchBrush hbrush1 = new HatchBrush(HatchStyle.LightHorizontal,
GetMainColor(), this.BackColor);

                RectangleF r2 = new RectangleF(1, 1, w1, height - 1);
                MGrap.DrawRectangle(p1, r2.X, r2.Y, r2.Width, r2.Height);
                MGrap.FillRectangle(hbrush1, r2);

                RectangleF r3 = new RectangleF(r1.Right - 1, 1, w1, height - 1);
                MGrap.DrawRectangle(p1, r3.X, r3.Y, r3.Width, r3.Height);
                MGrap.FillRectangle(hbrush1, r3);
            }
            else
            {
                w1 = width * 0.17f;
                h1 = height * 0.25f;
                r1.Inflate(-w1, -h1);

                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                pgb.CenterPoint = new PointF(r1.Left + r1.Width / 2, r1.Top + r1.Height / 2);
                pgb.FocusScales = new PointF(0f, 1f);
                pgb.SurroundColors = new Color[] { GetStatusColor() };
                Pen p1 = new Pen(GetStatusColor(), 2);
                MGrap.DrawPath(p1, gp);
                MGrap.FillPath(pgb, gp);

                HatchBrush hbrush1 = new HatchBrush(HatchStyle.LightVertical,
GetMainColor(), this.BackColor);

                RectangleF r2 = new RectangleF(1, 1, width-1, h1);
                MGrap.DrawRectangle(p1, r2.X, r2.Y, r2.Width, r2.Height);
                MGrap.FillRectangle(hbrush1, r2);

                RectangleF r3 = new RectangleF(1, r1.Bottom, width - 1, h1);
                MGrap.DrawRectangle(p1, r3.X, r3.Y, r3.Width, r3.Height);
                MGrap.FillRectangle(hbrush1, r3);

            }
            


            //GraphicsPath gp=new GraphicsPath(new Point[] {
            //        new Point(20, 20),
            //        new Point(50, 20),
            //         new Point(50, 50),
            //          new Point(20, 50),
            //            new Point(20, 20),
            //    }, new byte[] {
            //        (byte)PathPointType.Start,
            //        (byte)PathPointType.Line,
            //         (byte)PathPointType.Line,
            //          (byte)PathPointType.Line,
            //           (byte)PathPointType.Line,

            //    });
            ////  gp.AddRectangle(r1);


            //PathGradientBrush pgb = new PathGradientBrush(gp);
            //pgb.CenterColor = Color.White;
            //pgb.CenterPoint = new Point(35, 35);
            //pgb.FocusScales=new PointF(1f, 0);
            ////pgb.SurroundColors = new Color[] { Color.Yellow, Color.Red, Color.Gray };
            //pgb.SurroundColors = new Color[] {
            //Color.Black,
            //Color.Black,
            //};


            //MGrap.FillRectangle(lgb, r1);
            //------------------------------------
            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
