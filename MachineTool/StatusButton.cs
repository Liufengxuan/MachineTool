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
                if (_TextFormat == null)
                {
                    _TextFormat = new StringFormat();
                    _TextFormat.Alignment = StringAlignment.Center;
                    _TextFormat.LineAlignment = StringAlignment.Center;
                    _TextFormat.FormatFlags = StringFormatFlags.NoWrap;


                }
                return _TextFormat;
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
            MGrap.Clear(this.BackColor);
            if (AntiAliasing)
                MGrap.SmoothingMode = SmoothingMode.AntiAlias;
            //------------------------------------
            float w = this.Width - 1;
            float h=this.Height - 1;
            Rectangle borderRec = new Rectangle(0,0, this.Width - 1, this.Height - 1);
            GraphicsPath gp = CreateRoundedRectanglePath(borderRec, 8);
            this.Region = new Region(gp);


            borderRec.Inflate(-1, -1);
            gp.ClearMarkers();
            gp = CreateRoundedRectanglePath(borderRec, 8);
            MGrap.DrawPath(BorderPen, gp);
            MGrap.FillPath(BackColorBrush, gp);

            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = BackColor;
            pgb.CenterPoint = new PointF(borderRec.Left + borderRec.Width / 2, borderRec.Top + borderRec.Height / 2);
            pgb.FocusScales = new PointF(0.95f, 0.5f);
            pgb.SurroundColors = new Color[] {Color.FromArgb(85, GetStatusColor()) };
            MGrap.FillPath(pgb, gp);

            int h1=Convert.ToInt32( borderRec.Height * 0.1f);
            int w1 = Convert.ToInt32(borderRec.Width * 0.1f);
            borderRec.Inflate(0, -h1);

            //MGrap.DrawRectangle(BorderPen, borderRec);
            Font f = this.Font;
            MGrap.DrawString(MText, f, StringBrush, borderRec, TextFormat);


            //------------------------------------
            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
