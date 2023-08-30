using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPromedio_Prueba
{
    public partial class FrmPromedio : Form
    {
        public FrmPromedio()
        {
            InitializeComponent();
        }
        ClCalificacion obj = new ClCalificacion();
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Validar();
            AgregarDatos();
            Limpiar();
        }

        private void Validar()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtEstudiante.Text) || String.IsNullOrWhiteSpace(txtNota1.Text)
                || String.IsNullOrWhiteSpace(txtNota2.Text) || String.IsNullOrWhiteSpace(txtNota3.Text))
            {
                MessageBox.Show("Por favor llene todos los espacios vacios" ,"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            } else if (Convert.ToInt32(txtNota1.Text) > 100 || Convert.ToInt32(txtNota2.Text) > 100 || Convert.ToInt32(txtNota3.Text) > 100){
                MessageBox.Show("La nota debe ser menor que 100", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error dato invalido");
                return;
            }
        }

        private void Limpiar()
        {
           txtEstudiante.Clear();
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
        }

        private void AgregarDatos()
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txtEstudiante.Text) || String.IsNullOrWhiteSpace(txtNota1.Text)
                   || String.IsNullOrWhiteSpace(txtNota2.Text) || String.IsNullOrWhiteSpace(txtNota3.Text))
                {
                    return;
                }
                obj.notas[0] = Convert.ToInt32(txtNota1.Text);
                obj.notas[1] = Convert.ToInt32(txtNota2.Text);
                obj.notas[2] = Convert.ToInt32(txtNota3.Text);

                ListViewItem item = new ListViewItem(txtEstudiante.Text);
                item.SubItems.Add(txtNota1.Text);
                item.SubItems.Add(txtNota2.Text);
                item.SubItems.Add(txtNota3.Text);
                item.SubItems.Add(obj.ObtenerPromedio().ToString());
                lvDatos.Items.Add(item);
            } catch (FormatException ex)
            {
                return;
            }
        }
    }
}
