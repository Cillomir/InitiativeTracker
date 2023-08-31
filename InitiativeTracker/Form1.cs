/* **************************************************
 * Initiative Tracker v1
 * Author: Joel Leckie
 * Created: Aug. 2023
 * 
 * A lightweight initiative tracker for tabletop games
 ************************************************** */
using InitiativeTracker.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InitiativeTracker
{
    public partial class Form1 : Form
    {
        public List<Character> characters;
        BindingSource source;
        bool fromRefresh = false;
        public int entryWidth = 320;

        public Form1()
        {
            InitializeComponent();
            characters = new List<Character>();
            source = new BindingSource();
            gridview.AutoGenerateColumns = false;
            gridview.AutoSize = true;
            //gridview.RowHeadersVisible = false;
            gridview.DataSource = source;

            Gridview_LoadGrid();
            gridview.RowLeave += Gridview_UpdateData;
            gridview.CellValueChanged += Gridview_UpdateData;

            optionShowType.Checked = Settings.Default.ShowType;
            optionTrackHealth.Checked = Settings.Default.TrackHealth;
            optionTrackArmor.Checked = Settings.Default.TrackArmor;
            optionTrackAbilities.Checked = Settings.Default.TrackAbilities;
            optionShowDexterity.Checked = Settings.Default.ShowDex;

            UpdateEntryBoxes();
            this.Width = gridview.Width + entryWidth;
        }

        private void Gridview_LoadGrid()
        {
            gridview.Columns.Clear();
            int width = gridview.Width;

            DataGridViewColumn column;
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "ID";
            column.Name = "ID";
            column.ReadOnly = true;
            column.Visible = false;
            gridview.Columns.Add(column);

            gridview.Columns.Add(CreateComboBox());

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Name";
            column.Width = 96;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Health";
            column.Name = "HP";
            column.Width = 36;
            column.Visible = Settings.Default.TrackHealth;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Max";
            column.Name = "Max";
            column.Width = 36;
            column.Visible = Settings.Default.TrackHealth;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Armor";
            column.Name = "AC";
            column.Width = 28;
            column.Visible = Settings.Default.TrackArmor;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Strength";
            column.Name = "Str";
            column.Width = 32;
            column.Visible = Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dexterity";
            column.Name = "Dex";
            column.Width = 32;
            column.Visible = Settings.Default.ShowDex | Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Constitution";
            column.Name = "Con";
            column.Width = 32;
            column.Visible = Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Intelligence";
            column.Name = "Int";
            column.Width = 32;
            column.Visible = Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Wisdom";
            column.Name = "Wis";
            column.Width = 32;
            column.Visible = Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Charisma";
            column.Name = "Cha";
            column.Width = 32;
            column.Visible = Settings.Default.TrackAbilities;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Initiative";
            column.Name = "Initiative";
            column.Width = 56;
            gridview.Columns.Add(column);
        }

        private void Gridview_UpdateData(object sender, DataGridViewCellEventArgs e)
        {
            if (fromRefresh) return;
            DataGridViewRow r = gridview.Rows[e.RowIndex];
            characters.Where(c => c.ID == (int)r.Cells[0].Value).ToList().ForEach(c =>
            {
                int editVal;
                if (r.Cells[1].IsInEditMode)
                    switch (r.Cells[1].EditedFormattedValue.ToString()){
                        case "PC":
                            c.Chartype = charType.PC;
                            break;
                        case "NPC":
                            c.Chartype = charType.NPC;
                            break;
                        case "MOB":
                            c.Chartype = charType.MOB;
                            break;
                        default:
                            lbl_status.Text = "Invalid Character Type";
                            break;
                    }
                if (r.Cells[2].IsInEditMode)
                    c.Name = r.Cells[2].EditedFormattedValue.ToString();
                if (r.Cells[3].IsInEditMode)
                    if (int.TryParse(r.Cells[3].EditedFormattedValue.ToString(), out editVal))
                        c.Armor = editVal;
                    else
                        lbl_status.Text = "Invalid Armor Value";
                if (r.Cells[4].IsInEditMode)
                    if (int.TryParse(r.Cells[4].EditedFormattedValue.ToString(), out editVal))
                        c.Dexterity = editVal;
                    else
                        lbl_status.Text = "Invalid Dexterity Value";
                if (r.Cells[5].IsInEditMode)
                    if (int.TryParse(r.Cells[5].EditedFormattedValue.ToString(), out editVal))
                        c.Initiative = editVal;
                    else
                        lbl_status.Text = "Invalid Initiative Value";
            });
            refresh();
        }

        DataGridViewComboBoxColumn CreateComboBox()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.DataSource = Enum.GetValues(typeof(charType));
            combo.DataPropertyName = "Chartype";
            combo.Name = "Type";
            combo.Width = 64;
            combo.Visible = Settings.Default.ShowType;
            return combo;
        }

        public void UpdateEntryBoxes()
        {
            int health_num_Y = num_health.Location.Y;
            int health_lbl_Y = lbl_health.Location.Y;
            if (Settings.Default.TrackHealth)
            {
                num_health.Enabled = num_health.Visible = lbl_health.Visible = true;
                num_maxHP.Enabled = num_maxHP.Visible = true;
                health_num_Y += 40;
                health_lbl_Y += 40;
            }
            else
            {
                num_health.Enabled = num_health.Visible = lbl_health.Visible = false;
                num_maxHP.Enabled = num_maxHP.Visible = false;
            }
            num_AC.Location = new Point(num_AC.Location.X, health_num_Y);
            lbl_armor.Location = new Point(lbl_armor.Location.X, health_lbl_Y);
            num_init.Location = new Point(num_init.Location.X, health_num_Y + 40);
            lbl_init.Location = new Point(lbl_init.Location.X, health_lbl_Y + 40);
            num_str.Location = new Point(num_str.Location.X, health_num_Y);
            lbl_str.Location = new Point(lbl_str.Location.X, health_lbl_Y);
            num_dex.Location = new Point(num_dex.Location.X, health_num_Y);
            lbl_dex.Location = new Point(lbl_dex.Location.X, health_lbl_Y);
            num_con.Location = new Point(num_con.Location.X, health_num_Y + 40);
            lbl_con.Location = new Point(lbl_con.Location.X, health_lbl_Y + 40);
            num_int.Location = new Point(num_int.Location.X, health_num_Y + 40);
            lbl_int.Location = new Point(lbl_int.Location.X, health_lbl_Y + 40);
            num_wis.Location = new Point(num_wis.Location.X, health_num_Y + 80);
            lbl_wis.Location = new Point(lbl_wis.Location.X, health_lbl_Y + 80);
            num_cha.Location = new Point(num_cha.Location.X, health_num_Y + 80);
            lbl_cha.Location = new Point(lbl_cha.Location.X, health_lbl_Y + 80);

            if (Settings.Default.TrackArmor)
            {
                num_AC.Enabled = num_AC.Visible = lbl_armor.Visible = true;
                num_init.Location = new Point(num_init.Location.X, num_con.Location.Y);
                lbl_init.Location = new Point(lbl_init.Location.X, lbl_con.Location.Y);
            }
            else
            {
                num_AC.Enabled = num_AC.Visible = lbl_armor.Visible = false;
                num_init.Location = new Point(num_init.Location.X, num_str.Location.Y);
                lbl_init.Location = new Point(lbl_init.Location.X, lbl_str.Location.Y);
            }
            if (Settings.Default.TrackAbilities)
            {
                num_str.Enabled = num_str.Visible = lbl_str.Visible = true;
                num_con.Enabled = num_con.Visible = lbl_con.Visible = true;
                num_int.Enabled = num_int.Visible = lbl_int.Visible = true;
                num_wis.Enabled = num_wis.Visible = lbl_wis.Visible = true;
                num_cha.Enabled = num_cha.Visible = lbl_cha.Visible = true;
                //txt_name.Width = 192;
                //entryWidth = 320;
                num_dex.Location = new Point(num_cha.Location.X, num_dex.Location.Y);
                lbl_dex.Location = new Point(lbl_cha.Location.X, lbl_dex.Location.Y);
            }
            else
            {
                num_str.Enabled = num_str.Visible = lbl_str.Visible = false;
                num_con.Enabled = num_con.Visible = lbl_con.Visible = false;
                num_int.Enabled = num_int.Visible = lbl_int.Visible = false;
                num_wis.Enabled = num_wis.Visible = lbl_wis.Visible = false;
                num_cha.Enabled = num_cha.Visible = lbl_cha.Visible = false;
                //txt_name.Width = 130;
                //entryWidth = 258;
                num_dex.Location = new Point(num_wis.Location.X, num_dex.Location.Y);
                lbl_dex.Location = new Point(lbl_wis.Location.X, lbl_dex.Location.Y);
            }

            //btn_PC.BackColor = Settings.Default.PCcolor;
            //btn_MOB.BackColor = Settings.Default.MOBcolor;
            //btn_NPC.BackColor = Settings.Default.NPCcolor;
        }

        private void btn_PC_Click(object sender, EventArgs e)
        {
            add_character(charType.PC);
        }

        private void btn_NPC_Click(object sender, EventArgs e)
        {
            add_character(charType.NPC);
        }

        private void btn_MOB_Click(object sender, EventArgs e)
        {
            add_character(charType.MOB);
        }

        private void add_character(charType chartype)
        {
            // if (Settings.Default.TrackHealth)
            characters.Add(new Character(txt_name.Text, chartype, (int)num_init.Value,
                (int)num_health.Value, (int)num_maxHP.Value, (int)num_AC.Value,
                (int)num_str.Value, (int)num_dex.Value, (int)num_con.Value,
                (int)num_int.Value, (int)num_wis.Value, (int)num_cha.Value));
            refresh();
            txt_name.Focus();
            txt_name.Text = "";
            num_health.Value = 1;
            num_maxHP.Value = 1;
            num_AC.Value = 10;
            num_str.Value = 10;
            num_dex.Value = 10;
            num_con.Value = 10;
            num_int.Value = 10;
            num_wis.Value = 10;
            num_cha.Value = 10;
            num_init.Value = 0;
        }

        private void refresh()
        {
            fromRefresh = true;
            source.DataSource = characters;
            //source.ResetBindings(true);
            //foreach (Character c in characters)
                //source.Add(c);
            gridview.DataSource = source;
            gridview.Columns[0].Visible = false;
            foreach (DataGridViewRow r in gridview.Rows)
            {
                switch (r.Cells[1].Value.ToString())
                {
                    case "PC":
                        r.Cells[2].Style.BackColor = Color.LightSteelBlue;
                        //r.Cells[2].Style.BackColor = Settings.Default.PCcolor;
                        r.Cells[2].Style.Font = new Font(gridview.Font, FontStyle.Bold);
                        break;
                    case "NPC":
                        r.Cells[2].Style.BackColor = Color.YellowGreen;
                        //r.Cells[2].Style.BackColor = Settings.Default.NPCcolor;
                        break;
                    case "MOB":
                        r.Cells[2].Style.BackColor = Color.LightCoral;
                        //r.Cells[2].Style.BackColor = Settings.Default.MOBcolor;
                        break;
                    default:
                        break;
                }
            }
            fromRefresh = false;
            gridview.Width = gridview.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            characters.Sort(Character.SortInitiative);
            refresh();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            characters.ForEach(c => c.Initiative = 0);
            characters.Sort(Character.SortCharacter);
            refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName, false);
                    foreach (Character c in characters)
                    {
                        writer.Write("ID:" + c.ID + " ");
                        writer.Write("Name:" + c.Name + " ");
                        writer.Write("Type:" + c.Chartype + " ");
                        writer.Write("Armor:" + c.Armor + " ");
                        writer.Write("Dex:" + c.Dexterity + " ");
                        writer.Write("Init:" + c.Initiative);
                        writer.WriteLine();
                    }
                    writer.Close();
                }
                catch
                {
                    Console.WriteLine("Unable to write file");
                }
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                characters = new List<Character>();
                AddFromFile(openFileDialog1.FileName);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                AddFromFile(openFileDialog1.FileName);
            }
        }    

        private void AddFromFile(string file)
        {
            try
            {
                StreamReader fn = new StreamReader(file);
                string line = fn.ReadLine();
                while (line != null)
                {
                    string name = "";
                    charType ct = 0;
                    int armor = 10;
                    int dexterity = 10;
                    int initiative = 0;
                    string[] lnArray = line.Split(' ');
                    foreach (string x in lnArray)
                    {
                        try
                        {
                            string field = x.Split(':')[0];
                            string val = x.Split(':')[1];
                            switch (field)
                            {
                                case "Name":
                                    name = val;
                                    break;
                                case "Type":
                                    switch (val)
                                    {
                                        case "0":
                                        case "PC":
                                            ct = charType.PC;
                                            break;
                                        case "1":
                                        case "NPC":
                                            ct = charType.NPC;
                                            break;
                                        case "2":
                                        case "MOB":
                                            ct = charType.MOB;
                                            break;
                                        default:
                                            ct = charType.NPC;
                                            break;
                                    }
                                    break;
                                case "Armor":
                                    if (!int.TryParse(val, out armor))
                                        armor = 10;
                                    break;
                                case "Dex":
                                    if (!int.TryParse(val, out dexterity))
                                        dexterity = 10;
                                    break;
                                case "Init":
                                    if (!int.TryParse(val, out initiative))
                                        initiative = 0;
                                    break;
                                default:
                                    break;
                            }
                        }
                        catch (Exception er)
                        {
                            Console.WriteLine("Unable to parse line");
                            Console.WriteLine(er.Message);
                        }
                    }
                    characters.Add(new Character(name, ct, armor, initiative, dexterity));
                    line = fn.ReadLine();
                }
                refresh();
            }
            catch (Exception er)
            {
                Console.WriteLine("Unable to load file");
                Console.WriteLine(er.Message);
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            characters = new List<Character>();
            refresh();
        }

        private void numeric_Enter(object sender, EventArgs e)
        {
            if (sender is NumericUpDown)
                ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        private void num_AC_Enter(object sender, EventArgs e)
        {
            num_AC.Select(0, num_AC.Text.Length);
        }

        private void num_dex_Enter(object sender, EventArgs e)
        {
            num_dex.Select(0, num_dex.Text.Length);
        }

        private void num_init_Enter(object sender, EventArgs e)
        {
            num_init.Select(0, num_init.Text.Length);
        }

        private void menu_tools_options_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUserOptions(object sender, EventArgs e)
        {
            //Settings.Default.PCcolor
            //Settings.Default.MOBcolor
            //Settings.Default.NPCcolor
            Settings.Default.ShowType = optionShowType.Checked;
            Settings.Default.TrackHealth = optionTrackHealth.Checked;
            Settings.Default.TrackArmor = optionTrackArmor.Checked;
            Settings.Default.TrackAbilities = optionTrackAbilities.Checked;
            Settings.Default.ShowDex = optionShowDexterity.Checked;
            Settings.Default.Save();
            Gridview_LoadGrid();
            refresh();
            UpdateEntryBoxes();
            this.Width = gridview.Width + entryWidth;
        }

        private void optionPC_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Settings.Default.PCcolor = colorDialog1.Color;
                Settings.Default.Save();
                Gridview_LoadGrid();
                refresh();
                UpdateEntryBoxes();
            }
        }
    }
}
