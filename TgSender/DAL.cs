using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TgSender.DSTableAdapters;

namespace TgSender
{

    class DAL
    {


        public static int Insert(BAL.TGREQ Obj)
        {
            TGTableAdapter Ta = new TGTableAdapter();
            int ReturnID = int.Parse(Ta.Insert_Data(Obj.Title1,
                Obj.Title2,
                Obj.DATETIME_INSERT,
                Obj.DATETIME_DONE,
                Obj.DATETIME_START,
                Obj.DATETIME_ORDER,
                Obj.SENT,
                Obj.ISDONE,
                Obj.TEMPLATE,
                Obj.REPORT,
                Obj.ENDINGKIND,
                Obj.VIDEODURTION,
                Obj.T1,
                Obj.T2,
                Obj.T3,
                Obj.T4,
                Obj.T5,
                Obj.T6,
                Obj.T7,
                Obj.T8,
                Obj.T9,
                Obj.T10
                ).ToString());
            return ReturnID;
        }

        public static List<BAL.TGREQ> Select(DateTime InDate)
        {
            List<BAL.TGREQ> Lst = new List<BAL.TGREQ>();
            TGTableAdapter Ta = new TGTableAdapter();


            DateTime startDate = DateTime.Parse(InDate.ToShortDateString() + " 00:00");
            DateTime endDate = DateTime.Parse(InDate.ToShortDateString() + " 23:59");


            DS.TGDataTable Dt = Ta.Data_Select_ByDate(startDate, endDate);
            for (int i = 0; i < Dt.Rows.Count; i++)
            {
                BAL.TGREQ Rq = new BAL.TGREQ();
                Rq.Title1 = Dt[i]["Title1"].ToString();
                Rq.Title2 = Dt[i]["Title2"].ToString();
                Rq.TEMPLATE = Dt[i]["TEMPLATE"].ToString();
                Rq.ENDINGKIND = Dt[i]["ENDINGKIND"].ToString();

                Rq.T1 = Dt[i]["T1"].ToString();
                Rq.T2 = Dt[i]["T2"].ToString();
                Rq.T3 = Dt[i]["T3"].ToString();
                Rq.T4 = Dt[i]["T4"].ToString();
                Rq.T5 = Dt[i]["T5"].ToString();
                Rq.T6 = Dt[i]["T6"].ToString();
                Rq.T7 = Dt[i]["T7"].ToString();
                Rq.T8 = Dt[i]["T8"].ToString();
                Rq.T9 = Dt[i]["T9"].ToString();
                Rq.T10 = Dt[i]["T10"].ToString();

                Rq.REPORT = Dt[i]["REPORT"].ToString();

                Rq.ISDONE = bool.Parse(Dt[i]["ISDONE"].ToString());
                Rq.SENT = bool.Parse(Dt[i]["SENT"].ToString());
                Rq.VIDEODURTION = Dt[i]["VIDEODURTION"].ToString();

                Rq.DATETIME_INSERT = DateTime.Parse(Dt[i]["DATETIME_INSERT"].ToString());
                Rq.DATETIME_DONE = DateTime.Parse(Dt[i]["DATETIME_DONE"].ToString());
                Rq.DATETIME_ORDER = DateTime.Parse(Dt[i]["DATETIME_ORDER"].ToString());
                Rq.DATETIME_START = DateTime.Parse(Dt[i]["DATETIME_START"].ToString());

                Rq.FinalFile = Dt[0]["FinalFile"].ToString();

                Rq.Id = int.Parse(Dt[i]["ID"].ToString());
                Lst.Add(Rq);
            }



            return Lst;
        }

        public static BAL.TGREQ SelectById(int Id)
        {

            TGTableAdapter Ta = new TGTableAdapter();
            DS.TGDataTable Dt = Ta.Select_Data_ById(Id);

            BAL.TGREQ Rq = new BAL.TGREQ();
            Rq.Title1 = Dt[0]["Title1"].ToString();
            Rq.Title2 = Dt[0]["Title2"].ToString();
            Rq.TEMPLATE = Dt[0]["TEMPLATE"].ToString();
            Rq.ENDINGKIND = Dt[0]["ENDINGKIND"].ToString();

            Rq.T1 = Dt[0]["T1"].ToString();
            Rq.T2 = Dt[0]["T2"].ToString();
            Rq.T3 = Dt[0]["T3"].ToString();
            Rq.T4 = Dt[0]["T4"].ToString();
            Rq.T5 = Dt[0]["T5"].ToString();
            Rq.T6 = Dt[0]["T6"].ToString();
            Rq.T7 = Dt[0]["T7"].ToString();
            Rq.T8 = Dt[0]["T8"].ToString();
            Rq.T9 = Dt[0]["T9"].ToString();
            Rq.T10 = Dt[0]["T10"].ToString();

            Rq.REPORT = Dt[0]["REPORT"].ToString();

            Rq.ISDONE = bool.Parse(Dt[0]["ISDONE"].ToString());
            Rq.SENT = bool.Parse(Dt[0]["SENT"].ToString());
            Rq.VIDEODURTION = Dt[0]["VIDEODURTION"].ToString();

            Rq.DATETIME_INSERT = DateTime.Parse(Dt[0]["DATETIME_INSERT"].ToString());
            Rq.DATETIME_DONE = DateTime.Parse(Dt[0]["DATETIME_DONE"].ToString());
            Rq.DATETIME_ORDER = DateTime.Parse(Dt[0]["DATETIME_ORDER"].ToString());
            Rq.DATETIME_START = DateTime.Parse(Dt[0]["DATETIME_START"].ToString());


            Rq.FinalFile = Dt[0]["FinalFile"].ToString();

            Rq.Id = int.Parse(Dt[0]["ID"].ToString());


            return Rq;
        }

        public static void Update(BAL.TGREQ Obj)
        {
            TGTableAdapter Ta = new TGTableAdapter();
            int ReturnID = Ta.Update_Data(Obj.Title1,
                Obj.Title2,
                Obj.DATETIME_INSERT,
                Obj.DATETIME_DONE,
                Obj.DATETIME_START,
                Obj.DATETIME_ORDER,
                Obj.SENT,
                Obj.ISDONE,
                Obj.TEMPLATE,
                Obj.REPORT,
                Obj.ENDINGKIND,
                Obj.VIDEODURTION,
                Obj.T1,
                Obj.T2,
                Obj.T3,
                Obj.T4,
                Obj.T5,
                Obj.T6,
                Obj.T7,
                Obj.T8,
                Obj.T9,
                Obj.T10,
                Obj.Id
                );
        }
        public static void UpdateSent(int Id, bool Sent)
        {
            TGTableAdapter Ta = new TGTableAdapter();
            int ReturnID = Ta.Update_Sent(Sent, DateTime.Now, Id);
        }
        public static void Delete(int Id)
        {
            TGTableAdapter Ta = new TGTableAdapter();
            Ta.Delete_ById(Id);
        }
    }
}
