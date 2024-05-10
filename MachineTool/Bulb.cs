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
    public partial class Bulb : BaseControl
    {

        public Bulb()
        {
            InitializeComponent();
        }


        private Color _stateColor1 = Color.Lime;
        [Description("状态一颜色"), Category("bulb"), Browsable(true)]
        public Color StateColor1
        {
            get { return _stateColor1; }
            set { _stateColor1 = value; this.Invalidate(); }
        }
        private Color _stateColor2 = Color.Red;
        [Description("状态二颜色"), Category("bulb"), Browsable(true)]
        public Color StateColor2
        {
            get { return _stateColor2; }
            set { _stateColor2 = value; this.Invalidate(); }
        }


        private bool _currentState = true;
        [Description("当前状态"), Category("bulb"), Browsable(true)]
        public bool CurrentState
        {
            get { return _currentState; }
            set { _currentState = value; this.Invalidate(); }
        }

        private string _content = "abc123汉";
        [Description("文字"), Category("bulb"), Browsable(true)]
        public string Content
        {
            get { return _content; }
            set { _content = value; this.Invalidate(); }
        }


        private DireEnum _textDire = DireEnum.left;
        [Description("文字方向"), Category("bulb"), Browsable(true)]
        public DireEnum TextDire
        {
            get { return _textDire; }
            set { _textDire = value; this.Invalidate(); }
        }


        private DireEnum _blubDire = DireEnum.left;
        [Description("灯泡相对于文字的方向"), Category("bulb"), Browsable(true)]
        public DireEnum BlubDire
        {
            get { return _blubDire; }
            set { _blubDire = value; this.Invalidate(); }
        }

        public enum DireEnum
        {
            left = 0, right = 1
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

            SolidBrush Brush1 = new SolidBrush(this.ForeColor);
            SizeF stringSize = MGrap.MeasureString(Content, this.Font);
            SizeF elliSizeF = new SizeF(this.Height - 3, this.Height - 3);
            Color color = CurrentState ? StateColor1 : StateColor2;

            if (TextDire == DireEnum.right)
            {
                if (BlubDire == DireEnum.right)
                {
                    MGrap.DrawString(Content, Font, Brush1, this.Width - stringSize.Width - 5 - elliSizeF.Width, this.Height / 2 - stringSize.Height / 2);
                    PointF elliPointF = new PointF(this.Width - elliSizeF.Width - 5, this.Height / 2 - elliSizeF.Height / 2);
                    RectangleF elliRectF = new RectangleF(elliPointF, elliSizeF);
                    Brush b = new LinearGradientBrush(elliRectF, color, Color.White, LinearGradientMode.ForwardDiagonal);
                    MGrap.FillEllipse(b, new RectangleF(elliPointF, elliSizeF));
                }
                else
                {
                    MGrap.DrawString(Content, Font, Brush1, this.Width - stringSize.Width - 5, this.Height / 2 - stringSize.Height / 2);
                    PointF elliPointF = new PointF(this.Width - elliSizeF.Width - 5 - stringSize.Width, this.Height / 2 - elliSizeF.Height / 2);
                    RectangleF elliRectF = new RectangleF(elliPointF, elliSizeF);
                    Brush b = new LinearGradientBrush(elliRectF, color, Color.White, LinearGradientMode.ForwardDiagonal);
                    MGrap.FillEllipse(b, new RectangleF(elliPointF, elliSizeF));
                }


            }
            else
            {
                if (BlubDire == DireEnum.right)
                {
                    MGrap.DrawString(Content, Font, Brush1, 5, this.Height / 2 - stringSize.Height / 2);
                    PointF elliPointF = new PointF(stringSize.Width + 5, this.Height / 2 - elliSizeF.Height / 2);
                    RectangleF elliRectF = new RectangleF(elliPointF, elliSizeF);
                    //MGrap.DrawEllipse(new Pen(Color.Red),new RectangleF(elliPointF,elliSizeF));
                    Brush b = new LinearGradientBrush(elliRectF, color, Color.White, LinearGradientMode.ForwardDiagonal);
                    MGrap.FillEllipse(b, new RectangleF(elliPointF, elliSizeF));

                }
                else
                {
                    MGrap.DrawString(Content, Font, Brush1, elliSizeF.Width + 5, this.Height / 2 - stringSize.Height / 2);
                    PointF elliPointF = new PointF(5, this.Height / 2 - elliSizeF.Height / 2);
                    RectangleF elliRectF = new RectangleF(elliPointF, elliSizeF);
                    //MGrap.DrawEllipse(new Pen(Color.Red),new RectangleF(elliPointF,elliSizeF));
                    Brush b = new LinearGradientBrush(elliRectF, color, Color.White, LinearGradientMode.ForwardDiagonal);
                    MGrap.FillEllipse(b, new RectangleF(elliPointF, elliSizeF));
                }


            }


            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }

    }
}
