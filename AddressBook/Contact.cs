using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AddressBook
{
    public class Contact
    {
        [XmlElement("name")]
        public string Name { get; set; } = string.Empty;

        [XmlElement("phone")]
        public string Phone { get; set; } = string.Empty;

        [XmlElement("email")]
        public string Email { get; set; } = string.Empty;
    }
}
