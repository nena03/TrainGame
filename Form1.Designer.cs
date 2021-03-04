namespace TrainGame
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
            this.reset = new System.Windows.Forms.Button();
            this.throttle = new System.Windows.Forms.TrackBar();
            this.fire = new System.Windows.Forms.PictureBox();
            this.train2 = new TrainGame.Train();
            this.train1 = new TrainGame.Train();
            this.track1 = new TrainGame.Track();
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).BeginInit();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(417, 363);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 0;
            this.reset.Text = "Play";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // throttle
            // 
            this.throttle.Location = new System.Drawing.Point(50, 341);
            this.throttle.Name = "throttle";
            this.throttle.Size = new System.Drawing.Size(104, 45);
            this.throttle.TabIndex = 1;
            this.throttle.ValueChanged += new System.EventHandler(this.Throttle_ValueChanged);
            // 
            // fire
            // 
            this.fire.BackgroundImage = global::TrainGame.Properties.Resources.fire;
            this.fire.Location = new System.Drawing.Point(370, 99);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(193, 147);
            this.fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fire.TabIndex = 2;
            this.fire.TabStop = false;
            // 
            // train2
            // 
            this.train2.Location = new System.Drawing.Point(28, -33);
            this.train2.Name = "train2";
            this.train2.Size = new System.Drawing.Size(282, 258);
            this.train2.Speed = 0;
            this.train2.TabIndex = 3;
            this.train2.DistanceChanged += new TrainGame.Train.DistanceChangedEventHandler(this.Train2_DistanceChanged);
            // 
            // train1
            // 
            this.train1.Location = new System.Drawing.Point(28, 119);
            this.train1.Name = "train1";
            this.train1.Size = new System.Drawing.Size(246, 74);
            this.train1.Speed = 0;
            this.train1.TabIndex = 0;
            // 
            // track1
            // 
            this.track1.BackgroundImage = global::TrainGame.Properties.Resources.track;
            this.track1.FireFrequency = 3;
            this.track1.Location = new System.Drawing.Point(53, 231);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(592, 15);
            this.track1.TabIndex = 3;
            this.track1.CaughtOfFire += new TrainGame.Track.CoughtOfFireEventHandler(this.Track1_CaughtOfFire);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.train2);
            this.Controls.Add(this.train1);
            this.Controls.Add(this.track1);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.throttle);
            this.Controls.Add(this.reset);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TrackBar throttle;
        private System.Windows.Forms.PictureBox fire;
        private Track track1;
        private Train train1;
        private Train train2;
    }
}

