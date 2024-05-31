using MachineTool.Properties;
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
    public partial class Roller : BaseControl
    {
        public Roller()
        {
            InitializeComponent();
        }






        private Color _gtColor1 = Color.Black;
        [Description("滚筒闲置颜色"), Category("roller"), Browsable(true)]
        public Color GTColor1
        {
            get
            {
                if (UseThemeColor)
                {
                    return ThemeColor;
                }
                return _gtColor1; }
            set
            {
                if (value != _gtColor1)
                {
                    _gtColor1 = value;
                    this.Invalidate();
                }
            }
        }
        private Color _gtColor2 = Color.LimeGreen;
        [Description("滚筒工作颜色"), Category("roller"), Browsable(true)]
        public Color GTColor2
        {
            get { return _gtColor2; }
            set
            {
                if (value != _gtColor2)
                {
                    _gtColor2 = value;
                    this.Invalidate();
                }
            }
        }


        private bool _gtWork = false;
        [Description("滚筒状态"), Category("roller"), Browsable(true)]
        public bool GTWork
        {
            get { return _gtWork; }
            set
            {
                if (value != _gtWork)
                {
                    _gtWork = value;
                    this.Invalidate();
                }
            }
        }

        private string _banContent = "abc123汉.nc";
        [Description("板件文字"), Category("roller"), Browsable(true)]
        public string BanContent
        {
            get { return _banContent; }
            set
            {
                if (value != _banContent)
                {
                    _banContent = value;
                    this.Invalidate();
                }
            }
        }

        private int _pyMode = 0;
        [Description("0不显示，1显示为闲置状态，2显示为工作状态"), Category("roller"), Browsable(true)]
        public int PYMode
        {
            get { return _pyMode; }
            set
            {
                if (value != _pyMode)
                {
                    _pyMode = value;
                    this.Invalidate();
                }
            }
        }

        private Color _pyColor1 = Color.Black;
        [Description("平移皮带闲置时颜色"), Category("roller"), Browsable(true)]
        public Color PYColor1
        {
            get
            {
                if (UseThemeColor)
                {
                    return ThemeColor;
                }
                return _pyColor1; }
            set
            {
                if (value != _pyColor1)
                {
                    _pyColor1 = value;
                    this.Invalidate();
                }
            }
        }

        private Color _pyColor2 = Color.LimeGreen;
        [Description("平移皮带工作时颜色"), Category("roller"), Browsable(true)]
        public Color PYColor2
        {
            get { return _pyColor2; }
            set
            {
                if (value != _pyColor2)
                {
                    _pyColor2 = value;
                    this.Invalidate();
                }
            }
        }

        private PYLocEnum _pyLoc = PYLocEnum.left;
        [Description("平移皮带工作时颜色"), Category("roller"), Browsable(true)]
        public PYLocEnum PYLoc
        {
            get { return _pyLoc; }
            set
            {
                if (value != _pyLoc)
                {
                    _pyLoc = value;
                    this.Invalidate();
                }
            }
        }
        public enum PYLocEnum
        {
            left = 0,
            right = 1,
            full=2
        }

        private bool _vertical = false;
        [Description("显示为垂直方向"), Category("roller"), Browsable(true)]
        public bool Vertical
        {
            get { return _vertical; }
            set
            {
                if (value != _vertical)
                {
                    _vertical = value;
                    this.Invalidate();
                }
            }
        }
        private bool _banStyle = false;
        [Description("木板显示实木图片"), Category("roller"), Browsable(true)]
        public bool BanStyle
        {
            get { return _banStyle; }
            set
            {
                if (value != _banStyle)
                {
                    _banStyle = value;
                    this.Invalidate();
                }
            }
        }



        private int _banMode = 0;
        [Description("0不显示，1显示板件默认颜色，2显示板件颜色2"), Category("roller"), Browsable(true)]
        public int BanMode
        {
            get { return _banMode; }
            set
            {
                if (value != _banMode)
                {
                    _banMode = value;
                    this.Invalidate();
                }
            }
        }

        private Color _banColor1 = Color.BurlyWood;
        [Description("板件默认颜色"), Category("roller"), Browsable(true)]
        public Color BanColor1
        {
            get { return _banColor1; }
            set
            {
                if (value != _banColor1)
                {
                    _banColor1 = value;
                    this.Invalidate();
                }
            }
        }

        private Color _banColor2 = Color.DarkGray;
        [Description("板件颜色2"), Category("roller"), Browsable(true)]
        public Color BanColor2
        {
            get { return _banColor2; }
            set
            {
                if (value != _banColor2)
                {
                    _banColor2 = value;
                    this.Invalidate();
                }
            }
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
            if (Vertical)
            {
                Color color = GTWork ? GTColor2 : GTColor1;
                //外框宽度缩放：
                float beamZoom = 0.05f;//外框占百分之十
                RectangleF upRect = new RectangleF(0, 1, this.Width * beamZoom, this.Height );
                //  Brush b = new LinearGradientBrush(upRect, GTColor1, Color.DarkGray, LinearGradientMode.BackwardDiagonal);
                Brush b = new SolidBrush(GTColor1);
                MGrap.FillRectangle(b, upRect);


                RectangleF downRect = new RectangleF(this.Width- this.Width * beamZoom - 1, 0, this.Width * beamZoom, this.Height );
                //  b = new LinearGradientBrush(downRect, GTColor1, Color.DarkGray, LinearGradientMode.ForwardDiagonal);
                MGrap.FillRectangle(b, downRect);

                //每根滚筒的宽度
                float rollerWidth = 0.04f * this.Height;
                //每根滚筒的间距
                float rollerHSpan = 0.07f * this.Height;
                //平移皮带的宽度
                float pyWidth = rollerHSpan / 2;
                //平移皮带距离滚筒的距离
                float pySpan = (rollerHSpan - pyWidth) / 2;

                //滚筒个数
                int rollerCount = Convert.ToInt32(this.Height / (rollerWidth + rollerHSpan));
                //滚筒两头相对于边缘的距离
                float rollerVSpan = this.Width * 0.07f;

                float curX = rollerWidth;
                for (int i = 0; i < rollerCount; i++)
                {

                    RectangleF rr = new RectangleF(rollerVSpan, curX, this.Width - rollerVSpan * 2, rollerWidth);
                    //b = new LinearGradientBrush(new PointF(rr.X,rr.Y/2),new PointF(rr.X+rr.Width,rr.Y/2),StateColor1,Color.DarkGray);

                    GraphicsPath gp = new GraphicsPath();
                    gp.AddRectangle(rr);
                    PathGradientBrush pgb = new PathGradientBrush(gp);
                    pgb.CenterColor = Color.White;
                    pgb.CenterPoint = new PointF(rr.X + rr.Width / 2, rr.Y + rr.Height / 2);
                    pgb.FocusScales = new PointF(1f, 0f);
                    pgb.SurroundColors = new Color[] { color };
                    MGrap.FillPath(pgb, gp);
                    //MGrap.DrawLine(new Pen(color, 0.5f), rr.X + rr.Width / 2, 0, rr.X + rr.Width / 2, this.Height);
                    MGrap.DrawLine(new Pen(color, 0.5f), 0,rr.Y+rr.Height/2, this.Width, rr.Y+rr.Height/2);
                    //MGrap.FillRectangle(b, rr);
                    curX += rollerWidth + rollerHSpan;
                }

                //平移皮带
                if (PYMode == 2 || PYMode == 1)
                {
                    curX = rollerWidth;
                    color = PYMode == 2 ? PYColor2 : PYColor1;
                    for (int i = 0; i < rollerCount - 1; i++)
                    {
                        // if (PYLoc == PYLocEnum.left && i < (rollerCount / 2) || PYLoc == PYLocEnum.right && i > (rollerCount / 2))
                        if (PYLoc == PYLocEnum.left && i < (rollerCount / 2) || PYLoc == PYLocEnum.right && i >= (rollerCount / 2) || PYLoc == PYLocEnum.full)
                        {
                          //  RectangleF rr = new RectangleF(curX + rollerWidth + pySpan, rollerVSpan, pyWidth, this.Height - rollerVSpan * 2);
                            RectangleF rr = new RectangleF(rollerVSpan, curX + rollerWidth + pySpan, this.Width - rollerVSpan * 2, pyWidth);
                            b = new HatchBrush(HatchStyle.NarrowHorizontal, this.BackColor, color);
                            MGrap.FillRectangle(b, rr);
                            //MGrap.DrawRectangle(new Pen(StateColor1), ToRectangle(rr));
                            MGrap.DrawRectangles(new Pen(color), new RectangleF[] { rr });

                        }
                        curX += rollerWidth + rollerHSpan;
                    }


                }

                //板子
                if (BanMode == 2 || BanMode == 1)
                {
                    rollerVSpan = this.Width * 0.1f;
                    color = BanMode == 2 ? Color.FromArgb(210, BanColor2) : Color.FromArgb(210, BanColor1); // 半透明红色
                    Brush brush = new SolidBrush(color);
                    RectangleF rr = new RectangleF(rollerVSpan, rollerWidth, this.Width - rollerVSpan * 2, this.Height - rollerWidth * 2);
                    if (BanStyle)
                        MGrap.DrawImage(ZiYuan.muWen1, rr);
                    else
                        MGrap.FillRectangle(brush, rr);

                    SizeF sizeF = MGrap.MeasureString(BanContent, this.Font);

                    // rr = new RectangleF(rollerWidth, rollerVSpan + rr.Height * 0.2f, this.Width - rollerWidth * 2, this.Height - rollerVSpan * 2);
                    //rr = new RectangleF( rollerVSpan + rr.Width * 0.2f, rollerWidth, this.Width - rollerVSpan * 2 , this.Height - rollerWidth * 2);
                    rr.Inflate(0, -Convert.ToInt16(this.Height * 0.2));
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.LineLimit; // 设置换行标志
                                                                      // format.SetTabStops(0, 300); // 设置制表符位置，可以通过改变制表位置来影响换行点
                    MGrap.DrawString(this.BanContent, this.Font, Brushes.Black, rr, format);
                }
            }
            else
            {
                Color color = GTWork ? GTColor2 : GTColor1;
                //外框宽度缩放：
                float beamZoom = 0.05f;//外框占百分之十
                RectangleF upRect = new RectangleF(0, 1, this.Width, this.Height * beamZoom);
                //  Brush b = new LinearGradientBrush(upRect, GTColor1, Color.DarkGray, LinearGradientMode.BackwardDiagonal);
                Brush b = new SolidBrush(GTColor1);
                MGrap.FillRectangle(b, upRect);


                RectangleF downRect = new RectangleF(0, this.Height - this.Height * beamZoom - 1, this.Width, this.Height * beamZoom);
                //  b = new LinearGradientBrush(downRect, GTColor1, Color.DarkGray, LinearGradientMode.ForwardDiagonal);
                MGrap.FillRectangle(b, downRect);

                //每根滚筒的宽度
                float rollerWidth = 0.04f * this.Width;
                //每根滚筒的间距
                float rollerHSpan = 0.07f * this.Width;
                //平移皮带的宽度
                float pyWidth = rollerHSpan / 2;
                //平移皮带距离滚筒的距离
                float pySpan = (rollerHSpan - pyWidth) / 2;

                //滚筒个数
                int rollerCount = Convert.ToInt32(this.Width / (rollerWidth + rollerHSpan));
                //滚筒两头相对于边缘的距离
                float rollerVSpan = this.Height * 0.07f;

                float curX = rollerWidth;
                for (int i = 0; i < rollerCount; i++)
                {

                    RectangleF rr = new RectangleF(curX, rollerVSpan, rollerWidth, this.Height - rollerVSpan * 2);
                    //b = new LinearGradientBrush(new PointF(rr.X,rr.Y/2),new PointF(rr.X+rr.Width,rr.Y/2),StateColor1,Color.DarkGray);

                    GraphicsPath gp = new GraphicsPath();
                    gp.AddRectangle(rr);
                    PathGradientBrush pgb = new PathGradientBrush(gp);
                    pgb.CenterColor = Color.White;
                    pgb.CenterPoint = new PointF(rr.X + rr.Width / 2, rr.Y + rr.Height / 2);
                    pgb.FocusScales = new PointF(0f, 1f);
                    pgb.SurroundColors = new Color[] { color };
                    MGrap.FillPath(pgb, gp);
                    MGrap.DrawLine(new Pen(color, 0.5f), rr.X + rr.Width / 2, 0, rr.X + rr.Width / 2, this.Height);
                    //MGrap.FillRectangle(b, rr);
                    curX += rollerWidth + rollerHSpan;
                }

                //平移皮带
                if (PYMode == 2 || PYMode == 1)
                {
                    curX = rollerWidth;
                    color = PYMode == 2 ? PYColor2 : PYColor1;
                    for (int i = 0; i < rollerCount - 1; i++)
                    {
                        // if (PYLoc == PYLocEnum.left && i < (rollerCount / 2) || PYLoc == PYLocEnum.right && i > (rollerCount / 2))
                        if (PYLoc == PYLocEnum.left && i < (rollerCount / 2) || PYLoc == PYLocEnum.right && i >= (rollerCount / 2) || PYLoc == PYLocEnum.full)
                        {
                            RectangleF rr = new RectangleF(curX + rollerWidth + pySpan, rollerVSpan, pyWidth, this.Height - rollerVSpan * 2);
                            //b = new LinearGradientBrush(new PointF(rr.X,rr.Y/2),new PointF(rr.X+rr.Width,rr.Y/2),StateColor1,Color.DarkGray);
                            b = new HatchBrush(HatchStyle.DarkHorizontal, this.BackColor, color);
                            MGrap.FillRectangle(b, rr);
                            //MGrap.DrawRectangle(new Pen(StateColor1), ToRectangle(rr));
                            MGrap.DrawRectangles(new Pen(color), new RectangleF[] { rr });

                        }
                        curX += rollerWidth + rollerHSpan;
                    }


                }

                //板子
                if (BanMode == 2 || BanMode == 1)
                {
                    rollerVSpan = this.Height * 0.1f;
                    color = BanMode == 2 ? Color.FromArgb(210, BanColor2) : Color.FromArgb(210, BanColor1); // 半透明红色
                    Brush brush = new SolidBrush(color);
                    RectangleF rr = new RectangleF(rollerWidth, rollerVSpan, this.Width - rollerWidth * 2, this.Height - rollerVSpan * 2);
                    // MGrap.DrawRectangles(new Pen(color), new RectangleF[] { rr });
                    //MGrap.FillRectangle(brush, rr);
                    if (BanStyle)
                        MGrap.DrawImage(ZiYuan.muWen1, rr);
                    else
                        MGrap.FillRectangle(brush, rr);
                    SizeF sizeF = MGrap.MeasureString(BanContent, this.Font);




                    rr = new RectangleF(rollerWidth, rollerVSpan + rr.Height * 0.2f, this.Width - rollerWidth * 2, this.Height - rollerVSpan * 2);
                    StringFormat format = new StringFormat();
                    format.FormatFlags = StringFormatFlags.LineLimit; // 设置换行标志
                                                                      // format.SetTabStops(0, 300); // 设置制表符位置，可以通过改变制表位置来影响换行点
                    MGrap.DrawString(this.BanContent, this.Font, Brushes.Black, rr, format);
                }
            }
          

            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
