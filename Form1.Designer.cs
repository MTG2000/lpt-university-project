namespace WindowsFormsApp4
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxIsCorrupted = new Guna.UI2.WinForms.Guna2CheckBox();
            this.radioSizeSmall = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioSizeBig = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.labelFirstTrackStart = new Guna.UI2.WinForms.Guna2Chip();
            this.labelCorruptionCheck = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip3 = new Guna.UI2.WinForms.Guna2Chip();
            this.labelCorruptionBasket = new Guna.UI2.WinForms.Guna2Chip();
            this.labelSizeCheck = new Guna.UI2.WinForms.Guna2Chip();
            this.labelFirstTrackEnd = new Guna.UI2.WinForms.Guna2Chip();
            this.labelBigSizeTrack = new Guna.UI2.WinForms.Guna2Chip();
            this.labelSmallSizeTrack = new Guna.UI2.WinForms.Guna2Chip();
            this.labelBigSizeBasket = new Guna.UI2.WinForms.Guna2Chip();
            this.labelSmallSizeBasket = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip1 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip2 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip4 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip5 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip6 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip7 = new Guna.UI2.WinForms.Guna2Chip();
            this.guna2Chip8 = new Guna.UI2.WinForms.Guna2Chip();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxIsCorrupted);
            this.groupBox1.Controls.Add(this.radioSizeSmall);
            this.groupBox1.Controls.Add(this.radioSizeBig);
            this.groupBox1.Controls.Add(this.guna2Button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Apple";
            // 
            // checkBoxIsCorrupted
            // 
            this.checkBoxIsCorrupted.AutoSize = true;
            this.checkBoxIsCorrupted.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxIsCorrupted.CheckedState.BorderRadius = 55;
            this.checkBoxIsCorrupted.CheckedState.BorderThickness = 0;
            this.checkBoxIsCorrupted.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBoxIsCorrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.checkBoxIsCorrupted.Location = new System.Drawing.Point(35, 84);
            this.checkBoxIsCorrupted.Name = "checkBoxIsCorrupted";
            this.checkBoxIsCorrupted.Size = new System.Drawing.Size(121, 29);
            this.checkBoxIsCorrupted.TabIndex = 36;
            this.checkBoxIsCorrupted.Text = "Corrupted";
            this.checkBoxIsCorrupted.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxIsCorrupted.UncheckedState.BorderRadius = 55;
            this.checkBoxIsCorrupted.UncheckedState.BorderThickness = 2;
            this.checkBoxIsCorrupted.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // radioSizeSmall
            // 
            this.radioSizeSmall.AutoSize = true;
            this.radioSizeSmall.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSizeSmall.CheckedState.BorderThickness = 0;
            this.radioSizeSmall.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSizeSmall.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioSizeSmall.CheckedState.InnerOffset = -4;
            this.radioSizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioSizeSmall.Location = new System.Drawing.Point(102, 37);
            this.radioSizeSmall.Name = "radioSizeSmall";
            this.radioSizeSmall.Size = new System.Drawing.Size(82, 29);
            this.radioSizeSmall.TabIndex = 37;
            this.radioSizeSmall.Text = "Small";
            this.radioSizeSmall.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioSizeSmall.UncheckedState.BorderThickness = 2;
            this.radioSizeSmall.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioSizeSmall.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioSizeSmall.CheckedChanged += new System.EventHandler(this.Guna2RadioButton2_CheckedChanged);
            // 
            // radioSizeBig
            // 
            this.radioSizeBig.AutoSize = true;
            this.radioSizeBig.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSizeBig.CheckedState.BorderThickness = 2;
            this.radioSizeBig.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioSizeBig.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioSizeBig.CheckedState.InnerOffset = -4;
            this.radioSizeBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioSizeBig.Location = new System.Drawing.Point(35, 37);
            this.radioSizeBig.Name = "radioSizeBig";
            this.radioSizeBig.Size = new System.Drawing.Size(61, 29);
            this.radioSizeBig.TabIndex = 36;
            this.radioSizeBig.Text = "Big";
            this.radioSizeBig.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioSizeBig.UncheckedState.BorderThickness = 2;
            this.radioSizeBig.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioSizeBig.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(36, 131);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 8;
            this.guna2Button1.Text = "Create Apple";
            this.guna2Button1.Click += new System.EventHandler(this.Guna2Button1_Click);
            // 
            // labelFirstTrackStart
            // 
            this.labelFirstTrackStart.AutoRoundedCorners = true;
            this.labelFirstTrackStart.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstTrackStart.BorderColor = System.Drawing.Color.Transparent;
            this.labelFirstTrackStart.BorderRadius = 37;
            this.labelFirstTrackStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelFirstTrackStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstTrackStart.ForeColor = System.Drawing.Color.Black;
            this.labelFirstTrackStart.Location = new System.Drawing.Point(31, 337);
            this.labelFirstTrackStart.Name = "labelFirstTrackStart";
            this.labelFirstTrackStart.ShadowDecoration.Parent = this.labelFirstTrackStart;
            this.labelFirstTrackStart.Size = new System.Drawing.Size(217, 76);
            this.labelFirstTrackStart.TabIndex = 19;
            this.labelFirstTrackStart.Text = "First Track Start";
            this.labelFirstTrackStart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelCorruptionCheck
            // 
            this.labelCorruptionCheck.AutoRoundedCorners = true;
            this.labelCorruptionCheck.BackColor = System.Drawing.Color.Transparent;
            this.labelCorruptionCheck.BorderColor = System.Drawing.Color.Transparent;
            this.labelCorruptionCheck.BorderRadius = 37;
            this.labelCorruptionCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelCorruptionCheck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorruptionCheck.ForeColor = System.Drawing.Color.Black;
            this.labelCorruptionCheck.Location = new System.Drawing.Point(281, 337);
            this.labelCorruptionCheck.Name = "labelCorruptionCheck";
            this.labelCorruptionCheck.ShadowDecoration.Parent = this.labelCorruptionCheck;
            this.labelCorruptionCheck.Size = new System.Drawing.Size(217, 76);
            this.labelCorruptionCheck.TabIndex = 20;
            this.labelCorruptionCheck.Text = "Corruption Check";
            this.labelCorruptionCheck.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip3
            // 
            this.guna2Chip3.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip3.CustomizableEdges.BottomLeft = false;
            this.guna2Chip3.CustomizableEdges.BottomRight = false;
            this.guna2Chip3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip3.ForeColor = System.Drawing.Color.White;
            this.guna2Chip3.Location = new System.Drawing.Point(187, 369);
            this.guna2Chip3.Name = "guna2Chip3";
            this.guna2Chip3.ShadowDecoration.Parent = this.guna2Chip3;
            this.guna2Chip3.Size = new System.Drawing.Size(147, 10);
            this.guna2Chip3.TabIndex = 21;
            this.guna2Chip3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelCorruptionBasket
            // 
            this.labelCorruptionBasket.AutoRoundedCorners = true;
            this.labelCorruptionBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelCorruptionBasket.BorderColor = System.Drawing.Color.Transparent;
            this.labelCorruptionBasket.BorderRadius = 37;
            this.labelCorruptionBasket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelCorruptionBasket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorruptionBasket.ForeColor = System.Drawing.Color.Black;
            this.labelCorruptionBasket.Location = new System.Drawing.Point(281, 440);
            this.labelCorruptionBasket.Name = "labelCorruptionBasket";
            this.labelCorruptionBasket.ShadowDecoration.Parent = this.labelCorruptionBasket;
            this.labelCorruptionBasket.Size = new System.Drawing.Size(217, 76);
            this.labelCorruptionBasket.TabIndex = 22;
            this.labelCorruptionBasket.Text = "Corrupted Basket";
            this.labelCorruptionBasket.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelSizeCheck
            // 
            this.labelSizeCheck.AutoRoundedCorners = true;
            this.labelSizeCheck.BackColor = System.Drawing.Color.Transparent;
            this.labelSizeCheck.BorderColor = System.Drawing.Color.Transparent;
            this.labelSizeCheck.BorderRadius = 37;
            this.labelSizeCheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelSizeCheck.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeCheck.ForeColor = System.Drawing.Color.Black;
            this.labelSizeCheck.Location = new System.Drawing.Point(751, 337);
            this.labelSizeCheck.Name = "labelSizeCheck";
            this.labelSizeCheck.ShadowDecoration.Parent = this.labelSizeCheck;
            this.labelSizeCheck.Size = new System.Drawing.Size(217, 76);
            this.labelSizeCheck.TabIndex = 23;
            this.labelSizeCheck.Text = "Size Check";
            this.labelSizeCheck.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelFirstTrackEnd
            // 
            this.labelFirstTrackEnd.AutoRoundedCorners = true;
            this.labelFirstTrackEnd.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstTrackEnd.BorderColor = System.Drawing.Color.Transparent;
            this.labelFirstTrackEnd.BorderRadius = 37;
            this.labelFirstTrackEnd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelFirstTrackEnd.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstTrackEnd.ForeColor = System.Drawing.Color.Black;
            this.labelFirstTrackEnd.Location = new System.Drawing.Point(519, 337);
            this.labelFirstTrackEnd.Name = "labelFirstTrackEnd";
            this.labelFirstTrackEnd.ShadowDecoration.Parent = this.labelFirstTrackEnd;
            this.labelFirstTrackEnd.Size = new System.Drawing.Size(217, 76);
            this.labelFirstTrackEnd.TabIndex = 24;
            this.labelFirstTrackEnd.Text = "First Track End";
            this.labelFirstTrackEnd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelBigSizeTrack
            // 
            this.labelBigSizeTrack.AutoRoundedCorners = true;
            this.labelBigSizeTrack.BackColor = System.Drawing.Color.Transparent;
            this.labelBigSizeTrack.BorderColor = System.Drawing.Color.Transparent;
            this.labelBigSizeTrack.BorderRadius = 37;
            this.labelBigSizeTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelBigSizeTrack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBigSizeTrack.ForeColor = System.Drawing.Color.Black;
            this.labelBigSizeTrack.Location = new System.Drawing.Point(751, 225);
            this.labelBigSizeTrack.Name = "labelBigSizeTrack";
            this.labelBigSizeTrack.ShadowDecoration.Parent = this.labelBigSizeTrack;
            this.labelBigSizeTrack.Size = new System.Drawing.Size(217, 76);
            this.labelBigSizeTrack.TabIndex = 25;
            this.labelBigSizeTrack.Text = "Big Apples Track";
            this.labelBigSizeTrack.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelSmallSizeTrack
            // 
            this.labelSmallSizeTrack.AutoRoundedCorners = true;
            this.labelSmallSizeTrack.BackColor = System.Drawing.Color.Transparent;
            this.labelSmallSizeTrack.BorderColor = System.Drawing.Color.Transparent;
            this.labelSmallSizeTrack.BorderRadius = 37;
            this.labelSmallSizeTrack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelSmallSizeTrack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmallSizeTrack.ForeColor = System.Drawing.Color.Black;
            this.labelSmallSizeTrack.Location = new System.Drawing.Point(751, 440);
            this.labelSmallSizeTrack.Name = "labelSmallSizeTrack";
            this.labelSmallSizeTrack.ShadowDecoration.Parent = this.labelSmallSizeTrack;
            this.labelSmallSizeTrack.Size = new System.Drawing.Size(217, 76);
            this.labelSmallSizeTrack.TabIndex = 26;
            this.labelSmallSizeTrack.Text = "Small Apples Track";
            this.labelSmallSizeTrack.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelBigSizeBasket
            // 
            this.labelBigSizeBasket.AutoRoundedCorners = true;
            this.labelBigSizeBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelBigSizeBasket.BorderColor = System.Drawing.Color.Transparent;
            this.labelBigSizeBasket.BorderRadius = 37;
            this.labelBigSizeBasket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelBigSizeBasket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBigSizeBasket.ForeColor = System.Drawing.Color.Black;
            this.labelBigSizeBasket.Location = new System.Drawing.Point(1009, 225);
            this.labelBigSizeBasket.Name = "labelBigSizeBasket";
            this.labelBigSizeBasket.ShadowDecoration.Parent = this.labelBigSizeBasket;
            this.labelBigSizeBasket.Size = new System.Drawing.Size(217, 76);
            this.labelBigSizeBasket.TabIndex = 27;
            this.labelBigSizeBasket.Text = "Big Apples Basket";
            this.labelBigSizeBasket.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // labelSmallSizeBasket
            // 
            this.labelSmallSizeBasket.AutoRoundedCorners = true;
            this.labelSmallSizeBasket.BackColor = System.Drawing.Color.Transparent;
            this.labelSmallSizeBasket.BorderColor = System.Drawing.Color.Transparent;
            this.labelSmallSizeBasket.BorderRadius = 37;
            this.labelSmallSizeBasket.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.labelSmallSizeBasket.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmallSizeBasket.ForeColor = System.Drawing.Color.Black;
            this.labelSmallSizeBasket.Location = new System.Drawing.Point(1009, 440);
            this.labelSmallSizeBasket.Name = "labelSmallSizeBasket";
            this.labelSmallSizeBasket.ShadowDecoration.Parent = this.labelSmallSizeBasket;
            this.labelSmallSizeBasket.Size = new System.Drawing.Size(217, 76);
            this.labelSmallSizeBasket.TabIndex = 28;
            this.labelSmallSizeBasket.Text = "Small Apples Basket";
            this.labelSmallSizeBasket.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip1
            // 
            this.guna2Chip1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip1.CustomizableEdges.BottomLeft = false;
            this.guna2Chip1.CustomizableEdges.BottomRight = false;
            this.guna2Chip1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip1.ForeColor = System.Drawing.Color.White;
            this.guna2Chip1.Location = new System.Drawing.Point(436, 369);
            this.guna2Chip1.Name = "guna2Chip1";
            this.guna2Chip1.ShadowDecoration.Parent = this.guna2Chip1;
            this.guna2Chip1.Size = new System.Drawing.Size(147, 10);
            this.guna2Chip1.TabIndex = 29;
            this.guna2Chip1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip2
            // 
            this.guna2Chip2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip2.CustomizableEdges.BottomLeft = false;
            this.guna2Chip2.CustomizableEdges.BottomRight = false;
            this.guna2Chip2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip2.ForeColor = System.Drawing.Color.White;
            this.guna2Chip2.Location = new System.Drawing.Point(664, 369);
            this.guna2Chip2.Name = "guna2Chip2";
            this.guna2Chip2.ShadowDecoration.Parent = this.guna2Chip2;
            this.guna2Chip2.Size = new System.Drawing.Size(147, 10);
            this.guna2Chip2.TabIndex = 30;
            this.guna2Chip2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip4
            // 
            this.guna2Chip4.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip4.CustomizableEdges.BottomLeft = false;
            this.guna2Chip4.CustomizableEdges.BottomRight = false;
            this.guna2Chip4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip4.ForeColor = System.Drawing.Color.White;
            this.guna2Chip4.Location = new System.Drawing.Point(919, 259);
            this.guna2Chip4.Name = "guna2Chip4";
            this.guna2Chip4.ShadowDecoration.Parent = this.guna2Chip4;
            this.guna2Chip4.Size = new System.Drawing.Size(147, 10);
            this.guna2Chip4.TabIndex = 31;
            this.guna2Chip4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip5
            // 
            this.guna2Chip5.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip5.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip5.CustomizableEdges.BottomLeft = false;
            this.guna2Chip5.CustomizableEdges.BottomRight = false;
            this.guna2Chip5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip5.ForeColor = System.Drawing.Color.White;
            this.guna2Chip5.Location = new System.Drawing.Point(919, 479);
            this.guna2Chip5.Name = "guna2Chip5";
            this.guna2Chip5.ShadowDecoration.Parent = this.guna2Chip5;
            this.guna2Chip5.Size = new System.Drawing.Size(147, 10);
            this.guna2Chip5.TabIndex = 32;
            this.guna2Chip5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip6
            // 
            this.guna2Chip6.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip6.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip6.CustomizableEdges.BottomLeft = false;
            this.guna2Chip6.CustomizableEdges.BottomRight = false;
            this.guna2Chip6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip6.ForeColor = System.Drawing.Color.White;
            this.guna2Chip6.Location = new System.Drawing.Point(386, 379);
            this.guna2Chip6.Name = "guna2Chip6";
            this.guna2Chip6.ShadowDecoration.Parent = this.guna2Chip6;
            this.guna2Chip6.Size = new System.Drawing.Size(10, 100);
            this.guna2Chip6.TabIndex = 33;
            this.guna2Chip6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip7
            // 
            this.guna2Chip7.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip7.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip7.CustomizableEdges.BottomLeft = false;
            this.guna2Chip7.CustomizableEdges.BottomRight = false;
            this.guna2Chip7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip7.ForeColor = System.Drawing.Color.White;
            this.guna2Chip7.Location = new System.Drawing.Point(856, 259);
            this.guna2Chip7.Name = "guna2Chip7";
            this.guna2Chip7.ShadowDecoration.Parent = this.guna2Chip7;
            this.guna2Chip7.Size = new System.Drawing.Size(10, 100);
            this.guna2Chip7.TabIndex = 34;
            this.guna2Chip7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2Chip8
            // 
            this.guna2Chip8.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Chip8.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Chip8.CustomizableEdges.BottomLeft = false;
            this.guna2Chip8.CustomizableEdges.BottomRight = false;
            this.guna2Chip8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(216)))), ((int)(((byte)(193)))));
            this.guna2Chip8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Chip8.ForeColor = System.Drawing.Color.White;
            this.guna2Chip8.Location = new System.Drawing.Point(856, 389);
            this.guna2Chip8.Name = "guna2Chip8";
            this.guna2Chip8.ShadowDecoration.Parent = this.guna2Chip8;
            this.guna2Chip8.Size = new System.Drawing.Size(10, 100);
            this.guna2Chip8.TabIndex = 35;
            this.guna2Chip8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(89)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1410, 743);
            this.Controls.Add(this.labelSmallSizeBasket);
            this.Controls.Add(this.labelBigSizeBasket);
            this.Controls.Add(this.labelSmallSizeTrack);
            this.Controls.Add(this.labelBigSizeTrack);
            this.Controls.Add(this.labelFirstTrackEnd);
            this.Controls.Add(this.labelSizeCheck);
            this.Controls.Add(this.labelCorruptionBasket);
            this.Controls.Add(this.labelFirstTrackStart);
            this.Controls.Add(this.labelCorruptionCheck);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2Chip8);
            this.Controls.Add(this.guna2Chip7);
            this.Controls.Add(this.guna2Chip6);
            this.Controls.Add(this.guna2Chip5);
            this.Controls.Add(this.guna2Chip4);
            this.Controls.Add(this.guna2Chip2);
            this.Controls.Add(this.guna2Chip1);
            this.Controls.Add(this.guna2Chip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Chip labelFirstTrackStart;
        private Guna.UI2.WinForms.Guna2Chip labelCorruptionCheck;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip3;
        private Guna.UI2.WinForms.Guna2Chip labelSmallSizeBasket;
        private Guna.UI2.WinForms.Guna2Chip labelBigSizeBasket;
        private Guna.UI2.WinForms.Guna2Chip labelSmallSizeTrack;
        private Guna.UI2.WinForms.Guna2Chip labelBigSizeTrack;
        private Guna.UI2.WinForms.Guna2Chip labelFirstTrackEnd;
        private Guna.UI2.WinForms.Guna2Chip labelSizeCheck;
        private Guna.UI2.WinForms.Guna2Chip labelCorruptionBasket;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip8;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip7;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip6;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip5;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip4;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip2;
        private Guna.UI2.WinForms.Guna2Chip guna2Chip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2RadioButton radioSizeSmall;
        private Guna.UI2.WinForms.Guna2RadioButton radioSizeBig;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxIsCorrupted;
    }
}

