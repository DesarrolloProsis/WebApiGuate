using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiGuate.Models;

namespace WebApiGuate.Controllers
{
    public class HomeController : Controller
    {
        GTDBEntities db = new GTDBEntities();
        public static DateTime HistoricoListas { get; set; }
        public static DateTime HistoricoTags { get; set; }
        public static int OracleTransactions { get; set; }
        public static int SQLTransactions { get; set; }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public void GetHistoricoListas()
        {
            HistoricoListas = db.HistoricoListas.OrderByDescending(x => x.Fecha_Creacion).FirstOrDefault().Fecha_Creacion;
        }
        public DateTime SendHistoricoListas()
        {
            return HistoricoListas;
        }
        public void GetHistoricoTags()
        {
            HistoricoTags = db.Historico.OrderByDescending(x => x.Fecha).FirstOrDefault().Fecha;
        }
        public DateTime SendHistoricoTags()
        {
            return HistoricoTags;
        }
        public void GetOracleTransactions()
        {
            var query = @"Select count(*) From Transaction Where  ID_PAIEMENT = '15' 
                        AND TO_CHAR(DATE_TRANSACTION, 'YYYY/MM/DD HH24:MI:SS' ) >= '2019/03/21 12:31:55'  
                        AND SUBSTR(TO_CHAR(CONTENU_ISO),0,3) = '501'  
                        AND TAB_ID_CLASSE >= 1 order by DATE_TRANSACTION ASC";
            OracleConnection connection = new OracleConnection("User Id = GEADBA; Password = fgeuorjvne; Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = 10.1.10.111)(PORT = 1521)))(CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = GEAPROD)))");
            connection.Open();
            OracleCommand cmd = new OracleCommand(query, connection);
            OracleTransactions = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();
        }
        public int SendOracleTransactions()
        {
            return OracleTransactions;
        }
        public void GetSQLTransactions()
        {
            SQLTransactions = db.Historico.Count();
        }
        public int SendSQLTransactions()
        {
            return SQLTransactions;
        }
    }
}
