using Bunifu.Framework.UI;

namespace Lavy
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnWtap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGui = new System.Windows.Forms.Button();
            this.btnJitter = new System.Windows.Forms.Button();
            this.btnDestruct = new System.Windows.Forms.Button();
            this.btnAutoclicker = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.setGuiColor = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.autoclickerThread = new System.Windows.Forms.Timer(this.components);
            this.wtapThread = new System.Windows.Forms.Timer(this.components);
            this.wtapThreadPress = new System.Windows.Forms.Timer(this.components);
            this.rainbow = new System.Windows.Forms.Timer(this.components);
            this.tabControlWithoutHeader1 = new Lavy.TabControlWithoutHeader();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.autoclickerStatus = new Bunifu.Framework.UI.BunifuSwitch();
            this.sliderMaxCPS = new Bunifu.Framework.UI.BunifuSlider();
            this.sliderMinCPS = new Bunifu.Framework.UI.BunifuSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.method2 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.jitterY = new Bunifu.Framework.UI.BunifuSlider();
            this.label7 = new System.Windows.Forms.Label();
            this.jitterX = new Bunifu.Framework.UI.BunifuSlider();
            this.label6 = new System.Windows.Forms.Label();
            this.jitterStatus = new Bunifu.Framework.UI.BunifuSwitch();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.rainbowCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.button1 = new System.Windows.Forms.Button();
            this.wtapPage = new System.Windows.Forms.TabPage();
            this.bunifuSlider1 = new Bunifu.Framework.UI.BunifuSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.wtapStatus = new Bunifu.Framework.UI.BunifuSwitch();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControlWithoutHeader1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.wtapPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnWtap);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.tabControlWithoutHeader1);
            this.panel1.Controls.Add(this.btnJitter);
            this.panel1.Controls.Add(this.btnDestruct);
            this.panel1.Controls.Add(this.btnAutoclicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 271);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnWtap
            // 
            this.btnWtap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnWtap.FlatAppearance.BorderSize = 0;
            this.btnWtap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWtap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWtap.Location = new System.Drawing.Point(175, 1);
            this.btnWtap.Name = "btnWtap";
            this.btnWtap.Size = new System.Drawing.Size(75, 23);
            this.btnWtap.TabIndex = 5;
            this.btnWtap.Text = "W-TAP";
            this.btnWtap.UseVisualStyleBackColor = false;
            this.btnWtap.Click += new System.EventHandler(this.btnWtap_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(566, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(10, 10);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnGui.FlatAppearance.BorderSize = 0;
            this.btnGui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Location = new System.Drawing.Point(250, 1);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 23);
            this.btnGui.TabIndex = 3;
            this.btnGui.Text = "GUI";
            this.btnGui.UseVisualStyleBackColor = false;
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnJitter
            // 
            this.btnJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnJitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnJitter.FlatAppearance.BorderSize = 0;
            this.btnJitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJitter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJitter.Location = new System.Drawing.Point(100, 1);
            this.btnJitter.Name = "btnJitter";
            this.btnJitter.Size = new System.Drawing.Size(75, 23);
            this.btnJitter.TabIndex = 1;
            this.btnJitter.Text = "JITTER";
            this.btnJitter.UseVisualStyleBackColor = false;
            this.btnJitter.Click += new System.EventHandler(this.btnJitter_Click);
            // 
            // btnDestruct
            // 
            this.btnDestruct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDestruct.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDestruct.FlatAppearance.BorderSize = 0;
            this.btnDestruct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestruct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestruct.Location = new System.Drawing.Point(325, 1);
            this.btnDestruct.Name = "btnDestruct";
            this.btnDestruct.Size = new System.Drawing.Size(75, 23);
            this.btnDestruct.TabIndex = 1;
            this.btnDestruct.Text = "DESTRUCT";
            this.btnDestruct.UseVisualStyleBackColor = false;
            this.btnDestruct.Click += new System.EventHandler(this.btnDestruct_Click);
            // 
            // btnAutoclicker
            // 
            this.btnAutoclicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAutoclicker.FlatAppearance.BorderSize = 0;
            this.btnAutoclicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoclicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoclicker.Location = new System.Drawing.Point(1, 1);
            this.btnAutoclicker.Name = "btnAutoclicker";
            this.btnAutoclicker.Size = new System.Drawing.Size(99, 23);
            this.btnAutoclicker.TabIndex = 1;
            this.btnAutoclicker.Text = "AUTOCLICKER";
            this.btnAutoclicker.UseVisualStyleBackColor = false;
            this.btnAutoclicker.Click += new System.EventHandler(this.btnAutoclicker_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lavy 2.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(573, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(547, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // setGuiColor
            // 
            this.setGuiColor.Enabled = true;
            this.setGuiColor.Interval = 150;
            this.setGuiColor.Tick += new System.EventHandler(this.setGuiColor_Tick);
            // 
            // autoclickerThread
            // 
            this.autoclickerThread.Enabled = true;
            this.autoclickerThread.Interval = 900;
            this.autoclickerThread.Tick += new System.EventHandler(this.autoclickerThread_Tick);
            // 
            // wtapThread
            // 
            this.wtapThread.Tick += new System.EventHandler(this.wtapThread_Tick);
            // 
            // wtapThreadPress
            // 
            this.wtapThreadPress.Enabled = true;
            this.wtapThreadPress.Tick += new System.EventHandler(this.wtapThreadPress_Tick);
            // 
            // rainbow
            // 
            this.rainbow.Enabled = true;
            this.rainbow.Tick += new System.EventHandler(this.rainbow_Tick);
            // 
            // tabControlWithoutHeader1
            // 
            this.tabControlWithoutHeader1.Controls.Add(this.tabPage1);
            this.tabControlWithoutHeader1.Controls.Add(this.tabPage2);
            this.tabControlWithoutHeader1.Controls.Add(this.tabPage3);
            this.tabControlWithoutHeader1.Controls.Add(this.tabPage4);
            this.tabControlWithoutHeader1.Controls.Add(this.wtapPage);
            this.tabControlWithoutHeader1.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControlWithoutHeader1.Location = new System.Drawing.Point(17, 32);
            this.tabControlWithoutHeader1.Multiline = true;
            this.tabControlWithoutHeader1.Name = "tabControlWithoutHeader1";
            this.tabControlWithoutHeader1.SelectedIndex = 0;
            this.tabControlWithoutHeader1.Size = new System.Drawing.Size(576, 227);
            this.tabControlWithoutHeader1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.autoclickerStatus);
            this.tabPage1.Controls.Add(this.sliderMaxCPS);
            this.tabPage1.Controls.Add(this.sliderMinCPS);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 218);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(18, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hotkey: ALT";
            // 
            // autoclickerStatus
            // 
            this.autoclickerStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.autoclickerStatus.BorderRadius = 0;
            this.autoclickerStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.autoclickerStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoclickerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.autoclickerStatus.Location = new System.Drawing.Point(20, 30);
            this.autoclickerStatus.Margin = new System.Windows.Forms.Padding(5);
            this.autoclickerStatus.Name = "autoclickerStatus";
            this.autoclickerStatus.Oncolor = System.Drawing.Color.SeaGreen;
            this.autoclickerStatus.Onoffcolor = System.Drawing.Color.DarkGray;
            this.autoclickerStatus.Size = new System.Drawing.Size(51, 19);
            this.autoclickerStatus.TabIndex = 6;
            this.autoclickerStatus.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.autoclickerStatus.Value = true;
            // 
            // sliderMaxCPS
            // 
            this.sliderMaxCPS.BackColor = System.Drawing.Color.Transparent;
            this.sliderMaxCPS.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sliderMaxCPS.BorderRadius = 0;
            this.sliderMaxCPS.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.sliderMaxCPS.Location = new System.Drawing.Point(22, 150);
            this.sliderMaxCPS.Margin = new System.Windows.Forms.Padding(5);
            this.sliderMaxCPS.MaximumValue = 16;
            this.sliderMaxCPS.Name = "sliderMaxCPS";
            this.sliderMaxCPS.Size = new System.Drawing.Size(404, 30);
            this.sliderMaxCPS.TabIndex = 5;
            this.sliderMaxCPS.Value = 6;
            this.sliderMaxCPS.ValueChanged += new System.EventHandler(this.sliderMaxCPS_ValueChanged);
            // 
            // sliderMinCPS
            // 
            this.sliderMinCPS.BackColor = System.Drawing.Color.Transparent;
            this.sliderMinCPS.BackgroudColor = System.Drawing.Color.DarkGray;
            this.sliderMinCPS.BorderRadius = 0;
            this.sliderMinCPS.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.sliderMinCPS.Location = new System.Drawing.Point(22, 87);
            this.sliderMinCPS.Margin = new System.Windows.Forms.Padding(5);
            this.sliderMinCPS.MaximumValue = 16;
            this.sliderMinCPS.Name = "sliderMinCPS";
            this.sliderMinCPS.Size = new System.Drawing.Size(404, 30);
            this.sliderMinCPS.TabIndex = 4;
            this.sliderMinCPS.Value = 5;
            this.sliderMinCPS.ValueChanged += new System.EventHandler(this.sliderMinCPS_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Maximum CPS (8)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minimum CPS (7)";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.method2);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 218);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(24, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(521, 68);
            this.button3.TabIndex = 2;
            this.button3.Text = "Destruct";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Clear \"explorer.exe\" strings";
            // 
            // method2
            // 
            this.method2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.method2.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.method2.Checked = true;
            this.method2.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.method2.ForeColor = System.Drawing.Color.White;
            this.method2.Location = new System.Drawing.Point(25, 23);
            this.method2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.method2.Name = "method2";
            this.method2.Size = new System.Drawing.Size(20, 20);
            this.method2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage3.Controls.Add(this.jitterY);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.jitterX);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.jitterStatus);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(568, 218);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            // 
            // jitterY
            // 
            this.jitterY.BackColor = System.Drawing.Color.Transparent;
            this.jitterY.BackgroudColor = System.Drawing.Color.DarkGray;
            this.jitterY.BorderRadius = 0;
            this.jitterY.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.jitterY.Location = new System.Drawing.Point(115, 103);
            this.jitterY.Margin = new System.Windows.Forms.Padding(5);
            this.jitterY.MaximumValue = 10;
            this.jitterY.Name = "jitterY";
            this.jitterY.Size = new System.Drawing.Size(415, 30);
            this.jitterY.TabIndex = 4;
            this.jitterY.Value = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Vertical:";
            // 
            // jitterX
            // 
            this.jitterX.BackColor = System.Drawing.Color.Transparent;
            this.jitterX.BackgroudColor = System.Drawing.Color.DarkGray;
            this.jitterX.BorderRadius = 0;
            this.jitterX.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.jitterX.Location = new System.Drawing.Point(115, 59);
            this.jitterX.Margin = new System.Windows.Forms.Padding(5);
            this.jitterX.MaximumValue = 10;
            this.jitterX.Name = "jitterX";
            this.jitterX.Size = new System.Drawing.Size(415, 30);
            this.jitterX.TabIndex = 2;
            this.jitterX.Value = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Horizontal:";
            // 
            // jitterStatus
            // 
            this.jitterStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.jitterStatus.BorderRadius = 0;
            this.jitterStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.jitterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jitterStatus.Location = new System.Drawing.Point(20, 30);
            this.jitterStatus.Margin = new System.Windows.Forms.Padding(5);
            this.jitterStatus.Name = "jitterStatus";
            this.jitterStatus.Oncolor = System.Drawing.Color.SeaGreen;
            this.jitterStatus.Onoffcolor = System.Drawing.Color.DarkGray;
            this.jitterStatus.Size = new System.Drawing.Size(51, 19);
            this.jitterStatus.TabIndex = 0;
            this.jitterStatus.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.jitterStatus.Value = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.rainbowCheck);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(568, 218);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(249, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rainbow";
            // 
            // rainbowCheck
            // 
            this.rainbowCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.rainbowCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.rainbowCheck.Checked = false;
            this.rainbowCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.rainbowCheck.ForeColor = System.Drawing.Color.White;
            this.rainbowCheck.Location = new System.Drawing.Point(223, 122);
            this.rainbowCheck.Name = "rainbowCheck";
            this.rainbowCheck.Size = new System.Drawing.Size(20, 20);
            this.rainbowCheck.TabIndex = 7;
            this.rainbowCheck.OnChange += new System.EventHandler(this.rainbowCheck_OnChange);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.Location = new System.Drawing.Point(188, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "GUI Color...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // wtapPage
            // 
            this.wtapPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.wtapPage.Controls.Add(this.bunifuSlider1);
            this.wtapPage.Controls.Add(this.label9);
            this.wtapPage.Controls.Add(this.wtapStatus);
            this.wtapPage.Location = new System.Drawing.Point(4, 5);
            this.wtapPage.Name = "wtapPage";
            this.wtapPage.Padding = new System.Windows.Forms.Padding(3);
            this.wtapPage.Size = new System.Drawing.Size(568, 218);
            this.wtapPage.TabIndex = 5;
            this.wtapPage.Text = "tabPage5";
            // 
            // bunifuSlider1
            // 
            this.bunifuSlider1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSlider1.BackgroudColor = System.Drawing.Color.DarkGray;
            this.bunifuSlider1.BorderRadius = 0;
            this.bunifuSlider1.IndicatorColor = System.Drawing.Color.SeaGreen;
            this.bunifuSlider1.Location = new System.Drawing.Point(20, 99);
            this.bunifuSlider1.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuSlider1.MaximumValue = 500;
            this.bunifuSlider1.Name = "bunifuSlider1";
            this.bunifuSlider1.Size = new System.Drawing.Size(526, 30);
            this.bunifuSlider1.TabIndex = 9;
            this.bunifuSlider1.Value = 100;
            this.bunifuSlider1.ValueChanged += new System.EventHandler(this.bunifuSlider1_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Delay (100):";
            // 
            // wtapStatus
            // 
            this.wtapStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.wtapStatus.BorderRadius = 0;
            this.wtapStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.wtapStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtapStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wtapStatus.Location = new System.Drawing.Point(20, 30);
            this.wtapStatus.Margin = new System.Windows.Forms.Padding(5);
            this.wtapStatus.Name = "wtapStatus";
            this.wtapStatus.Oncolor = System.Drawing.Color.SeaGreen;
            this.wtapStatus.Onoffcolor = System.Drawing.Color.DarkGray;
            this.wtapStatus.Size = new System.Drawing.Size(51, 19);
            this.wtapStatus.TabIndex = 7;
            this.wtapStatus.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.wtapStatus.Value = false;
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(605, 301);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashboard_FormClosing);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControlWithoutHeader1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.wtapPage.ResumeLayout(false);
            this.wtapPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnAutoclicker;
        private TabControlWithoutHeader tabControlWithoutHeader1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.Button btnDestruct;
        private System.Windows.Forms.Timer setGuiColor;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer autoclickerThread;
        private System.Windows.Forms.TabPage tabPage1;
        private Bunifu.Framework.UI.BunifuSwitch autoclickerStatus;
        private Bunifu.Framework.UI.BunifuSlider sliderMaxCPS;
        private Bunifu.Framework.UI.BunifuSlider sliderMinCPS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer wtapThread;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnJitter;
        private Bunifu.Framework.UI.BunifuSlider jitterY;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuSlider jitterX;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuSwitch jitterStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCheckbox method2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnWtap;
        private System.Windows.Forms.TabPage wtapPage;
        private Bunifu.Framework.UI.BunifuSlider bunifuSlider1;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuSwitch wtapStatus;
        private System.Windows.Forms.Timer wtapThreadPress;
        private System.Windows.Forms.Label label4;
        private BunifuCheckbox rainbowCheck;
        public System.Windows.Forms.Timer rainbow;
    }
}