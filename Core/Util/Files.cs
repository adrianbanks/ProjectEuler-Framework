using System;
using System.IO;
using System.Reflection;

namespace ProjectEuler.Core.Util
{
    public static class Files
    {
        public static string Load(string filename)
        {
            Assembly assembly = Assembly.GetEntryAssembly();

            foreach (string resourceName in assembly.GetManifestResourceNames())
            {
                if (resourceName.EndsWith(filename))
                {
                    using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                    {
                        if (stream != null)
                        {
                            using (TextReader reader = new StreamReader(stream))
                            {
                                return reader.ReadToEnd();
                            }
                        }
                    }
                }
            }

            throw new Exception("Could not find file " + filename);
        }
    }
}
