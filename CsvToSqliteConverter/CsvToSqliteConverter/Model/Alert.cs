using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToSqliteConverter.Model
{
    public class AlertMsg
    {
        public string Name = "--";
        public string Uid = "--";
        public int Severity = -1;
        public string Category = "--";
        public string ErrorCode = "--";
        public string Description_EN = "Unknown error";
        public string Description_ZH = "Unknown error";
        public bool IsSelfTestable = false;

        public AlertMsg()
        {

        }

        public AlertMsg(string name, string uid, int severity, string errorcode, string description_en, string description_zh, bool isselftestable)
        {
            Name = name;
            Uid = uid;
            Severity = severity;
            ErrorCode = errorcode;
            Description_EN = description_en;
            Description_ZH = description_zh;
        }
    }

}
