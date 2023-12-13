namespace Mebelny
{
    partial class Zakaz1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zakaz1Form));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id_zakaz = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_client_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_id_tovar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_client_surname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_client_otch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_cena_zakaza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_zakaz_col = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_satus = new System.Windows.Forms.ComboBox();
            this.button_addZakaz = new System.Windows.Forms.Button();
            this.button_izm = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_reload = new System.Windows.Forms.Button();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_toAut = new System.Windows.Forms.Button();
            this.buttonAddvzakaz = new System.Windows.Forms.Button();
            this.button_vzakaz = new System.Windows.Forms.Button();
            this.textBox_fam = new System.Windows.Forms.TextBox();
            this.comboBoxj = new System.Windows.Forms.ComboBox();
            this.textBoxj = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.Location = new System.Drawing.Point(325, 290);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 257);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_id_zakaz
            // 
            this.textBox_id_zakaz.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_id_zakaz.Location = new System.Drawing.Point(527, 567);
            this.textBox_id_zakaz.Multiline = true;
            this.textBox_id_zakaz.Name = "textBox_id_zakaz";
            this.textBox_id_zakaz.ReadOnly = true;
            this.textBox_id_zakaz.Size = new System.Drawing.Size(258, 25);
            this.textBox_id_zakaz.TabIndex = 43;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(363, 559);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(158, 33);
            this.label_id.TabIndex = 44;
            this.label_id.Text = "Номер заказа";
            // 
            // textBox_client_name
            // 
            this.textBox_client_name.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_client_name.Location = new System.Drawing.Point(527, 672);
            this.textBox_client_name.Multiline = true;
            this.textBox_client_name.Name = "textBox_client_name";
            this.textBox_client_name.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_name.TabIndex = 45;
            this.textBox_client_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_client_name_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(386, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "Код товара";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_id_tovar
            // 
            this.comboBox_id_tovar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_id_tovar.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_id_tovar.FormattingEnabled = true;
            this.comboBox_id_tovar.Location = new System.Drawing.Point(527, 616);
            this.comboBox_id_tovar.Name = "comboBox_id_tovar";
            this.comboBox_id_tovar.Size = new System.Drawing.Size(258, 34);
            this.comboBox_id_tovar.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(372, 668);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 33);
            this.label2.TabIndex = 48;
            this.label2.Text = "Имя клиента";
            // 
            // textBox_client_surname
            // 
            this.textBox_client_surname.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_client_surname.Location = new System.Drawing.Point(527, 730);
            this.textBox_client_surname.Multiline = true;
            this.textBox_client_surname.Name = "textBox_client_surname";
            this.textBox_client_surname.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_surname.TabIndex = 49;
            this.textBox_client_surname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_client_surname_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(321, 722);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 33);
            this.label3.TabIndex = 50;
            this.label3.Text = "Фамалия клиента";
            // 
            // textBox_client_otch
            // 
            this.textBox_client_otch.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_client_otch.Location = new System.Drawing.Point(527, 783);
            this.textBox_client_otch.Multiline = true;
            this.textBox_client_otch.Name = "textBox_client_otch";
            this.textBox_client_otch.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_otch.TabIndex = 51;
            this.textBox_client_otch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_client_otch_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(319, 775);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 33);
            this.label4.TabIndex = 52;
            this.label4.Text = "Отчество клиента";
            // 
            // textBox_cena_zakaza
            // 
            this.textBox_cena_zakaza.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_cena_zakaza.Location = new System.Drawing.Point(1013, 568);
            this.textBox_cena_zakaza.Multiline = true;
            this.textBox_cena_zakaza.Name = "textBox_cena_zakaza";
            this.textBox_cena_zakaza.ReadOnly = true;
            this.textBox_cena_zakaza.Size = new System.Drawing.Size(258, 25);
            this.textBox_cena_zakaza.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(865, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 33);
            this.label5.TabIndex = 54;
            this.label5.Text = "Цена заказа";
            // 
            // textBox_zakaz_col
            // 
            this.textBox_zakaz_col.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_zakaz_col.Location = new System.Drawing.Point(1013, 619);
            this.textBox_zakaz_col.Multiline = true;
            this.textBox_zakaz_col.Name = "textBox_zakaz_col";
            this.textBox_zakaz_col.Size = new System.Drawing.Size(258, 25);
            this.textBox_zakaz_col.TabIndex = 55;
            this.textBox_zakaz_col.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_zakaz_col_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(868, 611);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 33);
            this.label6.TabIndex = 56;
            this.label6.Text = "Количество";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(868, 665);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 33);
            this.label7.TabIndex = 57;
            this.label7.Text = "Сотрудник";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(847, 725);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 33);
            this.label8.TabIndex = 59;
            this.label8.Text = "Статус заказа";
            // 
            // comboBox_satus
            // 
            this.comboBox_satus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_satus.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_satus.FormattingEnabled = true;
            this.comboBox_satus.Items.AddRange(new object[] {
            "Сборка",
            "Отправка",
            "Отправлен",
            "Доставлен"});
            this.comboBox_satus.Location = new System.Drawing.Point(1013, 722);
            this.comboBox_satus.Name = "comboBox_satus";
            this.comboBox_satus.Size = new System.Drawing.Size(258, 34);
            this.comboBox_satus.TabIndex = 60;
            // 
            // button_addZakaz
            // 
            this.button_addZakaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addZakaz.FlatAppearance.BorderSize = 0;
            this.button_addZakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addZakaz.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addZakaz.Location = new System.Drawing.Point(572, 856);
            this.button_addZakaz.Name = "button_addZakaz";
            this.button_addZakaz.Size = new System.Drawing.Size(235, 39);
            this.button_addZakaz.TabIndex = 61;
            this.button_addZakaz.Text = "Добавить заказ";
            this.button_addZakaz.UseVisualStyleBackColor = true;
            this.button_addZakaz.Click += new System.EventHandler(this.button_addZakaz_Click);
            // 
            // button_izm
            // 
            this.button_izm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_izm.FlatAppearance.BorderSize = 0;
            this.button_izm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_izm.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_izm.Location = new System.Drawing.Point(813, 856);
            this.button_izm.Name = "button_izm";
            this.button_izm.Size = new System.Drawing.Size(235, 39);
            this.button_izm.TabIndex = 62;
            this.button_izm.Text = "Изменить данные";
            this.button_izm.UseVisualStyleBackColor = true;
            this.button_izm.Click += new System.EventHandler(this.button_izm_Click);
            // 
            // button_save
            // 
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(1054, 856);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(235, 39);
            this.button_save.TabIndex = 63;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Search.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(1419, 250);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(360, 34);
            this.textBox_Search.TabIndex = 64;
            this.textBox_Search.Enter += new System.EventHandler(this.textBox_Search_Enter);
            this.textBox_Search.Leave += new System.EventHandler(this.textBox_Search_Leave);
            // 
            // button_search
            // 
            this.button_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_search.Location = new System.Drawing.Point(1785, 249);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(35, 35);
            this.button_search.TabIndex = 65;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_reload
            // 
            this.button_reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_reload.FlatAppearance.BorderSize = 0;
            this.button_reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reload.Location = new System.Drawing.Point(1492, 290);
            this.button_reload.Name = "button_reload";
            this.button_reload.Size = new System.Drawing.Size(240, 40);
            this.button_reload.TabIndex = 66;
            this.button_reload.Text = "Показать все данные";
            this.button_reload.UseVisualStyleBackColor = true;
            this.button_reload.Click += new System.EventHandler(this.button_reload_Click);
            // 
            // button_hide
            // 
            this.button_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hide.BackgroundImage")));
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Location = new System.Drawing.Point(1816, 12);
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
            this.button_close.Location = new System.Drawing.Point(1857, 12);
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
            this.button_toAut.Location = new System.Drawing.Point(1775, 12);
            this.button_toAut.Name = "button_toAut";
            this.button_toAut.Size = new System.Drawing.Size(35, 35);
            this.button_toAut.TabIndex = 97;
            this.button_toAut.UseVisualStyleBackColor = true;
            this.button_toAut.Click += new System.EventHandler(this.button_toAut_Click);
            // 
            // buttonAddvzakaz
            // 
            this.buttonAddvzakaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddvzakaz.FlatAppearance.BorderSize = 0;
            this.buttonAddvzakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddvzakaz.Font = new System.Drawing.Font("Arsenal", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddvzakaz.Location = new System.Drawing.Point(1277, 606);
            this.buttonAddvzakaz.Name = "buttonAddvzakaz";
            this.buttonAddvzakaz.Size = new System.Drawing.Size(116, 50);
            this.buttonAddvzakaz.TabIndex = 100;
            this.buttonAddvzakaz.Text = "Добавить";
            this.buttonAddvzakaz.UseVisualStyleBackColor = true;
            this.buttonAddvzakaz.Click += new System.EventHandler(this.buttonAddvzakaz_Click);
            // 
            // button_vzakaz
            // 
            this.button_vzakaz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_vzakaz.FlatAppearance.BorderSize = 0;
            this.button_vzakaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_vzakaz.Font = new System.Drawing.Font("Arsenal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_vzakaz.Location = new System.Drawing.Point(357, 837);
            this.button_vzakaz.Name = "button_vzakaz";
            this.button_vzakaz.Size = new System.Drawing.Size(235, 77);
            this.button_vzakaz.TabIndex = 101;
            this.button_vzakaz.Text = "Внести товар в заказ";
            this.button_vzakaz.UseVisualStyleBackColor = true;
            this.button_vzakaz.Click += new System.EventHandler(this.button_vzakaz_Click);
            // 
            // textBox_fam
            // 
            this.textBox_fam.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fam.Location = new System.Drawing.Point(1013, 672);
            this.textBox_fam.Multiline = true;
            this.textBox_fam.Name = "textBox_fam";
            this.textBox_fam.ReadOnly = true;
            this.textBox_fam.Size = new System.Drawing.Size(258, 25);
            this.textBox_fam.TabIndex = 102;
            // 
            // comboBoxj
            // 
            this.comboBoxj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxj.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxj.FormattingEnabled = true;
            this.comboBoxj.Location = new System.Drawing.Point(527, 616);
            this.comboBoxj.Name = "comboBoxj";
            this.comboBoxj.Size = new System.Drawing.Size(258, 34);
            this.comboBoxj.TabIndex = 103;
            // 
            // textBoxj
            // 
            this.textBoxj.Font = new System.Drawing.Font("Arsenal", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxj.Location = new System.Drawing.Point(1012, 619);
            this.textBoxj.Multiline = true;
            this.textBoxj.Name = "textBoxj";
            this.textBoxj.Size = new System.Drawing.Size(258, 25);
            this.textBoxj.TabIndex = 104;
            this.textBoxj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxj_KeyPress);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.Location = new System.Drawing.Point(325, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1044, 254);
            this.dataGridView2.TabIndex = 105;
            // 
            // Zakaz1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxj);
            this.Controls.Add(this.comboBoxj);
            this.Controls.Add(this.textBox_fam);
            this.Controls.Add(this.button_vzakaz);
            this.Controls.Add(this.buttonAddvzakaz);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_toAut);
            this.Controls.Add(this.button_reload);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_izm);
            this.Controls.Add(this.button_addZakaz);
            this.Controls.Add(this.comboBox_satus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_zakaz_col);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_cena_zakaza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_client_otch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_client_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_id_tovar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_client_name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBox_id_zakaz);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zakaz1Form";
            this.Text = "Zakaz1Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zakaz1Form_FormClosing);
            this.Load += new System.EventHandler(this.Zakaz1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id_zakaz;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_client_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_id_tovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_client_surname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_client_otch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_cena_zakaza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_zakaz_col;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_satus;
        private System.Windows.Forms.Button button_addZakaz;
        private System.Windows.Forms.Button button_izm;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_reload;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_toAut;
        private System.Windows.Forms.Button buttonAddvzakaz;
        private System.Windows.Forms.Button button_vzakaz;
        private System.Windows.Forms.TextBox textBox_fam;
        private System.Windows.Forms.ComboBox comboBoxj;
        private System.Windows.Forms.TextBox textBoxj;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}