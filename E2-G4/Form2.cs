using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace E2_G4
{
    public partial class Registro : E2_G4.Form1
    {
        private List<Persona> Persons = new List<Persona>();
        private int index = -1;
        public Registro()
        {
            InitializeComponent();
        }

        private void updateGrip()
        {
            dgvPersona.DataSource = null;
            dgvPersona.DataSource = Persons;
        }
        private void clean()
        {
            txtName.Clear();
            txtUser.Clear();
            txtCode.Clear();
            txtName.Focus();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            //Check if index is selected
            if (index > -1)
            {
                Persons.RemoveAt(index);
                index = -1;
                clean();
                updateGrip();
            }
            else
            {
                MessageBox.Show("Debe seleccionar la persona dando doble click sobre el");
            }
        }

        private void dgvPersona_DoubleClick(object sender, EventArgs e)
        {
            ///Select item of data grid
            DataGridViewRow select = dgvPersona.SelectedRows[0];
            int pos = dgvPersona.Rows.IndexOf(select);
            //Information store class
            Persona per = new Persona();
            txtName.Text = per.Nombre;
            txtUser.Text = per.Usuario;
            txtCode.Text = per.Codigo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Information store class
            Persona per = new Persona();
            per.Nombre = txtName.Text;
            per.Usuario = txtUser.Text;
            per.Codigo = txtCode.Text;
            //check if index is selected
            if (index > -1)
            {
                Persons[index] = per;
            }
            else
            {
                Persons.Add(per);
            }
            updateGrip();
            clean();
        }

    }
    
}
