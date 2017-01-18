﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace Serializing.Classes
{
    public class Student
    {
        private string m_Name;
        private int m_Age;
        private string m_ID;
        public Student(string name, int age, string id)
        {
            m_Name = name;
            m_Age = age;
            m_ID = id;
        }
        public Student() { }
        public string NAME { get { return m_Name; } set { m_Name = value; } }
        public int AGE { get { return m_Age; } set { m_Age = value; } }
        public string ID { get { return m_ID; } set { m_ID = value; } }

    }

    class DataManager<T>
    {
        public static void Serialize(string fileName, ref T data)
        {
            XmlSerializer serialize = new XmlSerializer(typeof(T));
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
            return data;
        }
    }

}
