using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Configuration;
using System.Collections.Specialized;
using Microsoft.Win32;

namespace TestODBC
{
    public partial class Form1 : Form
    {

        TestQueries myTesteur;
        public Form1()
        {
            InitializeComponent();
            string bezin = Environment.UserDomainName;
            txtDomain.Text = Environment.UserDomainName;
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["Domain"]))
            {
                txtDomain.Text = ConfigurationManager.AppSettings["Domain"].ToString();
            }


            txtUser.Text = Environment.UserName;
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["User"]))
            {
                txtUser.Text = ConfigurationManager.AppSettings["User"].ToString();
            }
            if (!String.IsNullOrEmpty(ConfigurationManager.AppSettings["Password"]))
            {
                txtPwd.Text = ConfigurationManager.AppSettings["Password"].ToString();
            }

            List<string> zeDNSs = Properties.Settings.Default.DNSnames.Cast<string>().ToList();

            RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"Software\ODBC\ODBC.INI\ODBC Data Sources");
            if (regKey != null)
            {
                foreach (string name in regKey.GetValueNames())
                {
                    if (regKey.GetValue(name, "").ToString().IndexOf("SQL Server", StringComparison.CurrentCultureIgnoreCase)>=0)
                    {
                        var IndexItem = chkListDNS.Items.Add(name);
                        chkListDNS.SetItemChecked(IndexItem, true);
                    }
                }

            }
        }





        private void butLaunch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDomain.Text) || String.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show(" User or domain empty ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<String> checkedDSN = new List<string>();

            for (int i = 0; i < chkListDNS.Items.Count; i++)
            {
                if (chkListDNS.GetItemChecked(i))
                {

                    checkedDSN.Add(chkListDNS.Items[i].ToString());
                }
            }


            myTesteur = new TestQueries(txtDomain.Text, txtUser.Text, txtPwd.Text);


            
            try
            {
                List<QueryError> resultat = myTesteur.launchTest(Properties.Settings.Default.Queries.Cast<string>().ToList(), checkedDSN);
               
                GridResultat.DataSource = resultat;
               
                
                /*
                if (resultat.Count == 0)
                {
                    MessageBox.Show("All " + checkedDSN.Count.ToString() + "  DNS and " + Properties.Settings.Default.Queries.Cast<string>().Count() + " Queries are OK", "Check OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string ErrorMessage = String.Join("\n\n", resultat.Select(s => " DNS : " + s.DNS + " Query: " + s.zeQuery + " Result: " + s.TextError));

                    MessageBox.Show(ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }

            catch (Exception ex)
            {
                MessageBox.Show("NOK " + ex.Message);

            }
        }

        private void GridResultat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (GridResultat.Columns[e.ColumnIndex].DataPropertyName == "TextError")
            {
                if (e.Value != null)
                
                {
                    if (e.Value == "OK")
                    {
                        GridResultat.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; 
                    }
                    else
                    {
                        GridResultat.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                        GridResultat.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.WrapMode = DataGridViewTriState.True;
                        GridResultat.Rows[e.RowIndex].Height = Math.Max( e.Value.ToString().Length / 2,30) ;
                    }
                }

            }
            
        }
    }
}
