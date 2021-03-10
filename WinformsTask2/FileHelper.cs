using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using WinformsTask2.Entities;

namespace WinformsTask2
{
    public static class FileHelper
    {
        private static readonly JsonSerializer Serializer;

        public static string FileName { get; set; }
        static FileHelper()
        {
            Serializer = new JsonSerializer();
        }

        public static void WriteToJson(IList<Worker> workers)
        {
            using (var fs = new FileStream(FileName, FileMode.Create))
            {
                using (var sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        Serializer.Formatting = Formatting.Indented;

                        Serializer.Serialize(jw, workers);
                    }
                }
            }
        }

        public static IList<Worker> ReadFromJson()
        {
            var workers = new List<Worker>();

            using (var fs = new FileStream(FileName, FileMode.Open))
            {
                using (var sr = new StreamReader(fs, Encoding.UTF8))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        workers = Serializer.Deserialize<List<Worker>>(jr) ?? workers;
                    }
                }
            }

            return workers;
        }
    }
}