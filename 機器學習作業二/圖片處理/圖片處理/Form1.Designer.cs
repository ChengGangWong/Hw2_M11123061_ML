
namespace 圖片處理
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ResizeG = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.newName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.resizeNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newMask = new System.Windows.Forms.TextBox();
            this.orgMask = new System.Windows.Forms.TextBox();
            this.newXRay = new System.Windows.Forms.TextBox();
            this.orgXRay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CutOut = new System.Windows.Forms.GroupBox();
            this.cutoutHeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.cutoutNewName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cutoutWidth = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.newCOMask = new System.Windows.Forms.TextBox();
            this.orgCOMask = new System.Windows.Forms.TextBox();
            this.newCOXRay = new System.Windows.Forms.TextBox();
            this.orgCOXRay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Spin = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.spinNewName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.newSpinMask = new System.Windows.Forms.TextBox();
            this.orgSpinMask = new System.Windows.Forms.TextBox();
            this.newSpinXRay = new System.Windows.Forms.TextBox();
            this.orgSpinXRay = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nowProcess = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bwResize = new System.ComponentModel.BackgroundWorker();
            this.bwCutout = new System.ComponentModel.BackgroundWorker();
            this.bwSpin = new System.ComponentModel.BackgroundWorker();
            this.ResizeG.SuspendLayout();
            this.CutOut.SuspendLayout();
            this.Spin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResizeG
            // 
            this.ResizeG.Controls.Add(this.button5);
            this.ResizeG.Controls.Add(this.newName);
            this.ResizeG.Controls.Add(this.label6);
            this.ResizeG.Controls.Add(this.resizeNumber);
            this.ResizeG.Controls.Add(this.label5);
            this.ResizeG.Controls.Add(this.button4);
            this.ResizeG.Controls.Add(this.button3);
            this.ResizeG.Controls.Add(this.button2);
            this.ResizeG.Controls.Add(this.button1);
            this.ResizeG.Controls.Add(this.newMask);
            this.ResizeG.Controls.Add(this.orgMask);
            this.ResizeG.Controls.Add(this.newXRay);
            this.ResizeG.Controls.Add(this.orgXRay);
            this.ResizeG.Controls.Add(this.label4);
            this.ResizeG.Controls.Add(this.label3);
            this.ResizeG.Controls.Add(this.label2);
            this.ResizeG.Controls.Add(this.label1);
            this.ResizeG.Dock = System.Windows.Forms.DockStyle.Top;
            this.ResizeG.Location = new System.Drawing.Point(0, 0);
            this.ResizeG.Name = "ResizeG";
            this.ResizeG.Size = new System.Drawing.Size(836, 165);
            this.ResizeG.TabIndex = 0;
            this.ResizeG.TabStop = false;
            this.ResizeG.Text = "圖片原比例尺寸修改";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(634, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(173, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "執行";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // newName
            // 
            this.newName.Location = new System.Drawing.Point(723, 80);
            this.newName.Name = "newName";
            this.newName.Size = new System.Drawing.Size(84, 25);
            this.newName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(631, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "新圖片命名:";
            // 
            // resizeNumber
            // 
            this.resizeNumber.Location = new System.Drawing.Point(746, 33);
            this.resizeNumber.Name = "resizeNumber";
            this.resizeNumber.Size = new System.Drawing.Size(61, 25);
            this.resizeNumber.TabIndex = 13;
            this.resizeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResizeNumber_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "短邊尺寸(pixel):";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(523, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 11;
            this.button4.Text = "選擇";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(523, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 10;
            this.button3.Text = "選擇";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(523, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "選擇";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "選擇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // newMask
            // 
            this.newMask.BackColor = System.Drawing.Color.White;
            this.newMask.Location = new System.Drawing.Point(126, 126);
            this.newMask.Name = "newMask";
            this.newMask.ReadOnly = true;
            this.newMask.Size = new System.Drawing.Size(391, 25);
            this.newMask.TabIndex = 7;
            // 
            // orgMask
            // 
            this.orgMask.BackColor = System.Drawing.Color.White;
            this.orgMask.Location = new System.Drawing.Point(126, 94);
            this.orgMask.Name = "orgMask";
            this.orgMask.ReadOnly = true;
            this.orgMask.Size = new System.Drawing.Size(391, 25);
            this.orgMask.TabIndex = 6;
            // 
            // newXRay
            // 
            this.newXRay.BackColor = System.Drawing.Color.White;
            this.newXRay.Location = new System.Drawing.Point(126, 62);
            this.newXRay.Name = "newXRay";
            this.newXRay.ReadOnly = true;
            this.newXRay.Size = new System.Drawing.Size(391, 25);
            this.newXRay.TabIndex = 5;
            // 
            // orgXRay
            // 
            this.orgXRay.BackColor = System.Drawing.Color.White;
            this.orgXRay.Location = new System.Drawing.Point(126, 30);
            this.orgXRay.Name = "orgXRay";
            this.orgXRay.ReadOnly = true;
            this.orgXRay.Size = new System.Drawing.Size(391, 25);
            this.orgXRay.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mask新資料夾:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "X-Ray新資料夾:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mask原資料夾:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X-Ray原資料夾:";
            // 
            // CutOut
            // 
            this.CutOut.Controls.Add(this.cutoutHeight);
            this.CutOut.Controls.Add(this.label15);
            this.CutOut.Controls.Add(this.button6);
            this.CutOut.Controls.Add(this.cutoutNewName);
            this.CutOut.Controls.Add(this.label9);
            this.CutOut.Controls.Add(this.cutoutWidth);
            this.CutOut.Controls.Add(this.label10);
            this.CutOut.Controls.Add(this.button7);
            this.CutOut.Controls.Add(this.button8);
            this.CutOut.Controls.Add(this.button9);
            this.CutOut.Controls.Add(this.button10);
            this.CutOut.Controls.Add(this.newCOMask);
            this.CutOut.Controls.Add(this.orgCOMask);
            this.CutOut.Controls.Add(this.newCOXRay);
            this.CutOut.Controls.Add(this.orgCOXRay);
            this.CutOut.Controls.Add(this.label11);
            this.CutOut.Controls.Add(this.label12);
            this.CutOut.Controls.Add(this.label13);
            this.CutOut.Controls.Add(this.label14);
            this.CutOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.CutOut.Location = new System.Drawing.Point(0, 165);
            this.CutOut.Name = "CutOut";
            this.CutOut.Size = new System.Drawing.Size(836, 172);
            this.CutOut.TabIndex = 1;
            this.CutOut.TabStop = false;
            this.CutOut.Text = "圖片裁剪";
            // 
            // cutoutHeight
            // 
            this.cutoutHeight.Location = new System.Drawing.Point(701, 65);
            this.cutoutHeight.Name = "cutoutHeight";
            this.cutoutHeight.Size = new System.Drawing.Size(106, 25);
            this.cutoutHeight.TabIndex = 35;
            this.cutoutHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResizeNumber_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(631, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 15);
            this.label15.TabIndex = 34;
            this.label15.Text = "高(pixel):";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(634, 130);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(173, 31);
            this.button6.TabIndex = 33;
            this.button6.Text = "執行";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // cutoutNewName
            // 
            this.cutoutNewName.Location = new System.Drawing.Point(723, 98);
            this.cutoutNewName.Name = "cutoutNewName";
            this.cutoutNewName.Size = new System.Drawing.Size(84, 25);
            this.cutoutNewName.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(631, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 15);
            this.label9.TabIndex = 31;
            this.label9.Text = "新圖片命名:";
            // 
            // cutoutWidth
            // 
            this.cutoutWidth.Location = new System.Drawing.Point(701, 34);
            this.cutoutWidth.Name = "cutoutWidth";
            this.cutoutWidth.Size = new System.Drawing.Size(106, 25);
            this.cutoutWidth.TabIndex = 30;
            this.cutoutWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ResizeNumber_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(631, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 29;
            this.label10.Text = "寬(pixel):";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(532, 127);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 26);
            this.button7.TabIndex = 28;
            this.button7.Text = "選擇";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(532, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 26);
            this.button8.TabIndex = 27;
            this.button8.Text = "選擇";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(532, 63);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 26);
            this.button9.TabIndex = 26;
            this.button9.Text = "選擇";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(532, 31);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 26);
            this.button10.TabIndex = 25;
            this.button10.Text = "選擇";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // newCOMask
            // 
            this.newCOMask.BackColor = System.Drawing.Color.White;
            this.newCOMask.Location = new System.Drawing.Point(135, 127);
            this.newCOMask.Name = "newCOMask";
            this.newCOMask.ReadOnly = true;
            this.newCOMask.Size = new System.Drawing.Size(391, 25);
            this.newCOMask.TabIndex = 24;
            // 
            // orgCOMask
            // 
            this.orgCOMask.BackColor = System.Drawing.Color.White;
            this.orgCOMask.Location = new System.Drawing.Point(135, 94);
            this.orgCOMask.Name = "orgCOMask";
            this.orgCOMask.ReadOnly = true;
            this.orgCOMask.Size = new System.Drawing.Size(391, 25);
            this.orgCOMask.TabIndex = 23;
            // 
            // newCOXRay
            // 
            this.newCOXRay.BackColor = System.Drawing.Color.White;
            this.newCOXRay.Location = new System.Drawing.Point(135, 63);
            this.newCOXRay.Name = "newCOXRay";
            this.newCOXRay.ReadOnly = true;
            this.newCOXRay.Size = new System.Drawing.Size(391, 25);
            this.newCOXRay.TabIndex = 22;
            // 
            // orgCOXRay
            // 
            this.orgCOXRay.BackColor = System.Drawing.Color.White;
            this.orgCOXRay.Location = new System.Drawing.Point(135, 31);
            this.orgCOXRay.Name = "orgCOXRay";
            this.orgCOXRay.ReadOnly = true;
            this.orgCOXRay.Size = new System.Drawing.Size(391, 25);
            this.orgCOXRay.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Mask新資料夾:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "X-Ray新資料夾:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 18;
            this.label13.Text = "Mask原資料夾:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "X-Ray原資料夾:";
            // 
            // Spin
            // 
            this.Spin.Controls.Add(this.button11);
            this.Spin.Controls.Add(this.spinNewName);
            this.Spin.Controls.Add(this.label17);
            this.Spin.Controls.Add(this.button12);
            this.Spin.Controls.Add(this.button13);
            this.Spin.Controls.Add(this.button14);
            this.Spin.Controls.Add(this.button15);
            this.Spin.Controls.Add(this.newSpinMask);
            this.Spin.Controls.Add(this.orgSpinMask);
            this.Spin.Controls.Add(this.newSpinXRay);
            this.Spin.Controls.Add(this.orgSpinXRay);
            this.Spin.Controls.Add(this.label19);
            this.Spin.Controls.Add(this.label20);
            this.Spin.Controls.Add(this.label21);
            this.Spin.Controls.Add(this.label22);
            this.Spin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Spin.Location = new System.Drawing.Point(0, 337);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(836, 167);
            this.Spin.TabIndex = 2;
            this.Spin.TabStop = false;
            this.Spin.Text = "圖片旋轉";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(634, 130);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(173, 31);
            this.button11.TabIndex = 52;
            this.button11.Text = "執行";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // spinNewName
            // 
            this.spinNewName.Location = new System.Drawing.Point(723, 66);
            this.spinNewName.Name = "spinNewName";
            this.spinNewName.Size = new System.Drawing.Size(84, 25);
            this.spinNewName.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(631, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = "新圖片命名:";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(532, 127);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 26);
            this.button12.TabIndex = 47;
            this.button12.Text = "選擇";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(532, 95);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 26);
            this.button13.TabIndex = 46;
            this.button13.Text = "選擇";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(532, 63);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 26);
            this.button14.TabIndex = 45;
            this.button14.Text = "選擇";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.Button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(532, 31);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 26);
            this.button15.TabIndex = 44;
            this.button15.Text = "選擇";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.Button15_Click);
            // 
            // newSpinMask
            // 
            this.newSpinMask.BackColor = System.Drawing.Color.White;
            this.newSpinMask.Location = new System.Drawing.Point(135, 127);
            this.newSpinMask.Name = "newSpinMask";
            this.newSpinMask.ReadOnly = true;
            this.newSpinMask.Size = new System.Drawing.Size(391, 25);
            this.newSpinMask.TabIndex = 43;
            // 
            // orgSpinMask
            // 
            this.orgSpinMask.BackColor = System.Drawing.Color.White;
            this.orgSpinMask.Location = new System.Drawing.Point(135, 94);
            this.orgSpinMask.Name = "orgSpinMask";
            this.orgSpinMask.ReadOnly = true;
            this.orgSpinMask.Size = new System.Drawing.Size(391, 25);
            this.orgSpinMask.TabIndex = 42;
            // 
            // newSpinXRay
            // 
            this.newSpinXRay.BackColor = System.Drawing.Color.White;
            this.newSpinXRay.Location = new System.Drawing.Point(135, 63);
            this.newSpinXRay.Name = "newSpinXRay";
            this.newSpinXRay.ReadOnly = true;
            this.newSpinXRay.Size = new System.Drawing.Size(391, 25);
            this.newSpinXRay.TabIndex = 41;
            // 
            // orgSpinXRay
            // 
            this.orgSpinXRay.BackColor = System.Drawing.Color.White;
            this.orgSpinXRay.Location = new System.Drawing.Point(135, 31);
            this.orgSpinXRay.Name = "orgSpinXRay";
            this.orgSpinXRay.ReadOnly = true;
            this.orgSpinXRay.Size = new System.Drawing.Size(391, 25);
            this.orgSpinXRay.TabIndex = 40;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 15);
            this.label19.TabIndex = 39;
            this.label19.Text = "Mask新資料夾:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 66);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(108, 15);
            this.label20.TabIndex = 38;
            this.label20.Text = "X-Ray新資料夾:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 98);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(102, 15);
            this.label21.TabIndex = 37;
            this.label21.Text = "Mask原資料夾:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 34);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(108, 15);
            this.label22.TabIndex = 36;
            this.label22.Text = "X-Ray原資料夾:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 504);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 381);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "執行";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMsg);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(830, 296);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // tbMsg
            // 
            this.tbMsg.BackColor = System.Drawing.Color.White;
            this.tbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMsg.Location = new System.Drawing.Point(3, 21);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMsg.Size = new System.Drawing.Size(824, 272);
            this.tbMsg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nowProcess);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 317);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // nowProcess
            // 
            this.nowProcess.Location = new System.Drawing.Point(71, 24);
            this.nowProcess.Name = "nowProcess";
            this.nowProcess.Size = new System.Drawing.Size(688, 23);
            this.nowProcess.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(780, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "label7";
            // 
            // bwResize
            // 
            this.bwResize.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwResize_DoWork);
            // 
            // bwCutout
            // 
            this.bwCutout.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwCutout_DoWork);
            // 
            // bwSpin
            // 
            this.bwSpin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwSpin_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 885);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.CutOut);
            this.Controls.Add(this.ResizeG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "圖片處理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeG.ResumeLayout(false);
            this.ResizeG.PerformLayout();
            this.CutOut.ResumeLayout(false);
            this.CutOut.PerformLayout();
            this.Spin.ResumeLayout(false);
            this.Spin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ResizeG;
        private System.Windows.Forms.TextBox resizeNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox newMask;
        private System.Windows.Forms.TextBox orgMask;
        private System.Windows.Forms.TextBox newXRay;
        private System.Windows.Forms.TextBox orgXRay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CutOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newName;
        private System.Windows.Forms.GroupBox Spin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar nowProcess;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker bwResize;
        private System.Windows.Forms.TextBox cutoutHeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox cutoutNewName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox cutoutWidth;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox newCOMask;
        private System.Windows.Forms.TextBox orgCOMask;
        private System.Windows.Forms.TextBox newCOXRay;
        private System.Windows.Forms.TextBox orgCOXRay;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker bwCutout;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox spinNewName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox newSpinMask;
        private System.Windows.Forms.TextBox orgSpinMask;
        private System.Windows.Forms.TextBox newSpinXRay;
        private System.Windows.Forms.TextBox orgSpinXRay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.ComponentModel.BackgroundWorker bwSpin;
    }
}

