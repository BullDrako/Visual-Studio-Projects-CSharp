using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Llibres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem treb = listView1.SelectedItems[0];
                //tbIsbn.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tb0.Text = treb.SubItems[0].Text;
                tb1.Text = treb.SubItems[1].Text;
                tb2.Text = treb.SubItems[2].Text;
                tb3.Text = treb.SubItems[3].Text;
                tb4.Text = treb.SubItems[4].Text;
                tb5.Text = treb.SubItems[5].Text;
                tb6.Text = treb.SubItems[6].Text;
                dateTimePicker1.Value = Convert.ToDateTime(treb.SubItems[7].Text);
           }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 1;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
               
                if( tb6.Text.Equals(listView1.Items[i].SubItems[6].Text))
                {
                   flag =0;
                    break;
                }
               
            }
            if(flag == 1){
                ListViewItem lVI = listView1.Items.Add(tb0.Text);
                lVI.SubItems.Add(tb1.Text);
                lVI.SubItems.Add(tb2.Text);
                lVI.SubItems.Add(tb3.Text);
                lVI.SubItems.Add(tb4.Text);
                lVI.SubItems.Add(tb5.Text);
                lVI.SubItems.Add(tb6.Text);
                lVI.SubItems.Add(dateTimePicker1.Value.ToString());
            }
            else{
                MessageBox.Show("Aquest treballador ja està ficat dins del fitxer! DNIs idèntics.","Atenció",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("llibres.txt", false))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');
                    ListViewItem lVI = listView1.Items.Add(fields[0]);
                    lVI.SubItems.Add(fields[1]);
                    lVI.SubItems.Add(fields[2]);
                    lVI.SubItems.Add(fields[3]);
                    lVI.SubItems.Add(fields[4]);
                    lVI.SubItems.Add(fields[5]);
                    lVI.SubItems.Add(fields[6]);
                    lVI.SubItems.Add(fields[7]);
                }
            }
            
        }

        private void cerrando(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("llibres.txt", false);
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    for(int j = 0; j<listView1.Items[i].SubItems.Count;j++)
                    {
                        writer.Write(listView1.Items[i].SubItems[j].Text);
                        writer.Write(";");
                    }
                    writer.WriteLine();
                }
                writer.Close();

            }
            catch (IOException ioe)
            {
            }
        }
    }
}
