namespace MultiROM_Linker
{
    partial class MultiROM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiROM));
            this.dgv_files = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filesize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_banksize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_romsize = new System.Windows.Forms.ComboBox();
            this.bt_addROM = new System.Windows.Forms.Button();
            this.bt_uplist = new System.Windows.Forms.Button();
            this.bt_downlist = new System.Windows.Forms.Button();
            this.bt_make = new System.Windows.Forms.Button();
            this.tb_debug = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_resetIndex = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_files
            // 
            this.dgv_files.AllowUserToAddRows = false;
            this.dgv_files.AllowUserToOrderColumns = true;
            this.dgv_files.AllowUserToResizeColumns = false;
            this.dgv_files.AllowUserToResizeRows = false;
            this.dgv_files.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_files.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.filename,
            this.filesize,
            this.fullname});
            this.dgv_files.Location = new System.Drawing.Point(163, 12);
            this.dgv_files.Name = "dgv_files";
            this.dgv_files.RowHeadersVisible = false;
            this.dgv_files.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_files.Size = new System.Drawing.Size(657, 342);
            this.dgv_files.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // filename
            // 
            this.filename.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.filename.HeaderText = "Image Name";
            this.filename.Name = "filename";
            // 
            // filesize
            // 
            this.filesize.HeaderText = "Size";
            this.filesize.Name = "filesize";
            // 
            // fullname
            // 
            this.fullname.HeaderText = "fullname";
            this.fullname.Name = "fullname";
            this.fullname.Visible = false;
            // 
            // cb_banksize
            // 
            this.cb_banksize.FormattingEnabled = true;
            this.cb_banksize.Location = new System.Drawing.Point(13, 41);
            this.cb_banksize.Name = "cb_banksize";
            this.cb_banksize.Size = new System.Drawing.Size(121, 21);
            this.cb_banksize.TabIndex = 1;
            this.cb_banksize.SelectedValueChanged += new System.EventHandler(this.cb_banksize_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Bank Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select EPROM";
            // 
            // cb_romsize
            // 
            this.cb_romsize.FormattingEnabled = true;
            this.cb_romsize.Location = new System.Drawing.Point(13, 101);
            this.cb_romsize.Name = "cb_romsize";
            this.cb_romsize.Size = new System.Drawing.Size(121, 21);
            this.cb_romsize.TabIndex = 3;
            // 
            // bt_addROM
            // 
            this.bt_addROM.Location = new System.Drawing.Point(13, 146);
            this.bt_addROM.Name = "bt_addROM";
            this.bt_addROM.Size = new System.Drawing.Size(121, 29);
            this.bt_addROM.TabIndex = 5;
            this.bt_addROM.Text = "Add ROMs";
            this.bt_addROM.UseVisualStyleBackColor = true;
            this.bt_addROM.Click += new System.EventHandler(this.bt_addROM_Click);
            // 
            // bt_uplist
            // 
            this.bt_uplist.Location = new System.Drawing.Point(12, 181);
            this.bt_uplist.Name = "bt_uplist";
            this.bt_uplist.Size = new System.Drawing.Size(121, 29);
            this.bt_uplist.TabIndex = 6;
            this.bt_uplist.Text = "Up";
            this.bt_uplist.UseVisualStyleBackColor = true;
            this.bt_uplist.Click += new System.EventHandler(this.bt_uplist_Click);
            // 
            // bt_downlist
            // 
            this.bt_downlist.Location = new System.Drawing.Point(13, 216);
            this.bt_downlist.Name = "bt_downlist";
            this.bt_downlist.Size = new System.Drawing.Size(121, 29);
            this.bt_downlist.TabIndex = 7;
            this.bt_downlist.Text = "Down";
            this.bt_downlist.UseVisualStyleBackColor = true;
            this.bt_downlist.Click += new System.EventHandler(this.bt_downlist_Click);
            // 
            // bt_make
            // 
            this.bt_make.Location = new System.Drawing.Point(13, 325);
            this.bt_make.Name = "bt_make";
            this.bt_make.Size = new System.Drawing.Size(121, 29);
            this.bt_make.TabIndex = 9;
            this.bt_make.Text = "Make ROM";
            this.bt_make.UseVisualStyleBackColor = true;
            this.bt_make.Click += new System.EventHandler(this.bt_make_Click);
            // 
            // tb_debug
            // 
            this.tb_debug.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_debug.Location = new System.Drawing.Point(12, 379);
            this.tb_debug.Multiline = true;
            this.tb_debug.Name = "tb_debug";
            this.tb_debug.Size = new System.Drawing.Size(808, 161);
            this.tb_debug.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Press DEL for delete";
            // 
            // bt_resetIndex
            // 
            this.bt_resetIndex.Location = new System.Drawing.Point(12, 290);
            this.bt_resetIndex.Name = "bt_resetIndex";
            this.bt_resetIndex.Size = new System.Drawing.Size(121, 29);
            this.bt_resetIndex.TabIndex = 12;
            this.bt_resetIndex.Text = "Reset Index";
            this.bt_resetIndex.UseVisualStyleBackColor = true;
            this.bt_resetIndex.Click += new System.EventHandler(this.bt_resetIndex_Click);
            // 
            // MultiROM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 552);
            this.Controls.Add(this.bt_resetIndex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_debug);
            this.Controls.Add(this.bt_make);
            this.Controls.Add(this.bt_downlist);
            this.Controls.Add(this.bt_uplist);
            this.Controls.Add(this.bt_addROM);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_romsize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_banksize);
            this.Controls.Add(this.dgv_files);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiROM";
            this.Text = "MultiROM Linker v.1.1 by SnC Museum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_files)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_files;
        private System.Windows.Forms.ComboBox cb_banksize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_romsize;
        private System.Windows.Forms.Button bt_addROM;
        private System.Windows.Forms.Button bt_uplist;
        private System.Windows.Forms.Button bt_downlist;
        private System.Windows.Forms.Button bt_make;
        private System.Windows.Forms.TextBox tb_debug;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn filename;
        private System.Windows.Forms.DataGridViewTextBoxColumn filesize;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_resetIndex;
    }
}

