using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            // Verifica que el TextBox no esté vacío
            if (!string.IsNullOrWhiteSpace(txtTarea.Text))
            {
                // Agrega el texto del TextBox al ListBox
                lstTareas.Items.Add(txtTarea.Text);

                // Limpia el TextBox
                txtTarea.Clear();
            }
            else
            {
                // Muestra un mensaje si el TextBox está vacío
                MessageBox.Show("Por favor, ingrese una tarea.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            // Verifica que hay una tarea seleccionada
            if (lstTareas.SelectedItem != null)
            {
                // Elimina la tarea seleccionada
                lstTareas.Items.Remove(lstTareas.SelectedItem);
            }
            else
            {
                // Muestra un mensaje si no hay ninguna tarea seleccionada
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.", "Ninguna tarea seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiarLista_Click(object sender, EventArgs e)
        {
            // Limpia todos los elementos del ListBox
            lstTareas.Items.Clear();
        }
    }
    }
    


