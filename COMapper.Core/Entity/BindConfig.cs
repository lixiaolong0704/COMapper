namespace COMapper.Core.Entity
{
    //[XmlRoot(ElementName = "MyClass")]
    public class BindConfig
    {
        public BindConfig()
        {
            Maps = new Maps();
        }

        public Maps Maps { get; set; }
    }
}
