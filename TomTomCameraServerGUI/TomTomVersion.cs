using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TomTomCameraServerGUI
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class TTVersion
    {
        public string version { get; set; }
        public string revision { get; set; }
        public List<string> supported_versions { get; set; }
    }

}
