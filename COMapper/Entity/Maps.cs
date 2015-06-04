using System.Collections.Generic;
using System.Xml.Serialization;

namespace COMapper.Entity
{
    [XmlType("Maps")]
    public class Maps 
    {
        public Maps ()
        {
            maps=new List<Map>();
        }
        [XmlAttribute]
        public string Id { get; set; }
        [XmlElement("Map")] // now the array element will be as same as the object element Rats. 
        public List<Map> maps { get; set; }
    }
}
