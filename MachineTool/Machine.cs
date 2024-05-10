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
using static System.Net.Mime.MediaTypeNames;

namespace MachineTool
{
    [ToolboxItem(true)]
    public partial class Machine : BaseControl
    {
        public Machine()
        {
            InitializeComponent();
        }
        private int _banMode = 0;
        [Description("0不显示，1显示板件默认颜色，2显示板件颜色2"), Category("Machine"), Browsable(true)]
        public int BanMode
        {
            get { return _banMode; }
            set { _banMode = value; this.Invalidate(); }
        }

        private Color _banColor1 = Color.BurlyWood;
        [Description("板件默认颜色"), Category("Machine"), Browsable(true)]
        public Color BanColor1
        {
            get { return _banColor1; }
            set { _banColor1 = value; this.Invalidate(); }
        }

        private Color _banColor2 = Color.DarkGray;
        [Description("板件颜色2"), Category("Machine"), Browsable(true)]
        public Color BanColor2
        {
            get { return _banColor2; }
            set { _banColor2 = value; this.Invalidate(); }
        }



        private bool _mWork = false;
        [Description("1显示板件颜色2，0显示板件默认颜色"), Category("Machine"), Browsable(true)]
        public bool MWork
        {
            get { return _mWork; }
            set { _mWork = value; this.Invalidate(); }
        }

        private Color _mColor1 = Color.Gray;
        [Description("皮带默认颜色"), Category("Machine"), Browsable(true)]
        public Color MColor1
        {
            get
            {
                if (UseThemeColor)
                {
                    return ThemeColor;
                }
                return _mColor1; }
            set { _mColor1 = value; this.Invalidate(); }
        }

        private Color _mColor2 = Color.LimeGreen;
        [Description("皮带板件颜色2"), Category("Machine"), Browsable(true)]
        public Color MColor2
        {
            get { return _mColor2; }
            set { _mColor2 = value; this.Invalidate(); }
        }

        private string _banContent = "abc123汉.nc";
        [Description("板件文字"), Category("Machine"), Browsable(true)]
        public string BanContent
        {
            get { return _banContent; }
            set { _banContent = value; this.Invalidate(); }
        }


        private float _jtLoc = 0.5f;
        [Description("机头位置（0~1）"), Category("Machine"), Browsable(true)]
        public float JtLoc
        {
            get { return _jtLoc; }
            set { _jtLoc = value; this.Invalidate(); }
        }




        //滚筒间隔
        private float RollerSpan = 5;
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
            MGrap.Clear(this.BackColor);

            Color color = MWork ? MColor2 : MColor1;
            //床身距离控件边缘的距离
            float csX = this.Width * 0.03f;
            float csY = this.Height * 0.08f;
            RectangleF bodyRect = new RectangleF(csX, csY, this.Width - csX * 2, this.Height - csY * 2);
            MGrap.DrawRectangles(new Pen(MColor1, 2), new RectangleF[] { bodyRect });
            Brush b = new HatchBrush(HatchStyle.Cross, this.BackColor, color);
            //MGrap.FillRectangle(b, bodyRect);


            //float beamWidth = this.Height * 0.08f;//外框占百分之十
            //RectangleF upRect = new RectangleF(0, 0, this.Width, beamWidth);
            // b = new LinearGradientBrush(upRect, MColor1, Color.DarkGray, LinearGradientMode.BackwardDiagonal);
            //MGrap.FillRectangle(b, upRect);


            //RectangleF downRect = new RectangleF(0, this.Height - beamWidth, this.Width, beamWidth);
            //b = new LinearGradientBrush(downRect, MColor1, Color.DarkGray, LinearGradientMode.ForwardDiagonal);
            //MGrap.FillRectangle(b, downRect);



            if (BanMode == 2 || BanMode == 1)
            {
                csX = this.Width * 0.08f;
                csY = this.Height * 0.15f;
                color = BanMode == 2 ? Color.FromArgb(210, BanColor2) : Color.FromArgb(210, BanColor1); // 半透明红色
                Brush brush = new SolidBrush(color);
                RectangleF rr = new RectangleF(csX, csY, this.Width - csX * 2, this.Height - csY * 2);
                // MGrap.DrawRectangles(new Pen(color), new RectangleF[] { rr });
                MGrap.FillRectangle(brush, rr);
                SizeF sizeF = MGrap.MeasureString(BanContent, this.Font);




                rr = new RectangleF(rr.X, rr.Y + rr.Height * 0.2f, rr.Width, rr.Height);
                StringFormat format = new StringFormat();
                format.FormatFlags = StringFormatFlags.LineLimit; // 设置换行标志
                                                                  // format.SetTabStops(0, 300); // 设置制表符位置，可以通过改变制表位置来影响换行点
                MGrap.DrawString(this.BanContent, this.Font, Brushes.Black, rr, format);
            }
            color = MWork ? MColor2 : MColor1;
            //横梁
            csX = this.Width * 0.7f;
            csY = this.Height * 0.01f;
            RectangleF horRect = new RectangleF(csX, csY, this.Width * 0.1f, this.Height - csY * 2);
            //b = new LinearGradientBrush(horRect, Color.FromArgb(210, Color.Black), Color.FromArgb(210,Color.Silver), LinearGradientMode.BackwardDiagonal);
            // b = new LinearGradientBrush(horRect, Color.Black, Color.Silver, LinearGradientMode.ForwardDiagonal);
            //MGrap.DrawRectangles(new Pen(Color.Black), new RectangleF[] { horRect });
            //MGrap.FillRectangle(b, horRect);

            GraphicsPath gp = new GraphicsPath();
            gp.AddRectangle(horRect);
            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = this.BackColor;
            // pgb.CenterPoint = new PointF(r2.Left + r2.Width / 2, r2.Top + r2.Height / 2);
            pgb.CenterPoint = new PointF(horRect.Left + horRect.Width / 3, horRect.Top + horRect.Height / 3);
            pgb.FocusScales = new PointF(0.0f, 0.3f);
            pgb.SurroundColors = new Color[] { color };
            MGrap.FillPath(pgb, gp);

            //机头
            csX = this.Width * 0.7f;
            csY = this.Height * JtLoc;
            float a = this.Height * 0.2f;
            horRect = new RectangleF(csX + horRect.Width, csY, a, a);
            b = new LinearGradientBrush(horRect, color, Color.Silver, LinearGradientMode.ForwardDiagonal);
            MGrap.DrawRectangles(new Pen(color), new RectangleF[] { horRect });
            MGrap.FillRectangle(b, horRect);


            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
