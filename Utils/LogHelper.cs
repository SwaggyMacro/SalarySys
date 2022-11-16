using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Utils
{
    public class LogHelper
    {
        public static void WriteLog(string log)
        {
            Thread t = new Thread(() => {
                string sFilePath = Environment.CurrentDirectory + "/Log";
                string sFileName = "log_" + DateTime.Now.ToString("yyyy-MM-dd") + ".log";
                sFileName = sFilePath + "\\" + sFileName;
                if (!Directory.Exists(sFilePath))
                {
                    Directory.CreateDirectory(sFilePath);
                }
                FileStream fs;
                StreamWriter sw;
                if (File.Exists(sFileName))
                {
                    fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
                }
                else
                {
                    fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
                }
                sw = new StreamWriter(fs);
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "   ---   " + log);
                sw.Close();
                fs.Close();
            });
            t.Start();
        }
    }
}
