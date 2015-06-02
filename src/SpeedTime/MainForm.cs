using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SpeedTime.BlueFairy;

namespace SpeedTime
{
    struct Speed
    {
        public string m_name;
        public float m_value;

        public Speed(string name, float value)
        {
            m_name = name;
            m_value = value;
        }

        public override string ToString()
        {
            return m_name;
        }
    }

    public partial class MainForm : Form
    {
        private int m_cntPerSecond;//每秒种定时器的计数值
        private int m_countOfTimer;//当前计数值
        private Int64 m_seconds;//已经经过的秒数
        private DateTime m_beginTime;//初始时间

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbSpeed.Items.Add(new Speed("1", 1));
            cbSpeed.Items.Add(new Speed("2", 2));
            cbSpeed.Items.Add(new Speed("3", 3));
            cbSpeed.Items.Add(new Speed("4", 4));
            cbSpeed.Items.Add(new Speed("5", 5));

            cbSpeed.SelectedIndex = 0;//正常速度

            m_cntPerSecond = 1000 / timerSpeed.Interval;
            m_countOfTimer = 0;
            m_beginTime = DateTime.Now;
            m_seconds = 0;
        }

        private void ckbCurTime_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerBeginTime.Enabled = !ckbCurTime.Checked;
        }

        private void timerSpeed_Tick(object sender, EventArgs e)
        {
            ++m_countOfTimer;

            if (m_countOfTimer >= m_cntPerSecond)
            {
                m_countOfTimer = 0;//计数满一个周期，重新开始计数

                //此时可以认为增加了1秒
                ++m_seconds;
                //1秒=1000豪秒  1毫秒=1000微秒   1微秒=1000毫微秒
                SetSystemTimeCls.SetSysTime(m_beginTime + new TimeSpan(m_seconds * 10000000));
            }
            else
            {
                //继续计数
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            m_cntPerSecond = (int)((1000.0 / timerSpeed.Interval) / ((Speed)cbSpeed.SelectedItem).m_value);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
