using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rain51
{
    public class Serialization
    {
        public void serialize(string savePath, IList seznam)
        {
            JsonSerializer serializer = new JsonSerializer();
            string output = JsonConvert.SerializeObject(seznam);
            serializer.NullValueHandling = NullValueHandling.Ignore;
            string path = savePath + ".json";
            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, seznam);
            }
        }

    }
}
