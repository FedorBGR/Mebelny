namespace Mebelny
{
    partial class TovarForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_col = new System.Windows.Forms.TextBox();
            this.textBox_cena = new System.Windows.Forms.TextBox();
            this.textBox_postav = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_addtovar = new System.Windows.Forms.Button();
            this.button_deletetovar = new System.Windows.Forms.Button();
            this.button_izm = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label_id = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_col = new System.Windows.Forms.Label();
            this.label_cena = new System.Windows.Forms.Label();
            this.label_postav = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1144, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(1067, 65);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(185, 20);
            this.textBox_Search.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(289, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Запись:";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(341, 424);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(258, 25);
            this.textBox_id.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(341, 473);
            this.textBox_name.Multiline = true;
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(258, 26);
            this.textBox_name.TabIndex = 5;
            // 
            // textBox_col
            // 
            this.textBox_col.Location = new System.Drawing.Point(341, 526);
            this.textBox_col.Multiline = true;
            this.textBox_col.Name = "textBox_col";
            this.textBox_col.Size = new System.Drawing.Size(258, 25);
            this.textBox_col.TabIndex = 6;
            // 
            // textBox_cena
            // 
            this.textBox_cena.Location = new System.Drawing.Point(341, 577);
            this.textBox_cena.Multiline = true;
            this.textBox_cena.Name = "textBox_cena";
            this.textBox_cena.Size = new System.Drawing.Size(258, 25);
            this.textBox_cena.TabIndex = 7;
            // 
            // textBox_postav
            // 
            this.textBox_postav.Location = new System.Drawing.Point(341, 634);
            this.textBox_postav.Multiline = true;
            this.textBox_postav.Name = "textBox_postav";
            this.textBox_postav.Size = new System.Drawing.Size(258, 25);
            this.textBox_postav.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(732, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Управление товарами:";
            // 
            // button_addtovar
            // 
            this.button_addtovar.Location = new System.Drawing.Point(737, 424);
            this.button_addtovar.Name = "button_addtovar";
            this.button_addtovar.Size = new System.Drawing.Size(235, 39);
            this.button_addtovar.TabIndex = 10;
            this.button_addtovar.Text = "Добавить товар";
            this.button_addtovar.UseVisualStyleBackColor = true;
            this.button_addtovar.Click += new System.EventHandler(this.button_addtovar_Click);
            // 
            // button_deletetovar
            // 
            this.button_deletetovar.Location = new System.Drawing.Point(737, 492);
            this.button_deletetovar.Name = "button_deletetovar";
            this.button_deletetovar.Size = new System.Drawing.Size(235, 39);
            this.button_deletetovar.TabIndex = 11;
            this.button_deletetovar.Text = "Удалить товар";
            this.button_deletetovar.UseVisualStyleBackColor = true;
            // 
            // button_izm
            // 
            this.button_izm.Location = new System.Drawing.Point(737, 554);
            this.button_izm.Name = "button_izm";
            this.button_izm.Size = new System.Drawing.Size(235, 39);
            this.button_izm.TabIndex = 12;
            this.button_izm.Text = "Изменить данные";
            this.button_izm.UseVisualStyleBackColor = true;
            this.button_izm.Click += new System.EventHandler(this.button_izm_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(737, 620);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(235, 39);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Сохроанить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(231, 424);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(104, 25);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "id товара";
            this.label_id.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(174, 473);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(161, 25);
            this.label_name.TabIndex = 15;
            this.label_name.Text = "Наименование";
            // 
            // label_col
            // 
            this.label_col.AutoSize = true;
            this.label_col.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_col.Location = new System.Drawing.Point(206, 526);
            this.label_col.Name = "label_col";
            this.label_col.Size = new System.Drawing.Size(129, 25);
            this.label_col.TabIndex = 16;
            this.label_col.Text = "Количество";
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_cena.Location = new System.Drawing.Point(215, 577);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(120, 25);
            this.label_cena.TabIndex = 17;
            this.label_cena.Text = "Стоимость";
            // 
            // label_postav
            // 
            this.label_postav.AutoSize = true;
            this.label_postav.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_postav.Location = new System.Drawing.Point(200, 634);
            this.label_postav.Name = "label_postav";
            this.label_postav.Size = new System.Drawing.Size(135, 25);
            this.label_postav.TabIndex = 18;
            this.label_postav.Text = "Поставищик";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(364, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 283);
            this.dataGridView1.TabIndex = 19;
            // 
            // TovarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_postav);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.label_col);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_izm);
            this.Controls.Add(this.button_deletetovar);
            this.Controls.Add(this.button_addtovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_postav);
            this.Controls.Add(this.textBox_cena);
            this.Controls.Add(this.textBox_col);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button1);
            this.Name = "TovarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TovarForm";
            this.Load += new System.EventHandler(this.TovarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_col;
        private System.Windows.Forms.TextBox textBox_cena;
        private System.Windows.Forms.TextBox textBox_postav;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_addtovar;
        private System.Windows.Forms.Button button_deletetovar;
        private System.Windows.Forms.Button button_izm;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_col;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.Label label_postav;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}