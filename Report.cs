using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Report_Editor
{
    class Report
    {
        public int ID;
        public string Timespan;
        public DateTime Date;
        public String Content;

        public Report(int id, string timespan, DateTime date, String content)
        {
            ID = id;
            Timespan = timespan;
            Date = date;
            Content = content;
        }

        public override string ToString()
        {
            return Timespan + " | " + Date.ToString() + ": " + Content;
        }

    }
}
