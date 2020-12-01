using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTomCameraServerGUI
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TTStatus
    {
        public bool recording_active { get; set; }
        public int recoding_secs { get; set; }
        public int battery_level_pct { get; set; }
        public bool battery_charging { get; set; }
        public bool gnss_fix { get; set; }
        public int gnss_strength_pct { get; set; }
        public bool heart_rate_sensor_connected { get; set; }
        public bool cadence_sensor_connected { get; set; }
        public bool preview_active { get; set; }
        public bool viewfinder_active { get; set; }
        public int viewfinder_streaming_port { get; set; }
        public int backchannel_port { get; set; }
        public long memory_free_bytes { get; set; }
        public int remaining_time_secs { get; set; }
        public int remaining_photos { get; set; }
        public bool transcoding_active { get; set; }
        public int transcoding_progress { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class Camera
    {
        public string serial_number { get; set; }
        public bool gnss_enabled { get; set; }
        public bool sound_enabled { get; set; }
        public bool lights_enabled { get; set; }
        public bool image_rotation_enabled { get; set; }
        public bool external_microphone_enabled { get; set; }
    }

    public class Wifi
    {
        public string ssid { get; set; }
    }

    public class Scene
    {
        public string mode { get; set; }
        public int brightness { get; set; }
        public int contrast { get; set; }
        public int hue { get; set; }
        public int saturation { get; set; }
        public int sharpness { get; set; }
    }

    public class Video
    {
        public string mode { get; set; }
        public string resolution { get; set; }
        public int framerate_fps { get; set; }
        public string fov { get; set; }
    }

    public class RootSettings
    {
        public Camera camera { get; set; }
        public Wifi wifi { get; set; }
        public Scene scene { get; set; }
        public Video video { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TTDateTime
    {
        public DateTime datetime { get; set; }
    }

}
