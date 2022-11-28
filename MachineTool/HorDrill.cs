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
    public partial class HorDrill : BaseControl
    {
        public HorDrill()
        {
        
        }
        public enum HorDrillTypeEnum
        {
            Left=0,
            Right=1,
            Top=2,
            Bottom=3,
        }

        private HorDrillTypeEnum _HorDrillType ;
        [Description("类型"), Category("MT"), Browsable(true)]
        public HorDrillTypeEnum HorDrillType
        {
            get { return _HorDrillType; }
            set { _HorDrillType = value; }
        }


        private SolidBrush _StringBrush;

        private SolidBrush StringBrush
        {
            get
            {
                if (_StringBrush == null)
                {
                    _StringBrush = new SolidBrush(this.ForeColor);
                }
                return _StringBrush;
            }
        }

        private StringFormat _drillNumFormat;

        public StringFormat DrillNumForMat
        {
            get
            {
                if (_drillNumFormat == null)
                {
                    _drillNumFormat = new StringFormat();
                    _drillNumFormat.Alignment = StringAlignment.Center;
                    _drillNumFormat.LineAlignment = StringAlignment.Center;
                }
                return _drillNumFormat;
            }
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
            int width = this.Width;
            int height = this.Height ;
            float w1 = width-1;
            float h1 = height-1;
            HatchBrush hbrush1 = new HatchBrush(HatchStyle.DarkDownwardDiagonal,
GetStatusColor(), this.BackColor);
            Pen p1 = new Pen(GetStatusColor(), 2);
            Pen p2 = new Pen(GetStatusColor(), 1);
            RectangleF r1 = new RectangleF(0,0, 2, 2);
            RectangleF r2 = new RectangleF(0, 0, 2, 2);

            RectangleF str= new RectangleF(0, 0, 2, 2);
            if (HorDrillType == HorDrillTypeEnum.Left)
            {
                w1 = width / 2;
                h1 = height / 3;

                 r1 = new RectangleF(0, h1, w1, h1);
                str= r2 = new RectangleF(w1, 0, w1, height);
                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                gp.AddRectangle(r2);
                this.Region=new Region(gp);

                h1 = height * 0.1f;
                r1.Inflate(0, -1);
                r2.Inflate(-1, -h1);
                gp = new GraphicsPath();
                //gp.AddRectangle(r1);
                //gp.AddRectangle(r2);


                //钻尖长度=r1 长度的百分之25
                float h = r1.Width * 0.25f;
                gp = new GraphicsPath(new PointF[] {
                    new PointF(r1.X, r1.Top+r1.Height/2),
                    new PointF(r1.X+h,r1.Y),
                     new PointF(r1.Right,r1.Top),
                      new PointF(r1.Right, r1.Bottom),
                        new PointF(r1.X+h, r1.Bottom),
                          new PointF(r1.X, r1.Top+r1.Height/2),
                }, new byte[] {
                    (byte)PathPointType.Start,
                    (byte)PathPointType.Line,
                     (byte)PathPointType.Line,
                      (byte)PathPointType.Line,
                       (byte)PathPointType.Line,
                        (byte)PathPointType.Line,
                });


             
                MGrap.FillPath(hbrush1, gp);
                MGrap.DrawPath(p2, gp);
                gp = new GraphicsPath();
                gp.AddRectangle(r2);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                // pgb.CenterPoint = new PointF(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);
                pgb.CenterPoint = new PointF(r2.Left + r2.Width / 3, r2.Top + r2.Height / 3);
                pgb.FocusScales = new PointF(0.7f,0f);
                pgb.SurroundColors = new Color[] { ThemeColor };

               
                MGrap.FillPath(pgb, gp);
                MGrap.DrawPath(p1, gp);


            }

            if (HorDrillType == HorDrillTypeEnum.Right)
            {
                w1 = width / 2;
                h1 = height / 3;
              

                 r1 = new RectangleF(w1, h1, w1, h1);
                str = r2 = new RectangleF(0, 0, w1, height);
                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                gp.AddRectangle(r2);
                this.Region = new Region(gp);

                h1 = height * 0.1f;
                r1.Inflate(0, -1);
                r2.Inflate(-1, -h1);
                gp = new GraphicsPath();
                //gp.AddRectangle(r1);
                //gp.AddRectangle(r2);


                //钻尖长度=r1 长度的百分之25
                float h = r1.Width * 0.25f;
                gp = new GraphicsPath(new PointF[] {
                    new PointF(r1.Right, r1.Top+r1.Height/2),
                    new PointF(r1.Right-h,r1.Top),
                     new PointF(r1.Left,r1.Top),
                      new PointF(r1.Left, r1.Bottom),
                        new PointF(r1.Right-h, r1.Bottom),
                            new PointF(r1.Right, r1.Top+r1.Height/2),
                }, new byte[] {
                    (byte)PathPointType.Start,
                    (byte)PathPointType.Line,
                     (byte)PathPointType.Line,
                      (byte)PathPointType.Line,
                       (byte)PathPointType.Line,
                        (byte)PathPointType.Line,
                });


               
                MGrap.FillPath(hbrush1, gp);
                MGrap.DrawPath(p2, gp);
                gp = new GraphicsPath();
                gp.AddRectangle(r2);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                // pgb.CenterPoint = new PointF(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);
                pgb.CenterPoint = new PointF(r2.Left + r2.Width / 3*2, r2.Top + r2.Height / 3);
                pgb.FocusScales = new PointF(0.7f, 0f);
                pgb.SurroundColors = new Color[] { ThemeColor };

               
                MGrap.FillPath(pgb, gp);
                MGrap.DrawPath(p1, gp);
            }

            if (HorDrillType == HorDrillTypeEnum.Top)
            {
               
                w1 = width / 3;
                h1 = height / 2;
            

                 r1 = new RectangleF(w1, 0, w1, h1);
                str = r2 = new RectangleF(0, h1, width, h1);
                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                gp.AddRectangle(r2);
                this.Region = new Region(gp);

                h1 = width * 0.1f;
                r1.Inflate(-1, 0);
                r2.Inflate(-h1, -1 );
                gp = new GraphicsPath();
                //gp.AddRectangle(r1);
                //gp.AddRectangle(r2);


                //钻尖长度=r1 长度的百分之25
                float h = r1.Height * 0.25f;
                gp = new GraphicsPath(new PointF[] {
                    new PointF(r1.Left+r1.Width/2, r1.Top),
                    new PointF(r1.Right,r1.Top+h),
                     new PointF(r1.Right,r1.Bottom),
                      new PointF(r1.Left, r1.Bottom),
                        new PointF(r1.Left, r1.Top+h),
                          new PointF(r1.Left+r1.Width/2, r1.Top),
                }, new byte[] {
                    (byte)PathPointType.Start,
                    (byte)PathPointType.Line,
                     (byte)PathPointType.Line,
                      (byte)PathPointType.Line,
                       (byte)PathPointType.Line,
                        (byte)PathPointType.Line,
                });


              
                MGrap.FillPath(hbrush1, gp);
                MGrap.DrawPath(p2, gp);
                gp = new GraphicsPath();
                gp.AddRectangle(r2);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                // pgb.CenterPoint = new PointF(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);
                pgb.CenterPoint = new PointF(r2.Left + r2.Width / 3 , r2.Top + r2.Height / 3);
                pgb.FocusScales = new PointF(0f, 0.7f);
                pgb.SurroundColors = new Color[] { ThemeColor };

              
                MGrap.FillPath(pgb, gp);
                MGrap.DrawPath(p1, gp);
            }

            if (HorDrillType == HorDrillTypeEnum.Bottom)
            {
               
                w1 = width / 3;
                h1 = height / 2;
              

                 r1 = new RectangleF(w1, h1, w1, h1);
                str = r2 = new RectangleF(0,0, width, h1);
                GraphicsPath gp = new GraphicsPath();
                gp.AddRectangle(r1);
                gp.AddRectangle(r2);
                this.Region = new Region(gp);

                h1 = width * 0.1f;
                r1.Inflate(-1, 0);
                r2.Inflate(-h1, -1);
                gp = new GraphicsPath();
                //gp.AddRectangle(r1);
                //gp.AddRectangle(r2);


                //钻尖长度=r1 长度的百分之25
                float h = r1.Height * 0.25f;
                gp = new GraphicsPath(new PointF[] {
                    new PointF(r1.Left+r1.Width/2, r1.Bottom),
                    new PointF(r1.Right,r1.Bottom-h),
                     new PointF(r1.Right,r1.Top),
                      new PointF(r1.Left, r1.Top),
                        new PointF(r1.Left, r1.Bottom-h),
                         new PointF(r1.Left+r1.Width/2, r1.Bottom),
                }, new byte[] {
                    (byte)PathPointType.Start,
                    (byte)PathPointType.Line,
                     (byte)PathPointType.Line,
                      (byte)PathPointType.Line,
                       (byte)PathPointType.Line,
                        (byte)PathPointType.Line,
                });


              
                MGrap.FillPath(hbrush1, gp);
                MGrap.DrawPath(p2, gp);
                gp = new GraphicsPath();
                gp.AddRectangle(r2);
                PathGradientBrush pgb = new PathGradientBrush(gp);
                pgb.CenterColor = this.BackColor;
                // pgb.CenterPoint = new PointF(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);
                pgb.CenterPoint = new PointF(r2.Left + r2.Width / 3 , r2.Top + r2.Height / 3*2);
                pgb.FocusScales = new PointF(0f, 0.7f);
                pgb.SurroundColors = new Color[] { ThemeColor };

               
                MGrap.FillPath(pgb, gp);
                MGrap.DrawPath(p1, gp);
            }




            float d = str.Height > str.Width ? str.Width : str.Height;

            Font f = new Font(this.Font.FontFamily, d / 2.5f, FontStyle.Bold);
            MGrap.DrawString(DrillNumber, f, StringBrush, str, DrillNumForMat);
            //------------------------------------
            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }



    }
}
