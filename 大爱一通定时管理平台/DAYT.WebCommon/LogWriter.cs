using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAYT.WebCommon
{
    /// <summary>
    /// 文件日志操作类
    /// </summary>
    public class LogWriter
    {
        private static string _file_path;

        /// <summary>
        /// 文件路径
        /// </summary>
        public static string FILE_PATH
        {
            get
            {
                return _file_path;
            }
            set
            {
                _file_path = value;
            }
        }
        public LogWriter() { }

        /// <summary>
        /// 写文件日志
        /// </summary>
        /// <param name="message">日志信息</param>
        public static void WriteLog(string message)
        {
            string str2;
            Monitor.Enter(str2 = FILE_PATH);
            try
            {
                StreamWriter writer;
                if (!Directory.Exists(FILE_PATH))
                {
                    Directory.CreateDirectory(FILE_PATH);
                }
                string path = FILE_PATH + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                if (!File.Exists(path))
                {
                    writer = File.CreateText(path);
                }
                else
                {
                    writer = File.AppendText(path);
                }
                writer.WriteLine("\n");
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff ") + ":  " + message);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {
            }
            finally
            {
                Monitor.Exit(str2);
            }
        }

        /// <summary>
        /// 写文件日志
        /// </summary>
        /// <param name="sFrom">日志名称</param>
        /// <param name="e">异常信息对象</param>
        public static void WriteLog(string sFrom, Exception e)
        {
            WriteLog(sFrom);
            WriteLog("Source=" + e.Source + "\tMessage=" + e.Message + " TargetSite.Name=" + e.TargetSite.Name);
            WriteLog("StackTrace = " + e.StackTrace);
        }
    }
}
