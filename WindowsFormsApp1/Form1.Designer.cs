namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axisDisplay1 = new MachineTool.AxisDisplay();
            this.verDrill4 = new MachineTool.VerDrill();
            this.verDrill3 = new MachineTool.VerDrill();
            this.pressPlate3 = new MachineTool.PressPlate();
            this.statusButton2 = new MachineTool.StatusButton();
            this.statusButton1 = new MachineTool.StatusButton();
            this.verDrill2 = new MachineTool.VerDrill();
            this.verDrill1 = new MachineTool.VerDrill();
            this.pressWheel2 = new MachineTool.PressWheel();
            this.pressPlate2 = new MachineTool.PressPlate();
            this.pressWheel1 = new MachineTool.PressWheel();
            this.pressPlate1 = new MachineTool.PressPlate();
            this.horDrill4 = new MachineTool.HorDrill();
            this.horDrill3 = new MachineTool.HorDrill();
            this.horDrill2 = new MachineTool.HorDrill();
            this.horDrill1 = new MachineTool.HorDrill();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axisDisplay1
            // 
            this.axisDisplay1.ActColor = System.Drawing.Color.Lime;
            this.axisDisplay1.AntiAliasing = true;
            this.axisDisplay1.BackColor = System.Drawing.Color.Transparent;
            this.axisDisplay1.EnterColor = System.Drawing.Color.Peru;
            this.axisDisplay1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.axisDisplay1.IsActivate = false;
            this.axisDisplay1.Location = new System.Drawing.Point(582, 49);
            this.axisDisplay1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axisDisplay1.Name = "axisDisplay1";
            this.axisDisplay1.PressColor = System.Drawing.Color.Gold;
            this.axisDisplay1.Size = new System.Drawing.Size(338, 241);
            this.axisDisplay1.TabIndex = 15;
            this.axisDisplay1.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill4
            // 
            this.verDrill4.ActColor = System.Drawing.Color.Lime;
            this.verDrill4.AntiAliasing = true;
            this.verDrill4.Center11 = System.Drawing.Color.Black;
            this.verDrill4.Center12 = System.Drawing.Color.White;
            this.verDrill4.EnterColor = System.Drawing.Color.Peru;
            this.verDrill4.IsActivate = false;
            this.verDrill4.Location = new System.Drawing.Point(271, 350);
            this.verDrill4.Name = "verDrill4";
            this.verDrill4.PressColor = System.Drawing.Color.Gold;
            this.verDrill4.Size = new System.Drawing.Size(39, 39);
            this.verDrill4.TabIndex = 14;
            this.verDrill4.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill3
            // 
            this.verDrill3.ActColor = System.Drawing.Color.Lime;
            this.verDrill3.AntiAliasing = true;
            this.verDrill3.Center11 = System.Drawing.Color.Black;
            this.verDrill3.Center12 = System.Drawing.Color.White;
            this.verDrill3.EnterColor = System.Drawing.Color.Peru;
            this.verDrill3.IsActivate = false;
            this.verDrill3.Location = new System.Drawing.Point(212, 350);
            this.verDrill3.Name = "verDrill3";
            this.verDrill3.PressColor = System.Drawing.Color.Gold;
            this.verDrill3.Size = new System.Drawing.Size(39, 39);
            this.verDrill3.TabIndex = 13;
            this.verDrill3.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate3
            // 
            this.pressPlate3.ActColor = System.Drawing.Color.Lime;
            this.pressPlate3.AntiAliasing = true;
            this.pressPlate3.EnterColor = System.Drawing.Color.Peru;
            this.pressPlate3.IsActivate = true;
            this.pressPlate3.LinesHor = false;
            this.pressPlate3.Location = new System.Drawing.Point(198, 366);
            this.pressPlate3.Name = "pressPlate3";
            this.pressPlate3.PressColor = System.Drawing.Color.Gold;
            this.pressPlate3.Size = new System.Drawing.Size(140, 41);
            this.pressPlate3.TabIndex = 12;
            this.pressPlate3.ThemeColor = System.Drawing.Color.Black;
            // 
            // statusButton2
            // 
            this.statusButton2.ActColor = System.Drawing.Color.Lime;
            this.statusButton2.AntiAliasing = true;
            this.statusButton2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusButton2.borderColor = System.Drawing.Color.DarkGray;
            this.statusButton2.EnterColor = System.Drawing.Color.Peru;
            this.statusButton2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusButton2.IsActivate = true;
            this.statusButton2.Location = new System.Drawing.Point(212, 446);
            this.statusButton2.Margin = new System.Windows.Forms.Padding(4);
            this.statusButton2.Name = "statusButton2";
            this.statusButton2.PressColor = System.Drawing.Color.Gold;
            this.statusButton2.Size = new System.Drawing.Size(95, 43);
            this.statusButton2.TabIndex = 11;
            this.statusButton2.ThemeColor = System.Drawing.Color.Black;
            // 
            // statusButton1
            // 
            this.statusButton1.ActColor = System.Drawing.Color.Lime;
            this.statusButton1.AntiAliasing = true;
            this.statusButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusButton1.borderColor = System.Drawing.Color.DarkGray;
            this.statusButton1.EnterColor = System.Drawing.Color.Peru;
            this.statusButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusButton1.IsActivate = false;
            this.statusButton1.Location = new System.Drawing.Point(78, 446);
            this.statusButton1.Margin = new System.Windows.Forms.Padding(4);
            this.statusButton1.Name = "statusButton1";
            this.statusButton1.PressColor = System.Drawing.Color.Gold;
            this.statusButton1.Size = new System.Drawing.Size(95, 43);
            this.statusButton1.TabIndex = 10;
            this.statusButton1.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill2
            // 
            this.verDrill2.ActColor = System.Drawing.Color.Lime;
            this.verDrill2.AntiAliasing = true;
            this.verDrill2.Center11 = System.Drawing.Color.Black;
            this.verDrill2.Center12 = System.Drawing.Color.White;
            this.verDrill2.EnterColor = System.Drawing.Color.Peru;
            this.verDrill2.IsActivate = true;
            this.verDrill2.Location = new System.Drawing.Point(104, 322);
            this.verDrill2.Name = "verDrill2";
            this.verDrill2.PressColor = System.Drawing.Color.Gold;
            this.verDrill2.Size = new System.Drawing.Size(41, 41);
            this.verDrill2.TabIndex = 9;
            this.verDrill2.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill1
            // 
            this.verDrill1.ActColor = System.Drawing.Color.Lime;
            this.verDrill1.AntiAliasing = true;
            this.verDrill1.Center11 = System.Drawing.Color.Black;
            this.verDrill1.Center12 = System.Drawing.Color.White;
            this.verDrill1.EnterColor = System.Drawing.Color.Peru;
            this.verDrill1.IsActivate = false;
            this.verDrill1.Location = new System.Drawing.Point(207, 211);
            this.verDrill1.Name = "verDrill1";
            this.verDrill1.PressColor = System.Drawing.Color.Gold;
            this.verDrill1.Size = new System.Drawing.Size(39, 39);
            this.verDrill1.TabIndex = 8;
            this.verDrill1.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel2
            // 
            this.pressWheel2.ActColor = System.Drawing.Color.Lime;
            this.pressWheel2.AntiAliasing = true;
            this.pressWheel2.C1 = System.Drawing.Color.Black;
            this.pressWheel2.EnterColor = System.Drawing.Color.Peru;
            this.pressWheel2.IsActivate = false;
            this.pressWheel2.IsHor = false;
            this.pressWheel2.Location = new System.Drawing.Point(401, 202);
            this.pressWheel2.Name = "pressWheel2";
            this.pressWheel2.PressColor = System.Drawing.Color.Gold;
            this.pressWheel2.Size = new System.Drawing.Size(36, 52);
            this.pressWheel2.TabIndex = 7;
            this.pressWheel2.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate2
            // 
            this.pressPlate2.ActColor = System.Drawing.Color.Lime;
            this.pressPlate2.AntiAliasing = true;
            this.pressPlate2.EnterColor = System.Drawing.Color.Peru;
            this.pressPlate2.IsActivate = false;
            this.pressPlate2.LinesHor = true;
            this.pressPlate2.Location = new System.Drawing.Point(176, 202);
            this.pressPlate2.Name = "pressPlate2";
            this.pressPlate2.PressColor = System.Drawing.Color.Gold;
            this.pressPlate2.Size = new System.Drawing.Size(59, 112);
            this.pressPlate2.TabIndex = 6;
            this.pressPlate2.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel1
            // 
            this.pressWheel1.ActColor = System.Drawing.Color.Lime;
            this.pressWheel1.AntiAliasing = true;
            this.pressWheel1.C1 = System.Drawing.Color.Black;
            this.pressWheel1.EnterColor = System.Drawing.Color.Peru;
            this.pressWheel1.IsActivate = false;
            this.pressWheel1.IsHor = true;
            this.pressWheel1.Location = new System.Drawing.Point(477, 103);
            this.pressWheel1.Name = "pressWheel1";
            this.pressWheel1.PressColor = System.Drawing.Color.Gold;
            this.pressWheel1.Size = new System.Drawing.Size(51, 34);
            this.pressWheel1.TabIndex = 5;
            this.pressWheel1.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate1
            // 
            this.pressPlate1.ActColor = System.Drawing.Color.Lime;
            this.pressPlate1.AntiAliasing = true;
            this.pressPlate1.EnterColor = System.Drawing.Color.Peru;
            this.pressPlate1.IsActivate = true;
            this.pressPlate1.LinesHor = true;
            this.pressPlate1.Location = new System.Drawing.Point(271, 74);
            this.pressPlate1.Name = "pressPlate1";
            this.pressPlate1.PressColor = System.Drawing.Color.Gold;
            this.pressPlate1.Size = new System.Drawing.Size(58, 139);
            this.pressPlate1.TabIndex = 4;
            this.pressPlate1.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill4
            // 
            this.horDrill4.ActColor = System.Drawing.Color.Lime;
            this.horDrill4.AntiAliasing = true;
            this.horDrill4.EnterColor = System.Drawing.Color.Peru;
            this.horDrill4.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Right;
            this.horDrill4.IsActivate = false;
            this.horDrill4.Location = new System.Drawing.Point(106, 99);
            this.horDrill4.Name = "horDrill4";
            this.horDrill4.PressColor = System.Drawing.Color.Gold;
            this.horDrill4.Size = new System.Drawing.Size(67, 38);
            this.horDrill4.TabIndex = 3;
            this.horDrill4.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill3
            // 
            this.horDrill3.ActColor = System.Drawing.Color.Lime;
            this.horDrill3.AntiAliasing = true;
            this.horDrill3.EnterColor = System.Drawing.Color.Peru;
            this.horDrill3.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Top;
            this.horDrill3.IsActivate = false;
            this.horDrill3.Location = new System.Drawing.Point(38, 58);
            this.horDrill3.Name = "horDrill3";
            this.horDrill3.PressColor = System.Drawing.Color.Gold;
            this.horDrill3.Size = new System.Drawing.Size(34, 79);
            this.horDrill3.TabIndex = 2;
            this.horDrill3.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill2
            // 
            this.horDrill2.ActColor = System.Drawing.Color.Lime;
            this.horDrill2.AntiAliasing = true;
            this.horDrill2.EnterColor = System.Drawing.Color.Peru;
            this.horDrill2.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Bottom;
            this.horDrill2.IsActivate = true;
            this.horDrill2.Location = new System.Drawing.Point(41, 152);
            this.horDrill2.Name = "horDrill2";
            this.horDrill2.PressColor = System.Drawing.Color.Gold;
            this.horDrill2.Size = new System.Drawing.Size(48, 94);
            this.horDrill2.TabIndex = 1;
            this.horDrill2.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill1
            // 
            this.horDrill1.ActColor = System.Drawing.Color.Lime;
            this.horDrill1.AntiAliasing = true;
            this.horDrill1.EnterColor = System.Drawing.Color.Peru;
            this.horDrill1.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Left;
            this.horDrill1.IsActivate = false;
            this.horDrill1.Location = new System.Drawing.Point(78, 34);
            this.horDrill1.Name = "horDrill1";
            this.horDrill1.PressColor = System.Drawing.Color.Gold;
            this.horDrill1.Size = new System.Drawing.Size(67, 38);
            this.horDrill1.TabIndex = 0;
            this.horDrill1.ThemeColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(932, 555);
            this.Controls.Add(this.axisDisplay1);
            this.Controls.Add(this.verDrill4);
            this.Controls.Add(this.verDrill3);
            this.Controls.Add(this.pressPlate3);
            this.Controls.Add(this.statusButton2);
            this.Controls.Add(this.statusButton1);
            this.Controls.Add(this.verDrill2);
            this.Controls.Add(this.verDrill1);
            this.Controls.Add(this.pressWheel2);
            this.Controls.Add(this.pressPlate2);
            this.Controls.Add(this.pressWheel1);
            this.Controls.Add(this.pressPlate1);
            this.Controls.Add(this.horDrill4);
            this.Controls.Add(this.horDrill3);
            this.Controls.Add(this.horDrill2);
            this.Controls.Add(this.horDrill1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MachineTool.HorDrill horDrill1;
        private MachineTool.HorDrill horDrill2;
        private MachineTool.HorDrill horDrill3;
        private MachineTool.HorDrill horDrill4;
        private MachineTool.PressPlate pressPlate1;
        private MachineTool.PressWheel pressWheel1;
        private MachineTool.PressPlate pressPlate2;
        private MachineTool.PressWheel pressWheel2;
        private MachineTool.VerDrill verDrill1;
        private MachineTool.VerDrill verDrill2;
        private MachineTool.StatusButton statusButton1;
        private MachineTool.StatusButton statusButton2;
        private MachineTool.PressPlate pressPlate3;
        private MachineTool.VerDrill verDrill3;
        private MachineTool.VerDrill verDrill4;
        private MachineTool.AxisDisplay axisDisplay1;
    }
}

