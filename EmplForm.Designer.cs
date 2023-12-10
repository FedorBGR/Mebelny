namespace Mebelny
{
    partial class EmplForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmplForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button_tovary = new System.Windows.Forms.Button();
            this.button_zakazy = new System.Windows.Forms.Button();
            this.button_hide = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arsenal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_tovary
            // 
            this.button_tovary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_tovary.FlatAppearance.BorderSize = 0;
            this.button_tovary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tovary.Font = new System.Drawing.Font("Arsenal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_tovary.Location = new System.Drawing.Point(76, 148);
            this.button_tovary.Name = "button_tovary";
            this.button_tovary.Size = new System.Drawing.Size(128, 45);
            this.button_tovary.TabIndex = 2;
            this.button_tovary.Text = "Товары";
            this.button_tovary.UseVisualStyleBackColor = true;
            this.button_tovary.Click += new System.EventHandler(this.button_tovary_Click);
            // 
            // button_zakazy
            // 
            this.button_zakazy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_zakazy.FlatAppearance.BorderSize = 0;
            this.button_zakazy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_zakazy.Font = new System.Drawing.Font("Arsenal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_zakazy.Location = new System.Drawing.Point(76, 62);
            this.button_zakazy.Name = "button_zakazy";
            this.button_zakazy.Size = new System.Drawing.Size(128, 45);
            this.button_zakazy.TabIndex = 3;
            this.button_zakazy.Text = "Заказы";
            this.button_zakazy.UseVisualStyleBackColor = true;
            this.button_zakazy.Click += new System.EventHandler(this.button_zakazy_Click);
            // 
            // button_hide
            // 
            this.button_hide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_hide.BackgroundImage")));
            this.button_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hide.FlatAppearance.BorderSize = 0;
            this.button_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hide.Location = new System.Drawing.Point(200, 12);
            this.button_hide.Name = "button_hide";
            this.button_hide.Size = new System.Drawing.Size(35, 35);
            this.button_hide.TabIndex = 102;
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
            this.button_close.Location = new System.Drawing.Point(241, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(35, 35);
            this.button_close.TabIndex = 101;
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // EmplForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 276);
            this.Controls.Add(this.button_hide);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_zakazy);
            this.Controls.Add(this.button_tovary);
            this.Controls.Add(this.button1);
            this.Name = "EmplForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmplForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EmplForm_FormClosing);
            this.Load += new System.EventHandler(this.EmplForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_tovary;
        private System.Windows.Forms.Button button_zakazy;
        private System.Windows.Forms.Button button_hide;
        private System.Windows.Forms.Button button_close;
    }
}