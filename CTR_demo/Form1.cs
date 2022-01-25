using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CTR_demo
{
    public partial class Form1 : Form
    {
        MotorControl CTR_motor = new MotorControl();
        // COM Port Parameters
        private static SerialPort Port;
        private string PortName;
        private int BaudRate;
        // Read Data
        private byte[] BufferData;
        // Send Data
        private byte[] SendData;

        private double[] Angle = new double[7];
        private double AngleStep = 10;
        private double[] Distance = new double[7];
        private double DistanceStep = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cb_portName.Items.AddRange(ports);
            cb_baudrate.SelectedIndex = 6;
            OpenPanel(false);
        }
        private SerialPort InitSerialPortParameter()
        {
            if (cb_portName.SelectedIndex < 0 || cb_baudrate.SelectedIndex < 0)
            {
                MessageBox.Show("Please Set the COM Port!");
                return null;
            }
            else
            {
                PortName = cb_portName.SelectedItem.ToString();
                BaudRate = int.Parse(cb_baudrate.SelectedIndex.ToString());
                Port = new SerialPort(PortName, BaudRate);
                return Port;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            InitSerialPortParameter();
            if (!Port.IsOpen) Port.Open();
            Port.DataReceived += new SerialDataReceivedEventHandler(Rece);
            lb_connectStatus.Text = "Connecting";
            lb_connectStatus.ForeColor = Color.Green;
            OpenPanel(true);
        }
        private void Rece(object sender, SerialDataReceivedEventArgs e)
        {
            if (Port.BytesToRead > 0)
            {
                BufferData = new byte[Port.BytesToRead];
                Port.Read(BufferData, 0, BufferData.Length);
                BeginInvoke(new MethodInvoker(() =>
                {
                    rtb_message.AppendText("\r\nReceive Data: ");
                    foreach (char i in BitConverter.ToString(BufferData).Replace("-", " "))
                        rtb_message.AppendText(" " + i + " ");
                    rtb_message.AppendText("\r\n");
                }));
            }
        }
        public void SetMsg(string msg)
        {
            rtb_message.Invoke(new Action(() => { rtb_message.AppendText(msg); }));
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rtb_message.Clear();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            if (Port.IsOpen)
            {
                Port.Close();
                lb_connectStatus.Text = "Disconnect";
                lb_connectStatus.ForeColor = Color.Gray;
                OpenPanel(false);
            }
        }

        private void btn_rotation_send_Click(object sender, EventArgs e)
        {
            if (tb_rotation_absoluteAngle.Text == "")
            {
                SendData = CTR_motor.RelativeRotation(Int16.Parse(cb_rotation_id.SelectedItem.ToString()), Int16.Parse(tb_rotation_relativeAngle.Text));
            }
            else if (tb_rotation_relativeAngle.Text == "")
            {
                SendData = CTR_motor.AbsoluteRotation(Int16.Parse(cb_rotation_id.SelectedItem.ToString()), Int16.Parse(tb_rotation_absoluteAngle.Text));
            }
            else
            {
                MessageBox.Show("Error");
            }
            Port.Write(SendData, 0, SendData.Length);
            WriteSendData(SendData);
            tb_rotation_absoluteAngle.Enabled = true;
            tb_rotation_relativeAngle.Enabled = true;
        }

        private void btn_translation_send_Click(object sender, EventArgs e)
        {
            SendData = CTR_motor.Translation(Int16.Parse(cb_translation_id.SelectedItem.ToString()), Int16.Parse(tb_translation_distance.Text));
            Port.Write(SendData, 0, SendData.Length);
            WriteSendData(SendData);
        }

        private void btn_brake_Click(object sender, EventArgs e)
        {
            SendData = CTR_motor.Brake();
            Port.Write(SendData, 0, SendData.Length);
            SetMsg("STOP\n");
        }

        private void OpenPanel(bool OpenStatus)
        {
            gb_rotation.Enabled = OpenStatus;
            gb_translation.Enabled = OpenStatus;
            gb_movement.Enabled = OpenStatus;
        }

        private void tb_rotation_relativeAngle_Click(object sender, EventArgs e)
        {
            tb_rotation_absoluteAngle.Text = "";
            tb_rotation_absoluteAngle.Enabled = false;
        }

        private void tb_rotation_absoluteAngle_Click(object sender, EventArgs e)
        {
            tb_rotation_relativeAngle.Text = "";
            tb_rotation_relativeAngle.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SendData = CTR_motor.AbsoluteRotation(255, 0);
            Port.Write(SendData, 0, SendData.Length);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            SendData = CTR_motor.AbsoluteRotation(255, 0);
            Port.Write(SendData, 0, SendData.Length);
            UpdatePos(255, 0);
        }

        private void WriteSendData(byte[] data)
        {
            rtb_message.AppendText("\nSend Data: ");
            foreach (char i in BitConverter.ToString(data).Replace("-", " "))
                rtb_message.AppendText(" " + i + " ");
        }

        #region Continuous Move
        /// <summary>
        /// Select the motor's ID for different functions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_id.SelectedIndex < 0)     // Motor ID:1,2,3 -> Translation, Motor ID:4,5,6 -> Rotation
            {
                MessageBox.Show("Please fill in ID blank.");
            }
            else if (cb_id.SelectedIndex < 3)
            {
                btn_id_CW.Text = "Forward";
                btn_id_CCW.Text = "Backward";
            }
            else
            {
                btn_id_CW.Text = "CW";
                btn_id_CCW.Text = "CCW";
            }
        }
        /// <summary>
        /// The first time when you pressed the button.
        /// After 1 second,it keeps executing the function.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_id_CW_MouseDown(object sender, MouseEventArgs e)
        {
            DoPositiveMove();
            timer2.Interval = 1000;
            timer2.Enabled = true;
        }
        /// <summary>
        /// Repeat for every 0.2 second.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 200;
            timer1.Enabled = true;
            timer2.Enabled = false;
        }
        /// <summary>
        /// Execute when Long pressing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            DoPositiveMove();
        }
        /// <summary>
        /// When you release the button, it stops.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_id_CW_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
        }
        /// <summary>
        /// The function about translation and rotation.
        /// </summary>
        private void DoPositiveMove()
        {
            int id = int.Parse(cb_id.SelectedItem.ToString());
            if (btn_id_CW.Text == "Forward")
            {
                SendData = CTR_motor.Translation(id, DistanceStep);
                Port.Write(SendData, 0, SendData.Length);
                Distance[id] += DistanceStep;
                UpdatePos(id, Distance[id]);
            }
            else if (btn_id_CW.Text == "CW")
            {
                SendData = CTR_motor.RelativeRotation(id, AngleStep);
                Port.Write(SendData, 0, SendData.Length);
                Angle[id] += AngleStep;
                UpdatePos(id, Angle[id]);
            }
            else
            {
                MessageBox.Show("Please fill in ID blank.");
            }
        }

        private void btn_id_CCW_MouseDown(object sender, MouseEventArgs e)
        {
            DoNegativeMove();
            timer4.Interval = 1000;
            timer4.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer3.Interval = 200;
            timer3.Enabled = true;
            timer4.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            DoNegativeMove();
        }

        private void btn_id_CCW_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void DoNegativeMove()
        {
            int id = int.Parse(cb_id.SelectedItem.ToString());
            if (btn_id_CCW.Text == "Backward")
            {
                SendData = CTR_motor.Translation(id, -DistanceStep);
                Port.Write(SendData, 0, SendData.Length);
                Distance[id] -= DistanceStep;
                UpdatePos(id, Distance[id]);
            }
            else if (btn_id_CCW.Text == "CCW")
            {
                SendData = CTR_motor.RelativeRotation(id, -AngleStep);
                Port.Write(SendData, 0, SendData.Length);
                Angle[id] -= AngleStep;
                UpdatePos(id, Angle[id]);
            }
            else
            {
                MessageBox.Show("Please fill in ID blank.");
            }
        }
        #endregion Continuous Move

        private void UpdatePos(int id, double pos)
        {
            TextBox[] tb_id_pos = { tb_id1_pos, tb_id2_pos, tb_id3_pos, tb_id4_pos, tb_id5_pos, tb_id6_pos };
            if (id == 255)  // Reset
            {
                for(int i = 0; i < 6; i++)
                {
                    tb_id_pos[i].Text = pos.ToString();
                }
            }
            else
            {
                tb_id_pos[id - 1].Text = pos.ToString();
            }
        }
    }
}
