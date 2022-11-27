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
            this.button1 = new System.Windows.Forms.Button();
            this.horDrill4 = new MachineTool.HorDrill();
            this.horDrill3 = new MachineTool.HorDrill();
            this.horDrill2 = new MachineTool.HorDrill();
            this.horDrill1 = new MachineTool.HorDrill();
            this.verDrill4 = new MachineTool.VerDrill();
            this.pressPlate3 = new MachineTool.PressPlate();
            this.pressWheel5 = new MachineTool.PressWheel();
            this.pressWheel4 = new MachineTool.PressWheel();
            this.pressWheel3 = new MachineTool.PressWheel();
            this.pressWheel2 = new MachineTool.PressWheel();
            this.pressWheel1 = new MachineTool.PressWheel();
            this.verDrill3 = new MachineTool.VerDrill();
            this.verDrill1 = new MachineTool.VerDrill();
            this.verDrill2 = new MachineTool.VerDrill();
            this.pressPlate2 = new MachineTool.PressPlate();
            this.pressPlate1 = new MachineTool.PressPlate();
            this.horDrill5 = new MachineTool.HorDrill();
            this.horDrill6 = new MachineTool.HorDrill();
            this.horDrill7 = new MachineTool.HorDrill();
            this.horDrill8 = new MachineTool.HorDrill();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // horDrill4
            // 
            this.horDrill4.ActColor = System.Drawing.Color.Gold;
            this.horDrill4.AntiAliasing = true;
            this.horDrill4.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill4.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Top;
            this.horDrill4.IsActivate = true;
            this.horDrill4.Location = new System.Drawing.Point(86, 250);
            this.horDrill4.Name = "horDrill4";
            this.horDrill4.PressColor = System.Drawing.Color.Tomato;
            this.horDrill4.Size = new System.Drawing.Size(39, 90);
            this.horDrill4.TabIndex = 30;
            this.horDrill4.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill3
            // 
            this.horDrill3.ActColor = System.Drawing.Color.Gold;
            this.horDrill3.AntiAliasing = true;
            this.horDrill3.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill3.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Bottom;
            this.horDrill3.IsActivate = false;
            this.horDrill3.Location = new System.Drawing.Point(86, 395);
            this.horDrill3.Name = "horDrill3";
            this.horDrill3.PressColor = System.Drawing.Color.Tomato;
            this.horDrill3.Size = new System.Drawing.Size(39, 73);
            this.horDrill3.TabIndex = 29;
            this.horDrill3.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill2
            // 
            this.horDrill2.ActColor = System.Drawing.Color.Gold;
            this.horDrill2.AntiAliasing = true;
            this.horDrill2.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill2.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Right;
            this.horDrill2.IsActivate = false;
            this.horDrill2.Location = new System.Drawing.Point(129, 345);
            this.horDrill2.Name = "horDrill2";
            this.horDrill2.PressColor = System.Drawing.Color.Tomato;
            this.horDrill2.Size = new System.Drawing.Size(73, 31);
            this.horDrill2.TabIndex = 28;
            this.horDrill2.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill1
            // 
            this.horDrill1.ActColor = System.Drawing.Color.Gold;
            this.horDrill1.AntiAliasing = true;
            this.horDrill1.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill1.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Left;
            this.horDrill1.IsActivate = false;
            this.horDrill1.Location = new System.Drawing.Point(2, 345);
            this.horDrill1.Name = "horDrill1";
            this.horDrill1.PressColor = System.Drawing.Color.Tomato;
            this.horDrill1.Size = new System.Drawing.Size(73, 31);
            this.horDrill1.TabIndex = 27;
            this.horDrill1.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill4
            // 
            this.verDrill4.ActColor = System.Drawing.Color.Gold;
            this.verDrill4.AntiAliasing = true;
            this.verDrill4.Center11 = System.Drawing.Color.Black;
            this.verDrill4.Center12 = System.Drawing.Color.White;
            this.verDrill4.EnterColor = System.Drawing.Color.SandyBrown;
            this.verDrill4.IsActivate = false;
            this.verDrill4.Location = new System.Drawing.Point(362, 23);
            this.verDrill4.Name = "verDrill4";
            this.verDrill4.PressColor = System.Drawing.Color.Tomato;
            this.verDrill4.Size = new System.Drawing.Size(44, 44);
            this.verDrill4.TabIndex = 26;
            this.verDrill4.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate3
            // 
            this.pressPlate3.ActColor = System.Drawing.Color.Gold;
            this.pressPlate3.AntiAliasing = true;
            this.pressPlate3.BackColor = System.Drawing.Color.Transparent;
            this.pressPlate3.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressPlate3.IsActivate = true;
            this.pressPlate3.LinesHor = false;
            this.pressPlate3.Location = new System.Drawing.Point(584, 27);
            this.pressPlate3.Name = "pressPlate3";
            this.pressPlate3.PressColor = System.Drawing.Color.Tomato;
            this.pressPlate3.Size = new System.Drawing.Size(133, 49);
            this.pressPlate3.TabIndex = 13;
            this.pressPlate3.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel5
            // 
            this.pressWheel5.ActColor = System.Drawing.Color.Gold;
            this.pressWheel5.AntiAliasing = true;
            this.pressWheel5.BackColor = System.Drawing.Color.Lavender;
            this.pressWheel5.C1 = System.Drawing.Color.Black;
            this.pressWheel5.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel5.IsActivate = false;
            this.pressWheel5.IsHor = false;
            this.pressWheel5.Location = new System.Drawing.Point(391, 345);
            this.pressWheel5.Name = "pressWheel5";
            this.pressWheel5.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel5.Size = new System.Drawing.Size(75, 103);
            this.pressWheel5.TabIndex = 12;
            this.pressWheel5.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel4
            // 
            this.pressWheel4.ActColor = System.Drawing.Color.Gold;
            this.pressWheel4.AntiAliasing = true;
            this.pressWheel4.C1 = System.Drawing.Color.Black;
            this.pressWheel4.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel4.IsActivate = false;
            this.pressWheel4.IsHor = false;
            this.pressWheel4.Location = new System.Drawing.Point(9, 12);
            this.pressWheel4.Name = "pressWheel4";
            this.pressWheel4.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel4.Size = new System.Drawing.Size(69, 91);
            this.pressWheel4.TabIndex = 11;
            this.pressWheel4.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel3
            // 
            this.pressWheel3.ActColor = System.Drawing.Color.Gold;
            this.pressWheel3.AntiAliasing = true;
            this.pressWheel3.C1 = System.Drawing.Color.Black;
            this.pressWheel3.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel3.IsActivate = true;
            this.pressWheel3.IsHor = false;
            this.pressWheel3.Location = new System.Drawing.Point(114, 12);
            this.pressWheel3.Name = "pressWheel3";
            this.pressWheel3.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel3.Size = new System.Drawing.Size(39, 55);
            this.pressWheel3.TabIndex = 10;
            this.pressWheel3.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel2
            // 
            this.pressWheel2.ActColor = System.Drawing.Color.Gold;
            this.pressWheel2.AntiAliasing = true;
            this.pressWheel2.C1 = System.Drawing.Color.Black;
            this.pressWheel2.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel2.IsActivate = true;
            this.pressWheel2.IsHor = true;
            this.pressWheel2.Location = new System.Drawing.Point(9, 109);
            this.pressWheel2.Name = "pressWheel2";
            this.pressWheel2.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel2.Size = new System.Drawing.Size(87, 44);
            this.pressWheel2.TabIndex = 9;
            this.pressWheel2.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel1
            // 
            this.pressWheel1.ActColor = System.Drawing.Color.Gold;
            this.pressWheel1.AntiAliasing = true;
            this.pressWheel1.C1 = System.Drawing.Color.Black;
            this.pressWheel1.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel1.IsActivate = false;
            this.pressWheel1.IsHor = true;
            this.pressWheel1.Location = new System.Drawing.Point(102, 100);
            this.pressWheel1.Name = "pressWheel1";
            this.pressWheel1.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel1.Size = new System.Drawing.Size(56, 29);
            this.pressWheel1.TabIndex = 8;
            this.pressWheel1.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill3
            // 
            this.verDrill3.ActColor = System.Drawing.Color.Gold;
            this.verDrill3.AntiAliasing = true;
            this.verDrill3.Center11 = System.Drawing.Color.Black;
            this.verDrill3.Center12 = System.Drawing.Color.White;
            this.verDrill3.EnterColor = System.Drawing.Color.SandyBrown;
            this.verDrill3.IsActivate = true;
            this.verDrill3.Location = new System.Drawing.Point(303, 73);
            this.verDrill3.Name = "verDrill3";
            this.verDrill3.PressColor = System.Drawing.Color.Tomato;
            this.verDrill3.Size = new System.Drawing.Size(44, 44);
            this.verDrill3.TabIndex = 7;
            this.verDrill3.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill1
            // 
            this.verDrill1.ActColor = System.Drawing.Color.Gold;
            this.verDrill1.AntiAliasing = true;
            this.verDrill1.BackColor = System.Drawing.Color.Lavender;
            this.verDrill1.Center11 = System.Drawing.Color.Black;
            this.verDrill1.Center12 = System.Drawing.Color.White;
            this.verDrill1.EnterColor = System.Drawing.Color.SandyBrown;
            this.verDrill1.IsActivate = false;
            this.verDrill1.Location = new System.Drawing.Point(771, 152);
            this.verDrill1.Name = "verDrill1";
            this.verDrill1.PressColor = System.Drawing.Color.Tomato;
            this.verDrill1.Size = new System.Drawing.Size(105, 105);
            this.verDrill1.TabIndex = 6;
            this.verDrill1.ThemeColor = System.Drawing.Color.Black;
            // 
            // verDrill2
            // 
            this.verDrill2.ActColor = System.Drawing.Color.Gold;
            this.verDrill2.AntiAliasing = true;
            this.verDrill2.Center11 = System.Drawing.Color.Black;
            this.verDrill2.Center12 = System.Drawing.Color.White;
            this.verDrill2.EnterColor = System.Drawing.Color.SandyBrown;
            this.verDrill2.IsActivate = false;
            this.verDrill2.Location = new System.Drawing.Point(303, 23);
            this.verDrill2.Name = "verDrill2";
            this.verDrill2.PressColor = System.Drawing.Color.Tomato;
            this.verDrill2.Size = new System.Drawing.Size(44, 44);
            this.verDrill2.TabIndex = 5;
            this.verDrill2.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate2
            // 
            this.pressPlate2.ActColor = System.Drawing.Color.Gold;
            this.pressPlate2.AntiAliasing = true;
            this.pressPlate2.BackColor = System.Drawing.Color.Lavender;
            this.pressPlate2.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressPlate2.IsActivate = false;
            this.pressPlate2.LinesHor = false;
            this.pressPlate2.Location = new System.Drawing.Point(484, 324);
            this.pressPlate2.Name = "pressPlate2";
            this.pressPlate2.PressColor = System.Drawing.Color.Tomato;
            this.pressPlate2.Size = new System.Drawing.Size(65, 162);
            this.pressPlate2.TabIndex = 3;
            this.pressPlate2.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressPlate1
            // 
            this.pressPlate1.ActColor = System.Drawing.Color.Gold;
            this.pressPlate1.AntiAliasing = true;
            this.pressPlate1.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressPlate1.IsActivate = false;
            this.pressPlate1.LinesHor = true;
            this.pressPlate1.Location = new System.Drawing.Point(500, 27);
            this.pressPlate1.Name = "pressPlate1";
            this.pressPlate1.PressColor = System.Drawing.Color.Tomato;
            this.pressPlate1.Size = new System.Drawing.Size(59, 150);
            this.pressPlate1.TabIndex = 2;
            this.pressPlate1.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill5
            // 
            this.horDrill5.ActColor = System.Drawing.Color.Gold;
            this.horDrill5.AntiAliasing = true;
            this.horDrill5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horDrill5.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill5.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Top;
            this.horDrill5.IsActivate = true;
            this.horDrill5.Location = new System.Drawing.Point(642, 262);
            this.horDrill5.Name = "horDrill5";
            this.horDrill5.PressColor = System.Drawing.Color.Tomato;
            this.horDrill5.Size = new System.Drawing.Size(39, 90);
            this.horDrill5.TabIndex = 34;
            this.horDrill5.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill6
            // 
            this.horDrill6.ActColor = System.Drawing.Color.Gold;
            this.horDrill6.AntiAliasing = true;
            this.horDrill6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horDrill6.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill6.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Bottom;
            this.horDrill6.IsActivate = false;
            this.horDrill6.Location = new System.Drawing.Point(642, 407);
            this.horDrill6.Name = "horDrill6";
            this.horDrill6.PressColor = System.Drawing.Color.Tomato;
            this.horDrill6.Size = new System.Drawing.Size(39, 73);
            this.horDrill6.TabIndex = 33;
            this.horDrill6.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill7
            // 
            this.horDrill7.ActColor = System.Drawing.Color.Gold;
            this.horDrill7.AntiAliasing = true;
            this.horDrill7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horDrill7.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill7.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Right;
            this.horDrill7.IsActivate = false;
            this.horDrill7.Location = new System.Drawing.Point(685, 357);
            this.horDrill7.Name = "horDrill7";
            this.horDrill7.PressColor = System.Drawing.Color.Tomato;
            this.horDrill7.Size = new System.Drawing.Size(73, 31);
            this.horDrill7.TabIndex = 32;
            this.horDrill7.ThemeColor = System.Drawing.Color.Black;
            // 
            // horDrill8
            // 
            this.horDrill8.ActColor = System.Drawing.Color.Gold;
            this.horDrill8.AntiAliasing = true;
            this.horDrill8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.horDrill8.EnterColor = System.Drawing.Color.SandyBrown;
            this.horDrill8.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Left;
            this.horDrill8.IsActivate = false;
            this.horDrill8.Location = new System.Drawing.Point(558, 357);
            this.horDrill8.Name = "horDrill8";
            this.horDrill8.PressColor = System.Drawing.Color.Tomato;
            this.horDrill8.Size = new System.Drawing.Size(73, 31);
            this.horDrill8.TabIndex = 31;
            this.horDrill8.ThemeColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1508, 587);
            this.Controls.Add(this.horDrill5);
            this.Controls.Add(this.horDrill6);
            this.Controls.Add(this.horDrill7);
            this.Controls.Add(this.horDrill8);
            this.Controls.Add(this.horDrill4);
            this.Controls.Add(this.horDrill3);
            this.Controls.Add(this.horDrill2);
            this.Controls.Add(this.horDrill1);
            this.Controls.Add(this.verDrill4);
            this.Controls.Add(this.pressPlate3);
            this.Controls.Add(this.pressWheel5);
            this.Controls.Add(this.pressWheel4);
            this.Controls.Add(this.pressWheel3);
            this.Controls.Add(this.pressWheel2);
            this.Controls.Add(this.pressWheel1);
            this.Controls.Add(this.verDrill3);
            this.Controls.Add(this.verDrill1);
            this.Controls.Add(this.verDrill2);
            this.Controls.Add(this.pressPlate2);
            this.Controls.Add(this.pressPlate1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private MachineTool.PressPlate pressPlate1;
        private MachineTool.PressPlate pressPlate2;
        private MachineTool.VerDrill verDrill2;
        private MachineTool.VerDrill verDrill1;
        private MachineTool.VerDrill verDrill3;
        private MachineTool.PressWheel pressWheel1;
        private MachineTool.PressWheel pressWheel2;
        private MachineTool.PressWheel pressWheel3;
        private MachineTool.PressWheel pressWheel4;
        private MachineTool.PressWheel pressWheel5;
        private MachineTool.PressPlate pressPlate3;
        private MachineTool.VerDrill verDrill4;
        private MachineTool.HorDrill horDrill1;
        private MachineTool.HorDrill horDrill2;
        private MachineTool.HorDrill horDrill3;
        private MachineTool.HorDrill horDrill4;
        private MachineTool.HorDrill horDrill5;
        private MachineTool.HorDrill horDrill6;
        private MachineTool.HorDrill horDrill7;
        private MachineTool.HorDrill horDrill8;
    }
}

