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
    public partial class MGroupBox : ContainerControl
    {
        public MGroupBox()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private string _titleText = "GroupBoxControl";
        [Description("文字"), Category("GroupBoxControl"), Browsable(true)]
        public string TitleText
        {
            get { return _titleText; }
            set
            {
                if (value != _titleText)
                {
                    _titleText = value;
                    this.Invalidate();
                }
            }
        }

        private Color _boderColor = Color.Black;
        [Description("边框颜色"), Category("GroupBoxControl"), Browsable(true)]
        public Color BoderColor
        {
            get
            {
                if (UseThemeColor)
                {
                    return BaseControl._ThemeColor;
                }
                return _boderColor; }
            set
            {
                if (value != _boderColor)
                {
                    _boderColor = value;
                    this.Invalidate();
                }
            }
        }

        private bool _UseThemeColor = true;
        [Description("是否使用全局主题颜色"), Category("GroupBoxControl"), Browsable(true)]
        public bool UseThemeColor
        {
            get
            {
                return _UseThemeColor;
            }
            set
            {
                if (value != _UseThemeColor)
                {
                    _UseThemeColor = value;
                    this.Invalidate();
                }
            }
        }


        private Color _fontColor = Color.Black;
        [Description("文字颜色"), Category("GroupBoxControl"), Browsable(true)]
        public Color FontColor
        {
            get { return _fontColor; }
            set
            {
                if (value != _fontColor)
                {
                    _fontColor = value;
                    this.Invalidate();
                }
            }
        }

        private int _borderWidth = 1;
        [Description("边框宽度"), Category("GroupBoxControl"), Browsable(true)]
        public int BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                if (value != _borderWidth)
                {
                    _borderWidth = value;
                    this.Invalidate();
                }
            }
        }

        private Font _titleFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        [Description("标题字体"), Category("GroupBoxControl"), Browsable(true)]
        public Font TitleFont
        {
            get { return _titleFont; }
            set
            {
                if (value != _titleFont)
                {
                    _titleFont = value;
                    this.Invalidate();
                }
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



            float neiSuo = 2;
            //Point leftTop=new Point(neiSuo, neiSuo);
            //Point  leftBottom=new Point(neiSuo, this.Height- neiSuo);
            //Point rightTop = new Point(this.Width- neiSuo, neiSuo);
            //Point rightBottom = new Point(this.Width - neiSuo, this.Height - neiSuo);


            SizeF sizeF = MGrap.MeasureString(TitleText, TitleFont);
            RectangleF rect = new RectangleF(neiSuo, sizeF.Height / 2 + neiSuo, this.Width - neiSuo * 2, this.Height - (sizeF.Height / 2 + neiSuo * 2));
            Rectangle rect2 = ToRectangle(rect);
            MGrap.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath gp = CreateRoundedRectanglePath(rect2, 6);

            MGrap.DrawPath(new Pen(BoderColor, BorderWidth), gp);


            SizeF backSize = new SizeF(sizeF.Width + neiSuo, sizeF.Height + neiSuo);
            MGrap.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            MGrap.FillRectangle(new SolidBrush(this.BackColor), new RectangleF(new PointF(this.Width / 2 - backSize.Width / 2, 0), backSize));
           
            MGrap.DrawString(TitleText, TitleFont, new SolidBrush(FontColor), new PointF(this.Width / 2 - sizeF.Width / 2, 0));



            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
        /// <summary>
        /// 用于画图纸的Graphics
        /// </summary>
        public Graphics MGrap = null;
        /// <summary>
        /// 用于画图纸的Image
        /// </summary>
        public Bitmap MImage = null;

        public Rectangle ToRectangle(RectangleF rectF)
        {
            return new Rectangle((int)rectF.X, (int)rectF.Y, (int)rectF.Width, (int)rectF.Height);
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
