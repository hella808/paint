namespace WinForm
{
    partial class FormPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaint));
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            xlbl = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            ylbl = new ToolStripStatusLabel();
            toolStripSplitButton1 = new ToolStripSplitButton();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            xuplbl = new ToolStripStatusLabel();
            toolStripStatusLabel6 = new ToolStripStatusLabel();
            yuplbl = new ToolStripStatusLabel();
            toolStripStatusLabel8 = new ToolStripStatusLabel();
            xclicklbl = new ToolStripStatusLabel();
            toolStripStatusLabel10 = new ToolStripStatusLabel();
            yclicklbl = new ToolStripStatusLabel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            orangebtn = new Button();
            blackbtn = new Button();
            whitnebtn = new Button();
            yellowbtn = new Button();
            purpblebtn = new Button();
            green = new Button();
            redbtn = new Button();
            bluebtn = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            clearToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(85, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1295, 706);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, xlbl, toolStripStatusLabel3, toolStripStatusLabel4, ylbl, toolStripSplitButton1, toolStripStatusLabel2, xuplbl, toolStripStatusLabel6, yuplbl, toolStripStatusLabel8, xclicklbl, toolStripStatusLabel10, yclicklbl });
            statusStrip1.Location = new Point(0, 706);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1380, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(13, 17);
            toolStripStatusLabel1.Text = "x";
            // 
            // xlbl
            // 
            xlbl.Name = "xlbl";
            xlbl.Size = new Size(13, 17);
            xlbl.Text = "0";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(13, 17);
            toolStripStatusLabel3.Text = "y";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(0, 17);
            // 
            // ylbl
            // 
            ylbl.Name = "ylbl";
            ylbl.Size = new Size(13, 17);
            ylbl.Text = "0";
            // 
            // toolStripSplitButton1
            // 
            toolStripSplitButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripSplitButton1.DropDownItems.AddRange(new ToolStripItem[] { clearToolStripMenuItem });
            toolStripSplitButton1.Image = (Image)resources.GetObject("toolStripSplitButton1.Image");
            toolStripSplitButton1.ImageTransparentColor = Color.Magenta;
            toolStripSplitButton1.Name = "toolStripSplitButton1";
            toolStripSplitButton1.Size = new Size(32, 20);
            toolStripSplitButton1.Text = "toolStripSplitButton1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(13, 17);
            toolStripStatusLabel2.Text = "x";
            // 
            // xuplbl
            // 
            xuplbl.Name = "xuplbl";
            xuplbl.Size = new Size(13, 17);
            xuplbl.Text = "0";
            // 
            // toolStripStatusLabel6
            // 
            toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            toolStripStatusLabel6.Size = new Size(13, 17);
            toolStripStatusLabel6.Text = "y";
            // 
            // yuplbl
            // 
            yuplbl.Name = "yuplbl";
            yuplbl.Size = new Size(13, 17);
            yuplbl.Text = "0";
            // 
            // toolStripStatusLabel8
            // 
            toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            toolStripStatusLabel8.Size = new Size(13, 17);
            toolStripStatusLabel8.Text = "x";
            // 
            // xclicklbl
            // 
            xclicklbl.Name = "xclicklbl";
            xclicklbl.Size = new Size(13, 17);
            xclicklbl.Text = "0";
            // 
            // toolStripStatusLabel10
            // 
            toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            toolStripStatusLabel10.Size = new Size(13, 17);
            toolStripStatusLabel10.Text = "y";
            // 
            // yclicklbl
            // 
            yclicklbl.Name = "yclicklbl";
            yclicklbl.Size = new Size(13, 17);
            yclicklbl.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Controls.Add(groupBox2);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(85, 706);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orangebtn);
            groupBox1.Controls.Add(blackbtn);
            groupBox1.Controls.Add(whitnebtn);
            groupBox1.Controls.Add(yellowbtn);
            groupBox1.Controls.Add(purpblebtn);
            groupBox1.Controls.Add(green);
            groupBox1.Controls.Add(redbtn);
            groupBox1.Controls.Add(bluebtn);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(68, 159);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Colors";
            // 
            // orangebtn
            // 
            orangebtn.BackColor = Color.Orange;
            orangebtn.Location = new Point(37, 87);
            orangebtn.Name = "orangebtn";
            orangebtn.Size = new Size(25, 25);
            orangebtn.TabIndex = 5;
            orangebtn.UseVisualStyleBackColor = false;
            // 
            // blackbtn
            // 
            blackbtn.BackColor = Color.Black;
            blackbtn.Location = new Point(6, 22);
            blackbtn.Name = "blackbtn";
            blackbtn.Size = new Size(25, 25);
            blackbtn.TabIndex = 1;
            blackbtn.UseVisualStyleBackColor = false;
            // 
            // whitnebtn
            // 
            whitnebtn.BackColor = Color.White;
            whitnebtn.Location = new Point(37, 22);
            whitnebtn.Name = "whitnebtn";
            whitnebtn.Size = new Size(25, 25);
            whitnebtn.TabIndex = 0;
            whitnebtn.UseVisualStyleBackColor = false;
            // 
            // yellowbtn
            // 
            yellowbtn.BackColor = Color.Yellow;
            yellowbtn.Location = new Point(37, 56);
            yellowbtn.Name = "yellowbtn";
            yellowbtn.Size = new Size(25, 25);
            yellowbtn.TabIndex = 3;
            yellowbtn.UseVisualStyleBackColor = false;
            // 
            // purpblebtn
            // 
            purpblebtn.BackColor = Color.Purple;
            purpblebtn.Location = new Point(6, 118);
            purpblebtn.Name = "purpblebtn";
            purpblebtn.Size = new Size(25, 25);
            purpblebtn.TabIndex = 6;
            purpblebtn.UseVisualStyleBackColor = false;
            // 
            // green
            // 
            green.BackColor = Color.Lime;
            green.Location = new Point(6, 87);
            green.Name = "green";
            green.Size = new Size(25, 25);
            green.TabIndex = 4;
            green.UseVisualStyleBackColor = false;
            // 
            // redbtn
            // 
            redbtn.BackColor = Color.Red;
            redbtn.Location = new Point(6, 56);
            redbtn.Name = "redbtn";
            redbtn.Size = new Size(25, 25);
            redbtn.TabIndex = 2;
            redbtn.UseVisualStyleBackColor = false;
            // 
            // bluebtn
            // 
            bluebtn.BackColor = Color.Blue;
            bluebtn.Location = new Point(40, 118);
            bluebtn.Name = "bluebtn";
            bluebtn.Size = new Size(25, 25);
            bluebtn.TabIndex = 7;
            bluebtn.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Location = new Point(3, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(75, 140);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "lines";
            // 
            // button4
            // 
            button4.Location = new Point(0, 109);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 15;
            button4.Text = "Style 4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 80);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Style 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(0, 51);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Style 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Style 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(3, 314);
            button5.Name = "button5";
            button5.Size = new Size(62, 45);
            button5.TabIndex = 13;
            button5.Text = "линия";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(3, 365);
            button6.Name = "button6";
            button6.Size = new Size(75, 48);
            button6.TabIndex = 14;
            button6.Text = "График";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 419);
            button7.Name = "button7";
            button7.Size = new Size(75, 50);
            button7.TabIndex = 15;
            button7.Text = "Прямоугольник";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // clearToolStripMenuItem
            // 
            clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            clearToolStripMenuItem.Size = new Size(180, 22);
            clearToolStripMenuItem.Text = "clear";
            clearToolStripMenuItem.Click += clearToolStripMenuItem_Click;
            // 
            // FormPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1380, 728);
            Controls.Add(pictureBox1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(statusStrip1);
            Name = "FormPaint";
            Text = "FormPaint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel xlbl;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private Button orangebtn;
        private Button blackbtn;
        private Button whitnebtn;
        private Button yellowbtn;
        private Button purpblebtn;
        private Button green;
        private Button redbtn;
        private Button bluebtn;
        private ToolStripStatusLabel ylbl;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel xuplbl;
        private ToolStripStatusLabel toolStripStatusLabel6;
        private ToolStripStatusLabel yuplbl;
        private ToolStripStatusLabel toolStripStatusLabel8;
        private ToolStripStatusLabel xclicklbl;
        private ToolStripStatusLabel toolStripStatusLabel10;
        private ToolStripStatusLabel yclicklbl;
        private Button button1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Button button7;
        private ToolStripMenuItem clearToolStripMenuItem;
    }
}