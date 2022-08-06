
namespace usuarios.Presentacion
{
    partial class Usuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btninsertar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtbuscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datalistado = new System.Windows.Forms.DataGridView();
            this.panelusuario = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.btnsavech = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.dlg = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.picboxuser = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).BeginInit();
            this.panelusuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(22, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(1733, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btninsertar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtbuscador);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 162);
            this.panel2.TabIndex = 1;
            // 
            // btninsertar
            // 
            this.btninsertar.BackColor = System.Drawing.Color.Salmon;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Location = new System.Drawing.Point(159, 66);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 33);
            this.btninsertar.TabIndex = 2;
            this.btninsertar.Text = "Add";
            this.btninsertar.UseVisualStyleBackColor = false;
            this.btninsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Brown;
            this.panel3.Location = new System.Drawing.Point(83, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 3);
            this.panel3.TabIndex = 2;
            // 
            // txtbuscador
            // 
            this.txtbuscador.Location = new System.Drawing.Point(86, 26);
            this.txtbuscador.Name = "txtbuscador";
            this.txtbuscador.Size = new System.Drawing.Size(255, 31);
            this.txtbuscador.TabIndex = 1;
            this.txtbuscador.TextChanged += new System.EventHandler(this.txtbuscador_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search";
            // 
            // datalistado
            // 
            this.datalistado.AllowUserToAddRows = false;
            this.datalistado.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.datalistado.Location = new System.Drawing.Point(0, 242);
            this.datalistado.Name = "datalistado";
            this.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistado.Size = new System.Drawing.Size(809, 184);
            this.datalistado.TabIndex = 2;
            this.datalistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistado_CellClick);
            this.datalistado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelusuario
            // 
            this.panelusuario.Controls.Add(this.label4);
            this.panelusuario.Controls.Add(this.label3);
            this.panelusuario.Controls.Add(this.btnback);
            this.panelusuario.Controls.Add(this.btnsavech);
            this.panelusuario.Controls.Add(this.btnsave);
            this.panelusuario.Controls.Add(this.picboxuser);
            this.panelusuario.Controls.Add(this.txtpass);
            this.panelusuario.Controls.Add(this.txtuser);
            this.panelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelusuario.Location = new System.Drawing.Point(405, 61);
            this.panelusuario.Name = "panelusuario";
            this.panelusuario.Size = new System.Drawing.Size(404, 175);
            this.panelusuario.TabIndex = 3;
            this.panelusuario.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(291, 130);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(101, 32);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnsavech
            // 
            this.btnsavech.Location = new System.Drawing.Point(125, 130);
            this.btnsavech.Name = "btnsavech";
            this.btnsavech.Size = new System.Drawing.Size(173, 32);
            this.btnsavech.TabIndex = 4;
            this.btnsavech.Text = "Save Changes";
            this.btnsavech.UseVisualStyleBackColor = true;
            this.btnsavech.Click += new System.EventHandler(this.btnsavech_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(32, 130);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(87, 32);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(150, 91);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(242, 23);
            this.txtpass.TabIndex = 1;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(150, 37);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(242, 23);
            this.txtuser.TabIndex = 0;
            // 
            // dlg
            // 
            this.dlg.FileName = "openFileDialog1";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::usuarios.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::usuarios.Properties.Resources.delete;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // picboxuser
            // 
            this.picboxuser.BackgroundImage = global::usuarios.Properties.Resources.profile;
            this.picboxuser.Image = global::usuarios.Properties.Resources.profile;
            this.picboxuser.Location = new System.Drawing.Point(24, 26);
            this.picboxuser.Name = "picboxuser";
            this.picboxuser.Size = new System.Drawing.Size(95, 88);
            this.picboxuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxuser.TabIndex = 2;
            this.picboxuser.TabStop = false;
            this.picboxuser.Click += new System.EventHandler(this.picboxuser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::usuarios.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(359, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::usuarios.Properties.Resources.edit;
            this.Editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Editar.Name = "Editar";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::usuarios.Properties.Resources.delete;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 426);
            this.Controls.Add(this.panelusuario);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.datalistado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios App";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datalistado)).EndInit();
            this.panelusuario.ResumeLayout(false);
            this.panelusuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbuscador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btninsertar;
        private System.Windows.Forms.DataGridView datalistado;
        private System.Windows.Forms.Panel panelusuario;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnsavech;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.PictureBox picboxuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog dlg;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}