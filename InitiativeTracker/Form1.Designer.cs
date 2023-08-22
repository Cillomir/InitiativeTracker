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
            ((System.ComponentModel.ISupportInitialize)(this.num_AC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_init)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dex)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(337, 269);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(199, 32);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear Initiative";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(440, 197);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(96, 28);
            this.btn_next.TabIndex = 8;
            this.btn_next.Text = "Next Turn";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(338, 197);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(96, 28);
            this.btn_prev.TabIndex = 7;
            this.btn_prev.Text = "Prev. Turn";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_PC
            // 
            this.btn_PC.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_PC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PC.Location = new System.Drawing.Point(456, 12);
            this.btn_PC.Name = "btn_PC";
            this.btn_PC.Size = new System.Drawing.Size(80, 32);
            this.btn_PC.TabIndex = 4;
            this.btn_PC.Text = "Add PC";
            this.btn_PC.UseVisualStyleBackColor = false;
            this.btn_PC.Click += new System.EventHandler(this.btn_PC_Click);
            // 
            // btn_NPC
            // 
            this.btn_NPC.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_NPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NPC.Location = new System.Drawing.Point(456, 88);
            this.btn_NPC.Name = "btn_NPC";
            this.btn_NPC.Size = new System.Drawing.Size(80, 32);
            this.btn_NPC.TabIndex = 6;
            this.btn_NPC.Text = "Add NPC";
            this.btn_NPC.UseVisualStyleBackColor = false;
            this.btn_NPC.Click += new System.EventHandler(this.btn_NPC_Click);
            // 
            // btn_MOB
            // 
            this.btn_MOB.BackColor = System.Drawing.Color.LightCoral;
            this.btn_MOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MOB.Location = new System.Drawing.Point(456, 50);
            this.btn_MOB.Name = "btn_MOB";
            this.btn_MOB.Size = new System.Drawing.Size(80, 32);
            this.btn_MOB.TabIndex = 5;
            this.btn_MOB.Text = "Add MOB";
            this.btn_MOB.UseVisualStyleBackColor = false;
            this.btn_MOB.Click += new System.EventHandler(this.btn_MOB_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(338, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(108, 20);
            this.txt_name.TabIndex = 0;
            // 
            // num_AC
            // 
            this.num_AC.Location = new System.Drawing.Point(338, 56);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Armor Class";
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(12, 12);
            this.gridview.Name = "gridview";
            this.gridview.Size = new System.Drawing.Size(320, 288);
            this.gridview.TabIndex = 11;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(337, 231);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(199, 32);
            this.btn_sort.TabIndex = 9;
            this.btn_sort.Text = "Sort by Initiative";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // num_init
            // 
            this.num_init.Location = new System.Drawing.Point(338, 144);
            this.num_init.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_init.Name = "num_init";
            this.num_init.Size = new System.Drawing.Size(60, 20);
            this.num_init.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Initiative";
            // 
            // num_dex
            // 
            this.num_dex.Location = new System.Drawing.Point(338, 100);
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Dexterity";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 306);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 16;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(93, 306);
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
            this.btn_add.Location = new System.Drawing.Point(174, 306);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clr
            // 
            this.btn_clr.Location = new System.Drawing.Point(255, 306);
            this.btn_clr.Name = "btn_clr";
            this.btn_clr.Size = new System.Drawing.Size(75, 23);
            this.btn_clr.TabIndex = 19;
            this.btn_clr.Text = "Clear";
            this.btn_clr.UseVisualStyleBackColor = true;
            this.btn_clr.Click += new System.EventHandler(this.btn_clr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 346);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Initiative Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.num_AC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_init)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dex)).EndInit();
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
    }
}

