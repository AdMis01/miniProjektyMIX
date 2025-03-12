using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            zasob.Tables.Add(New DataTable());
        }

        DataSet zasob = new DataSet();
            

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable tabela_dane = zasob.Tables[0];
            DataColumn kol_1 = new DataColumn();
            kol_1.ColumnName = "Symbol";
            kol_1.DataType = System.Type.GetType("System.String");
            tabela_dane.Columns.Add(kol_1);

            DataColumn kol_2 = new DataColumn("wartosc");
            kol_2.DataType = typeof(string);
            tabela_dane.Columns.Add(kol_2);

            tabela_dane.Columns.Add(new DataColumn("Jednoski", typeof(string));

            tabela_dane.PrimaryKey = new DataColumn[] { kol_1 };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabela_dane = zasob.Tables[0];
            DataGridView1.DataSource = tabela_dane;
            if(tabela_dane.Rows.Count > 0)
            {
                var ob = tabela_dane.GetChanges();
                if(ob != null)
                {
                    var ob_d = tabela_dane.GetChanges(DataRowState.Added);
                    if(ob_d != null)
                    {
                        MessageBox.Show("Liczba wierszy dodanych" + " " + Convert.ToString(ob_d.Rows.Count), "Dodane wiersze");

                    }
                }
            }
            tabela_dane.AcceptChanges();
            zasob.WriteXml(@"D:\obied_2.xml");
        }
        
    }
}
