using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using System.Xml.Serialization;

namespace AddressBook
{
    public class AddressBookManager
    {
        public string Save(Contact contact)
        {
            var serializer = new XmlSerializer(typeof(Contact));
            using var writer = new StringWriter();
            serializer.Serialize(writer, contact);
            return writer.ToString();
        }

        public Contact? Load(string xml)
        {
            var serializer = new XmlSerializer(typeof(Contact));
            using var reader = new StringReader(xml);
            return (Contact?)serializer.Deserialize(reader);
        }

    }
}
