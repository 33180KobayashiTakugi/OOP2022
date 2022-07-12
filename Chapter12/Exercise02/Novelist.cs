using System;
using System.Runtime.Serialization;
using System.Xml.Serialization; 

    [XmlRoot("novelist")]
public class Novelist {

    [XmlElement(ElementName = "name")]
    [DataMember(Name ="name")]
    public string Name { get; set; }

    [XmlElement(ElementName = "birth")]
    [DataMember(Name = "birth")]
    public DateTime Birth { get; set; }

    [XmlArray("masterpeces")]
    [XmlArrayItem("title",typeof(string))]
    [DataMember(Name = "masterpeces")]
    public string[] Masterpieces { get; set; }
}
