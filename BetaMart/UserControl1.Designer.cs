namespace BetaMart
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_buah = new System.Windows.Forms.TextBox();
            this.nama_buah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.harga_beli = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.harga_jual = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radio_impor = new System.Windows.Forms.RadioButton();
            this.radio_lokal = new System.Windows.Forms.RadioButton();
            this.stok = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tanggal_masuk = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 63);
            this.label3.TabIndex = 5;
            this.label3.Text = "DATA CRUD";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Buah";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id_buah
            // 
            this.id_buah.Location = new System.Drawing.Point(163, 76);
            this.id_buah.Name = "id_buah";
            this.id_buah.Size = new System.Drawing.Size(248, 22);
            this.id_buah.TabIndex = 8;
            this.id_buah.TextChanged += new System.EventHandler(this.id_buah_TextChanged);
            this.id_buah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.id_onlyNumber);
            // 
            // nama_buah
            // 
            this.nama_buah.Location = new System.Drawing.Point(163, 114);
            this.nama_buah.Name = "nama_buah";
            this.nama_buah.Size = new System.Drawing.Size(248, 22);
            this.nama_buah.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nama";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // harga_beli
            // 
            this.harga_beli.Location = new System.Drawing.Point(163, 152);
            this.harga_beli.Name = "harga_beli";
            this.harga_beli.Size = new System.Drawing.Size(248, 22);
            this.harga_beli.TabIndex = 13;
            this.harga_beli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hargaBeli_onlyNumber);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Harga Beli/kg";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Jenis Buah";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // harga_jual
            // 
            this.harga_jual.Location = new System.Drawing.Point(163, 231);
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Size = new System.Drawing.Size(248, 22);
            this.harga_jual.TabIndex = 17;
            this.harga_jual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hargaJual_onlyNumber);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Harga Jual/kg";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radio_impor
            // 
            this.radio_impor.AutoSize = true;
            this.radio_impor.Location = new System.Drawing.Point(163, 194);
            this.radio_impor.Name = "radio_impor";
            this.radio_impor.Size = new System.Drawing.Size(62, 20);
            this.radio_impor.TabIndex = 18;
            this.radio_impor.TabStop = true;
            this.radio_impor.Text = "Impor";
            this.radio_impor.UseVisualStyleBackColor = true;
            this.radio_impor.CheckedChanged += new System.EventHandler(this.radio_impor_CheckedChanged);
            // 
            // radio_lokal
            // 
            this.radio_lokal.AutoSize = true;
            this.radio_lokal.Location = new System.Drawing.Point(245, 194);
            this.radio_lokal.Name = "radio_lokal";
            this.radio_lokal.Size = new System.Drawing.Size(61, 20);
            this.radio_lokal.TabIndex = 19;
            this.radio_lokal.TabStop = true;
            this.radio_lokal.Text = "Lokal";
            this.radio_lokal.UseVisualStyleBackColor = true;
            // 
            // stok
            // 
            this.stok.Location = new System.Drawing.Point(163, 271);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(248, 22);
            this.stok.TabIndex = 21;
            this.stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stok_onlyNumber);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Stok/kg";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tanggal_masuk
            // 
            this.tanggal_masuk.Location = new System.Drawing.Point(211, 312);
            this.tanggal_masuk.Name = "tanggal_masuk";
            this.tanggal_masuk.Size = new System.Drawing.Size(200, 22);
            this.tanggal_masuk.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Tanggal Masuk";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(22, 373);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(190, 50);
            this.button_save.TabIndex = 24;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(444, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(973, 432);
            this.dataGridView1.TabIndex = 26;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(221, 373);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(190, 50);
            this.buttonUpdate.TabIndex = 27;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(221, 429);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(190, 50);
            this.buttonRefresh.TabIndex = 29;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(22, 429);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(190, 50);
            this.buttonDelete.TabIndex = 28;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tanggal_masuk);
            this.Controls.Add(this.stok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radio_lokal);
            this.Controls.Add(this.radio_impor);
            this.Controls.Add(this.harga_jual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.harga_beli);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nama_buah);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.id_buah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1440, 536);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_buah;
        private System.Windows.Forms.TextBox nama_buah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox harga_beli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox harga_jual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radio_impor;
        private System.Windows.Forms.RadioButton radio_lokal;
        private System.Windows.Forms.TextBox stok;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tanggal_masuk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
    }
}
