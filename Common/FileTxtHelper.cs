namespace SPL.Common
{
    public static class FileTxtHelper
    {
        private static object lokerCSV = new object();
        private static object lokerTxt = new object();
        private static object lokerCatch = new object();

        public static bool WriteTxtWithDeleteFile(string path, string fileName, string str)
        {
            try
            {
                if (Directory.Exists(path) == false)
                    Directory.CreateDirectory(path);
                path = path + $"\\{fileName}";
                if (File.Exists(path))
                    File.Delete(path);
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(str);
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool WriteTxtWithOldFile(string path, string fileName, string str)
        {
            try
            {
                bool createNewFile = true;
                if (Directory.Exists(path) == false)
                    Directory.CreateDirectory(path);
                path = path + $"\\{fileName}";
                if (File.Exists(path))
                    createNewFile = false;
                FileStream fs = new FileStream(path, createNewFile ? FileMode.Create : FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(str);
                sw.Close();
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static void WriteLogTxt(string msg, string filePrefix, string stationCode)
        {
            string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Log\{0}\{1}\{2}\{3}\", DateTime.Now.ToString("yyyyMMdd"), filePrefix, stationCode));   

            if (!Directory.Exists(logDir))
                Directory.CreateDirectory(logDir);
            string fileName = filePrefix + " " + DateTime.Now.ToString("HH") + "时" + ".txt";
            lock (lokerTxt)
            {
                using (StreamWriter sw = new StreamWriter(logDir + fileName, true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ":" + msg);
                    sw.Close();
                }
            }
        }

        public static void WriteCatchLog(string msg, string filePrefix, string stationCode)
        {
            string logDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format(@"Log\{0}\{1}\{2}\{3}\", DateTime.Now.ToString("yyyyMM"), DateTime.Now.ToString("yyyyMMdd"), filePrefix, stationCode));
            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }
            string fileName = filePrefix + ".txt";
            lock (lokerCatch)
            {
                using (StreamWriter sw = new StreamWriter(logDir + fileName, true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + ":" + msg);
                    sw.Close();
                }
            }
        }

        public static void WriteLogCSV(String DataStr, string fullPath, string Headline)
        {
            try
            {
                FileInfo fi = new FileInfo(fullPath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                if (File.Exists(fullPath) == false)
                {
                    FileStream fs = new FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF8);
                    sw.WriteLine(Headline);
                    sw.Close();
                    fs.Close();
                }
                lock (lokerCSV)
                {
                    FileStream fss = new FileStream(fullPath, System.IO.FileMode.Append, System.IO.FileAccess.Write);  //写出数据
                    StreamWriter ssw = new StreamWriter(fss, System.Text.Encoding.UTF8);
                    ssw.Write(DataStr);
                    ssw.Close();
                    fss.Close();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
