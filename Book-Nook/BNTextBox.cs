//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Book_Nook
{
    public partial class BNTextBox : TextBox
    {
        private int _cornerRadius = 10;
        private Color _borderColor = Color.Red;
        private Color _placeholderColor = Color.LightGray;
        private string _placeholderText = "";
        private int _padding = 5;
        public BNTextBox()
        {
            this.BorderStyle = BorderStyle.None;
            //InitializeComponent();
        }

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; Invalidate(); }
        }

        public Color BorderColor 
        { 
            get { return _borderColor; } 
            set { _borderColor = value; Invalidate(); } 
        }

        public Color PlaceholderColor 
        { 
            get { return _placeholderColor; }
            set { _placeholderColor = value; Invalidate(); }
        }

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set { _placeholderText = value; Invalidate(); }
        }

        public int Padding { 
            get { return _padding; } 
            set { _padding = value; Invalidate(); } 
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Draw the rounded rectangle border
            GraphicsPath path = GetRoundedRect(ClientRectangle, _cornerRadius);
            using (Pen pen = new Pen(_borderColor))
            {
                e.Graphics.DrawPath(pen, path);
            }

            //Draw the placeholder text
            if(string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(_placeholderText))
            {
                using (SolidBrush brush = new SolidBrush(_placeholderColor))
                {
                    e.Graphics.DrawString(_placeholderText, Font, brush, _padding, (Height - Font.Height) / 2);
                }
            }

            base.OnPaint(e);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            //Padding = new Padding(_padding);
        }

        private GraphicsPath GetRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Rectangle arcRect = new Rectangle(rect.Location, new Size(diameter, diameter));

            //Top left arc
            path.AddArc(arcRect, 180, 90);

            //Top right arc
            arcRect.X = rect.Right - diameter;
            path.AddArc(arcRect, 270, 90);

            //Bottom right arc
            arcRect.Y = rect.Bottom - diameter;
            path.AddArc(arcRect, 0, 90);

            //Bottom left arc
            arcRect.X = rect.Left;
            path.AddArc(arcRect, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
