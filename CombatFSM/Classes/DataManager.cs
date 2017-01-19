﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace CombatFSM.Classes
{
   
    class DataManager<T>
    {
        public static void Serialize(string fileName, ref T data)
        {
            XmlRootAttribute xRoot = new XmlRootAttribute();
            xRoot.ElementName = "Combat";
            xRoot.IsNullable = true;
            XmlSerializer serialize = new XmlSerializer(typeof(T),xRoot);
            if (!File.Exists(@"..\..\" + fileName + ".xml"))
            {
          
                FileStream ddk = File.Create(@"..\..\" + fileName + ".xml");
                ddk.Close();
            }

            TextWriter writer = new StreamWriter(@"..\..\" + fileName + ".xml");

            serialize.Serialize(writer, data);
            writer.Close();
        }
        public static T Deserialize(string fileName)
        {
            T data;
            XmlSerializer deser = new XmlSerializer(typeof(T));
            TextReader reader = new StreamReader(@"..\..\" + fileName + ".xml");
            data = (T)deser.Deserialize(reader);
            reader.Close();
            return data;
        }
    }

}
