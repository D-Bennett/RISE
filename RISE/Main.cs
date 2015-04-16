using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System;
using System.Net;
using System.Runtime.Serialization.Json;

namespace RISE
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SerialPort currentPort;
        Thread runThread = null;
        private void button_Click(object sender, EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
            button.Text = timer.Enabled ? "Enabled" : "Disabled";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    serial_port_select.Items.Add(port);
                }
            }
            catch (Exception exc) { }
            button.Text = timer.Enabled ? "Enabled" : "Disabled";
        }

        private void serial_port_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception exc) { }
        }

        public void rise_serialpush(int tickets)
        {
            try
            {

                log_textbox.Text = "Polling api\n" + log_textbox.Text;
                //Random rnd = new Random();
                //int tickets = rnd.Next(0, 20);
                log_textbox.Text = ""+tickets+" Tickets, Updating Display\n" + log_textbox.Text; 
                currentPort = new SerialPort(serial_port_select.GetItemText(serial_port_select.SelectedItem), 9600);
                currentPort.Open();
                string str = "" + tickets;
                currentPort.Write(str);
                Thread.Sleep(1000);
                currentPort.Close();
                log_textbox.Text = "Display Updated\n" + log_textbox.Text; 
            }
            catch (Exception exc) { }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RISEResponse resp = MakeRequest(endpoint.Text);
            if (resp != null)
            {
                int tickets = 0;

                if (tickets_low.Checked)
                {
                    tickets += resp.Low;
                }
                if (tickets_medium.Checked)
                {
                    tickets += resp.Medium;
                }
                if (tickets_high.Checked)
                {
                    tickets += resp.High;
                }
                if (tickets_critical.Checked)
                {
                    tickets += resp.Critical;
                }
                rise_serialpush(tickets);
            }
        }








        public class RISEResponse
        {
            public int Critical;
            public int High;
            public int Medium;
            public int Low;
        }
        public static RISEResponse MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription));
                    }
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RISEResponse));
                    object objResponse = jsonSerializer.ReadObject(response.GetResponseStream());
                    RISEResponse jsonResponse = objResponse as RISEResponse;
                    return jsonResponse;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }




    }
}