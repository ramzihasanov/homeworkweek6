using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    [Serializable]
    public class User:ISerializable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id", Id,typeof(int));
            info.AddValue("name", Name, typeof(string));
            info.AddValue("surname", SurName, typeof(string));
            info.AddValue("username", UserName, typeof(string));
        }

        public User(SerializationInfo info, StreamingContext context)
        {
            Id = info.GetInt32("id");
            Name = info.GetString("name");
            SurName = info.GetString("surname");
            UserName = info.GetString("username");

        }
        public User()
        {

        }


    }
}
