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
    public partial class NavBar : Panel
    {
        public NavBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MouseDown += Form_MouseDown;
            this.MouseUp += Form_MouseUp;
            this.MouseMove += Form_MouseMove;
            this.MinimumSize = new System.Drawing.Size(10, 10);
        }


        //private int _style = 1;
        //[Description("风格"), Category("NavBar"), Browsable(true)]
        //public int Style
        //{
        //    get { return _style; }
        //    set { _style = value; this.Invalidate(); }
        //}

        private PointF[] _borderPath;
        [Description("边框路径"), Category("NavBar"), Browsable(true)]
        public PointF[] BorderPath
        {
            get { return _borderPath; }
            set { _borderPath = value; this.Invalidate(); }
        }

        private Color _mainColor = Color.LightSkyBlue;
        [Description("主色调"), Category("NavBar"), Browsable(true)]
        public Color MainColor
        {
            get
            {
                if (UseThemeColor)
                {
                    return BaseControl._ThemeColor;
                }
                return _mainColor;
            }
            set { _mainColor = value; this.Invalidate(); }
        }
        private Color _mainColor2 = Color.Transparent;
        [Description("主色调2"), Category("NavBar"), Browsable(true)]
        public Color MainColor2
        {
            get { return _mainColor2; }
            set { _mainColor2 = value; this.Invalidate(); }
        }

  





        private PointF[] _pathGradient = new PointF[2] { new PointF(0.5f, 0.5f), new PointF(0.85f, 0.1f) };
        [DisplayName("渐变色参数"), Category("NavBar"), Description("渐变色参数[0]:渐变色中心点,[1]:过度色焦点"), Browsable(true)]
        public PointF[] PathGradientParam
        {
            get { return _pathGradient; }
            set { _pathGradient = value; this.Invalidate(); }
        }




        private Color _BorderColor = Color.Red;
        [Description("边框颜色"), Category("NavBar"), Browsable(true)]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set { _BorderColor = value; this.Invalidate(); }
        }
        private bool _DrawBorder =true;
        [Description("绘制边框"), Category("NavBar"), Browsable(true)]
        public bool DrawBorder
        {
            get { return _DrawBorder; }
            set { _DrawBorder = value; this.Invalidate(); }
        }

        [Description("拖动"), Category("NavBar"), Browsable(true)]
        public bool Tuodong
        {
            get { return _DrawBorder; }
            set { _DrawBorder = value; this.Invalidate(); }
        }

        private bool _UseThemeColor = true;
        [Description("是否使用全局主题颜色"), Category("NavBar"), Browsable(true)]
        public bool UseThemeColor
        {
            get
            {
                return _UseThemeColor;
            }
            set { _UseThemeColor = value; Invalidate(); }
        }

        /// <summary>
        /// 用于画图纸的Graphics
        /// </summary>
        public Graphics MGrap = null;
        /// <summary>
        /// 用于画图纸的Image
        /// </summary>
        public Bitmap MImage = null;

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


            GraphicsPath gp = new GraphicsPath();
            List<PointF> p = new List<PointF>();
            if (this.BorderPath!=null&&this.BorderPath.Length > 4)
            {
                foreach (var item in this.BorderPath)
                {
                    p.Add(new PointF(item.X * (this.Width - 1), item.Y * (this.Height - 1)));
                }
                gp.AddLines(p.ToArray());
            }
            else
            {
                gp.AddRectangle(new RectangleF(0,0,this.Width-2f, this.Height - 2f));
            }
          
          


          
            MGrap.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //this.Region = new Region(gp);

            PathGradientBrush pgb = new PathGradientBrush(gp);
            pgb.CenterColor = MainColor;
            pgb.CenterPoint = new PointF(this.Width * PathGradientParam[0].X, this.Height * PathGradientParam[0].Y);
            pgb.FocusScales = PathGradientParam[1];
            pgb.SurroundColors = new Color[] { Color.FromArgb(100, MainColor2) };
            MGrap.FillPath(pgb, gp);

            if (DrawBorder)
            {
                MGrap.DrawPath(new Pen(BorderColor, 0.5f), gp);
            }


            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);

        }





        bool isMouseDown = false;
        Point currentFormLocation = new Point(); //当前窗体位置
        Point currentMouseOffset = new Point(); //当前鼠标的按下位置


        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                currentFormLocation = this.Parent.Location;
                currentMouseOffset = Control.MousePosition;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {


            if (isMouseDown == true)
                isMouseDown = false;
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {

            if (isMouseDown)
            {
                int rangeX = 0, rangeY = 0; //计算当前鼠标光标的位移，让窗体进行相同大小的位移
                Point pt = Control.MousePosition;
                rangeX = currentMouseOffset.X - pt.X;
                rangeY = currentMouseOffset.Y - pt.Y;
                this.Parent.Location= new Point(currentFormLocation.X - rangeX, currentFormLocation.Y - rangeY);
            }
        }
        

    }
}
