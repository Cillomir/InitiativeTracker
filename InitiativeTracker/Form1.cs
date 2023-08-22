/* **************************************************
 * Initiative Tracker v1
 * Author: Joel Leckie
 * Created: Aug. 2023
 * 
 * A lightweight initiative tracker for tabletop games
 ************************************************** */
using System;
using System.Collections.Generic;
using System.Data;
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

        public Form1()
        {
            InitializeComponent();
            characters = new List<Character>();
            source = new BindingSource();
            gridview.AutoGenerateColumns = false;
            gridview.AutoSize = false;
            gridview.DataSource = source;

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
            column.DataPropertyName = "Armor";
            column.Name = "AC";
            column.Width = 28;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Dexterity";
            column.Name = "Dex";
            column.Width = 32;
            gridview.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Initiative";
            column.Name = "Initiative";
            column.Width = 56;
            gridview.Columns.Add(column);

            gridview.RowLeave += Gridview_UpdateData;
            gridview.CellValueChanged += Gridview_UpdateData;
        }

        private void Gridview_UpdateData(object sender, DataGridViewCellEventArgs e)
        {
            if (fromRefresh) return;
            DataGridViewRow r = gridview.Rows[e.RowIndex];
            characters.Where(c => c.ID == (int)r.Cells[0].Value).ToList().ForEach(c =>
            {
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
                    }
                if (r.Cells[2].IsInEditMode)
                    c.Name = r.Cells[2].EditedFormattedValue.ToString();
                if (r.Cells[3].IsInEditMode)
                    c.Armor = int.Parse(r.Cells[3].EditedFormattedValue.ToString());
                if (r.Cells[4].IsInEditMode)
                    c.Dexterity = int.Parse(r.Cells[4].EditedFormattedValue.ToString());
                if (r.Cells[5].IsInEditMode)
                    c.Initiative = int.Parse(r.Cells[5].EditedFormattedValue.ToString());
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
            return combo;
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
            characters.Add(new Character(txt_name.Text, chartype,
                (int)num_AC.Value, (int)num_init.Value, (int)num_dex.Value));
            refresh();
            txt_name.Focus();
            txt_name.Text = "";
            num_AC.Value = 10;
            num_dex.Value = 10;
            num_init.Value = 0;
        }

        private void refresh()
        {
            fromRefresh = true;
            source.DataSource = characters;
            source.ResetBindings(true);
            //foreach (Character c in characters)
                //source.Add(c);
            //gridview.DataSource = source;
            foreach (DataGridViewRow r in gridview.Rows)
            {
                switch (r.Cells[1].Value.ToString())
                {
                    case "PC":
                        r.Cells[2].Style.BackColor = Color.LightSteelBlue;
                        r.Cells[2].Style.Font = new Font(gridview.Font, FontStyle.Bold);
                        break;
                    case "NPC":
                        r.Cells[2].Style.BackColor = Color.YellowGreen;
                        break;
                    case "MOB":
                        r.Cells[2].Style.BackColor = Color.LightCoral;
                        break;
                    default:
                        break;
                }
            }
            fromRefresh = false;
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
    }
}
