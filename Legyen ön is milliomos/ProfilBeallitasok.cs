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
        public string[] helps = new string[3];
        public string[] Checkedthemes = new string[20];
        public string[] themes = new string[20];
        public string[] UnCheckedthemes = new string[20];
        public string[] temakor = new string[20];
        public string difficulty = "A";
        public int levelsWon = 0;


        public ProfilBeallitasok()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {
            yourName = profileName.Text;
        }

        private void ProfilBeallitasok_Load(object sender, EventArgs e)
        {
            //yourName = Properties.Settings.Default.playerName;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.playerName))
            {
                yourName = Properties.Settings.Default.playerName;
                profileName.Text = yourName;
            }
            //difficulty = Properties.Settings.Default.nehezseg;
            if (!string.IsNullOrEmpty(Properties.Settings.Default.nehezseg))
            {
                difficulty = Properties.Settings.Default.nehezseg;
                if (difficulty == "easy") radioButton1.Checked = true;
                if (difficulty == "normal") radioButton2.Checked = true;
                if (difficulty == "hard") radioButton3.Checked = true;
            }
            //levelsWon = Properties.Settings.Default.levels;
            if (Properties.Settings.Default.levels != 0)
            {
                levelsWon = Properties.Settings.Default.levels;
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                difficulty = "hard";
            }
        }

        private void ProfilBeallitasok_FormClosing(object sender, FormClosingEventArgs e)
        {
            int i = 0;
            var indices2 = this.checkedListBox2.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.helps = string.Join(",", indices2);
            foreach (var item in indices2)
            {
                helps[i] = item;
                i++;
            }

            var valami = checkedListBox1.CheckedItems.Cast<string>().ToArray();
            i = 0;
            foreach (var item in valami)
            {
                temakor[i] = item;
            }
            i = 0;
            foreach (string item in temakor)
            {
                Checkedthemes[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in checkedListBox1.Items)
            {
                themes[i] = item;
                i++;
            }
            i = 0;
            foreach (string item in checkedListBox1.Items)
            {
                if (!Checkedthemes.Contains<string>(item))
                {
                    UnCheckedthemes[i] = item;
                    i++;
                }
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
                if (difficulty.Equals("normal"))
                {
                    using (StreamWriter outputFile = new StreamWriter("temak.txt"))
                    {
                        foreach (string line in themes)
                            outputFile.Write(line + ';');
                    }
                }
                if (difficulty.Equals("hard"))
                {
                    using (StreamWriter outputFile = new StreamWriter("temak.txt"))
                    {
                        foreach (string line in UnCheckedthemes)
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
            //var indices = this.profileName.Text;
            //Properties.Settings.Default.playerName = indices;
            Properties.Settings.Default.nehezseg = difficulty;
            //var indices2 = this.radioButton1.Checked.ToString();
            //Properties.Settings.Default.nehezseg = indices2;
            Properties.Settings.Default.levels = levelsWon;
            //var indices3 = this.levelsWon;
            //Properties.Settings.Default.levels = indices3;
            var indices3 = this.checkedListBox1.CheckedItems.Cast<string>().ToArray();
            Properties.Settings.Default.checkedItems = string.Join(",", indices3);
            Properties.Settings.Default.Save();
        }
    }
}
