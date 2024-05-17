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
    public partial class StatusButton : BaseControl
    {
        public StatusButton()
        {
            InitializeComponent();
        }


        public int _Rounde =8;
        [Description("圆弧角度"), Category("MT"), Browsable(true)]
        public int MRounde
        {
            get { return _Rounde; }
            set { _Rounde = value; }
        }
        public string _Text = "正AbCd456";
        [Description("文字"), Category("MT"), Browsable(true)]
        public  string MText
        {
            get { return _Text; }
            set { _Text = value; }
        }

        public Color _borderColor = Color.DarkGray;
        [Description("边框颜色"), Category("MT"), Browsable(true)]
        public Color borderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

   

        private Pen _BorderPen;

        private Pen BorderPen
        {
            get
            {
                if (_BorderPen == null || _BorderPen.Color != borderColor)
                    _BorderPen = new Pen(borderColor);
                return _BorderPen;
            }

        }
        private SolidBrush _BackColorBrush;

        private SolidBrush BackColorBrush
        {
            get
            {
                if (_BackColorBrush == null || _BackColorBrush.Color != this.BackColor)
                    _BackColorBrush = new SolidBrush(this.BackColor);
                return _BackColorBrush;
            }

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

        private StringFormat _TextFormat;

        public StringFormat TextFormat
        {
            get
            {
                if (_TextFormat==null)
                {
                    _TextFormat = new StringFormat();
                    _TextFormat.Alignment = StringAlignment.Center;
                    _TextFormat.LineAlignment = StringAlignment.Center;
                    _TextFormat.FormatFlags = StringFormatFlags.NoWrap;
                }
                return _TextFormat;
            }
        }

        private PointF[] _pathGradient = new PointF[2] { new PointF(0.5f, 0.5f), new PointF(0.85f, 0.1f) };
        [DisplayName("渐变色参数"), Category("MT"), Description("渐变色参数\r\n[0]:渐变色中心点\r\n[1]:过度色焦点"), Browsable(true)]
        public PointF[] PathGradientParam
        {
            get { return _pathGradient; }
            set { _pathGradient = value; this.Invalidate(); }
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
            MGrap.Clear(this.BackColor);
            if (AntiAliasing)
                MGrap.SmoothingMode = SmoothingMode.AntiAlias;
            //------------------------------------
            float w = this.Width - 1;
            float h=this.Height - 1;
            Rectangle borderRec = new Rectangle(0,0, this.Width - 1, this.Height - 1);
            GraphicsPath gp = CreateRoundedRectanglePath(borderRec, MRounde);
            this.Region = new Region(gp);
           

            borderRec.Inflate(-1, -1);
            gp.ClearMarkers();
            gp = CreateRoundedRectanglePath(borderRec, MRounde);
            MGrap.DrawPath(BorderPen, gp);
            MGrap.FillPath(BackColorBrush, gp);

            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = BackColor;
            pgb.CenterPoint = new PointF( borderRec.Width* PathGradientParam[0].X,  borderRec.Height* PathGradientParam[0].Y);
            pgb.FocusScales = PathGradientParam[1];
            pgb.SurroundColors = new Color[] {Color.FromArgb(100, GetStatusColor()) };
            MGrap.FillPath(pgb, gp);

            int h1=Convert.ToInt32( borderRec.Height * 0.1f);
            int w1 = Convert.ToInt32(borderRec.Width * 0.1f);


            borderRec.Inflate(0, -h1);
            MGrap.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            MGrap.DrawString(MText, this.Font, StringBrush, borderRec,TextFormat );

            //Size s= MGrap.MeasureString(MText, f).ToSize();
            //float x = (borderRec.Width-s.Width) / 2;
            //float y=( borderRec.Height-s.Height) / 2;
            //MGrap.DrawString(MText, f, Brushes.Black, x,y);

   


            //------------------------------------
            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
