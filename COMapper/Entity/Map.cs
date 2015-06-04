using System.Xml.Serialization;

namespace COMapper.Entity
{
    public class Map
    {
        [XmlAttribute]
        public string Ignore { get; set; }
        [XmlAttribute]
        public string CTL { get; set; }
        [XmlAttribute]
        public string Converter { get; set; }
        [XmlAttribute]
        public string CTL_PROP { get; set; }
        [XmlAttribute]
        public string PROP { get; set; }
    }
}
