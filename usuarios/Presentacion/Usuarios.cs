using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuarios.Logica;
using usuarios.Datos;
using System.IO;

namespace usuarios.Presentacion
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        int idUsuarios;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            mostrar_usuario();
        }

        private void mostrar_usuario()
        {
            DataTable dt;
            Dusuarios funcion = new Dusuarios();
            dt = funcion.mostrar_usuarios();
            datalistado.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelusuario.Visible = true;
            panelusuario.Dock = DockStyle.Fill;
            btnsave.Visible = true;
            btnsavech.Visible = false;
            txtuser.Clear();
            txtpass.Clear();
        }

        private void picboxuser_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Pictures|*.jpg; *.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Upload an image";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                picboxuser.BackgroundImage = null;
                picboxuser.Image = new Bitmap(dlg.FileName);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if(txtuser.Text != "")
            {
                if (txtpass.Text != "")
                {
                    insertar_usuario();
                    mostrar_usuario();
                }
                else
                {
                    MessageBox.Show("Enter a password", "No password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
               MessageBox.Show("Enter a password", "No password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void insertar_usuario()
        {
            Lusuarios dt = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            dt.Usuario = txtuser.Text;
            dt.Password = txtpass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picboxuser.Image.Save(ms, picboxuser.Image.RawFormat);
            dt.Icon = ms.GetBuffer();
            dt.Status = "ACTIVE";
            if (funcion.insertar(dt))
            {
                MessageBox.Show("User Registered", "User added");
                panelusuario.Visible = false;
                panelusuario.Dock = DockStyle.None;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datalistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        idUsuarios = Convert.ToInt32(datalistado.SelectedCells[2].Value.ToString());

            if (e.ColumnIndex == this.datalistado.Columns["Eliminar"].Index)
            {
                DialogResult result;
                result = MessageBox.Show("Do you want to delete this user?", "Delete User", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(result == DialogResult.OK)
                {
                    eliminar_usuario();
                    mostrar_usuario();
                }
            }

                if (e.ColumnIndex == this.datalistado.Columns["Editar"].Index)
            {
                txtuser.Text = datalistado.SelectedCells[3].Value.ToString();
                txtpass.Text = datalistado.SelectedCells[4].Value.ToString();
                picboxuser.BackgroundImage = null;
                byte[] b = (Byte[])datalistado.SelectedCells[5].Value;
                MemoryStream ms = new MemoryStream(b);
                picboxuser.Image = Image.FromStream(ms);

                panelusuario.Visible = true;
                panelusuario.Dock = DockStyle.Fill;
                btnsave.Visible = false;
                btnsavech.Visible = true;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            panelusuario.Visible = false;
            panelusuario.Dock = DockStyle.None;
        }

        private void btnsavech_Click(object sender, EventArgs e)
        {
            editar_usuario();
            mostrar_usuario();
        }

        private void editar_usuario()
        {
            Lusuarios dt = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            dt.Idusuario = idUsuarios;
            dt.Usuario = txtuser.Text;
            dt.Password = txtpass.Text;
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            picboxuser.Image.Save(ms, picboxuser.Image.RawFormat);
            dt.Icon = ms.GetBuffer();
            dt.Status = "ACTIVE";
            if (funcion.editar(dt))
            {
                MessageBox.Show("User Updated", "User added");
                panelusuario.Visible = false;
                panelusuario.Dock = DockStyle.None;
            }
        }

        private void eliminar_usuario()
        {
            Lusuarios dt = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            dt.Idusuario = idUsuarios;
            if (funcion.eliminar_usuario(dt))
            {
                MessageBox.Show("User deleted", "Success");
                panelusuario.Visible = false;
                panelusuario.Dock = DockStyle.None;
            }

        }

        private void txtbuscador_TextChanged(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            DataTable dt;
            Dusuarios funcion = new Dusuarios();
            dt = funcion.buscar(txtbuscador.Text);
            datalistado.DataSource = dt;
        }
    }
}
