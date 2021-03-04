namespace TrainGame
{
    partial class Track
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.track1 = new System.Windows.Forms.ToolStripContainer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.track1.SuspendLayout();
            this.SuspendLayout();
            // 
            // track1
            // 
            // 
            // track1.ContentPanel
            // 
            this.track1.ContentPanel.BackgroundImage = global::TrainGame.Properties.Resources.track;
            this.track1.ContentPanel.Size = new System.Drawing.Size(402, 150);
            this.track1.Location = new System.Drawing.Point(3, 73);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(402, 150);
            this.track1.TabIndex = 0;
            this.track1.Text = "toolStripContainer1";
            // 
            // track1.track1
            // 
            this.track1.TopToolStripPanel.BackgroundImage = global::TrainGame.Properties.Resources.track;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.track1);
            this.Name = "Track";
            this.Size = new System.Drawing.Size(422, 313);
            this.track1.ResumeLayout(false);
            this.track1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer track1;
        private System.Windows.Forms.Timer timer1;
    }
}
