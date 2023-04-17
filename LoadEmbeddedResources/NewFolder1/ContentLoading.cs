using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoadEmbeddedResources.NewFolder1
{
    static class ContentLoading
    {
        public static string GetXmlContent()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            const string NAME = "LoadEmbeddedResources.NewFolder1.MyStuff.xml";

            using(Stream stream = assembly.GetManifestResourceStream(NAME))
            {
                using(StreamReader reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
