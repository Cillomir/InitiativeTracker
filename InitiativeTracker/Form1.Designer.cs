namespace InitiativeTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_PC = new System.Windows.Forms.Button();
            this.btn_NPC = new System.Windows.Forms.Button();
            this.btn_MOB = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.num_AC = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.btn_sort = new System.Windows.Forms.Button();
            this.num_init = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.num_dex = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clr = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_add = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionTrackHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.optionTrackArmor = new System.Windows.Forms.ToolStripMenuItem();
            this.optionTrackAbilities = new System.Windows.Forms.ToolStripMenuItem();
            this.optionShowDexterity = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.optionPC = new System.Windows.Forms.ToolStripMenuItem();
            this.optionMOB = new System.Windows.Forms.ToolStripMenuItem();
            this.optionNPC = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.optionShowType = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.num_AC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_init)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dex)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(337, 293);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(199, 32);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear Initiative";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(440, 221);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 28);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "Next Turn";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(338, 221);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(96, 28);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "Prev. Turn";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_PC
            // 
            this.btn_PC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PC.Location = new System.Drawing.Point(456, 36);
            this.btn_PC.Name = "btn_PC";
            this.btn_PC.Size = new System.Drawing.Size(80, 32);
            this.btn_PC.TabIndex = 4;
            this.btn_PC.Text = "Add PC";
            this.btn_PC.UseVisualStyleBackColor = false;
            this.btn_PC.Click += new System.EventHandler(this.btn_PC_Click);
            // 
            // btn_NPC
            // 
            this.btn_NPC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NPC.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_NPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NPC.Location = new System.Drawing.Point(456, 112);
            this.btn_NPC.Name = "btn_NPC";
            this.btn_NPC.Size = new System.Drawing.Size(80, 32);
            this.btn_NPC.TabIndex = 6;
            this.btn_NPC.Text = "Add NPC";
            this.btn_NPC.UseVisualStyleBackColor = false;
            this.btn_NPC.Click += new System.EventHandler(this.btn_NPC_Click);
            // 
            // btn_MOB
            // 
            this.btn_MOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_MOB.BackColor = System.Drawing.Color.LightCoral;
            this.btn_MOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MOB.Location = new System.Drawing.Point(456, 74);
            this.btn_MOB.Name = "btn_MOB";
            this.btn_MOB.Size = new System.Drawing.Size(80, 32);
            this.btn_MOB.TabIndex = 5;
            this.btn_MOB.Text = "Add MOB";
            this.btn_MOB.UseVisualStyleBackColor = false;
            this.btn_MOB.Click += new System.EventHandler(this.btn_MOB_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(338, 36);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(108, 20);
            this.txt_name.TabIndex = 0;
            // 
            // num_AC
            // 
            this.num_AC.Location = new System.Drawing.Point(338, 80);
            this.num_AC.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_AC.Name = "num_AC";
            this.num_AC.Size = new System.Drawing.Size(60, 20);
            this.num_AC.TabIndex = 1;
            this.num_AC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_AC.Click += new System.EventHandler(this.num_AC_Enter);
            this.num_AC.Enter += new System.EventHandler(this.num_AC_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Armor Class";
            // 
            // gridview
            // 
            this.gridview.AllowUserToAddRows = false;
            this.gridview.AllowUserToDeleteRows = false;
            this.gridview.AllowUserToResizeColumns = false;
            this.gridview.AllowUserToResizeRows = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(12, 36);
            this.gridview.MultiSelect = false;
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersVisible = false;
            this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gridview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridview.ShowEditingIcon = false;
            this.gridview.Size = new System.Drawing.Size(320, 288);
            this.gridview.TabIndex = 11;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(337, 255);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(199, 32);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort by Initiative";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // num_init
            // 
            this.num_init.Location = new System.Drawing.Point(338, 168);
            this.num_init.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_init.Name = "num_init";
            this.num_init.Size = new System.Drawing.Size(60, 20);
            this.num_init.TabIndex = 3;
            this.num_init.Click += new System.EventHandler(this.num_init_Enter);
            this.num_init.Enter += new System.EventHandler(this.num_init_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Initiative";
            // 
            // num_dex
            // 
            this.num_dex.Location = new System.Drawing.Point(338, 124);
            this.num_dex.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_dex.Name = "num_dex";
            this.num_dex.Size = new System.Drawing.Size(60, 20);
            this.num_dex.TabIndex = 2;
            this.num_dex.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_dex.Click += new System.EventHandler(this.num_dex_Enter);
            this.num_dex.Enter += new System.EventHandler(this.num_dex_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dexterity";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 330);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(93, 330);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 17;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(174, 330);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(255, 330);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 19;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_status.Location = new System.Drawing.Point(337, 330);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(200, 23);
            this.lbl_status.TabIndex = 20;
            this.lbl_status.Text = "Awaiting entry...";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_status.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_new,
            this.menu_file_open,
            this.menu_file_add,
            this.toolStripSeparator,
            this.menu_file_save,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menu_file_new
            // 
            this.menu_file_new.Image = ((System.Drawing.Image)(resources.GetObject("menu_file_new.Image")));
            this.menu_file_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_file_new.Name = "menu_file_new";
            this.menu_file_new.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menu_file_new.Size = new System.Drawing.Size(180, 22);
            this.menu_file_new.Text = "&New";
            this.menu_file_new.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // menu_file_open
            // 
            this.menu_file_open.Image = ((System.Drawing.Image)(resources.GetObject("menu_file_open.Image")));
            this.menu_file_open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_file_open.Name = "menu_file_open";
            this.menu_file_open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menu_file_open.Size = new System.Drawing.Size(180, 22);
            this.menu_file_open.Text = "&Open";
            this.menu_file_open.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // menu_file_add
            // 
            this.menu_file_add.Name = "menu_file_add";
            this.menu_file_add.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menu_file_add.Size = new System.Drawing.Size(180, 22);
            this.menu_file_add.Text = "&Add";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // menu_file_save
            // 
            this.menu_file_save.Image = ((System.Drawing.Image)(resources.GetObject("menu_file_save.Image")));
            this.menu_file_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu_file_save.Name = "menu_file_save";
            this.menu_file_save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menu_file_save.Size = new System.Drawing.Size(180, 22);
            this.menu_file_save.Text = "&Save";
            this.menu_file_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionShowType,
            this.optionTrackHealth,
            this.optionTrackArmor,
            this.optionTrackAbilities,
            this.optionShowDexterity,
            this.toolStripSeparator6,
            this.optionPC,
            this.optionMOB,
            this.optionNPC});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // optionTrackHealth
            // 
            this.optionTrackHealth.CheckOnClick = true;
            this.optionTrackHealth.Name = "optionTrackHealth";
            this.optionTrackHealth.Size = new System.Drawing.Size(185, 22);
            this.optionTrackHealth.Text = "Track Health";
            this.optionTrackHealth.CheckedChanged += new System.EventHandler(this.UpdateUserOptions);
            // 
            // optionTrackArmor
            // 
            this.optionTrackArmor.CheckOnClick = true;
            this.optionTrackArmor.Name = "optionTrackArmor";
            this.optionTrackArmor.Size = new System.Drawing.Size(185, 22);
            this.optionTrackArmor.Text = "Track Armor Class";
            this.optionTrackArmor.CheckedChanged += new System.EventHandler(this.UpdateUserOptions);
            // 
            // optionTrackAbilities
            // 
            this.optionTrackAbilities.CheckOnClick = true;
            this.optionTrackAbilities.Name = "optionTrackAbilities";
            this.optionTrackAbilities.Size = new System.Drawing.Size(185, 22);
            this.optionTrackAbilities.Text = "Track Ability Scores";
            this.optionTrackAbilities.CheckedChanged += new System.EventHandler(this.UpdateUserOptions);
            // 
            // optionShowDexterity
            // 
            this.optionShowDexterity.Checked = true;
            this.optionShowDexterity.CheckOnClick = true;
            this.optionShowDexterity.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionShowDexterity.Name = "optionShowDexterity";
            this.optionShowDexterity.Size = new System.Drawing.Size(185, 22);
            this.optionShowDexterity.Text = "Show Dexterity Score";
            this.optionShowDexterity.CheckedChanged += new System.EventHandler(this.UpdateUserOptions);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(182, 6);
            // 
            // optionPC
            // 
            this.optionPC.Enabled = false;
            this.optionPC.Name = "optionPC";
            this.optionPC.Size = new System.Drawing.Size(185, 22);
            this.optionPC.Text = "PC Color";
            // 
            // optionMOB
            // 
            this.optionMOB.Enabled = false;
            this.optionMOB.Name = "optionMOB";
            this.optionMOB.Size = new System.Drawing.Size(185, 22);
            this.optionMOB.Text = "MOB Color";
            // 
            // optionNPC
            // 
            this.optionNPC.Enabled = false;
            this.optionNPC.Name = "optionNPC";
            this.optionNPC.Size = new System.Drawing.Size(185, 22);
            this.optionNPC.Text = "NPC Color";
            // 
            // optionShowType
            // 
            this.optionShowType.Checked = true;
            this.optionShowType.CheckOnClick = true;
            this.optionShowType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.optionShowType.Name = "optionShowType";
            this.optionShowType.Size = new System.Drawing.Size(185, 22);
            this.optionShowType.Text = "Show Character Type";
            this.optionShowType.Click += new System.EventHandler(this.UpdateUserOptions);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 358);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_clr);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_dex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_init);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_AC);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_MOB);
            this.Controls.Add(this.btn_NPC);
            this.Controls.Add(this.btn_PC);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Initiative Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.num_AC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_init)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dex)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_PC;
        private System.Windows.Forms.Button btn_NPC;
        private System.Windows.Forms.Button btn_MOB;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.NumericUpDown num_AC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.NumericUpDown num_init;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_dex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clr;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_file_new;
        private System.Windows.Forms.ToolStripMenuItem menu_file_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menu_file_save;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_file_add;
        private System.Windows.Forms.ToolStripMenuItem optionTrackHealth;
        private System.Windows.Forms.ToolStripMenuItem optionTrackArmor;
        private System.Windows.Forms.ToolStripMenuItem optionTrackAbilities;
        private System.Windows.Forms.ToolStripMenuItem optionShowDexterity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem optionPC;
        private System.Windows.Forms.ToolStripMenuItem optionMOB;
        private System.Windows.Forms.ToolStripMenuItem optionNPC;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem optionShowType;
    }
}

