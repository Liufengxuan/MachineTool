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
    public partial class VerDrill : BaseControl
    {
        [ToolboxItem(true)]
        public VerDrill()
        {
            InitializeComponent();
         
        }

        #region 变量

     
        private Color _Center11 = Color.Black;
        private Color _Center12 = Color.White;
      



     

     
        /// <summary>
        /// 中心渐变色1
        /// </summary>
        [Description("中心渐变色1"), Category("MT"), Browsable(true)]
        public Color Center11
        {
            get { return _Center11; }
            set { _Center11 = value; Invalidate(); }
        }
        /// <summary>
        ///  中心渐变色2
        /// </summary>
        [Description("中心渐变色2"), Category("MT"), Browsable(true)]
        public Color Center12
        {
            get { return _Center12; }
            set { _Center12 = value; Invalidate(); }
        }



       
   


       


        private Pen _p1;

        private Pen P1
        {
            get
            {
                if (_p1 == null)
                    _p1 = new Pen(GetMainColor(), 1.2f);
                return _p1;
            }
        }

        private Pen _p2;

        private Pen P2
        {
            get
            {
                if (_p2 == null)
                    _p2 = new Pen(GetMainColor(), 1.8f);
                return _p2;
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

        private StringFormat _drillNumFormat;

        public StringFormat DrillNumForMat
        {
            get
            {
                if (_drillNumFormat == null)
                {
                    _drillNumFormat= new StringFormat();
                    _drillNumFormat.Alignment= StringAlignment.Center;
                    _drillNumFormat.LineAlignment = StringAlignment.Center;
                }
               return _drillNumFormat;
            }
        }


        #endregion




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
                MImage = new Bitmap(this.Width-1, this.Height-1);
                MGrap = Graphics.FromImage(MImage);
            }

            //------------------------------------
            MGrap.Clear(this.BackColor);
            if (AntiAliasing)
                MGrap.SmoothingMode = SmoothingMode.AntiAlias;
        
            int width = this.Width - 1;
            int height = this.Height - 1;

            //外圈
            float w1= width ;
            float h1 = height ;
            RectangleF r1 = new RectangleF(0,0,w1,h1);
            GraphicsPath g = new GraphicsPath();
            g.AddEllipse(r1);
            this.Region = new Region(g);


            r1.Inflate(-1.5f, -1.5f);
            g = new GraphicsPath();
            g.AddEllipse(r1);
            MGrap.DrawPath(P1, g);
          
         

            //中心十字
            MGrap.DrawLine(P2, r1.Left, r1.Top + r1.Height / 2, r1.Right, r1.Top + r1.Height / 2);
            MGrap.DrawLine(P2, r1.Right-r1.Width/2, r1.Top, r1.Right - r1.Width / 2, r1.Bottom);


            w1 = width * 0.09f;
            h1 = height * 0.09f;
            RectangleF r2 = RectangleF.Inflate(r1, -w1, -h1);
            Brush b = new LinearGradientBrush(r1, GetStatusColor(), Center12, LinearGradientMode.ForwardDiagonal);
          // MGrap.DrawEllipse(P1, r2);
            MGrap.FillEllipse(b, r2);
          

            w1 = width * 0.09f;
            h1 = height * 0.09f;
            RectangleF r3 = RectangleF.Inflate(r2, -w1, -h1);
            Font f = new Font(this.Font.FontFamily, r1.Height/2f, FontStyle.Bold);
            MGrap.DrawString(DrillNumber, f, StringBrush, r1, DrillNumForMat);
            // MGrap.DrawRectangle(P1,r3.X,r3.Y,r3.Width,r3.Height);
            //------------------------------------
           //this.Region= BmpRgn(MImage, this.BackColor);
            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
        /// <summary>
        /// 取得一个图片中非透明色部分的区域。
        /// </summary>
        /// <param name="Picture">取其区域的图片。</param>
        /// <param name="TransparentColor">透明色。</param>
        /// <returns>图片中非透明色部分的区域</returns>
        private Region BmpRgn(Bitmap Picture, Color TransparentColor)
        {
            int nWidth = Picture.Width;
            int nHeight = Picture.Height;
            Region rgn = new Region();
            rgn.MakeEmpty();
            bool isTransRgn;//前一个点是否在透明区
            Color curColor;//当前点的颜色
            Rectangle curRect = new Rectangle();
            curRect.Height = 1;
            int x = 0, y = 0;
            //逐像素扫描这个图片，找出非透明色部分区域并合并起来。
            for (y = 0; y < nHeight; ++y)
            {
                isTransRgn = true;
                for (x = 0; x < nWidth; ++x)
                {
                    curColor = Picture.GetPixel(x, y);
                    if (curColor == TransparentColor || x == nWidth - 1)//如果遇到透明色或行尾
                    {
                        if (isTransRgn == false)//退出有效区
                        {
                            curRect.Width = x - curRect.X;
                            rgn.Union(curRect);
                        }
                    }
                    else//非透明色
                    {
                        if (isTransRgn == true)//进入有效区
                        {
                            curRect.X = x;
                            curRect.Y = y;
                        }
                    }//if curColor
                    isTransRgn = curColor == TransparentColor;
                }//for x
            }//for y
            return rgn;
        }

        private void VerDrill_Resize(object sender, EventArgs e)
        {
            this.Height = this.Width;
        }

        private void VerDrill_MouseEnter(object sender, EventArgs e)
        {
            MouseEnterStatus = true;
            Invalidate();
        }

        private void VerDrill_MouseLeave(object sender, EventArgs e)
        {
            MouseEnterStatus = false;
            Invalidate();
        }

        private void VerDrill_MouseDown(object sender, MouseEventArgs e)
        {
            MousePressStatus = true;
            Invalidate();
        }

        private void VerDrill_MouseUp(object sender, MouseEventArgs e)
        {
            MousePressStatus = false;
            Invalidate();
        }


     
       
    }
}
