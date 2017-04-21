namespace _03串口调试助手_精简版_
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_receive_char = new System.Windows.Forms.RadioButton();
            this.radioButton_receive_valve = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton_send_char = new System.Windows.Forms.RadioButton();
            this.radioButton_send_valve = new System.Windows.Forms.RadioButton();
            this.button_close = new System.Windows.Forms.Button();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.comboBox_portname = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.comboBox_portname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(256, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_receive_char);
            this.panel2.Controls.Add(this.radioButton_receive_valve);
            this.panel2.Location = new System.Drawing.Point(95, 156);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(155, 38);
            this.panel2.TabIndex = 9;
            // 
            // radioButton_receive_char
            // 
            this.radioButton_receive_char.AutoSize = true;
            this.radioButton_receive_char.Location = new System.Drawing.Point(84, 10);
            this.radioButton_receive_char.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_receive_char.Name = "radioButton_receive_char";
            this.radioButton_receive_char.Size = new System.Drawing.Size(58, 19);
            this.radioButton_receive_char.TabIndex = 1;
            this.radioButton_receive_char.TabStop = true;
            this.radioButton_receive_char.Text = "字符";
            this.radioButton_receive_char.UseVisualStyleBackColor = true;
            // 
            // radioButton_receive_valve
            // 
            this.radioButton_receive_valve.AutoSize = true;
            this.radioButton_receive_valve.Location = new System.Drawing.Point(12, 10);
            this.radioButton_receive_valve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_receive_valve.Name = "radioButton_receive_valve";
            this.radioButton_receive_valve.Size = new System.Drawing.Size(58, 19);
            this.radioButton_receive_valve.TabIndex = 0;
            this.radioButton_receive_valve.TabStop = true;
            this.radioButton_receive_valve.Text = "数值";
            this.radioButton_receive_valve.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_send_char);
            this.panel1.Controls.Add(this.radioButton_send_valve);
            this.panel1.Location = new System.Drawing.Point(95, 111);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 38);
            this.panel1.TabIndex = 8;
            // 
            // radioButton_send_char
            // 
            this.radioButton_send_char.AutoSize = true;
            this.radioButton_send_char.Location = new System.Drawing.Point(84, 10);
            this.radioButton_send_char.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_send_char.Name = "radioButton_send_char";
            this.radioButton_send_char.Size = new System.Drawing.Size(58, 19);
            this.radioButton_send_char.TabIndex = 1;
            this.radioButton_send_char.TabStop = true;
            this.radioButton_send_char.Text = "字符";
            this.radioButton_send_char.UseVisualStyleBackColor = true;
            // 
            // radioButton_send_valve
            // 
            this.radioButton_send_valve.AutoSize = true;
            this.radioButton_send_valve.Location = new System.Drawing.Point(12, 10);
            this.radioButton_send_valve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_send_valve.Name = "radioButton_send_valve";
            this.radioButton_send_valve.Size = new System.Drawing.Size(58, 19);
            this.radioButton_send_valve.TabIndex = 0;
            this.radioButton_send_valve.TabStop = true;
            this.radioButton_send_valve.Text = "数值";
            this.radioButton_send_valve.UseVisualStyleBackColor = true;
            // 
            // button_close
            // 
            this.button_close.Enabled = false;
            this.button_close.Location = new System.Drawing.Point(149, 221);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(84, 29);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "关闭端口";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(21, 221);
            this.button_open.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(84, 29);
            this.button_open.TabIndex = 6;
            this.button_open.Text = "打开端口";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(107, 71);
            this.comboBox_baudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(125, 23);
            this.comboBox_baudrate.TabIndex = 5;
            // 
            // comboBox_portname
            // 
            this.comboBox_portname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_portname.FormattingEnabled = true;
            this.comboBox_portname.Location = new System.Drawing.Point(107, 35);
            this.comboBox_portname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_portname.Name = "comboBox_portname";
            this.comboBox_portname.Size = new System.Drawing.Size(125, 23);
            this.comboBox_portname.TabIndex = 4;
            this.comboBox_portname.Click += new System.EventHandler(this.comboBox_portname_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "接收模式";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "发送模式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口";
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(16, 302);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(636, 49);
            this.textBox_send.TabIndex = 1;
            this.textBox_send.TextChanged += new System.EventHandler(this.textBox_send_TextChanged);
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(297, 24);
            this.textBox_receive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(461, 255);
            this.textBox_receive.TabIndex = 2;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(665, 300);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(93, 52);
            this.button_send.TabIndex = 3;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Form1
            // 
            this.AcceptButton = this.button_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(785, 370);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_receive);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "串口调试助手(精简版)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.ComboBox comboBox_portname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_send_char;
        private System.Windows.Forms.RadioButton radioButton_send_valve;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton_receive_char;
        private System.Windows.Forms.RadioButton radioButton_receive_valve;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

