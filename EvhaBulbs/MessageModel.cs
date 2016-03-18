using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EvhaBulbs
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int Intensity { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
