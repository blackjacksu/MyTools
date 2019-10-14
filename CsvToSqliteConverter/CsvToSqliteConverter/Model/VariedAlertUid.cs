using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvToSqliteConverter.Model
{
    public class VariedAlertUid
    {
        public string Category = "--";
        public string Uid = "--";
        public Difference Diff = Difference.NoDifference;

        public VariedAlertUid()
        {

        }

        public VariedAlertUid(string category, string uid, Difference diff)
        {
            Category = category;
            Uid = uid;
            Diff = diff;
        }
    }
}
