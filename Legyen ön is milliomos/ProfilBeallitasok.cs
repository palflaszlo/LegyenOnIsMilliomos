using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legyen_ön_is_milliomos
{
    public partial class ProfilBeallitasok : Form
    {
        public string yourName = "";
        public string[] Checkedthemes = new string[20];
        public string difficulty = "A";


        public ProfilBeallitasok()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (difficulty.Equals("") || yourName.Equals("") || checkedListBox1.CheckedItems.Count == 0)
            {
                string message = "Valamit még üresen hagytáll! Páldául a neved, a nehézséget, a témákat, a segítségeket.";
                string caption = "Figyelem!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == DialogResult.OK)
                {
                   
                }
            }
            else
            {
                this.Close();
            }           
        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {
            yourName = profileName.Text;
        }

        private void ProfilBeallitasok_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.playerName))
            {
                yourName = Properties.Settings.Default.playerName;
                profileName.Text = yourName;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.nehezseg))
            {
                difficulty = Properties.Settings.Default.nehezseg;
                if (difficulty == "easy") radioButton1.Checked = true;
                if (difficulty == "normal") radioButton2.Checked = true;
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.checkedItems))
            {
                Properties.Settings.Default.checkedItems.Split(',').ToList().ForEach(item =>
                {
                    var index = this.checkedListBox1.Items.IndexOf(item);
                    this.checkedListBox1.SetItemChecked(index, true);
                });
            }
            if (!string.IsNullOrEmpty(Properties.Settings.Default.helps))
            {
                Properties.Settings.Default.helps.Split(',').ToList().ForEach(item =>
                {
                    var index = this.checkedListBox2.Items.IndexOf(item);
                    this.checkedListBox2.SetItemChecked(index, true);
                });
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                difficulty = "easy";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                difficulty = "normal";
            }
        }

        private void ProfilBeallitasok_FormClosing(object sender, FormClosingEventArgs e)
        {
            string[] valami = checkedListBox1.CheckedItems.Cast<string>().ToArray();
            int i = 0;
            foreach (string item in valami)
            {
                Checkedthemes[i] = item;
                i++;
            }

            try
            {
                if (difficulty.Equals("easy"))
                {
                    using (StreamWriter outputFile = new StreamWriter("temak.txt"))
                    {
                        foreach (string line in Checkedthemes)
                            outputFile.Write(line + ';');
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba! " + ex);
            }

            yourName = profileName.Text;
            Properties.Settings.Default.playerName = yourName;
            var indices = this.checkedListBox2.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.helps = string.Join(",", indices);
            Properties.Settings.Default.nehezseg = difficulty;
            var indices3 = this.checkedListBox1.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.checkedItems = string.Join(",", indices3);
            Properties.Settings.Default.Save();
        }
    }
}
