using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMef2
{
    public class Logger : ILogger
    {
        public string Header
        {
            get;
            set;
        } = " ";

        public string Status
        {
            get;
            set;
        } = "";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="msg"></param>
        public void WriteInfo(string msg)
        {
            System.Diagnostics.Debug.WriteLine(Header + msg + Status);
        }
    }
}
