using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TgSender
{
    class BAL
    {
        public class TGREQ
        {
            public int Id { get; set; }
            public string Title1 { get; set; }
            public string Title2 { get; set; }
            public DateTime DATETIME_INSERT { get; set; }
            public DateTime DATETIME_DONE { get; set; }
            public DateTime DATETIME_START { get; set; }
            public DateTime DATETIME_ORDER { get; set; }
            public bool SENT { get; set; }
            public bool ISDONE { get; set; }
            public string TEMPLATE { get; set; }
            public string REPORT { get; set; }
            public string ENDINGKIND { get; set; }
            public string VIDEODURTION { get; set; }
            public string T1 { get; set; }
            public string T2 { get; set; }
            public string T3 { get; set; }
            public string T4 { get; set; }
            public string T5 { get; set; }
            public string T6 { get; set; }
            public string T7 { get; set; }
            public string T8 { get; set; }
            public string T9 { get; set; }
            public string T10 { get; set; }
            public string FinalFile { get; set; }
        }
    }
}
