using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class FileUtil
    {
        public static string ReadFileString(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
