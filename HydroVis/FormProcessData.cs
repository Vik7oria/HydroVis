using System;
using System.IO;
using System.Windows.Forms;

namespace ReliefVisualisation
{
    public partial class FormProcessData : Form
    {
        StreamReader readerEtaNB = null, readerEtaVB = null, readerQ = null;
        StreamWriter writer;
        public FormProcessData()
        {
            InitializeComponent();
            label_done.Visible = false;
        }

        private void ButtonFileEtaVB_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD1 = new OpenFileDialog();
            OD1.Title = "Выбор файла с данными уровня воды на верхнем бьефе";
            OD1.Filter = "Файлы (*.csv) |*.csv| Все файлы (*.*)|*.*";
            OD1.FileName = "";
            if (OD1.ShowDialog() == DialogResult.OK)
            {
                textBox_fileEtaVB.Text = OD1.FileName;
            }
        }

        private void ButtonFileEtaNB_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD1 = new OpenFileDialog();
            OD1.Title = "Выбор файла с данными уровня воды на нижнем бьефе";
            OD1.Filter = "Файлы (*.csv) |*.csv| Все файлы (*.*)|*.*";
            OD1.FileName = "";
            if (OD1.ShowDialog() == DialogResult.OK)
            {
                textBox_fileEtaNB.Text = OD1.FileName;
            }
        }

        private void ButtonFileQ_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD1 = new OpenFileDialog();
            OD1.Title = "Выбор файла с данными расхода воды";
            OD1.Filter = "Файлы (*.csv) |*.csv| Все файлы (*.*)|*.*";
            OD1.FileName = "";
            if (OD1.ShowDialog() == DialogResult.OK)
            {
                textBox_fileQ.Text = OD1.FileName;
            }
        }

        private void ButtonFileWritePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_fileWrite.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void ButtonProcessData_Click(object sender, EventArgs e)
        {
            if (textBox_fileEtaNB.Text != "")
                readerEtaNB = new StreamReader(textBox_fileEtaNB.Text);
            if (textBox_fileEtaVB.Text != "")
                readerEtaVB = new StreamReader(textBox_fileEtaVB.Text);
            if (textBox_fileQ.Text != "")
                readerQ = new StreamReader(textBox_fileQ.Text);

            ProcessWaterData(readerEtaNB, readerEtaVB, readerQ);
        }

        private void ProcessWaterData(StreamReader sr_EtaNB, StreamReader sr_EtaVB, StreamReader sr_Q)
        {
            String line_EtaVB, line_EtaNB, line_Q;
            string[] column_EtaVB = new string[5];
            string[] column_EtaNB = new string[5];
            string[] column_Q = new string[3];
            string[] date_EtaVB = new string[3];
            string[] date_EtaNB = new string[3];
            string[] date_Q = new string[3];
            string strForWrite, EtaVB, EtaNB, Q, last_year;
            int year = DateTime.Now.Year + 1;
            double i = 1;

            DateTime date = new DateTime(2001, 1, 1);
            DateTime dateStop = new DateTime(2025, 03, 24);
            string current_date;

            if (sr_EtaNB == null)
            {
                line_EtaNB = "#,#,#";
            }
            else
            {
                line_EtaNB = sr_EtaNB.ReadLine();
                line_EtaNB = sr_EtaNB.ReadLine();
                year = Convert.ToInt32(line_EtaNB.Split(',')[1].Split('-')[2]);
            }

            if (sr_EtaVB == null)
            {
                line_EtaVB = "#,#,#";
            }
            else
            {
                line_EtaVB = sr_EtaVB.ReadLine();//первый раз считываем названия столбцов
                line_EtaVB = sr_EtaVB.ReadLine();//далее уже данные
                if (Convert.ToInt32(line_EtaVB.Split(',')[1].Split('-')[2]) < year)
                {
                    year = Convert.ToInt32(line_EtaVB.Split(',')[1].Split('-')[2]);
                }
            }

            if (sr_Q == null)
            {
                line_Q = "#,#,#";
            }
            else
            {
                line_Q = sr_Q.ReadLine();
                line_Q = sr_Q.ReadLine();
                if (Convert.ToInt32(line_Q.Split(',')[0].Split('-')[2]) < year)
                {
                    year = Convert.ToInt32(line_Q.Split(',')[0].Split('-')[2]);
                }
            }
            
            if (year == 0)
            {
                MessageBox.Show("Нет подходящих файлов");
                return;
            }

            date = new DateTime(year, 1, 1);
            current_date = date.ToShortDateString().Replace('.', '-');

            writer = new StreamWriter(textBox_fileWrite.Text + "\\Q_Eta_" + date.Year + ".dat");
            writer.WriteLine("№ " + "Дата " + "Eta(VB) " + "Eta(NB) " + "Q");

            bool stop = false;
            while (!stop)
            {
                if (line_EtaVB != null)
                    column_EtaVB = line_EtaVB.Split(',');
                if (line_EtaNB != null)
                    column_EtaNB = line_EtaNB.Split(',');
                if (line_Q != null)
                    column_Q = line_Q.Split(',');

                if (column_EtaVB[1] != "" && column_EtaVB[1] != "#")
                {
                    EtaVB = column_EtaVB[0].Replace('.', ',');//значение EtaVB
                    date_EtaVB = column_EtaVB[1].Split('-');
                }
                else
                {
                    EtaVB = "#";
                    date_EtaVB = "0-0-0".Split('-');
                    column_EtaVB = "#-#-#".Split('-');
                }

                if (column_EtaNB[1] != "" && column_EtaNB[1] != "#")
                {
                    EtaNB = column_EtaNB[0].Replace('.', ',');//значение EtaNB
                    date_EtaNB = column_EtaNB[1].Split('-');
                }
                else
                {
                    EtaNB = "#";
                    date_EtaNB = "0-0-0".Split('-');
                    column_EtaNB = "#-#-#".Split('-');
                }

                if (column_Q[0] != "" && column_Q[0] != "#")
                {
                    Q = column_Q[1].Replace('.', ',');//значение EtaQ
                    date_Q = column_Q[0].Split('-');
                }
                else
                {
                    Q = "#";
                    date_Q = "0-0-0".Split('-');
                    column_Q = "#-#-#".Split('-');
                }

                if (EtaNB == "")
                    EtaNB = "#";
                if (EtaVB == "")
                    EtaVB = "#";
                if (Q == "")
                    Q = "#";

                strForWrite = Convert.ToString(i) + " " + current_date;
                if (column_EtaVB[1] == current_date)
                {
                    strForWrite += " " + EtaVB;
                    line_EtaVB = sr_EtaVB.ReadLine();
                    if (line_EtaVB == null)
                    {
                        sr_EtaVB = null;
                    }
                }
                else
                {
                    strForWrite += " " + "#";
                }

                if (column_EtaNB[1] == current_date)
                {
                    strForWrite += " " + EtaNB;
                    line_EtaNB = sr_EtaNB.ReadLine();
                    if (line_EtaNB == null)
                    {
                        sr_EtaNB = null;
                    }
                }
                else
                {
                    strForWrite += " " + "#";
                }

                if (column_Q[0] == current_date)
                {
                    strForWrite += " " + Q;
                    line_Q = sr_Q.ReadLine();
                    if (line_Q == null)
                    {
                        sr_Q = null;
                    }
                }
                else
                {
                    strForWrite += " " + "#";
                }

                if (sr_EtaVB == null && sr_EtaNB == null && sr_Q == null)
                {
                    stop = true;
                }

                writer.WriteLine(strForWrite);
                strForWrite = strForWrite.Replace(',', '.'); //c точками для бд

                i++;//индекс данных
                last_year = date.Year.ToString();
                date = date.AddDays(1);
                if (date.Year.ToString() != last_year)
                {
                    writer.Close();
                    i = 1;
                    writer = new StreamWriter(textBox_fileWrite.Text + "\\Q_Eta_" + date.Year.ToString() + ".dat");
                    writer.WriteLine("№ " + "Дата " + "Eta(VB) " + "Eta(NB) " + "Q");
                }
                current_date = date.ToShortDateString().Replace('.', '-');
            }
            
            sr_EtaVB?.Close();
            sr_EtaNB?.Close();
            sr_Q?.Close();

            writer.Close();
            label_done.Text = "Выполнено";
            label_done.Visible = true;
        }
    }
}
