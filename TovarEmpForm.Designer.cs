namespace Mebelny
{
    partial class TovarEmpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TovarEmpForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_postav = new System.Windows.Forms.Label();
            this.label_cena = new System.Windows.Forms.Label();
            this.label_col = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_izm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_postav = new System.Windows.Forms.TextBox();
            this.textBox_cena = new System.Windows.Forms.TextBox();
            this.textBox_col = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_reload = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_toAut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 283);
            this.dataGridView1.TabIndex = 20;
            // 
            // label_postav
            // 
            this.label_postav.AutoSize = true;
            this.label_postav.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_postav.Location = new System.Drawing.Point(461, 765);
            this.label_postav.Name = "label_postav";
            this.label_postav.Size = new System.Drawing.Size(146, 33);
            this.label_postav.TabIndex = 36;
            this.label_postav.Text = "Поставищик";
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cena.Location = new System.Drawing.Point(478, 708);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(129, 33);
            this.label_cena.TabIndex = 35;
            this.label_cena.Text = "Стоимость";
            // 
            // label_col
            // 
            this.label_col.AutoSize = true;
            this.label_col.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_col.Location = new System.Drawing.Point(469, 657);
            this.label_col.Name = "label_col";
            this.label_col.Size = new System.Drawing.Size(138, 33);
            this.label_col.TabIndex = 34;
            this.label_col.Text = "Количество";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(437, 605);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(170, 33);
            this.label_name.TabIndex = 33;
            this.label_name.Text = "Наименование";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(494, 555);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(113, 33);
            this.label_id.TabIndex = 32;
            this.label_id.Text = "id товара";
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(1009, 702);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(235, 39);
            this.button_save.TabIndex = 31;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_izm
            // 
            this.button_izm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_izm.FlatAppearance.BorderSize = 0;
            this.button_izm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_izm.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_izm.Location = new System.Drawing.Point(1009, 612);
            this.button_izm.Name = "button_izm";
            this.button_izm.Size = new System.Drawing.Size(235, 39);
            this.button_izm.TabIndex = 30;
            this.button_izm.Text = "Изменить данные";
            this.button_izm.UseVisualStyleBackColor = true;
            this.button_izm.Click += new System.EventHandler(this.button_izm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1004, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 33);
            this.label2.TabIndex = 27;
            this.label2.Text = "Управление товарами:";
            // 
            // textBox_postav
            // 
            this.textBox_postav.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_postav.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_postav.Location = new System.Drawing.Point(613, 773);
            this.textBox_postav.Multiline = true;
            this.textBox_postav.Name = "textBox_postav";
            this.textBox_postav.Size = new System.Drawing.Size(258, 25);
            this.textBox_postav.TabIndex = 26;
            // 
            // textBox_cena
            // 
            this.textBox_cena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_cena.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cena.Location = new System.Drawing.Point(613, 716);
            this.textBox_cena.Multiline = true;
            this.textBox_cena.Name = "textBox_cena";
            this.textBox_cena.Size = new System.Drawing.Size(258, 25);
            this.textBox_cena.TabIndex = 25;
            // 
            // textBox_col
            // 
            this.textBox_col.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_col.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_col.Location = new System.Drawing.Point(613, 665);
            this.textBox_col.Multiline = true;
            this.textBox_col.Name = "textBox_col";
            this.textBox_col.Size = new System.Drawing.Size(258, 25);
            this.textBox_col.TabIndex = 24;
            // 
            // textBox_name
            // 
            this.textBox_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_name.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.Location = new System.Drawing.Point(613, 612);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(258, 26);
            this.textBox_name.TabIndex = 23;
            // 
            // textBox_id
            // 
            this.textBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_id.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id.Location = new System.Drawing.Point(613, 563);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(258, 25);
            this.textBox_id.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(561, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Запись:";
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reload.FlatAppearance.BorderSize = 0;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reload.Location = new System.Drawing.Point(1479, 250);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(240, 40);
            this.button_reload.TabIndex = 39;
            this.button_reload.Text = "Показать все данные";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(1773, 200);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(35, 35);
            this.button_search.TabIndex = 38;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_Search.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(1407, 201);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(360, 34);
            this.textBox_Search.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 40;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_hide
            // 
            this.button_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hide.BackgroundImage")));
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Location = new System.Drawing.Point(1815, 12);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(35, 35);
            this.button_hide.TabIndex = 99;
            this.button_hide.UseVisualStyleBackColor = true;
            this.button_hide.Click += new System.EventHandler(this.button_hide_Click);
            // 
            // button_close
            // 
            this.button_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close.BackgroundImage")));
            this.button_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_close.FlatAppearance.BorderSize = 0;
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Location = new System.Drawing.Point(1856, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(35, 35);
            this.button_close.TabIndex = 98;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_toAut
            // 
            this.button_toAut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_toAut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_toAut.BackgroundImage")));
            this.button_toAut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_toAut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_toAut.FlatAppearance.BorderSize = 0;
            this.button_toAut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_toAut.Location = new System.Drawing.Point(1774, 12);
            this.button_toAut.Name = "button_toAut";
            this.button_toAut.Size = new System.Drawing.Size(35, 35);
            this.button_toAut.TabIndex = 97;
            this.button_toAut.UseVisualStyleBackColor = true;
            this.button_toAut.Click += new System.EventHandler(this.button_toAut_Click);
            // 
            // TovarEmpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1904, 1011);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_toAut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_postav);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.label_col);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_izm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_postav);
            this.Controls.Add(this.textBox_cena);
            this.Controls.Add(this.textBox_col);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TovarEmpForm";
            this.Text = "TovarEmpForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TovarEmpForm_FormClosing);
            this.Load += new System.EventHandler(this.TovarEmpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_postav;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.Label label_col;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_izm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_postav;
        private System.Windows.Forms.TextBox textBox_cena;
        private System.Windows.Forms.TextBox textBox_col;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_toAut;
    }
}