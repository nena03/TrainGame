namespace TrainGame
{
    partial class Train
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.train1 = new System.Windows.Forms.ToolStripContainer();
            this.train1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // train1
            // 
            // 
            // train1.ContentPanel
            // 
            this.train1.ContentPanel.BackgroundImage = global::TrainGame.Properties.Resources.train;
            this.train1.ContentPanel.Size = new System.Drawing.Size(291, 168);
            this.train1.Location = new System.Drawing.Point(0, 101);
            this.train1.Name = "train1";
            this.train1.Size = new System.Drawing.Size(291, 168);
            this.train1.TabIndex = 0;
            this.train1.Text = "toolStripContainer1";
            // 
            // train1.TopToolStripPanel
            // 
            this.train1.TopToolStripPanel.BackgroundImage = global::TrainGame.Properties.Resources.train;
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.train1);
            this.Name = "Train";
            this.Size = new System.Drawing.Size(339, 317);
            this.train1.ResumeLayout(false);
            this.train1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripContainer train1;
    }
}
