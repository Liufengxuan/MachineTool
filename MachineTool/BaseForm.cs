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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            this.MouseLeave += Main_Leave;
            this.MouseMove += Main_MouseMove;
            this.MinimumSize = new System.Drawing.Size(300, 150);
        }
        #region 拖拽调整窗体大小 
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            int i = 6;
            if (e.Button == MouseButtons.Left)//左键按下移动，拖拽调整大小
            {
                // MousePosition的参考点是屏幕的左上角，表示鼠标当前相对于屏幕左上角的坐标。this.Left和this.Top的参考点也是屏幕
                if (Cursor == Cursors.SizeNWSE) // 倾斜拖拽 
                {
                    // 改变窗体宽和高的代码，其宽高为鼠标屏幕位置减去窗体的Left，Top距离
                    this.Width = MousePosition.X - this.Left;
                    this.Height = MousePosition.Y - this.Top;
                }
                else if (Cursor == Cursors.SizeWE) // 水平拖拽
                {
                    Width = MousePosition.X - this.Left;
                }
                else if (Cursor == Cursors.SizeNS) // 垂直拖拽
                {
                    Height = MousePosition.Y - this.Top;
                }
            }

          
            if (e.Location.X >= this.Width - i && e.Location.Y > this.Height - i)
            {
                this.Cursor = Cursors.SizeNWSE; // 右下角 双向对角线光标
            }

            else if (e.Location.X >= this.Width - i)
            {
                this.Cursor = Cursors.SizeWE;
            }

            else if (e.Location.Y >= this.Height - i)
            {
                this.Cursor = Cursors.SizeNS; 

            }           
            else this.Cursor = Cursors.Arrow;

        }

        private void Main_Leave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;// 移出窗体变为正常
        }


    
   

        #endregion


    }
}
