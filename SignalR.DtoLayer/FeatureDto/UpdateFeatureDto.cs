using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.FeatureDto
{
    public class UpdateFeatureDto
    {
        public int FeatureId { get; set; }
        public string Title1 { get; set; }
        public string Descripton1 { get; set; }
        public string Title2 { get; set; }
        public string Descripton2 { get; set; }
        public string Title3 { get; set; }
        public string Descripton3 { get; set; }
    }
}
