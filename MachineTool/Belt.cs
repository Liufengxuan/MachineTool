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
    public partial class Belt : BaseControl
    {
        public Belt()
        {
            InitializeComponent();
        }

        private int _banMode = 0;
        [Description("0不显示，1显示板件默认颜色，2显示板件颜色2"), Category("belt"), Browsable(true)]
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
        [Description("板件默认颜色"), Category("belt"), Browsable(true)]
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
        [Description("板件颜色2"), Category("belt"), Browsable(true)]
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



        private bool _beltWork = false;
        [Description("1显示板件颜色2，0显示板件默认颜色"), Category("belt"), Browsable(true)]
        public bool BeltWork
        {
            get { return _beltWork; }
            set
            {
                if (value != _beltWork)
                {
                    _beltWork = value;
                    this.Invalidate();
                }
            }
        }

        private Color _beltColor1 = Color.Black;
        [Description("皮带默认颜色"), Category("belt"), Browsable(true)]
        public Color BeltColor1
        {
            get {
                if (UseThemeColor)
                {
                    return ThemeColor;
                }
                
                return _beltColor1; }
            set
            {
                if (value != _beltColor1)
                {
                    _beltColor1 = value;
                    this.Invalidate();
                }
            }
        }

        private Color _beltColor2 = Color.LimeGreen;
        [Description("皮带板件颜色2"), Category("belt"), Browsable(true)]
        public Color BeltColor2
        {
            get { return _beltColor2; }
            set
            {
                if (value != _beltColor2)
                {
                    _beltColor2 = value;
                    this.Invalidate();
                }
            }
        }

        private string _banContent = "abc123汉.nc";
        [Description("板件文字"), Category("belt"), Browsable(true)]
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

            Color color = BeltWork ? BeltColor2 : BeltColor1;
            //外框宽度缩放：
            float beamWidth = this.Height * 0.05f;//外框占百分之十
            float beamWidth_Ban = this.Height * 0.09f;//外框占百分之十
            RectangleF upRect = new RectangleF(0, 0, this.Width, beamWidth);
            Brush b = new LinearGradientBrush(upRect, BeltColor1, Color.DarkGray, LinearGradientMode.BackwardDiagonal);
            MGrap.FillRectangle(b, upRect);


            RectangleF downRect = new RectangleF(0, this.Height - beamWidth, this.Width, beamWidth);
            b = new LinearGradientBrush(downRect, BeltColor1, Color.DarkGray, LinearGradientMode.ForwardDiagonal);
            MGrap.FillRectangle(b, downRect);

            //皮带
            RectangleF beltRect = new RectangleF(0, beamWidth + 1, this.Width, this.Height - 1 - beamWidth * 2);
            b = new HatchBrush(HatchStyle.LightVertical, color, this.BackColor);
            MGrap.FillRectangle(b, beltRect);

            if (BanMode == 2 || BanMode == 1)
            {
                color = BanMode == 2 ? Color.FromArgb(210, BanColor2) : Color.FromArgb(210, BanColor1); // 半透明红色
                Brush brush = new SolidBrush(color);
                RectangleF rr = new RectangleF(beamWidth_Ban, beamWidth_Ban, this.Width - beamWidth_Ban * 2, this.Height - beamWidth_Ban * 2);
                // MGrap.DrawRectangles(new Pen(color), new RectangleF[] { rr });
                MGrap.FillRectangle(brush, rr);
                SizeF sizeF = MGrap.MeasureString(BanContent, this.Font);




                rr = new RectangleF(rr.X, rr.Y + rr.Height * 0.2f, rr.Width, rr.Height);
                StringFormat format = new StringFormat();
                format.FormatFlags = StringFormatFlags.LineLimit; // 设置换行标志
                                                                  // format.SetTabStops(0, 300); // 设置制表符位置，可以通过改变制表位置来影响换行点
                MGrap.DrawString(this.BanContent, this.Font, Brushes.Black, rr, format);
            }


            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}

