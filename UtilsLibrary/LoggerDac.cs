using System.Collections.Generic;
using System.Text.Json;
using System;
using System.IO;

namespace UtilsLibrary.DAC
{
    internal sealed class LoggerDac
    {
        
        private string path = @"D:\POC\log\log.txt";
        private void SetCompletePath() {
            /*idea is to look for a location and there create rolling files*/
            var files = Directory.GetFiles()
        }
        internal List<Log> Get() 
        {
            // Variable Defination
            // var serializer = new JsonSerializer();

            //Read the content of the JSON DB
            var fileContents = System.IO.File.ReadAllText(path);
            //Serialize the JSON value            
            var deserializedResult = JsonSerializer.Deserialize<List<Log>>(fileContents);

            return deserializedResult; 
        }

        internal void Save(List<Log> logs) 
        {
            // Create a Serializer Object
            // var serializer = new JsonSerializer();
            //Serialize the list content
            var serializedResult = JsonSerializer.Serialize(logs);

            try
            {
                //Save the result
                System.IO.File.WriteAllText(path, serializedResult);
            }
            catch (Exception ex)
            { }
        }
    }
}