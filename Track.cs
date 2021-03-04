using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainGame
{
    [System.ComponentModel.DefaultEvent("CaughtOfFire")]
    public partial class Track : UserControl
    {
        public Track()
        {
            InitializeComponent();
        }

        private int m_fireFrequency = 1;
        public int FireFrequency
        {
            get { return m_fireFrequency; }
            set
            {
                if (value >= 1)
                {
                    m_fireFrequency = value;
                    timer1.Interval = m_fireFrequency * 1000;
                }
            }
        }
        private const int TrackHeight = 15;
        private const int BarWith = TrackHeight / 5;
        private const int BarSpacing = BarWith / 2;

        private void Track_Load(object sender, EventArgs e)
        {
            this.Height = 150;
        }
        protected override void OnSizeChanged(EventArgs e)
        {
            this.Height = TrackHeight;
            int nBars = this.Width / BarSpacing;
            this.Width = nBars * BarSpacing;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.FillMode = System.Drawing.Drawing2D.FillMode.Winding;
            int height = TrackHeight / 5;
            int nBars = this.Width / BarSpacing;
            for (int bar = 0; bar < nBars; bar++)
            {
                gp.AddRectangle(new System.Drawing.Rectangle(bar * BarSpacing, height, BarSpacing, height));
                gp.AddRectangle(new System.Drawing.Rectangle(bar * BarSpacing, height * 3, BarSpacing, height));
                gp.AddRectangle(new System.Drawing.Rectangle(bar * BarSpacing, 0, BarWith, TrackHeight));
            }
            e.Graphics.FillPath(System.Drawing.Brushes.SaddleBrown, gp);
        }
        public delegate void CoughtOfFireEventHandler(object sender, CaughtOnFireEventArgs e);
        public event CoughtOfFireEventHandler CaughtOfFire;



        public class CaughtOnFireEventArgs : System.EventArgs
        {
            private int m_location = 0;
            public CaughtOnFireEventArgs(int location)
            { m_location = location; }
            public int Location
            {
                get { return m_location; }
            }
        }
    }
}
