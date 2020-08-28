using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSHARP_MIT_MYSQL_DATENBANK
{
    public partial class Form1 : Form
    {
        Connect con = new Connect();
        public Form1()
        {
            InitializeComponent();
        }



        public void btneinlesen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }

        public void BindDataCSV(string FilePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(FilePath);
            if (lines.Length > 0)
            {
                //first line to create header
                string firstLine = lines[0];
                string[] headerLabels = firstLine.Split(';');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }

                // for the data

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] dataWords = lines[i].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        dr[headerWord] = dataWords[columnIndex++];
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dgvAngestellte.DataSource = dt;
            }

        }

        public void btnspeichern_Click(object sender, EventArgs e)
        {
            SaveToCSV(dgvAngestellte);

        }

        public void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount];
                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DGV.Columns[i].Name.ToString() + ";";
                }
                output[0] += columnNames;
                for (int i = 1; i < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        output[i] += DGV.Rows[i-1].Cells[j].Value.ToString() + ";";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Your file was generated and its ready for use.");
            }
        }
    }
}



        

       

