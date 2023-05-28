namespace JunkCodeAdder
{
    partial class Main
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
            this.siticoneTransparentDrag1 = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelJunk = new Siticone.UI.WinForms.SiticoneLabel();
            this.MinimizeButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.CloseButton = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedTextBox1 = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.EveryDirSwitch = new Siticone.UI.WinForms.SiticoneOSToggleSwith();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.EveryLocNum = new Siticone.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.MainNum = new Siticone.UI.WinForms.SiticoneNumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EveryLocNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNum)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneTransparentDrag1
            // 
            this.siticoneTransparentDrag1.DragEndTransparencyValue = 1D;
            this.siticoneTransparentDrag1.DragStartTransparencyValue = 0.9D;
            this.siticoneTransparentDrag1.TargetDragControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelJunk);
            this.panel1.Controls.Add(this.MinimizeButton);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Location = new System.Drawing.Point(-5, -9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 44);
            this.panel1.TabIndex = 0;
            // 
            // LabelJunk
            // 
            this.LabelJunk.BackColor = System.Drawing.Color.Transparent;
            this.LabelJunk.Enabled = false;
            this.LabelJunk.Font = new System.Drawing.Font("Horizon", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelJunk.Location = new System.Drawing.Point(144, 7);
            this.LabelJunk.Name = "LabelJunk";
            this.LabelJunk.Size = new System.Drawing.Size(263, 37);
            this.LabelJunk.TabIndex = 1;
            this.LabelJunk.Text = "JunkCoder";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.CheckedState.Parent = this.MinimizeButton;
            this.MinimizeButton.CustomImages.Parent = this.MinimizeButton;
            this.MinimizeButton.FillColor = System.Drawing.Color.Goldenrod;
            this.MinimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimizeButton.ForeColor = System.Drawing.Color.White;
            this.MinimizeButton.HoveredState.Parent = this.MinimizeButton;
            this.MinimizeButton.Location = new System.Drawing.Point(474, 14);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.ShadowDecoration.Parent = this.MinimizeButton;
            this.MinimizeButton.Size = new System.Drawing.Size(25, 25);
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.CustomImages.Parent = this.CloseButton;
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.HoveredState.Parent = this.CloseButton;
            this.CloseButton.Location = new System.Drawing.Point(505, 14);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // siticoneRoundedTextBox1
            // 
            this.siticoneRoundedTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneRoundedTextBox1.DefaultText = "Specify location of your project";
            this.siticoneRoundedTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneRoundedTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneRoundedTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.DisabledState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneRoundedTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(219)))), ((int)(((byte)(241)))));
            this.siticoneRoundedTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.FocusedState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticoneRoundedTextBox1.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneRoundedTextBox1.HoveredState.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Location = new System.Drawing.Point(12, 65);
            this.siticoneRoundedTextBox1.Name = "siticoneRoundedTextBox1";
            this.siticoneRoundedTextBox1.PasswordChar = '\0';
            this.siticoneRoundedTextBox1.PlaceholderText = "";
            this.siticoneRoundedTextBox1.SelectedText = "";
            this.siticoneRoundedTextBox1.ShadowDecoration.Parent = this.siticoneRoundedTextBox1;
            this.siticoneRoundedTextBox1.Size = new System.Drawing.Size(513, 36);
            this.siticoneRoundedTextBox1.TabIndex = 1;
            this.siticoneRoundedTextBox1.Enter += new System.EventHandler(this.siticoneRoundedTextBox1_Enter);
            // 
            // EveryDirSwitch
            // 
            this.EveryDirSwitch.Location = new System.Drawing.Point(12, 119);
            this.EveryDirSwitch.Name = "EveryDirSwitch";
            this.EveryDirSwitch.Size = new System.Drawing.Size(38, 22);
            this.EveryDirSwitch.TabIndex = 4;
            this.EveryDirSwitch.Checked = false;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(70)))), ((int)(((byte)(116)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("FZCuYuan-M03", 12.5F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(173, 393);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneRoundedButton1.TabIndex = 5;
            this.siticoneRoundedButton1.Text = "Add JunkCode";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("FZCuYuan-M03", 12.5F);
            this.siticoneLabel1.Location = new System.Drawing.Point(56, 119);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(265, 22);
            this.siticoneLabel1.TabIndex = 6;
            this.siticoneLabel1.Text = "Add JunkCode file to every location";
            // 
            // EveryLocNum
            // 
            this.EveryLocNum.BackColor = System.Drawing.Color.Transparent;
            this.EveryLocNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EveryLocNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EveryLocNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EveryLocNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EveryLocNum.DisabledState.Parent = this.EveryLocNum;
            this.EveryLocNum.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.EveryLocNum.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.EveryLocNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EveryLocNum.FocusedState.Parent = this.EveryLocNum;
            this.EveryLocNum.Font = new System.Drawing.Font("FZCuYuan-M03", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EveryLocNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.EveryLocNum.Location = new System.Drawing.Point(327, 119);
            this.EveryLocNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.EveryLocNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EveryLocNum.Name = "EveryLocNum";
            this.EveryLocNum.ShadowDecoration.Parent = this.EveryLocNum;
            this.EveryLocNum.Size = new System.Drawing.Size(41, 22);
            this.EveryLocNum.TabIndex = 9;
            this.EveryLocNum.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("FZCuYuan-M03", 12.5F);
            this.siticoneLabel2.Location = new System.Drawing.Point(56, 161);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(246, 22);
            this.siticoneLabel2.TabIndex = 10;
            this.siticoneLabel2.Text = "Number of files in main directory";
            // 
            // MainNum
            // 
            this.MainNum.BackColor = System.Drawing.Color.Transparent;
            this.MainNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MainNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MainNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MainNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MainNum.DisabledState.Parent = this.MainNum;
            this.MainNum.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.MainNum.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.MainNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MainNum.FocusedState.Parent = this.MainNum;
            this.MainNum.Font = new System.Drawing.Font("FZCuYuan-M03", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.MainNum.Location = new System.Drawing.Point(327, 161);
            this.MainNum.Name = "MainNum";
            this.MainNum.ShadowDecoration.Parent = this.MainNum;
            this.MainNum.Size = new System.Drawing.Size(41, 22);
            this.MainNum.TabIndex = 11;
            this.MainNum.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(532, 450);
            this.Controls.Add(this.MainNum);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.EveryLocNum);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.EveryDirSwitch);
            this.Controls.Add(this.siticoneRoundedTextBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("FZCuYuan-M03", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EveryLocNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneTransparentDrag siticoneTransparentDrag1;
        private System.Windows.Forms.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel LabelJunk;
        private Siticone.UI.WinForms.SiticoneRoundedButton MinimizeButton;
        private Siticone.UI.WinForms.SiticoneRoundedButton CloseButton;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox siticoneRoundedTextBox1;
        private Siticone.UI.WinForms.SiticoneOSToggleSwith EveryDirSwitch;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneNumericUpDown EveryLocNum;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneNumericUpDown MainNum;
    }
}

