﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSupermarket.CustomControl
{
    [DefaultEvent("_TextChanged")]
    public partial class CustomTextBox : UserControl
    {

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlineStyle = false;
        private Color focusBorderColor = Color.HotPink;
        private bool isFocus = false;
        private int borderRadius = 0;


        public CustomTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        [Category("Custom Textbox")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Custom Textbox")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Custom Textbox")]
        public bool UnderlineStyle
        {
            get
            {

                return underlineStyle;
            }
            set
            {
                underlineStyle = value;
                this.Invalidate();
            }
        }
        [Category("Custom Textbox")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("Custom Multiline")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }


        [Category("Custom Textbox")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Custom Textbox")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Custom Textbox")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("Custom Textbox")]
        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        [Category("Custom Textbox")]
        public Color FocusBorderColor { get => focusBorderColor; set => focusBorderColor = value; }
        [Category("Custom Textbox")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//Redraw control
                }
            }
        }

        public bool ReadOnly1 { get => textBox1.ReadOnly; set => textBox1.ReadOnly = value; }

        [Category("Custom Textbox")]
        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }
        [Category("Custom Textbox")]
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics grp = e.Graphics;

            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    grp.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocus) penBorder.Color = focusBorderColor;
                    if (UnderlineStyle) //Line Style
                    {
                        //Draw border smoothing
                        grp.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        grp.SmoothingMode = SmoothingMode.None;
                        grp.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        grp.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        grp.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                using (Pen pen = new Pen(borderColor, borderSize))
                {

                    pen.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (!isFocus)
                    {
                        if (underlineStyle)
                        {
                            grp.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            grp.DrawRectangle(pen, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }
                    else
                    {
                        pen.Color = focusBorderColor;
                        if (underlineStyle)
                        {
                            grp.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            grp.DrawRectangle(pen, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                        }
                    }

                }
            }

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                UpdateControlHeight();
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int textHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, textHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Bottom + this.Padding.Top;
            }
        }



        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocus = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocus = false;
            this.Invalidate();
        }

        private void textBox1_EnabledChanged(object sender, EventArgs e)
        {

        }
    }
}
