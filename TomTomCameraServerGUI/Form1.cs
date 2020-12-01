using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using static TomTomCameraServerGUI.TTVersion;
using static TomTomCameraServerGUI.TTStatus;
using static TomTomCameraServerGUI.RootSettings;
using System.IO;

namespace TomTomCameraServerGUI
{
    public partial class btnGetStatus : Form
    {
        public btnGetStatus()
        {
            InitializeComponent();
        }

        public void Log(string msg)
        {
            lbLog.Items.Add(DateTime.Now + " " + msg);
        }
        private void btnGetVer_Click(object sender, EventArgs e)
        {
            Log("Contacting camera...");
            WebRequest r = WebRequest.Create("http://192.168.1.101/api/version");
            Stream rp =  r.GetResponse().GetResponseStream();
            Log("Response recieved.");
            StreamReader read = new StreamReader(rp);
            string response = read.ReadToEnd();
            Log("Response: " + response);
            TTVersion verdata = JsonConvert.DeserializeObject<TTVersion>(response);
            lblVersion.Text = ("Version: " + verdata.version);
            lblRevision.Text = ("Revision: " + verdata.revision);
            StringBuilder sb = new StringBuilder();

            foreach (String i in verdata.supported_versions)
            {
                sb.Append(i + " ");
            }
            lblSupportedVersions.Text = sb.ToString();

        }
        static readonly string[] SizeSuffixes =
                  { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
        public static string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (value < 0) { return "-" + SizeSuffix(-value); }

            int i = 0;
            decimal dValue = (decimal)value;
            while (Math.Round(dValue, decimalPlaces) >= 1000)
            {
                dValue /= 1024;
                i++;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}", dValue, SizeSuffixes[i]);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Log("Contacting camera...");
            WebRequest r = WebRequest.Create("http://192.168.1.101/api/2/status");
            Log("Web request created.");
            Stream rp = r.GetResponse().GetResponseStream();
            Log("Response received.");
            StreamReader read = new StreamReader(rp);
            string response = read.ReadToEnd();
            Log("Response: " + response);
            Log("Printing status to other Text box...");
            TTStatus status = JsonConvert.DeserializeObject<TTStatus>(response);
            lbStatus.Items.Add("Is Camera Recording?: " + status.recording_active);
            lbStatus.Items.Add("Recording Time: " + status.recoding_secs);
            lbStatus.Items.Add("Battery Charge: " + status.battery_level_pct + "%");
            lbStatus.Items.Add("Battery Charging?: " + status.battery_charging);
            lbStatus.Items.Add("GNSS Fix Obtained?: " + status.gnss_fix);
            lbStatus.Items.Add("GNSS Signal: " + status.gnss_strength_pct + "%");
            lbStatus.Items.Add("Heart Rate Sensor Connected?: " + status.heart_rate_sensor_connected);
            lbStatus.Items.Add("Cadence Sensor Connected? :" + status.cadence_sensor_connected);
            lbStatus.Items.Add("Preview Active?: " + status.preview_active);
            lbStatus.Items.Add("Viewfinder Active?: " + status.viewfinder_active);
            lbStatus.Items.Add("Viewfinder Streaming Port: " + status.viewfinder_streaming_port);
            lbStatus.Items.Add("Backchannel Port: " + status.backchannel_port);
            lbStatus.Items.Add("Remaining Space on SD Card: " + SizeSuffix(status.memory_free_bytes, 2));
            lbStatus.Items.Add("Remaining Recording Time in Seconds: " + status.remaining_time_secs);
            lbStatus.Items.Add("Remaining Photos: " + status.remaining_photos);
            lbStatus.Items.Add("Is Transcoding Active: " + status.transcoding_active);
            lbStatus.Items.Add("Transcoding Progress: " + status.transcoding_progress + "%");
        }

        private void btnGetCameraDTcv_Click(object sender, EventArgs e)
        { 
            Log("Contacting camera...");
            WebRequest r = WebRequest.Create("http://192.168.1.101/api/2/datetime");
            Stream rp = r.GetResponse().GetResponseStream();
            Log("Response recieved.");
            StreamReader read = new StreamReader(rp);
            string response = read.ReadToEnd();
            Log("Response: " + response);
            TTDateTime dt = JsonConvert.DeserializeObject<TTDateTime>(response);
            Log("The date and time received from the camera was: " + dt.datetime.ToString());
        }

        private void btnSetCameraDT_Click(object sender, EventArgs e)
        {
            string currentDT = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ");
            var request = (HttpWebRequest)WebRequest.Create("http://192.168.1.101/api/2/datetime");
            request.ContentType = "application/json";
            request.Method = "POST";
            TTDateTime dt = new TTDateTime();
            string json = JsonConvert.SerializeObject(dt);
            json = currentDT;
            var streamWriter = new StreamWriter(request.GetRequestStream());
            streamWriter.Write(json);
            streamWriter.Flush();
            streamWriter.Close();
            var response = (HttpWebResponse)request.GetResponse();
            var sr = new StreamReader(response.GetResponseStream());
            var result = sr.ReadToEnd();
            




        }
    }
}
