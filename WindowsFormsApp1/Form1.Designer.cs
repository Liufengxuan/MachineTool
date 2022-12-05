namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MachineTool.ButtonInfo buttonInfo1 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo2 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo3 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo4 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo5 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo6 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo7 = new MachineTool.ButtonInfo();
            MachineTool.ButtonInfo buttonInfo8 = new MachineTool.ButtonInfo();
            this.verDrill1 = new MachineTool.VerDrill();
            this.axisDisplay1 = new MachineTool.AxisDisplay();
            this.horDrill1 = new MachineTool.HorDrill();
            this.pressPlate1 = new MachineTool.PressPlate();
            this.pressWheel1 = new MachineTool.PressWheel();
            this.statusButton1 = new MachineTool.StatusButton();
            this.horDrill2 = new MachineTool.HorDrill();
            this.pressWheel2 = new MachineTool.PressWheel();
            this.SuspendLayout();
            // 
            // verDrill1
            // 
            this.verDrill1.ActColor = System.Drawing.Color.Lime;
            this.verDrill1.AntiAliasing = true;
            this.verDrill1.Center11 = System.Drawing.Color.Black;
            this.verDrill1.Center12 = System.Drawing.Color.White;
            this.verDrill1.EnterColor = System.Drawing.Color.Peru;
            buttonInfo1.Command1 = null;
            buttonInfo1.Command2 = "55555";
            buttonInfo1.Command3 = null;
            buttonInfo1.Command4 = null;
            buttonInfo1.Command5 = null;
            buttonInfo1.Command6 = null;
            buttonInfo1.ID = "VerDrill";
            this.verDrill1.Info = buttonInfo1;
            this.verDrill1.IsActivate = false;
            this.verDrill1.Location = new System.Drawing.Point(347, 143);
            this.verDrill1.MainColor = System.Drawing.Color.Black;
            this.verDrill1.Name = "verDrill1";
            this.verDrill1.PressColor = System.Drawing.Color.Gold;
            this.verDrill1.Size = new System.Drawing.Size(150, 150);
            this.verDrill1.TabIndex = 0;
            this.verDrill1.ThemeColor = System.Drawing.Color.Black;
            this.verDrill1.UseThemeColor = true;
            // 
            // axisDisplay1
            // 
            this.axisDisplay1.ActColor = System.Drawing.Color.Lime;
            this.axisDisplay1.AntiAliasing = true;
            this.axisDisplay1.ContentColor = System.Drawing.Color.Black;
            this.axisDisplay1.EnterColor = System.Drawing.Color.Peru;
            buttonInfo2.Command1 = null;
            buttonInfo2.Command2 = null;
            buttonInfo2.Command3 = null;
            buttonInfo2.Command4 = null;
            buttonInfo2.Command5 = null;
            buttonInfo2.Command6 = null;
            buttonInfo2.ID = "AxisDisplay";
            this.axisDisplay1.Info = buttonInfo2;
            this.axisDisplay1.IsActivate = false;
            this.axisDisplay1.Location = new System.Drawing.Point(27, 33);
            this.axisDisplay1.MainColor = System.Drawing.Color.Black;
            this.axisDisplay1.Name = "axisDisplay1";
            this.axisDisplay1.PressColor = System.Drawing.Color.Gold;
            this.axisDisplay1.Size = new System.Drawing.Size(177, 143);
            this.axisDisplay1.TabIndex = 1;
            this.axisDisplay1.ThemeColor = System.Drawing.Color.Black;
            this.axisDisplay1.TitleColor = System.Drawing.Color.Red;
            this.axisDisplay1.UseThemeColor = true;
            // 
            // horDrill1
            // 
            this.horDrill1.ActColor = System.Drawing.Color.Lime;
            this.horDrill1.AntiAliasing = true;
            this.horDrill1.EnterColor = System.Drawing.Color.Peru;
            this.horDrill1.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Left;
            buttonInfo3.Command1 = null;
            buttonInfo3.Command2 = null;
            buttonInfo3.Command3 = null;
            buttonInfo3.Command4 = null;
            buttonInfo3.Command5 = null;
            buttonInfo3.Command6 = null;
            buttonInfo3.ID = "horDrill1";
            this.horDrill1.Info = buttonInfo3;
            this.horDrill1.IsActivate = false;
            this.horDrill1.Location = new System.Drawing.Point(598, 131);
            this.horDrill1.MainColor = System.Drawing.Color.Black;
            this.horDrill1.Name = "horDrill1";
            this.horDrill1.PressColor = System.Drawing.Color.Gold;
            this.horDrill1.Size = new System.Drawing.Size(102, 61);
            this.horDrill1.TabIndex = 2;
            this.horDrill1.ThemeColor = System.Drawing.Color.Black;
            this.horDrill1.UseThemeColor = true;
            // 
            // pressPlate1
            // 
            this.pressPlate1.ActColor = System.Drawing.Color.Lime;
            this.pressPlate1.AntiAliasing = true;
            this.pressPlate1.EnterColor = System.Drawing.Color.Peru;
            buttonInfo4.Command1 = null;
            buttonInfo4.Command2 = null;
            buttonInfo4.Command3 = null;
            buttonInfo4.Command4 = null;
            buttonInfo4.Command5 = null;
            buttonInfo4.Command6 = null;
            buttonInfo4.ID = "pressPlate1";
            this.pressPlate1.Info = buttonInfo4;
            this.pressPlate1.IsActivate = false;
            this.pressPlate1.LinesHor = true;
            this.pressPlate1.Location = new System.Drawing.Point(188, 288);
            this.pressPlate1.MainColor = System.Drawing.Color.Black;
            this.pressPlate1.Name = "pressPlate1";
            this.pressPlate1.PressColor = System.Drawing.Color.Gold;
            this.pressPlate1.Size = new System.Drawing.Size(150, 150);
            this.pressPlate1.TabIndex = 3;
            this.pressPlate1.ThemeColor = System.Drawing.Color.Black;
            this.pressPlate1.UseThemeColor = true;
            // 
            // pressWheel1
            // 
            this.pressWheel1.ActColor = System.Drawing.Color.Lime;
            this.pressWheel1.AntiAliasing = true;
            this.pressWheel1.C1 = System.Drawing.Color.Black;
            this.pressWheel1.EnterColor = System.Drawing.Color.Peru;
            buttonInfo5.Command1 = null;
            buttonInfo5.Command2 = null;
            buttonInfo5.Command3 = null;
            buttonInfo5.Command4 = null;
            buttonInfo5.Command5 = null;
            buttonInfo5.Command6 = null;
            buttonInfo5.ID = "PressWheel";
            this.pressWheel1.Info = buttonInfo5;
            this.pressWheel1.IsActivate = false;
            this.pressWheel1.IsHor = true;
            this.pressWheel1.Location = new System.Drawing.Point(559, 288);
            this.pressWheel1.MainColor = System.Drawing.Color.Black;
            this.pressWheel1.Name = "pressWheel1";
            this.pressWheel1.PressColor = System.Drawing.Color.Gold;
            this.pressWheel1.Size = new System.Drawing.Size(88, 48);
            this.pressWheel1.TabIndex = 4;
            this.pressWheel1.ThemeColor = System.Drawing.Color.Black;
            this.pressWheel1.UseThemeColor = true;
            // 
            // statusButton1
            // 
            this.statusButton1.ActColor = System.Drawing.Color.Lime;
            this.statusButton1.AntiAliasing = true;
            this.statusButton1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.statusButton1.borderColor = System.Drawing.Color.DarkGray;
            this.statusButton1.EnterColor = System.Drawing.Color.Peru;
            this.statusButton1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            buttonInfo6.Command1 = null;
            buttonInfo6.Command2 = null;
            buttonInfo6.Command3 = null;
            buttonInfo6.Command4 = null;
            buttonInfo6.Command5 = null;
            buttonInfo6.Command6 = null;
            buttonInfo6.ID = "StatusButton";
            this.statusButton1.Info = buttonInfo6;
            this.statusButton1.IsActivate = false;
            this.statusButton1.Location = new System.Drawing.Point(559, 72);
            this.statusButton1.MainColor = System.Drawing.Color.Black;
            this.statusButton1.Margin = new System.Windows.Forms.Padding(4);
            this.statusButton1.MText = "正AbCd456";
            this.statusButton1.Name = "statusButton1";
            this.statusButton1.PressColor = System.Drawing.Color.Gold;
            this.statusButton1.Size = new System.Drawing.Size(131, 58);
            this.statusButton1.TabIndex = 5;
            this.statusButton1.ThemeColor = System.Drawing.Color.Black;
            this.statusButton1.UseThemeColor = true;
            // 
            // horDrill2
            // 
            this.horDrill2.ActColor = System.Drawing.Color.Lime;
            this.horDrill2.AntiAliasing = true;
            this.horDrill2.EnterColor = System.Drawing.Color.Peru;
            this.horDrill2.HorDrillType = MachineTool.HorDrill.HorDrillTypeEnum.Bottom;
            buttonInfo7.Command1 = null;
            buttonInfo7.Command2 = null;
            buttonInfo7.Command3 = null;
            buttonInfo7.Command4 = null;
            buttonInfo7.Command5 = null;
            buttonInfo7.Command6 = null;
            buttonInfo7.ID = "horDrill2";
            this.horDrill2.Info = buttonInfo7;
            this.horDrill2.IsActivate = false;
            this.horDrill2.Location = new System.Drawing.Point(379, 299);
            this.horDrill2.MainColor = System.Drawing.Color.Black;
            this.horDrill2.Name = "horDrill2";
            this.horDrill2.PressColor = System.Drawing.Color.Gold;
            this.horDrill2.Size = new System.Drawing.Size(63, 117);
            this.horDrill2.TabIndex = 6;
            this.horDrill2.ThemeColor = System.Drawing.Color.Black;
            this.horDrill2.UseThemeColor = true;
            // 
            // pressWheel2
            // 
            this.pressWheel2.ActColor = System.Drawing.Color.Lime;
            this.pressWheel2.AntiAliasing = true;
            this.pressWheel2.C1 = System.Drawing.Color.Black;
            this.pressWheel2.EnterColor = System.Drawing.Color.Peru;
            buttonInfo8.Command1 = null;
            buttonInfo8.Command2 = null;
            buttonInfo8.Command3 = null;
            buttonInfo8.Command4 = null;
            buttonInfo8.Command5 = null;
            buttonInfo8.Command6 = null;
            buttonInfo8.ID = "PressWheel";
            this.pressWheel2.Info = buttonInfo8;
            this.pressWheel2.IsActivate = false;
            this.pressWheel2.IsHor = false;
            this.pressWheel2.Location = new System.Drawing.Point(675, 226);
            this.pressWheel2.MainColor = System.Drawing.Color.Black;
            this.pressWheel2.Name = "pressWheel2";
            this.pressWheel2.PressColor = System.Drawing.Color.Gold;
            this.pressWheel2.Size = new System.Drawing.Size(55, 75);
            this.pressWheel2.TabIndex = 7;
            this.pressWheel2.ThemeColor = System.Drawing.Color.Black;
            this.pressWheel2.UseThemeColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pressWheel2);
            this.Controls.Add(this.horDrill2);
            this.Controls.Add(this.statusButton1);
            this.Controls.Add(this.pressWheel1);
            this.Controls.Add(this.pressPlate1);
            this.Controls.Add(this.horDrill1);
            this.Controls.Add(this.axisDisplay1);
            this.Controls.Add(this.verDrill1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MachineTool.VerDrill verDrill1;
        private MachineTool.AxisDisplay axisDisplay1;
        private MachineTool.HorDrill horDrill1;
        private MachineTool.PressPlate pressPlate1;
        private MachineTool.PressWheel pressWheel1;
        private MachineTool.StatusButton statusButton1;
        private MachineTool.HorDrill horDrill2;
        private MachineTool.PressWheel pressWheel2;
    }
}