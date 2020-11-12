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
            this.radioSizeBig = new System.Windows.Forms.RadioButton();
            this.radioSizeSmall = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxIsCorrupted = new System.Windows.Forms.CheckBox();
            this.labelCorruptionCheck = new System.Windows.Forms.Label();
            this.labelFirstTrackStart = new System.Windows.Forms.Label();
            this.labelCorruptionBasket = new System.Windows.Forms.Label();
            this.labelFirstTrackEnd = new System.Windows.Forms.Label();
            this.labelSizeCheck = new System.Windows.Forms.Label();
            this.labelBigSizeTrack = new System.Windows.Forms.Label();
            this.labelBigSizeBasket = new System.Windows.Forms.Label();
            this.labelSmallSizeBasket = new System.Windows.Forms.Label();
            this.labelSmallSizeTrack = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // radioSizeBig
            // 
            this.radioSizeBig.AutoSize = true;
            this.radioSizeBig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioSizeBig.Location = new System.Drawing.Point(36, 51);
            this.radioSizeBig.Name = "radioSizeBig";
            this.radioSizeBig.Size = new System.Drawing.Size(49, 20);
            this.radioSizeBig.TabIndex = 3;
            this.radioSizeBig.TabStop = true;
            this.radioSizeBig.Text = "Big";
            this.radioSizeBig.UseVisualStyleBackColor = true;
            // 
            // radioSizeSmall
            // 
            this.radioSizeSmall.AutoSize = true;
            this.radioSizeSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.radioSizeSmall.Location = new System.Drawing.Point(91, 51);
            this.radioSizeSmall.Name = "radioSizeSmall";
            this.radioSizeSmall.Size = new System.Drawing.Size(63, 20);
            this.radioSizeSmall.TabIndex = 4;
            this.radioSizeSmall.TabStop = true;
            this.radioSizeSmall.Text = "Small";
            this.radioSizeSmall.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.checkBoxIsCorrupted);
            this.groupBox1.Controls.Add(this.radioSizeSmall);
            this.groupBox1.Controls.Add(this.radioSizeBig);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 195);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Apple";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(57, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // checkBoxIsCorrupted
            // 
            this.checkBoxIsCorrupted.AutoSize = true;
            this.checkBoxIsCorrupted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.checkBoxIsCorrupted.Location = new System.Drawing.Point(36, 77);
            this.checkBoxIsCorrupted.Name = "checkBoxIsCorrupted";
            this.checkBoxIsCorrupted.Size = new System.Drawing.Size(102, 20);
            this.checkBoxIsCorrupted.TabIndex = 6;
            this.checkBoxIsCorrupted.Text = "Is Corrupted";
            this.checkBoxIsCorrupted.UseVisualStyleBackColor = true;
            // 
            // labelCorruptionCheck
            // 
            this.labelCorruptionCheck.AutoSize = true;
            this.labelCorruptionCheck.BackColor = System.Drawing.Color.Silver;
            this.labelCorruptionCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCorruptionCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorruptionCheck.Location = new System.Drawing.Point(244, 259);
            this.labelCorruptionCheck.Margin = new System.Windows.Forms.Padding(5);
            this.labelCorruptionCheck.Name = "labelCorruptionCheck";
            this.labelCorruptionCheck.Padding = new System.Windows.Forms.Padding(20);
            this.labelCorruptionCheck.Size = new System.Drawing.Size(240, 69);
            this.labelCorruptionCheck.TabIndex = 8;
            this.labelCorruptionCheck.Text = "Corruption Check";
            // 
            // labelFirstTrackStart
            // 
            this.labelFirstTrackStart.AutoSize = true;
            this.labelFirstTrackStart.BackColor = System.Drawing.Color.Silver;
            this.labelFirstTrackStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFirstTrackStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstTrackStart.Location = new System.Drawing.Point(12, 259);
            this.labelFirstTrackStart.Margin = new System.Windows.Forms.Padding(5);
            this.labelFirstTrackStart.Name = "labelFirstTrackStart";
            this.labelFirstTrackStart.Padding = new System.Windows.Forms.Padding(20);
            this.labelFirstTrackStart.Size = new System.Drawing.Size(222, 69);
            this.labelFirstTrackStart.TabIndex = 9;
            this.labelFirstTrackStart.Text = "First Track Start";
            // 
            // labelCorruptionBasket
            // 
            this.labelCorruptionBasket.AutoSize = true;
            this.labelCorruptionBasket.BackColor = System.Drawing.Color.Silver;
            this.labelCorruptionBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelCorruptionBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorruptionBasket.Location = new System.Drawing.Point(244, 338);
            this.labelCorruptionBasket.Margin = new System.Windows.Forms.Padding(5);
            this.labelCorruptionBasket.Name = "labelCorruptionBasket";
            this.labelCorruptionBasket.Padding = new System.Windows.Forms.Padding(20);
            this.labelCorruptionBasket.Size = new System.Drawing.Size(245, 69);
            this.labelCorruptionBasket.TabIndex = 10;
            this.labelCorruptionBasket.Text = "Corruption Basket";
            // 
            // labelFirstTrackEnd
            // 
            this.labelFirstTrackEnd.AutoSize = true;
            this.labelFirstTrackEnd.BackColor = System.Drawing.Color.Silver;
            this.labelFirstTrackEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFirstTrackEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstTrackEnd.Location = new System.Drawing.Point(506, 259);
            this.labelFirstTrackEnd.Margin = new System.Windows.Forms.Padding(5);
            this.labelFirstTrackEnd.Name = "labelFirstTrackEnd";
            this.labelFirstTrackEnd.Padding = new System.Windows.Forms.Padding(20);
            this.labelFirstTrackEnd.Size = new System.Drawing.Size(216, 69);
            this.labelFirstTrackEnd.TabIndex = 11;
            this.labelFirstTrackEnd.Text = "First Track End";
            // 
            // labelSizeCheck
            // 
            this.labelSizeCheck.AutoSize = true;
            this.labelSizeCheck.BackColor = System.Drawing.Color.Silver;
            this.labelSizeCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSizeCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSizeCheck.Location = new System.Drawing.Point(732, 259);
            this.labelSizeCheck.Margin = new System.Windows.Forms.Padding(5);
            this.labelSizeCheck.Name = "labelSizeCheck";
            this.labelSizeCheck.Padding = new System.Windows.Forms.Padding(20);
            this.labelSizeCheck.Size = new System.Drawing.Size(174, 69);
            this.labelSizeCheck.TabIndex = 12;
            this.labelSizeCheck.Text = "Size Check";
            // 
            // labelBigSizeTrack
            // 
            this.labelBigSizeTrack.AutoSize = true;
            this.labelBigSizeTrack.BackColor = System.Drawing.Color.Silver;
            this.labelBigSizeTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBigSizeTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBigSizeTrack.Location = new System.Drawing.Point(881, 180);
            this.labelBigSizeTrack.Margin = new System.Windows.Forms.Padding(5);
            this.labelBigSizeTrack.Name = "labelBigSizeTrack";
            this.labelBigSizeTrack.Padding = new System.Windows.Forms.Padding(20);
            this.labelBigSizeTrack.Size = new System.Drawing.Size(209, 69);
            this.labelBigSizeTrack.TabIndex = 13;
            this.labelBigSizeTrack.Text = "Big Size Track";
            // 
            // labelBigSizeBasket
            // 
            this.labelBigSizeBasket.AutoSize = true;
            this.labelBigSizeBasket.BackColor = System.Drawing.Color.Silver;
            this.labelBigSizeBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBigSizeBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBigSizeBasket.Location = new System.Drawing.Point(1100, 180);
            this.labelBigSizeBasket.Margin = new System.Windows.Forms.Padding(5);
            this.labelBigSizeBasket.Name = "labelBigSizeBasket";
            this.labelBigSizeBasket.Padding = new System.Windows.Forms.Padding(20);
            this.labelBigSizeBasket.Size = new System.Drawing.Size(221, 69);
            this.labelBigSizeBasket.TabIndex = 15;
            this.labelBigSizeBasket.Text = "Big Size Basket";
            // 
            // labelSmallSizeBasket
            // 
            this.labelSmallSizeBasket.AutoSize = true;
            this.labelSmallSizeBasket.BackColor = System.Drawing.Color.Silver;
            this.labelSmallSizeBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSmallSizeBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmallSizeBasket.Location = new System.Drawing.Point(1125, 338);
            this.labelSmallSizeBasket.Margin = new System.Windows.Forms.Padding(5);
            this.labelSmallSizeBasket.Name = "labelSmallSizeBasket";
            this.labelSmallSizeBasket.Padding = new System.Windows.Forms.Padding(20);
            this.labelSmallSizeBasket.Size = new System.Drawing.Size(193, 69);
            this.labelSmallSizeBasket.TabIndex = 17;
            this.labelSmallSizeBasket.Text = "Small Basket";
            // 
            // labelSmallSizeTrack
            // 
            this.labelSmallSizeTrack.AutoSize = true;
            this.labelSmallSizeTrack.BackColor = System.Drawing.Color.Silver;
            this.labelSmallSizeTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSmallSizeTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSmallSizeTrack.Location = new System.Drawing.Point(881, 338);
            this.labelSmallSizeTrack.Margin = new System.Windows.Forms.Padding(5);
            this.labelSmallSizeTrack.Name = "labelSmallSizeTrack";
            this.labelSmallSizeTrack.Padding = new System.Windows.Forms.Padding(20);
            this.labelSmallSizeTrack.Size = new System.Drawing.Size(234, 69);
            this.labelSmallSizeTrack.TabIndex = 16;
            this.labelSmallSizeTrack.Text = "Small Size Track";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1410, 743);
            this.Controls.Add(this.labelSmallSizeBasket);
            this.Controls.Add(this.labelSmallSizeTrack);
            this.Controls.Add(this.labelBigSizeBasket);
            this.Controls.Add(this.labelBigSizeTrack);
            this.Controls.Add(this.labelSizeCheck);
            this.Controls.Add(this.labelFirstTrackEnd);
            this.Controls.Add(this.labelCorruptionBasket);
            this.Controls.Add(this.labelFirstTrackStart);
            this.Controls.Add(this.labelCorruptionCheck);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioSizeBig;
        private System.Windows.Forms.RadioButton radioSizeSmall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxIsCorrupted;
        private System.Windows.Forms.Label labelCorruptionCheck;
        private System.Windows.Forms.Label labelFirstTrackStart;
        private System.Windows.Forms.Label labelCorruptionBasket;
        private System.Windows.Forms.Label labelFirstTrackEnd;
        private System.Windows.Forms.Label labelSizeCheck;
        private System.Windows.Forms.Label labelBigSizeTrack;
        private System.Windows.Forms.Label labelBigSizeBasket;
        private System.Windows.Forms.Label labelSmallSizeBasket;
        private System.Windows.Forms.Label labelSmallSizeTrack;
    }
}

