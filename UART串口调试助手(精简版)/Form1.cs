using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03串口调试助手_精简版_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //至关重要的一行,允许一个控件被跨线程同时访问(textbox_receive)
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_baudrate.SelectedIndex = 4;  //初始化默认波特率为9600
            radioButton_receive_valve.Select();   //初始化接收数据类型
            radioButton_send_valve.Select();      //初始化发送数据类型

        }

        private void comboBox_portname_Click(object sender, EventArgs e) //combobox单击事件,每次单击重新载入串口数据
        {
            comboBox_portname.Items.Clear();  //清空所有项目,不然会重复显示
            comboBox_portname.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());  //添加存在的串口信息
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if(comboBox_portname.SelectedItem == null) //检查是否选择端口号
            {
                MessageBox.Show("请选择端口号");
                return;
            }

            try
            {
                serialPort1.PortName = comboBox_portname.Text;             //修改端口号
                serialPort1.BaudRate = int.Parse(comboBox_baudrate.Text);  //修改波特率
                serialPort1.Open();                                        //打开端口
            }
            catch(Exception err)
            {
                if(serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                MessageBox.Show(err.ToString(), "错误");
                return;
            }
            comboBox_portname.Enabled = false;
            comboBox_baudrate.Enabled = false;
            button_open.Enabled = false;
            button_close.Enabled = true;
            button_send.Enabled = true;
        }

        private void button_close_Click(object sender, EventArgs e) //关闭串口按钮事件
        {
            serialPort1.Close();
            comboBox_portname.Enabled = true;
            comboBox_baudrate.Enabled = true;
            button_open.Enabled = true;
            button_close.Enabled = false;
            button_send.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) //串口接收事件
        {
            if(radioButton_receive_valve.Checked) //接收模式为数值
            {
                byte data = (byte)serialPort1.ReadByte(); //ReadByte()返回值为int型,强制转换为byte型
                string str = Convert.ToString(data, 16).ToUpper();
                textBox_receive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + "\r\n"); //格式化后添加到textbox
            }
            else  //接收模式为字符
            {
                string str = serialPort1.ReadExisting(); //以字符串方式读取
                textBox_receive.AppendText(str);         //添加到textbox
            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            if(textBox_send.Text.Trim() == "")  //发送框非空校验
            {
                MessageBox.Show("请输入需要发送的数据");
                return;
            }

            if(!serialPort1.IsOpen)             //串口非本程序操作关闭后执行
            {
                MessageBox.Show("串口开启失败,请重试");
                button_close.PerformClick();
                return;
            }
                        
            if(radioButton_send_valve.Checked)  //以数值方式发送
            {
                string sendBuf = textBox_send.Text.Trim();      //去除两端空格                
                sendBuf = sendBuf.Replace(",", " ");                   //去除英文逗号
                sendBuf = sendBuf.Replace("，", " ");                //去除中文逗号
                sendBuf = sendBuf.Replace("0x", "");                //去除0x
                sendBuf = sendBuf.Replace("0X", "");               //去除0X
                sendBuf = new System.Text.RegularExpressions.Regex("[\\s]+").Replace(sendBuf, " ");  //用正则表达式将多个连续空格转化为一个,防止出错
                string[] sendBufArray = sendBuf.Split(' ');        //以空格分割字符串为字符串数组
                /* ---------------------- 修正输入框 -------------------- */
                textBox_send.Text = "";                 
                for(int i = 0; i < sendBufArray.Length; i++)
                {
                    textBox_send.AppendText("0x" + sendBufArray[i].ToUpper() + (i == sendBufArray.Length - 1 ? "" : ","));
                }
                /* -------------------------------------------------------- */
                
                byte[] byteBuf = new byte[sendBufArray.Length];   

                try  //检查输入是否有误,是否超过一个字节
                {
                    for (int i = 0; i < sendBufArray.Length; i++)
                    {
                        byteBuf[i] = Convert.ToByte(sendBufArray[i], 16); //将输入格式化后的输入数据转换为16进制数据
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.ToString(), "转换错误");
                    return;
                }

                try
                {
                    serialPort1.Write(byteBuf, 0, byteBuf.Length);  //发送
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.ToString(), "写入错误");
                    button_close.PerformClick();
                }
            }
            else     //以字符方式发送
            {
                try
                {
                    serialPort1.WriteLine(textBox_send.Text);  //发送
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.ToString(), "写入错误");
                    button_close.PerformClick();
                }
            }

        }

        private void textBox_send_TextChanged(object sender, EventArgs e)
        {
            textBox_send.Text = textBox_send.Text.TrimStart();  //自动去除头部空格
        }
    }
}
