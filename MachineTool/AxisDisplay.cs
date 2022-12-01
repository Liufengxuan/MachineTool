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
    public partial class AxisDisplay : BaseControl
    {
        public AxisDisplay()
        {
            InitializeComponent();

          
        }
        public void AddTestData()
        {
            DataColumn dc1 = new DataColumn("轴");
            Data.Columns.Add(dc1);
            DataColumn dc2 = new DataColumn("工件坐标");
            Data.Columns.Add(dc2);
            DataColumn dc3 = new DataColumn("机械坐标");
            Data.Columns.Add(dc3);

            Random rdm = new Random();

            for (int i = 0; i < 10; i++)
            {
                DataRow d = Data.NewRow();
                d[0] = "X" + (i * 10).ToString();
                d[1] = rdm.Next(10, 2300).ToString("f3");
                d[2] = rdm.Next(10, 2300).ToString("f3");
                Data.Rows.Add(d);
            }
        }

        private DataTable _Data = new DataTable();
        private Color _TitleColor=Color.Red ;
        private Color _ContentColor=Color.Black;


        [Description("标题颜色"), Category("MT"), Browsable(true)]
        public Color TitleColor
        {
            get { return _TitleColor; }
            set { _TitleColor = value; }
        }

        [Description("内容颜色"), Category("MT"), Browsable(true)]
        public Color ContentColor
        {
            get { return _ContentColor; }
            set { _ContentColor = value; }
        }

        public DataTable Data
        {
            get { return _Data; }
           
        }


        private SolidBrush _brush1;

        public SolidBrush Brush1
        {
            get {

                if (_brush1 == null || _brush1.Color != TitleColor)
                {
                    _brush1 = new SolidBrush(TitleColor);
                }
                return _brush1;
            }
        }

        private SolidBrush _brush2;

        public SolidBrush Brush2
        {
            get
            {

                if (_brush2 == null || _brush2.Color != ContentColor)
                {
                    _brush2 = new SolidBrush(ContentColor);
                }
                return _brush2;
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

            //------------------------------------
            MGrap.Clear(this.BackColor);
            if (AntiAliasing)
                MGrap.SmoothingMode = SmoothingMode.AntiAlias;

            int width = this.Width;
            int height = this.Height;
            Rectangle mainRec = new Rectangle(0, 0, width-1, height-1);
            mainRec.Inflate(-5, -5);
            if (Data.Columns.Count>0)
            {
                int xDistance = mainRec.Width / Data.Columns.Count;
                int yDistance = Convert.ToInt32(GetFontSize(MGrap, this.Font, "A长9").Height) + 3;
                for (int i = 0; i < Data.Rows.Count; i++)
                {

                    if (i == 0)
                    {
                        for (int j = 0; j < Data.Columns.Count; j++)
                        {
                            MGrap.DrawString(Data.Columns[j].ColumnName, Font, Brush1, new Point(mainRec.X + j * xDistance, mainRec.Y));
                        }
                    }
                    else
                    {
                        for (int j = 0; j < Data.Columns.Count; j++)
                        {
                            MGrap.DrawString(Data.Rows[i][j].ToString(), Font, Brush2, new Point(mainRec.X + j * xDistance, mainRec.Y + i * yDistance));
                        }
                    }

                }
            }

            //------------------------------------

            e.Graphics.DrawImage(MImage, 0, 0);
            base.OnPaint(e);
        }
    }
}
