using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace CustomWindowsForm
{
    public class ShapedButton : System.Windows.Forms.Button
    {
        Color clr1, clr2;
        private Color color1 = Color.DodgerBlue;
        private Color color2 = Color.MidnightBlue;
        private Color m_hovercolor1 = Color.Turquoise;
        private Color m_hovercolor2 = Color.DarkSlateGray;
        private int color1Transparent = 250;
        private int color2Transparent = 250;
        private Color clickcolor1 = Color.Yellow;
        private Color clickcolor2 = Color.Red;
        private int angle = 90;
        private int textX = 100;
        private int textY = 25;
        private String text = "";
       
        public Boolean showButtonText = true;
        private int borderWidth = 1;
        public Color borderColor = Color.Transparent;

        public enum ButtonsShapes
        {
            RoundRect,
            Circle
        }

        ButtonsShapes buttonShape;

        public ButtonsShapes ButtonShape
        {
            get { return buttonShape; }
            set
            {
                buttonShape = value; Invalidate();
            }
        }

        public String ButtonText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }

        private int BorderWidth
        {
            get { return borderWidth; }
            set { borderWidth = value; Invalidate(); }
        }


        


      

        public Color StartColor
        {
            get { return color1; }
            set { color1 = value; Invalidate(); }
        }
        public Color EndColor
        {
            get { return color2; }
            set { color2 = value; Invalidate(); }
        }
        public Color MouseHoverColor1
        {
            get { return m_hovercolor1; }
            set { m_hovercolor1 = value; Invalidate(); }
        }
        public Color MouseHoverColor2
        {
            get { return m_hovercolor2; }
            set { m_hovercolor2 = value; Invalidate(); }
        }
        public Color MouseClickColor1
        {
            get { return clickcolor1; }
            set { clickcolor1 = value; Invalidate(); }
        }
        public Color MouseClickColor2
        {
            get { return clickcolor2; }
            set { clickcolor2 = value; Invalidate(); }
        }

        public int Transparent1
        {
            get { return color1Transparent; }
            set
            {
                color1Transparent = value;
                if (color1Transparent > 255)
                {
                    color1Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int Transparent2
        {
            get { return color2Transparent; }
            set
            {
                color2Transparent = value;
                if (color2Transparent > 255)
                {
                    color2Transparent = 255;
                    Invalidate();
                }
                else
                    Invalidate();
            }
        }

        public int GradientAngle
        {
            get { return angle; }
            set { angle = value; Invalidate(); }
        }

        public int TextLocation_X
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }
        public int TextLocation_Y
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }

        public Boolean ShowButtontext
        {
            get { return showButtonText; }
            set { showButtonText = value; Invalidate(); }
        }


        public ShapedButton()
        {
            this.Size = new Size(100, 40);
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.FlatAppearance.MouseDownBackColor = Color.Transparent;
            text = this.Text;
        }


        //method mouse enter
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            clr1 = color1;
            clr2 = color2;
            color1 = m_hovercolor1;
            color2 = m_hovercolor2;
        }
        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            color1 = clr1;
            color2 = clr2;
        
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            color1 = clickcolor1;
            color2 = clickcolor2;
 
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            OnMouseLeave(mevent);
            color1 = clr1;
            color2 = clr2;
          
            this.Invalidate();
        }
       
        protected override void OnLostFocus(EventArgs e)
        {
            base.OnLostFocus(e);
            color1 = clr1;
            color2 = clr2;
            this.Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textX = (int)((this.Width / 3) - 1);
            textY = (int)((this.Height / 3) + 5);
        }


        //draw circular button function
        void DrawCircularButton(Graphics g)
        {
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);


            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);
            g.FillEllipse(b, 5, 5, this.Width - 10, this.Height - 10);

            for (int i = 0; i < borderWidth; i++)
            {
               // g.DrawEllipse(new Pen(new SolidBrush(buttonborder)), 5+i, 5, this.Width - 10, this.Height - 10);
            }




            if (showButtonText)
            {
                Point p = new Point(textX, textY);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                g.DrawString(text, this.Font, frcolor, p);
            }

            b.Dispose();
        }

        


        //draw round rectangular button function
        void DrawRoundRectangularButton(Graphics g)
        {
            Color c1 = Color.FromArgb(color1Transparent, color1);
            Color c2 = Color.FromArgb(color2Transparent, color2);
            int radius = 20;

            Brush b = new System.Drawing.Drawing2D.LinearGradientBrush(ClientRectangle, c1, c2, angle);

            Region region = new System.Drawing.Region(new Rectangle(5, 5, this.Width, this.Height));

            GraphicsPath grp = new GraphicsPath();
            grp.AddArc(5, 5, radius, radius, 180, 90);
          
            grp.AddArc(this.Width - (radius+5), 5, radius, radius, 270, 90);
          
            grp.AddArc(this.Width - (radius + 5), this.Height - (radius + 5), radius, radius, 0, 90);
           
            grp.AddArc(5, this.Height - (radius + 5), radius, radius, 90, 90);
          

            region.Intersect(grp);

            g.FillRegion(b, region);

          



            if (showButtonText)
            {
                Point p = new Point(textX, textY);
                SolidBrush frcolor = new SolidBrush(this.ForeColor);
                g.DrawString(text, this.Font, frcolor, p);
            }

            b.Dispose();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
           
            switch (buttonShape)
            {
                case ButtonsShapes.Circle:
                    this.DrawCircularButton(e.Graphics);
                    break;

                case ButtonsShapes.RoundRect:
                    this.DrawRoundRectangularButton(e.Graphics);
                    break;
            }
        }


    }
}
