using ConsoleApp1.Models;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.Id = 15;
            //user.UserName = "remzi.2004";
            //user.Name = "remzi";
            //user.SurName = "hesenov";
            //SerializeToJson(user);
            User user=DeserializeFromJson();
            Console.WriteLine(user);

            //    SeryalizeToBinary(user);
            //    SerializeToXML(user);

            //    User user = DeserializeFromBinary();
            //User user = DeSerializeFromXML();
            //Console.WriteLine(user);


        }

        public static void SeryalizeToBinary(User user)
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.dat";
            Stream stream=new FileStream(path,FileMode.Create);
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            binaryFormatter.Serialize(stream, user);
        }

        public static User DeserializeFromBinary()
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.dat";
            Stream stream = new FileStream(path, FileMode.Open);
            BinaryFormatter binaryFormatter=new BinaryFormatter();
            var user =(User)binaryFormatter.Deserialize(stream);
            return user;

        }

        public static void SerializeToXML(User user)
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.xml";
            Stream stream = new FileStream(path, FileMode.Create);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            xmlSerializer.Serialize(stream, user);
        }

        public static User DeSerializeFromXML()
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.xml";
            Stream stream = new FileStream(path, FileMode.Open);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(User));
            var User =(User)xmlSerializer.Deserialize(stream);
            return User;

        }


        public static void SerializeToJson(User user)
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.json";
            string json = JsonSerializer.Serialize(user);
            File.WriteAllText(path, json);
        }

        public static User DeserializeFromJson()
        {
            string path = "C:\\Users\\hesen\\OneDrive\\İş masası\\User.json";
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<User>(json);
        }


       
    }
}