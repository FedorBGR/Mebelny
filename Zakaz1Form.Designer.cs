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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_id_zakaz = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_client_name = new System.Windows.Forms.TextBox();
            this.comboBox_id_tovar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_client_surname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_client_otch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_cena_zakaza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_zakaz_col = new System.Windows.Forms.TextBox();
            this.comboBox_Id_user = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_satus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_addZakaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1144, 628);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 41);
            this.button1.TabIndex = 41;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Location = new System.Drawing.Point(96, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 283);
            this.dataGridView1.TabIndex = 42;
            // 
            // textBox_id_zakaz
            // 
            this.textBox_id_zakaz.Location = new System.Drawing.Point(208, 339);
            this.textBox_id_zakaz.Multiline = true;
            this.textBox_id_zakaz.Name = "textBox_id_zakaz";
            this.textBox_id_zakaz.Size = new System.Drawing.Size(258, 25);
            this.textBox_id_zakaz.TabIndex = 43;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_id.Location = new System.Drawing.Point(98, 339);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(104, 25);
            this.label_id.TabIndex = 44;
            this.label_id.Text = "id заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 46;
            this.label1.Text = "id товара";
            // 
            // textBox_client_name
            // 
            this.textBox_client_name.Location = new System.Drawing.Point(208, 444);
            this.textBox_client_name.Multiline = true;
            this.textBox_client_name.Name = "textBox_client_name";
            this.textBox_client_name.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_name.TabIndex = 45;
            // 
            // comboBox_id_tovar
            // 
            this.comboBox_id_tovar.FormattingEnabled = true;
            this.comboBox_id_tovar.Location = new System.Drawing.Point(208, 394);
            this.comboBox_id_tovar.Name = "comboBox_id_tovar";
            this.comboBox_id_tovar.Size = new System.Drawing.Size(258, 21);
            this.comboBox_id_tovar.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(62, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Имя клиента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Фамалия клиента";
            // 
            // textBox_client_surname
            // 
            this.textBox_client_surname.Location = new System.Drawing.Point(208, 502);
            this.textBox_client_surname.Multiline = true;
            this.textBox_client_surname.Name = "textBox_client_surname";
            this.textBox_client_surname.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_surname.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 555);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Отчество клиента";
            // 
            // textBox_client_otch
            // 
            this.textBox_client_otch.Location = new System.Drawing.Point(208, 555);
            this.textBox_client_otch.Multiline = true;
            this.textBox_client_otch.Name = "textBox_client_otch";
            this.textBox_client_otch.Size = new System.Drawing.Size(258, 25);
            this.textBox_client_otch.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(549, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 25);
            this.label5.TabIndex = 54;
            this.label5.Text = "Цена заказа";
            // 
            // textBox_cena_zakaza
            // 
            this.textBox_cena_zakaza.Location = new System.Drawing.Point(694, 339);
            this.textBox_cena_zakaza.Multiline = true;
            this.textBox_cena_zakaza.Name = "textBox_cena_zakaza";
            this.textBox_cena_zakaza.Size = new System.Drawing.Size(258, 25);
            this.textBox_cena_zakaza.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(559, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 56;
            this.label6.Text = "Количество";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_zakaz_col
            // 
            this.textBox_zakaz_col.Location = new System.Drawing.Point(694, 390);
            this.textBox_zakaz_col.Multiline = true;
            this.textBox_zakaz_col.Name = "textBox_zakaz_col";
            this.textBox_zakaz_col.Size = new System.Drawing.Size(258, 25);
            this.textBox_zakaz_col.TabIndex = 55;
            // 
            // comboBox_Id_user
            // 
            this.comboBox_Id_user.FormattingEnabled = true;
            this.comboBox_Id_user.Location = new System.Drawing.Point(694, 444);
            this.comboBox_Id_user.Name = "comboBox_Id_user";
            this.comboBox_Id_user.Size = new System.Drawing.Size(258, 21);
            this.comboBox_Id_user.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(538, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "id сотрудника";
            // 
            // comboBox_satus
            // 
            this.comboBox_satus.FormattingEnabled = true;
            this.comboBox_satus.Items.AddRange(new object[] {
            "Сборка",
            "Отпарвка",
            "Отправлен",
            "Доставлен"});
            this.comboBox_satus.Location = new System.Drawing.Point(694, 502);
            this.comboBox_satus.Name = "comboBox_satus";
            this.comboBox_satus.Size = new System.Drawing.Size(258, 21);
            this.comboBox_satus.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(538, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 59;
            this.label8.Text = "Статус заказа";
            // 
            // button_addZakaz
            // 
            this.button_addZakaz.Location = new System.Drawing.Point(208, 613);
            this.button_addZakaz.Name = "button_addZakaz";
            this.button_addZakaz.Size = new System.Drawing.Size(235, 39);
            this.button_addZakaz.TabIndex = 61;
            this.button_addZakaz.Text = "Добавить заказ";
            this.button_addZakaz.UseVisualStyleBackColor = true;
            this.button_addZakaz.Click += new System.EventHandler(this.button_addZakaz_Click);
            // 
            // Zakaz1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button_addZakaz);
            this.Controls.Add(this.comboBox_satus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox_Id_user);
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
            this.Name = "Zakaz1Form";
            this.Text = "Zakaz1Form";
            this.Load += new System.EventHandler(this.Zakaz1Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_id_zakaz;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_client_name;
        private System.Windows.Forms.ComboBox comboBox_id_tovar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_client_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_client_otch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cena_zakaza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_zakaz_col;
        private System.Windows.Forms.ComboBox comboBox_Id_user;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_satus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_addZakaz;
    }
}