
namespace CTR_demo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabControl_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_brake = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.rtb_message = new System.Windows.Forms.RichTextBox();
            this.gb_translation = new System.Windows.Forms.GroupBox();
            this.lb_translation_id = new System.Windows.Forms.Label();
            this.btn_translation_send = new System.Windows.Forms.Button();
            this.cb_translation_id = new System.Windows.Forms.ComboBox();
            this.tb_translation_distance = new System.Windows.Forms.TextBox();
            this.lb_translation_distance = new System.Windows.Forms.Label();
            this.gb_rotation = new System.Windows.Forms.GroupBox();
            this.btn_rotation_send = new System.Windows.Forms.Button();
            this.tb_rotation_absoluteAngle = new System.Windows.Forms.TextBox();
            this.lb_rotation_id = new System.Windows.Forms.Label();
            this.lb_rotation_absoluteAngle = new System.Windows.Forms.Label();
            this.tb_rotation_relativeAngle = new System.Windows.Forms.TextBox();
            this.cb_rotation_id = new System.Windows.Forms.ComboBox();
            this.lb_rotation_relativeAngle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_id6_pos = new System.Windows.Forms.TextBox();
            this.tb_id5_pos = new System.Windows.Forms.TextBox();
            this.tb_id4_pos = new System.Windows.Forms.TextBox();
            this.tb_id3_pos = new System.Windows.Forms.TextBox();
            this.tb_id2_pos = new System.Windows.Forms.TextBox();
            this.tb_id1_pos = new System.Windows.Forms.TextBox();
            this.lb_id6 = new System.Windows.Forms.Label();
            this.lb_id5 = new System.Windows.Forms.Label();
            this.lb_id4 = new System.Windows.Forms.Label();
            this.lb_id3 = new System.Windows.Forms.Label();
            this.lb_id2 = new System.Windows.Forms.Label();
            this.lb_id1 = new System.Windows.Forms.Label();
            this.gb_movement = new System.Windows.Forms.GroupBox();
            this.btn_id_CW = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lb_id = new System.Windows.Forms.Label();
            this.btn_id_CCW = new System.Windows.Forms.Button();
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gb_port = new System.Windows.Forms.GroupBox();
            this.lb_connectStatus = new System.Windows.Forms.Label();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.cb_baudrate = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.lb_portName = new System.Windows.Forms.Label();
            this.lb_baudrate = new System.Windows.Forms.Label();
            this.cb_portName = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.gb_position = new System.Windows.Forms.GroupBox();
            this.lb_id1_pos = new System.Windows.Forms.Label();
            this.lb_id2_pos = new System.Windows.Forms.Label();
            this.lb_id3_pos = new System.Windows.Forms.Label();
            this.lb_id4_pos = new System.Windows.Forms.Label();
            this.lb_id5_pos = new System.Windows.Forms.Label();
            this.lb_id6_pos = new System.Windows.Forms.Label();
            this.tabControl_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gb_translation.SuspendLayout();
            this.gb_rotation.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.gb_movement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_port.SuspendLayout();
            this.gb_position.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_main
            // 
            this.tabControl_main.Controls.Add(this.tabPage1);
            this.tabControl_main.Controls.Add(this.tabPage3);
            this.tabControl_main.Controls.Add(this.tabPage2);
            this.tabControl_main.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl_main.Location = new System.Drawing.Point(12, 78);
            this.tabControl_main.Name = "tabControl_main";
            this.tabControl_main.SelectedIndex = 0;
            this.tabControl_main.Size = new System.Drawing.Size(720, 597);
            this.tabControl_main.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_brake);
            this.tabPage1.Controls.Add(this.btn_clear);
            this.tabPage1.Controls.Add(this.rtb_message);
            this.tabPage1.Controls.Add(this.gb_translation);
            this.tabPage1.Controls.Add(this.gb_rotation);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(712, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Testing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_brake
            // 
            this.btn_brake.Location = new System.Drawing.Point(509, 440);
            this.btn_brake.Name = "btn_brake";
            this.btn_brake.Size = new System.Drawing.Size(90, 23);
            this.btn_brake.TabIndex = 18;
            this.btn_brake.Text = "Brake";
            this.btn_brake.UseVisualStyleBackColor = true;
            this.btn_brake.Click += new System.EventHandler(this.btn_brake_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(605, 440);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 23);
            this.btn_clear.TabIndex = 17;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // rtb_message
            // 
            this.rtb_message.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rtb_message.Location = new System.Drawing.Point(15, 134);
            this.rtb_message.Name = "rtb_message";
            this.rtb_message.Size = new System.Drawing.Size(680, 300);
            this.rtb_message.TabIndex = 16;
            this.rtb_message.Text = "";
            // 
            // gb_translation
            // 
            this.gb_translation.Controls.Add(this.lb_translation_id);
            this.gb_translation.Controls.Add(this.btn_translation_send);
            this.gb_translation.Controls.Add(this.cb_translation_id);
            this.gb_translation.Controls.Add(this.tb_translation_distance);
            this.gb_translation.Controls.Add(this.lb_translation_distance);
            this.gb_translation.Location = new System.Drawing.Point(15, 5);
            this.gb_translation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_translation.Name = "gb_translation";
            this.gb_translation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_translation.Size = new System.Drawing.Size(680, 60);
            this.gb_translation.TabIndex = 15;
            this.gb_translation.TabStop = false;
            this.gb_translation.Text = "Translation Motors Control";
            // 
            // lb_translation_id
            // 
            this.lb_translation_id.AutoSize = true;
            this.lb_translation_id.Location = new System.Drawing.Point(6, 30);
            this.lb_translation_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_translation_id.Name = "lb_translation_id";
            this.lb_translation_id.Size = new System.Drawing.Size(24, 16);
            this.lb_translation_id.TabIndex = 8;
            this.lb_translation_id.Text = "ID";
            // 
            // btn_translation_send
            // 
            this.btn_translation_send.Location = new System.Drawing.Point(549, 23);
            this.btn_translation_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_translation_send.Name = "btn_translation_send";
            this.btn_translation_send.Size = new System.Drawing.Size(90, 23);
            this.btn_translation_send.TabIndex = 14;
            this.btn_translation_send.Text = "Send";
            this.btn_translation_send.UseVisualStyleBackColor = true;
            this.btn_translation_send.Click += new System.EventHandler(this.btn_translation_send_Click);
            // 
            // cb_translation_id
            // 
            this.cb_translation_id.FormattingEnabled = true;
            this.cb_translation_id.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cb_translation_id.Location = new System.Drawing.Point(41, 28);
            this.cb_translation_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_translation_id.Name = "cb_translation_id";
            this.cb_translation_id.Size = new System.Drawing.Size(80, 24);
            this.cb_translation_id.TabIndex = 11;
            // 
            // tb_translation_distance
            // 
            this.tb_translation_distance.Location = new System.Drawing.Point(191, 27);
            this.tb_translation_distance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_translation_distance.Name = "tb_translation_distance";
            this.tb_translation_distance.Size = new System.Drawing.Size(76, 27);
            this.tb_translation_distance.TabIndex = 13;
            // 
            // lb_translation_distance
            // 
            this.lb_translation_distance.AutoSize = true;
            this.lb_translation_distance.Location = new System.Drawing.Point(125, 31);
            this.lb_translation_distance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_translation_distance.Name = "lb_translation_distance";
            this.lb_translation_distance.Size = new System.Drawing.Size(62, 16);
            this.lb_translation_distance.TabIndex = 10;
            this.lb_translation_distance.Text = "Distance";
            // 
            // gb_rotation
            // 
            this.gb_rotation.Controls.Add(this.btn_rotation_send);
            this.gb_rotation.Controls.Add(this.tb_rotation_absoluteAngle);
            this.gb_rotation.Controls.Add(this.lb_rotation_id);
            this.gb_rotation.Controls.Add(this.lb_rotation_absoluteAngle);
            this.gb_rotation.Controls.Add(this.tb_rotation_relativeAngle);
            this.gb_rotation.Controls.Add(this.cb_rotation_id);
            this.gb_rotation.Controls.Add(this.lb_rotation_relativeAngle);
            this.gb_rotation.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_rotation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_rotation.Location = new System.Drawing.Point(15, 69);
            this.gb_rotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_rotation.Name = "gb_rotation";
            this.gb_rotation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_rotation.Size = new System.Drawing.Size(680, 60);
            this.gb_rotation.TabIndex = 7;
            this.gb_rotation.TabStop = false;
            this.gb_rotation.Text = "Rotation Motors Control";
            // 
            // btn_rotation_send
            // 
            this.btn_rotation_send.Location = new System.Drawing.Point(549, 24);
            this.btn_rotation_send.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_rotation_send.Name = "btn_rotation_send";
            this.btn_rotation_send.Size = new System.Drawing.Size(90, 23);
            this.btn_rotation_send.TabIndex = 7;
            this.btn_rotation_send.Text = "Send";
            this.btn_rotation_send.UseVisualStyleBackColor = true;
            this.btn_rotation_send.Click += new System.EventHandler(this.btn_rotation_send_Click);
            // 
            // tb_rotation_absoluteAngle
            // 
            this.tb_rotation_absoluteAngle.Location = new System.Drawing.Point(423, 23);
            this.tb_rotation_absoluteAngle.Name = "tb_rotation_absoluteAngle";
            this.tb_rotation_absoluteAngle.Size = new System.Drawing.Size(76, 27);
            this.tb_rotation_absoluteAngle.TabIndex = 18;
            this.tb_rotation_absoluteAngle.Click += new System.EventHandler(this.tb_rotation_absoluteAngle_Click);
            // 
            // lb_rotation_id
            // 
            this.lb_rotation_id.AutoSize = true;
            this.lb_rotation_id.Location = new System.Drawing.Point(6, 30);
            this.lb_rotation_id.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rotation_id.Name = "lb_rotation_id";
            this.lb_rotation_id.Size = new System.Drawing.Size(24, 16);
            this.lb_rotation_id.TabIndex = 1;
            this.lb_rotation_id.Text = "ID";
            // 
            // lb_rotation_absoluteAngle
            // 
            this.lb_rotation_absoluteAngle.AutoSize = true;
            this.lb_rotation_absoluteAngle.Location = new System.Drawing.Point(311, 30);
            this.lb_rotation_absoluteAngle.Name = "lb_rotation_absoluteAngle";
            this.lb_rotation_absoluteAngle.Size = new System.Drawing.Size(106, 16);
            this.lb_rotation_absoluteAngle.TabIndex = 8;
            this.lb_rotation_absoluteAngle.Text = "Absolute Angle";
            // 
            // tb_rotation_relativeAngle
            // 
            this.tb_rotation_relativeAngle.Location = new System.Drawing.Point(230, 24);
            this.tb_rotation_relativeAngle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_rotation_relativeAngle.Name = "tb_rotation_relativeAngle";
            this.tb_rotation_relativeAngle.Size = new System.Drawing.Size(76, 27);
            this.tb_rotation_relativeAngle.TabIndex = 6;
            this.tb_rotation_relativeAngle.Click += new System.EventHandler(this.tb_rotation_relativeAngle_Click);
            // 
            // cb_rotation_id
            // 
            this.cb_rotation_id.BackColor = System.Drawing.SystemColors.Window;
            this.cb_rotation_id.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cb_rotation_id.FormattingEnabled = true;
            this.cb_rotation_id.Items.AddRange(new object[] {
            "4",
            "5",
            "6"});
            this.cb_rotation_id.Location = new System.Drawing.Point(41, 28);
            this.cb_rotation_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_rotation_id.Name = "cb_rotation_id";
            this.cb_rotation_id.Size = new System.Drawing.Size(80, 24);
            this.cb_rotation_id.TabIndex = 4;
            // 
            // lb_rotation_relativeAngle
            // 
            this.lb_rotation_relativeAngle.AutoSize = true;
            this.lb_rotation_relativeAngle.Location = new System.Drawing.Point(125, 30);
            this.lb_rotation_relativeAngle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_rotation_relativeAngle.Name = "lb_rotation_relativeAngle";
            this.lb_rotation_relativeAngle.Size = new System.Drawing.Size(101, 16);
            this.lb_rotation_relativeAngle.TabIndex = 3;
            this.lb_rotation_relativeAngle.Text = "Relative Angle";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gb_position);
            this.tabPage3.Controls.Add(this.lb_id6);
            this.tabPage3.Controls.Add(this.lb_id5);
            this.tabPage3.Controls.Add(this.lb_id4);
            this.tabPage3.Controls.Add(this.lb_id3);
            this.tabPage3.Controls.Add(this.lb_id2);
            this.tabPage3.Controls.Add(this.lb_id1);
            this.tabPage3.Controls.Add(this.gb_movement);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(712, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_id6_pos
            // 
            this.tb_id6_pos.Location = new System.Drawing.Point(533, 44);
            this.tb_id6_pos.Name = "tb_id6_pos";
            this.tb_id6_pos.ReadOnly = true;
            this.tb_id6_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id6_pos.TabIndex = 19;
            // 
            // tb_id5_pos
            // 
            this.tb_id5_pos.Location = new System.Drawing.Point(431, 44);
            this.tb_id5_pos.Name = "tb_id5_pos";
            this.tb_id5_pos.ReadOnly = true;
            this.tb_id5_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id5_pos.TabIndex = 18;
            // 
            // tb_id4_pos
            // 
            this.tb_id4_pos.Location = new System.Drawing.Point(332, 44);
            this.tb_id4_pos.Name = "tb_id4_pos";
            this.tb_id4_pos.ReadOnly = true;
            this.tb_id4_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id4_pos.TabIndex = 17;
            // 
            // tb_id3_pos
            // 
            this.tb_id3_pos.Location = new System.Drawing.Point(235, 44);
            this.tb_id3_pos.Name = "tb_id3_pos";
            this.tb_id3_pos.ReadOnly = true;
            this.tb_id3_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id3_pos.TabIndex = 16;
            // 
            // tb_id2_pos
            // 
            this.tb_id2_pos.Location = new System.Drawing.Point(131, 44);
            this.tb_id2_pos.Name = "tb_id2_pos";
            this.tb_id2_pos.ReadOnly = true;
            this.tb_id2_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id2_pos.TabIndex = 15;
            // 
            // tb_id1_pos
            // 
            this.tb_id1_pos.Location = new System.Drawing.Point(34, 44);
            this.tb_id1_pos.Name = "tb_id1_pos";
            this.tb_id1_pos.ReadOnly = true;
            this.tb_id1_pos.Size = new System.Drawing.Size(80, 27);
            this.tb_id1_pos.TabIndex = 14;
            // 
            // lb_id6
            // 
            this.lb_id6.AutoSize = true;
            this.lb_id6.Location = new System.Drawing.Point(278, 277);
            this.lb_id6.Name = "lb_id6";
            this.lb_id6.Size = new System.Drawing.Size(40, 16);
            this.lb_id6.TabIndex = 13;
            this.lb_id6.Text = "ID: 6";
            // 
            // lb_id5
            // 
            this.lb_id5.AutoSize = true;
            this.lb_id5.Location = new System.Drawing.Point(374, 219);
            this.lb_id5.Name = "lb_id5";
            this.lb_id5.Size = new System.Drawing.Size(40, 16);
            this.lb_id5.TabIndex = 12;
            this.lb_id5.Text = "ID: 5";
            // 
            // lb_id4
            // 
            this.lb_id4.AutoSize = true;
            this.lb_id4.Location = new System.Drawing.Point(477, 158);
            this.lb_id4.Name = "lb_id4";
            this.lb_id4.Size = new System.Drawing.Size(40, 16);
            this.lb_id4.TabIndex = 11;
            this.lb_id4.Text = "ID: 4";
            // 
            // lb_id3
            // 
            this.lb_id3.AutoSize = true;
            this.lb_id3.Location = new System.Drawing.Point(131, 175);
            this.lb_id3.Name = "lb_id3";
            this.lb_id3.Size = new System.Drawing.Size(40, 16);
            this.lb_id3.TabIndex = 10;
            this.lb_id3.Text = "ID: 3";
            // 
            // lb_id2
            // 
            this.lb_id2.AutoSize = true;
            this.lb_id2.Location = new System.Drawing.Point(223, 119);
            this.lb_id2.Name = "lb_id2";
            this.lb_id2.Size = new System.Drawing.Size(40, 16);
            this.lb_id2.TabIndex = 9;
            this.lb_id2.Text = "ID: 2";
            // 
            // lb_id1
            // 
            this.lb_id1.AutoSize = true;
            this.lb_id1.Location = new System.Drawing.Point(321, 67);
            this.lb_id1.Name = "lb_id1";
            this.lb_id1.Size = new System.Drawing.Size(40, 16);
            this.lb_id1.TabIndex = 8;
            this.lb_id1.Text = "ID: 1";
            // 
            // gb_movement
            // 
            this.gb_movement.Controls.Add(this.btn_id_CW);
            this.gb_movement.Controls.Add(this.btn_reset);
            this.gb_movement.Controls.Add(this.lb_id);
            this.gb_movement.Controls.Add(this.btn_id_CCW);
            this.gb_movement.Controls.Add(this.cb_id);
            this.gb_movement.Location = new System.Drawing.Point(3, 404);
            this.gb_movement.Name = "gb_movement";
            this.gb_movement.Size = new System.Drawing.Size(700, 60);
            this.gb_movement.TabIndex = 7;
            this.gb_movement.TabStop = false;
            this.gb_movement.Text = "Movement";
            // 
            // btn_id_CW
            // 
            this.btn_id_CW.Location = new System.Drawing.Point(165, 26);
            this.btn_id_CW.Name = "btn_id_CW";
            this.btn_id_CW.Size = new System.Drawing.Size(150, 23);
            this.btn_id_CW.TabIndex = 3;
            this.btn_id_CW.Text = "CW / Forward";
            this.btn_id_CW.UseVisualStyleBackColor = true;
            this.btn_id_CW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_id_CW_MouseDown);
            this.btn_id_CW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_id_CW_MouseUp);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(619, 26);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 1;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(25, 29);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(24, 16);
            this.lb_id.TabIndex = 6;
            this.lb_id.Text = "ID";
            // 
            // btn_id_CCW
            // 
            this.btn_id_CCW.Location = new System.Drawing.Point(321, 26);
            this.btn_id_CCW.Name = "btn_id_CCW";
            this.btn_id_CCW.Size = new System.Drawing.Size(150, 23);
            this.btn_id_CCW.TabIndex = 4;
            this.btn_id_CCW.Text = "CCW / Backward";
            this.btn_id_CCW.UseVisualStyleBackColor = true;
            this.btn_id_CCW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_id_CCW_MouseDown);
            this.btn_id_CCW.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_id_CCW_MouseUp);
            // 
            // cb_id
            // 
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_id.Location = new System.Drawing.Point(55, 26);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(80, 24);
            this.cb_id.TabIndex = 5;
            this.cb_id.SelectedIndexChanged += new System.EventHandler(this.cb_id_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 395);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(712, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Motion Planning";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gb_port
            // 
            this.gb_port.Controls.Add(this.lb_connectStatus);
            this.gb_port.Controls.Add(this.btn_disconnect);
            this.gb_port.Controls.Add(this.cb_baudrate);
            this.gb_port.Controls.Add(this.btn_connect);
            this.gb_port.Controls.Add(this.lb_portName);
            this.gb_port.Controls.Add(this.lb_baudrate);
            this.gb_port.Controls.Add(this.cb_portName);
            this.gb_port.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gb_port.Location = new System.Drawing.Point(12, 12);
            this.gb_port.Name = "gb_port";
            this.gb_port.Size = new System.Drawing.Size(720, 60);
            this.gb_port.TabIndex = 0;
            this.gb_port.TabStop = false;
            this.gb_port.Text = "Serial Port";
            // 
            // lb_connectStatus
            // 
            this.lb_connectStatus.AutoSize = true;
            this.lb_connectStatus.ForeColor = System.Drawing.Color.Gray;
            this.lb_connectStatus.Location = new System.Drawing.Point(605, 30);
            this.lb_connectStatus.Name = "lb_connectStatus";
            this.lb_connectStatus.Size = new System.Drawing.Size(78, 16);
            this.lb_connectStatus.TabIndex = 5;
            this.lb_connectStatus.Text = "Disconnect";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(487, 27);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(90, 23);
            this.btn_disconnect.TabIndex = 2;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // cb_baudrate
            // 
            this.cb_baudrate.FormattingEnabled = true;
            this.cb_baudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "9600",
            "19200",
            "38400",
            "115200"});
            this.cb_baudrate.Location = new System.Drawing.Point(230, 26);
            this.cb_baudrate.Name = "cb_baudrate";
            this.cb_baudrate.Size = new System.Drawing.Size(121, 24);
            this.cb_baudrate.TabIndex = 4;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(388, 27);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(90, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // lb_portName
            // 
            this.lb_portName.AutoSize = true;
            this.lb_portName.Location = new System.Drawing.Point(6, 30);
            this.lb_portName.Name = "lb_portName";
            this.lb_portName.Size = new System.Drawing.Size(33, 16);
            this.lb_portName.TabIndex = 1;
            this.lb_portName.Text = "Port";
            // 
            // lb_baudrate
            // 
            this.lb_baudrate.AutoSize = true;
            this.lb_baudrate.Location = new System.Drawing.Point(167, 30);
            this.lb_baudrate.Name = "lb_baudrate";
            this.lb_baudrate.Size = new System.Drawing.Size(64, 16);
            this.lb_baudrate.TabIndex = 2;
            this.lb_baudrate.Text = "Baudrate";
            // 
            // cb_portName
            // 
            this.cb_portName.FormattingEnabled = true;
            this.cb_portName.Location = new System.Drawing.Point(41, 26);
            this.cb_portName.Name = "cb_portName";
            this.cb_portName.Size = new System.Drawing.Size(121, 24);
            this.cb_portName.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // gb_position
            // 
            this.gb_position.Controls.Add(this.lb_id6_pos);
            this.gb_position.Controls.Add(this.lb_id5_pos);
            this.gb_position.Controls.Add(this.lb_id4_pos);
            this.gb_position.Controls.Add(this.lb_id3_pos);
            this.gb_position.Controls.Add(this.lb_id2_pos);
            this.gb_position.Controls.Add(this.lb_id1_pos);
            this.gb_position.Controls.Add(this.tb_id1_pos);
            this.gb_position.Controls.Add(this.tb_id6_pos);
            this.gb_position.Controls.Add(this.tb_id2_pos);
            this.gb_position.Controls.Add(this.tb_id5_pos);
            this.gb_position.Controls.Add(this.tb_id3_pos);
            this.gb_position.Controls.Add(this.tb_id4_pos);
            this.gb_position.Location = new System.Drawing.Point(3, 470);
            this.gb_position.Name = "gb_position";
            this.gb_position.Size = new System.Drawing.Size(700, 90);
            this.gb_position.TabIndex = 20;
            this.gb_position.TabStop = false;
            this.gb_position.Text = "Position";
            // 
            // lb_id1_pos
            // 
            this.lb_id1_pos.AutoSize = true;
            this.lb_id1_pos.Location = new System.Drawing.Point(53, 25);
            this.lb_id1_pos.Name = "lb_id1_pos";
            this.lb_id1_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id1_pos.TabIndex = 20;
            this.lb_id1_pos.Text = "ID: 1";
            // 
            // lb_id2_pos
            // 
            this.lb_id2_pos.AutoSize = true;
            this.lb_id2_pos.Location = new System.Drawing.Point(151, 26);
            this.lb_id2_pos.Name = "lb_id2_pos";
            this.lb_id2_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id2_pos.TabIndex = 21;
            this.lb_id2_pos.Text = "ID: 2";
            // 
            // lb_id3_pos
            // 
            this.lb_id3_pos.AutoSize = true;
            this.lb_id3_pos.Location = new System.Drawing.Point(254, 26);
            this.lb_id3_pos.Name = "lb_id3_pos";
            this.lb_id3_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id3_pos.TabIndex = 22;
            this.lb_id3_pos.Text = "ID: 3";
            // 
            // lb_id4_pos
            // 
            this.lb_id4_pos.AutoSize = true;
            this.lb_id4_pos.Location = new System.Drawing.Point(351, 26);
            this.lb_id4_pos.Name = "lb_id4_pos";
            this.lb_id4_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id4_pos.TabIndex = 23;
            this.lb_id4_pos.Text = "ID: 4";
            // 
            // lb_id5_pos
            // 
            this.lb_id5_pos.AutoSize = true;
            this.lb_id5_pos.Location = new System.Drawing.Point(451, 26);
            this.lb_id5_pos.Name = "lb_id5_pos";
            this.lb_id5_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id5_pos.TabIndex = 24;
            this.lb_id5_pos.Text = "ID: 5";
            // 
            // lb_id6_pos
            // 
            this.lb_id6_pos.AutoSize = true;
            this.lb_id6_pos.Location = new System.Drawing.Point(552, 26);
            this.lb_id6_pos.Name = "lb_id6_pos";
            this.lb_id6_pos.Size = new System.Drawing.Size(40, 16);
            this.lb_id6_pos.TabIndex = 25;
            this.lb_id6_pos.Text = "ID: 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 682);
            this.Controls.Add(this.tabControl_main);
            this.Controls.Add(this.gb_port);
            this.Name = "Form1";
            this.Text = "CTR Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gb_translation.ResumeLayout(false);
            this.gb_translation.PerformLayout();
            this.gb_rotation.ResumeLayout(false);
            this.gb_rotation.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.gb_movement.ResumeLayout(false);
            this.gb_movement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_port.ResumeLayout(false);
            this.gb_port.PerformLayout();
            this.gb_position.ResumeLayout(false);
            this.gb_position.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabControl_main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gb_port;
        private System.Windows.Forms.ComboBox cb_baudrate;
        private System.Windows.Forms.Label lb_portName;
        private System.Windows.Forms.Label lb_baudrate;
        private System.Windows.Forms.ComboBox cb_portName;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label lb_rotation_relativeAngle;
        private System.Windows.Forms.Label lb_rotation_id;
        private System.Windows.Forms.TextBox tb_rotation_relativeAngle;
        private System.Windows.Forms.ComboBox cb_rotation_id;
        private System.Windows.Forms.GroupBox gb_rotation;
        private System.Windows.Forms.Button btn_rotation_send;
        private System.Windows.Forms.Button btn_translation_send;
        private System.Windows.Forms.TextBox tb_translation_distance;
        private System.Windows.Forms.ComboBox cb_translation_id;
        private System.Windows.Forms.Label lb_translation_distance;
        private System.Windows.Forms.Label lb_translation_id;
        private System.Windows.Forms.GroupBox gb_translation;
        private System.Windows.Forms.RichTextBox rtb_message;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lb_connectStatus;
        private System.Windows.Forms.Label lb_rotation_absoluteAngle;
        private System.Windows.Forms.TextBox tb_rotation_absoluteAngle;
        private System.Windows.Forms.Button btn_brake;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_id_CCW;
        private System.Windows.Forms.Button btn_id_CW;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.GroupBox gb_movement;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_id6;
        private System.Windows.Forms.Label lb_id5;
        private System.Windows.Forms.Label lb_id4;
        private System.Windows.Forms.Label lb_id3;
        private System.Windows.Forms.Label lb_id2;
        private System.Windows.Forms.Label lb_id1;
        private System.Windows.Forms.TextBox tb_id3_pos;
        private System.Windows.Forms.TextBox tb_id2_pos;
        private System.Windows.Forms.TextBox tb_id1_pos;
        private System.Windows.Forms.TextBox tb_id6_pos;
        private System.Windows.Forms.TextBox tb_id5_pos;
        private System.Windows.Forms.TextBox tb_id4_pos;
        private System.Windows.Forms.GroupBox gb_position;
        private System.Windows.Forms.Label lb_id6_pos;
        private System.Windows.Forms.Label lb_id5_pos;
        private System.Windows.Forms.Label lb_id4_pos;
        private System.Windows.Forms.Label lb_id3_pos;
        private System.Windows.Forms.Label lb_id2_pos;
        private System.Windows.Forms.Label lb_id1_pos;
    }
}

