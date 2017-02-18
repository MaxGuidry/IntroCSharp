using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace SerializePractice
{
    [System.Serializable]
    public class Entity
    {
        public Entity()
        {

        }
        public Entity(string n, bool a)
        {
            Name = n;
            Alive = a;
        }
       public string Name { get; set; }
        public bool Alive { get; set; }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Entity Donray = new Entity("Donray", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Entity));
            StreamWriter writer = new StreamWriter(Environment.CurrentDirectory + "/Entity.xml");
            serializer.Serialize(writer, Donray);
    
    }
    }
}
