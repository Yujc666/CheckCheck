using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            范围选择.SelectedIndex = 0;
            范围选择_SelectedIndexChanged(sender, e);
        }

        private void 范围选择_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (范围选择.SelectedIndex == 0)
            {
                label1.Text = "学号范围:";
                startid.Visible = true;
                label_.Visible = true;
                endid.Visible = true;
                singleid.Visible = false;
            }
            else if (范围选择.SelectedIndex == 1)
            {
                label1.Text = "输入学号:";
                startid.Visible = false;
                label_.Visible = false;
                endid.Visible = false;
                singleid.Visible = true;
            }
            else
            {
                label1.Visible = false;
                startid.Visible = false;
                label_.Visible = false;
                endid.Visible = false;
                singleid.Visible = false;
                button_search.Visible = false;
            }
        }

        private void label_all_Click(object sender, EventArgs e)
        {
            label_not.BorderStyle = BorderStyle.None;
            label_all.BorderStyle = BorderStyle.FixedSingle;
            listBox_all.Visible = true;
            listBox_not.Visible = false;
        }

        private void label_not_Click(object sender, EventArgs e)
        {
            label_all.BorderStyle = BorderStyle.None;
            label_not.BorderStyle = BorderStyle.FixedSingle;
            listBox_all.Visible = false;
            listBox_not.Visible = true;
        }
        private string ifChecked(string id)
        {
            string url = "https://ctsxx.gnway.org/xgxt-api/api/clockIn/clockInList/isClockIn?xh=" + id;
            string response = "";
            System.GC.Collect();
            /*
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.ServicePoint.ConnectionLimit = 250;
            httpWebRequest.Proxy = null;
            httpWebRequest.KeepAlive = false;
            WebResponse httpWebResponse = httpWebRequest.GetResponse();
            Stream stream = httpWebResponse.GetResponseStream();
            try
            {
                using (StreamReader reader = new StreamReader(stream))
                    response = reader.ReadToEnd();
            }
            finally
            {
                stream.Close();
                stream = null;
                httpWebResponse.Close();
                httpWebResponse = null;
            }
            */
            var client = new HttpClient();
            var result = client.GetAsync(url);
            response = result.Result.Content.ReadAsStringAsync().Result;
            result.Dispose();
            client.Dispose();
            if (response == "1")
                return "已打卡";
            else if (response == "0")
                return " 未打卡！";
            else
                return response;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (checkInput() == 0)
            {
                MessageBox.Show("学号是10位数", "提示");
                return;
            }
            string startId = startid.Text;
            string endId = endid.Text;
            string singleId = singleid.Text;
            if (范围选择.SelectedIndex == 1)
                startId = endId = singleId;
            long i = Convert.ToInt64(startId);
            long j = Convert.ToInt64(endId);
            if (j - i > 50 && MessageBox.Show("范围较大，耗时可能较长", "是否继续？", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                this.listBox_all.Items.Clear();
                this.listBox_not.Items.Clear();
                this.loading.Visible = true;
                for (; i <= j; i++)
                {
                    string item = ifChecked(i.ToString());
                    listBox_all.Items.Add(i.ToString() + item);
                    listBox_all.TopIndex = listBox_all.Items.Count - 1;
                    if (item == " 未打卡！")
                    {
                        listBox_not.Items.Add(i.ToString() + item);
                    }
                }
                label_all_count.Text = listBox_all.Items.Count.ToString();
                label_not_count.Text = listBox_not.Items.Count.ToString();
                loading.Visible = false;
            }
        }

        private void label_all_count_Click(object sender, EventArgs e)
        {
            label_all_Click(sender, e);
        }

        private void label_not_count_Click(object sender, EventArgs e)
        {
            label_not_Click(sender, e);
        }
        private int checkInput()
        {
            if (范围选择.SelectedIndex == 0 && (startid.Text.Length < 10 || endid.Text.Length < 10))
                return 0;
            else if (范围选择.SelectedIndex == 1 && singleid.Text.Length < 10)
                return 0;
            else
                return 1;
        }
    }
}
