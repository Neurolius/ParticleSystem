namespace ParticleSystem
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lblDirection = new System.Windows.Forms.Label();
            this.tbPartCount = new System.Windows.Forms.TrackBar();
            this.lbPartCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartCount)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(3, 1);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(934, 581);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseDown);
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            this.picDisplay.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseWheel);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(55, 608);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(3, 588);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(202, 45);
            this.tbDirection.TabIndex = 2;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(211, 598);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(13, 13);
            this.lblDirection.TabIndex = 3;
            this.lblDirection.Text = "0";
            // 
            // tbPartCount
            // 
            this.tbPartCount.Location = new System.Drawing.Point(269, 588);
            this.tbPartCount.Maximum = 16;
            this.tbPartCount.Minimum = 1;
            this.tbPartCount.Name = "tbPartCount";
            this.tbPartCount.Size = new System.Drawing.Size(197, 45);
            this.tbPartCount.TabIndex = 4;
            this.tbPartCount.Value = 16;
            this.tbPartCount.Scroll += new System.EventHandler(this.tbPartCount_Scroll);
            // 
            // lbPartCount
            // 
            this.lbPartCount.AutoSize = true;
            this.lbPartCount.Location = new System.Drawing.Point(483, 598);
            this.lbPartCount.Name = "lbPartCount";
            this.lbPartCount.Size = new System.Drawing.Size(19, 13);
            this.lbPartCount.TabIndex = 5;
            this.lbPartCount.Text = "16";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 640);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Направление вылета частиц";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество частиц в тик";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPartCount);
            this.Controls.Add(this.tbPartCount);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPartCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.TrackBar tbPartCount;
        private System.Windows.Forms.Label lbPartCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

