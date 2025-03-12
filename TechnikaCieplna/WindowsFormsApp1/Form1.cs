using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 //Adam Mischke
{
    public partial class Form1 : Form
    {
        DataTable tabla_dane = new DataTable();
        List<string> oblicz_w = new List<string>();
        DataTable wynik = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = textBox1.Text;
                wiersz1[1] = Convert.ToDouble(textBox2.Text);
                wiersz1[2] = textBox3.Text;
                tabla_dane.Rows.Add(wiersz1);
                dataGridView1.Refresh();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("wprowadz dane");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataColumn kol1 = new DataColumn();
            kol1.ColumnName = "Symbol";
            kol1.DataType = System.Type.GetType("System.String");
            tabla_dane.Columns.Add(kol1);

            DataColumn kol2 = new DataColumn("Wartosci");
            kol2.DataType = typeof(double);
            tabla_dane.Columns.Add(kol2);

            tabla_dane.Columns.Add(new DataColumn("Jednostki", typeof(string)));

            wynik = tabla_dane.Copy();
            dataGridView1.DataSource = tabla_dane;

            oblicz_w.Add("P_1");
            oblicz_w.Add("P_2");
            oblicz_w.Add("T_2");
            oblicz_w.Add("T_3");
            oblicz_w.Add("Q_d");
            oblicz_w.Add("Q_w");

            DataRow wiersz1 = tabla_dane.NewRow();
            wiersz1[0] = "R";
            wiersz1[1] = 296.8;
            wiersz1[2] = "j/kgK";
            tabla_dane.Rows.Add(wiersz1);

            DataRow wiersz2 = tabla_dane.NewRow();
            wiersz2[0] = "m";
            wiersz2[1] = 1.15;
            wiersz2[2] = "m";
            tabla_dane.Rows.Add(wiersz2);

            DataRow wiersz3 = tabla_dane.NewRow();
            wiersz3[0] = "T_1";
            wiersz3[1] = 295;
            wiersz3[2] = "K";
            tabla_dane.Rows.Add(wiersz3);

            DataRow wiersz4 = tabla_dane.NewRow();
            wiersz4[0] = "cp";
            wiersz4[1] = 1.051;
            wiersz4[2] = "Kj/kgK";
            tabla_dane.Rows.Add(wiersz4);

            DataRow wiersz5 = tabla_dane.NewRow();
            wiersz5[0] = "v_1";
            wiersz5[1] = 2.1;
            wiersz5[2] = "m^2/kg";
            tabla_dane.Rows.Add(wiersz5);

            DataRow wiersz6 = tabla_dane.NewRow();
            wiersz6[0] = "v_3";
            wiersz6[1] = 5.6;
            wiersz6[2] = "m^2/kg";
            tabla_dane.Rows.Add(wiersz6);

            listBox1.DataSource = oblicz_w;
            listBox1.Refresh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue.ToString() == "P_1")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'R'").First();
                double r_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'v_1'").First();
                double v_1_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'T_1'").First();
                double T_1_w = Convert.ToDouble(w4[1]);

                double p_1_w = (r_w * T_1_w) / v_1_w;
                DataRow p_1_wi = wynik.NewRow();
                p_1_wi[0] = "p_1";
                p_1_wi[1] = p_1_w;
                p_1_wi[2] = "Pa";
                wynik.Rows.Add(p_1_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "p_1";
                wiersz1[1] = p_1_w;
                wiersz1[2] = "Pa";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
            if (listBox1.SelectedValue.ToString() == "P_2")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'p_1'").First();
                double p_1_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'v_1'").First();
                double v_1_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'v_3'").First();
                double v_3_w = Convert.ToDouble(w4[1]);
                DataRow w5 = tabla_dane.Select("Symbol = 'm'").First();
                double m_w = Convert.ToDouble(w5[1]);

                double p_2_w = p_1_w * Math.Pow((v_3_w / v_1_w), m_w);
                DataRow p_2_wi = wynik.NewRow();
                p_2_wi[0] = "p_2";
                p_2_wi[1] = p_2_w;
                p_2_wi[2] = "Pa";
                wynik.Rows.Add(p_2_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "p_2";
                wiersz1[1] = p_2_w;
                wiersz1[2] = "Pa";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
            if (listBox1.SelectedValue.ToString() == "T_2")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'p_1'").First();
                double p_1_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'p_2'").First();
                double p_2_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'T_1'").First();
                double T_1_w = Convert.ToDouble(w4[1]);

                double T_2_w = T_1_w * (p_2_w / p_1_w);
                //MessageBox.Show(T_2_w.ToString());
                DataRow T_2_wi = wynik.NewRow();
                T_2_wi[0] = "T_2";
                T_2_wi[1] = T_2_w;
                T_2_wi[2] = "K";
                wynik.Rows.Add(T_2_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "T_2";
                wiersz1[1] = T_2_w;
                wiersz1[2] = "K";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
            if (listBox1.SelectedValue.ToString() == "T_3")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'v_3'").First();
                double v_3_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'v_1'").First();
                double v_1_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'T_1'").First();
                double T_1_w = Convert.ToDouble(w4[1]);

                double T_3_w = T_1_w * (v_3_w / v_1_w);
                DataRow T_3_wi = wynik.NewRow();
                T_3_wi[0] = "T_3";
                T_3_wi[1] = T_3_w;
                T_3_wi[2] = "K";
                wynik.Rows.Add(T_3_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "T_3";
                wiersz1[1] = T_3_w;
                wiersz1[2] = "K";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
            if (listBox1.SelectedValue.ToString() == "Q_d")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'T_3'").First();
                double T_3_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'R'").First();
                double R_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'T_2'").First();
                double T_2_w = Convert.ToDouble(w4[1]);
                DataRow w5 = tabla_dane.Select("Symbol = 'm'").First();
                double m_w = Convert.ToDouble(w5[1]);
                DataRow w6 = tabla_dane.Select("Symbol = 'cp'").First();
                double cp_w = Convert.ToDouble(w6[1]);
                DataRow w7 = tabla_dane.Select("Symbol = 'T_1'").First();
                double T_1_w = Convert.ToDouble(w7[1]);
                //MessageBox.Show(T_1_w.ToString());
                //MessageBox.Show(T_2_w.ToString());
                //MessageBox.Show(T_3_w.ToString());
                //MessageBox.Show(m_w.ToString());
                //MessageBox.Show(cp_w.ToString());
                double cv = R_w - cp_w;
                double pom = m_w * (cp_w - R_w);
                double c = (cv - cp_w) / (m_w - 1);
                //MessageBox.Show((c * (T_3_w - T_2_w)).ToString());
                //MessageBox.Show(cv.ToString());
                //MessageBox.Show(c.ToString());
                //MessageBox.Show((cv * (T_2_w - T_1_w)).ToString());
                //MessageBox.Show((c * (T_3_w - T_2_w)).ToString());
                double d_q_w = -((cv * (T_2_w - T_1_w)) + (c * (T_3_w - T_2_w)));

                DataRow d_q_wi = wynik.NewRow();
                d_q_wi[0] = "q_d";
                d_q_wi[1] = d_q_w;
                d_q_wi[2] = "J/kg";
                wynik.Rows.Add(d_q_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "q_d";
                wiersz1[1] = d_q_w;
                wiersz1[2] = "J/kg";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
            if (listBox1.SelectedValue.ToString() == "Q_w")
            {
                DataRow w2 = tabla_dane.Select("Symbol = 'cp'").First();
                double cp_w = Convert.ToDouble(w2[1]);
                DataRow w3 = tabla_dane.Select("Symbol = 'T_3'").First();
                double T_3_w = Convert.ToDouble(w3[1]);
                DataRow w4 = tabla_dane.Select("Symbol = 'T_1'").First();
                double T_1_w = Convert.ToDouble(w4[1]);

                double q_w_w = -(cp_w * (T_3_w - T_1_w));
                DataRow q_w_wi = wynik.NewRow();
                q_w_wi[0] = "Q_w";
                q_w_wi[1] = q_w_w;
                q_w_wi[2] = "J/kg";
                wynik.Rows.Add(q_w_wi);

                DataRow wiersz1 = tabla_dane.NewRow();
                wiersz1[0] = "Q_w";
                wiersz1[1] = q_w_w;
                wiersz1[2] = "J/kg";
                tabla_dane.Rows.Add(wiersz1);

                dataGridView2.DataSource = wynik;
            }
        }
    }
}
