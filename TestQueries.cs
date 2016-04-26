using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestODBC
{

    public class QueryError
    {
        public string DNS {get;set;}
        public string zeQuery { get; set; }
        public string Status { get; set; }
        public string TextError { get; set; }
    }


    public class QueryErrors : List<QueryError>
    {
    }

    public class TestQueries
    {
        protected string _domain;
        protected string _user;
        protected string _mdp;

        public TestQueries(string domain, string user, string mdp)
        {
            _domain = domain;
            _user = user;
            _mdp = mdp;
        }

        public List<QueryError> launchTest(List<String> zeQueries, List<String> odbcDNS)
        {
            QueryErrors resultat = new QueryErrors();

            using (UserImpersonation user = new UserImpersonation(_user, _domain, _mdp))
            {
                if (user.ImpersonateValidUser())
                {
                    foreach (string curDSN in odbcDNS)
                    {
                        OdbcConnection DbConnection = new OdbcConnection("DSN=" + curDSN);
                        try
                        {
                            DbConnection.Open();
                            foreach (string curQuery in zeQueries)
                            {
                                resultat = TestOneQuery(resultat, curQuery, DbConnection, curDSN);
                            }
                            DbConnection.Dispose();
                        }
                        catch (Exception ex)
                        {
                            resultat.Add(new QueryError { DNS = curDSN, zeQuery = "N/A", TextError = ex.Message,Status="ERROR" });
                        }
                    }
                }
                else
                {
                    return new QueryErrors { new QueryError { DNS = "N/A", zeQuery = "N/A", TextError = "Error when connecting domain " + _domain + " User " + _user, Status = "ERROR" } };
                }
                return resultat;
            }


        }
        protected QueryErrors TestOneQuery(QueryErrors resultat, string zeQuery, OdbcConnection curConn, string curDNS)
        {
            OdbcCommand DbCommand = curConn.CreateCommand();
            DataSet MyDs = new DataSet();

            try
            {
                DbCommand.CommandText = zeQuery;
                OdbcDataAdapter myDataAdapter = new OdbcDataAdapter();
                myDataAdapter.SelectCommand = DbCommand;
                myDataAdapter.Fill(MyDs);

                if (MyDs.Tables[0].Rows.Count == 0)
                {
                    resultat.Add(new QueryError { DNS = curDNS, zeQuery = zeQuery, TextError = " No data",Status="ERROR" });
                }
                else
                {
                    resultat.Add(new QueryError { DNS = curDNS, zeQuery = zeQuery, TextError = "OK",Status="OK" });
                }
            }
            catch (Exception ex)
            {
                resultat.Add(new QueryError { DNS = curDNS, zeQuery = zeQuery, TextError =   ex.Message, Status = "ERROR" });
            }



            DbCommand.Dispose();


            return resultat;

        }



    }
}
