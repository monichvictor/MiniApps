using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniApps
{
    public partial class MainForm : Form
    {

        int Count = 0;
        Random Rnd;
        char[] SpChars = new char[] { '$', '#', '~', '`', '%', '*', '(', ')', '&' };
        Dictionary<string, double> Metrica;

        public MainForm()
        {
            InitializeComponent();
            Rnd = new Random();
            labelRndResult.Text = Rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value) + 1).ToString();
            Metrica = new Dictionary<string, double>();
            Metrica.Add("mm", 1);
            Metrica.Add("cm", 10);
            Metrica.Add("dm", 100);
            Metrica.Add("m", 1000);
            Metrica.Add("km", 1000000);
            Metrica.Add("mile", 1609344);
            comboBoxIn.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is test program","About");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            Count++;
            labelCounter.Text = Count.ToString();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            Count--;
            labelCounter.Text = Count.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Count = 0;
            labelCounter.Text = Count.ToString();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            int cnt = 0;    
            int n;
            


            foreach (char c in RndList.Text)
                if (c == '\n')
                    cnt++;

            if (checkBoxDuplicates.Checked)
            {
                labelRndResult.Text = Rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value) + 1).ToString();
                RndList.AppendText(labelRndResult.Text + "\r\n");
            }    

            else
            {
                if (cnt==0)
                {
                    labelRndResult.Text = Rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value) + 1).ToString();
                    RndList.AppendText(labelRndResult.Text + "\r\n");
                }
                else
                {
                    if (cnt <= (numericUpDownTo.Value-numericUpDownFrom.Value))
                    {
                        n = Rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value) + 1);

                        while (RndList.Text.IndexOf(n.ToString() + "\r\n") != -1)
                        {
                            n = Rnd.Next(Convert.ToInt32(numericUpDownFrom.Value), Convert.ToInt32(numericUpDownTo.Value) + 1);
                        }

                        if (RndList.Text.IndexOf(n.ToString() + "\r\n") == -1)
                        {
                            labelRndResult.Text = n.ToString();
                            RndList.AppendText(labelRndResult.Text + "\r\n");
                        }
                    }
                }
              
            }
        }

        private void numericUpDownFrom_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownFrom.Value >= numericUpDownTo.Value)
            {
                numericUpDownTo.Value = numericUpDownFrom.Value + 1;
            }
                
            
        }

        private void numericUpDownTo_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDownFrom.Value >= numericUpDownTo.Value)
            {
                numericUpDownFrom.Value = numericUpDownTo.Value - 1;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            RndList.Clear();
        }

        private void buttonToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(RndList.Text);
        }

        private void InsertDate_Click(object sender, EventArgs e)
        {
            Notepad.AppendText(DateTime.Now.ToShortDateString()+"\r\n");
        }

        private void InsertTime_Click(object sender, EventArgs e)
        {
            Notepad.AppendText(DateTime.Now.ToShortTimeString() + "\r\n");
        }

        private void saveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
           
        }

        private void loadNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Notepad.LoadFile(openFileDialog1.InitialDirectory + openFileDialog1.FileName);
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Notepad.SaveFile(saveFileDialog1.InitialDirectory + saveFileDialog1.FileName);
        }

        private void GeneratePassword_Click(object sender, EventArgs e)
        {
            GeneratedPassword.Text = "";
            int n;

            for(int i = 0; i < PasswordLength.Value; i++)
            {
                n = Rnd.Next(PasswordSettings.CheckedItems.Count);
                string s = PasswordSettings.CheckedItems[n].ToString();
                switch (s)
                {
                    case "Numbers":
                        GeneratedPassword.Text+=Rnd.Next(10).ToString();
                        break;
                    case "Upper case":
                        GeneratedPassword.Text += Convert.ToChar(Rnd.Next(65, 88));
                        break;
                    case "Lower case":
                        GeneratedPassword.Text += Convert.ToChar(Rnd.Next(97, 122));
                        break;
                    case "Special Symbols($, #, ~, `, %, *, (, ), &)":
                        GeneratedPassword.Text += SpChars[Rnd.Next(SpChars.Length)];
                        break;

                    default:
                        break;
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PasswordSettings.SetItemChecked(0, true);
            GeneratedPassword.Text = "";
        }

        private void PasswordSettings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (numericUpDownValueIn.Text == "")
                MessageBox.Show("Enter value to convert", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                double m1 = Metrica[comboBoxIn.Text];
                double m2 = Metrica[comboBoxOut.Text];
                double n = Convert.ToDouble(numericUpDownValueIn.Text);
                ValueOut.Text = (n * m1 / m2).ToString();
            }
        }

        private void ButtonSwap_Click(object sender, EventArgs e)
        {
            string sw = comboBoxIn.Text;
            comboBoxIn.Text = comboBoxOut.Text;
            comboBoxOut.Text = sw;
        }

        private void comboBoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypes.SelectedItem.ToString())
            {

                case "Length":

                    Metrica.Clear();
                    Metrica.Add("mm", 1);
                    Metrica.Add("cm", 10);
                    Metrica.Add("dm", 100);
                    Metrica.Add("m", 1000);
                    Metrica.Add("km", 1000000);
                    Metrica.Add("mile", 1609344);

                    comboBoxIn.Items.Clear();
                    comboBoxIn.Items.Add("mm");
                    comboBoxIn.Items.Add("cm");
                    comboBoxIn.Items.Add("dm");
                    comboBoxIn.Items.Add("m");
                    comboBoxIn.Items.Add("km");
                    comboBoxIn.Items.Add("mile");

                    comboBoxOut.Items.Clear();
                    comboBoxOut.Items.Add("mm");
                    comboBoxOut.Items.Add("cm");
                    comboBoxOut.Items.Add("dm");
                    comboBoxOut.Items.Add("m");
                    comboBoxOut.Items.Add("km");
                    comboBoxOut.Items.Add("mile");

                    comboBoxIn.Text = "mm";
                    comboBoxOut.Text = "m";
                    break;
                case "Weight":

                    Metrica.Clear();
                    Metrica.Add("g", 1);
                    Metrica.Add("kg", 1000);
                    Metrica.Add("lb", 453.6);
                    Metrica.Add("oz", 283);

                    comboBoxIn.Items.Clear();
                    comboBoxIn.Items.Add("g");
                    comboBoxIn.Items.Add("kg");
                    comboBoxIn.Items.Add("lb");
                    comboBoxIn.Items.Add("oz");

                    comboBoxOut.Items.Clear();
                    comboBoxOut.Items.Add("g");
                    comboBoxOut.Items.Add("kg");
                    comboBoxOut.Items.Add("lb");
                    comboBoxOut.Items.Add("oz");

                    comboBoxIn.Text = "g";
                    comboBoxOut.Text = "kg";
                    break;
            }

        }
    }
}
