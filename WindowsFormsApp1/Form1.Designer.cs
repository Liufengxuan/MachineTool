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
            this.pressWheel3 = new MachineTool.PressWheel();
            this.pressWheel2 = new MachineTool.PressWheel();
            this.pressWheel1 = new MachineTool.PressWheel();
            this.verDrill3 = new MachineTool.VerDrill();
            this.verDrill1 = new MachineTool.VerDrill();
            this.verDrill2 = new MachineTool.VerDrill();
            this.pressPlate2 = new MachineTool.PressPlate();
            this.pressPlate1 = new MachineTool.PressPlate();
            this.pressWheel4 = new MachineTool.PressWheel();
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
            // pressWheel3
            // 
            this.pressWheel3.ActColor = System.Drawing.Color.Gold;
            this.pressWheel3.AntiAliasing = true;
            this.pressWheel3.C1 = System.Drawing.Color.Black;
            this.pressWheel3.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel3.IsActivate = true;
            this.pressWheel3.IsHor = false;
            this.pressWheel3.Location = new System.Drawing.Point(138, 12);
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
            this.pressWheel2.Location = new System.Drawing.Point(138, 135);
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
            this.pressWheel1.Location = new System.Drawing.Point(151, 85);
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
            this.verDrill3.Location = new System.Drawing.Point(462, 135);
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
            this.verDrill1.Center11 = System.Drawing.Color.Black;
            this.verDrill1.Center12 = System.Drawing.Color.White;
            this.verDrill1.EnterColor = System.Drawing.Color.SandyBrown;
            this.verDrill1.IsActivate = false;
            this.verDrill1.Location = new System.Drawing.Point(462, 35);
            this.verDrill1.Name = "verDrill1";
            this.verDrill1.PressColor = System.Drawing.Color.Tomato;
            this.verDrill1.Size = new System.Drawing.Size(44, 44);
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
            this.verDrill2.Location = new System.Drawing.Point(462, 85);
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
            this.pressPlate2.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressPlate2.IsActivate = true;
            this.pressPlate2.LinesHor = false;
            this.pressPlate2.Location = new System.Drawing.Point(462, 258);
            this.pressPlate2.Name = "pressPlate2";
            this.pressPlate2.PressColor = System.Drawing.Color.Tomato;
            this.pressPlate2.Size = new System.Drawing.Size(188, 50);
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
            this.pressPlate1.Location = new System.Drawing.Point(427, 27);
            this.pressPlate1.Name = "pressPlate1";
            this.pressPlate1.PressColor = System.Drawing.Color.Tomato;
            this.pressPlate1.Size = new System.Drawing.Size(59, 150);
            this.pressPlate1.TabIndex = 2;
            this.pressPlate1.ThemeColor = System.Drawing.Color.Black;
            // 
            // pressWheel4
            // 
            this.pressWheel4.ActColor = System.Drawing.Color.Gold;
            this.pressWheel4.AntiAliasing = true;
            this.pressWheel4.C1 = System.Drawing.Color.Black;
            this.pressWheel4.EnterColor = System.Drawing.Color.SandyBrown;
            this.pressWheel4.IsActivate = false;
            this.pressWheel4.IsHor = false;
            this.pressWheel4.Location = new System.Drawing.Point(46, 12);
            this.pressWheel4.Name = "pressWheel4";
            this.pressWheel4.PressColor = System.Drawing.Color.Tomato;
            this.pressWheel4.Size = new System.Drawing.Size(69, 91);
            this.pressWheel4.TabIndex = 11;
            this.pressWheel4.ThemeColor = System.Drawing.Color.Black;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 425);
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
    }
}

