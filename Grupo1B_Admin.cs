using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAula_
{
    public partial class Grupo1B_Admin : Form
    {
        public Grupo1B_Admin()
        {
            InitializeComponent();
        }

        private void button1BLista_Click(object sender, EventArgs e)
        {
            //select a la tabla de Lista de asistencia 1B
        }

        private void button1BListaAsistencia_Click(object sender, EventArgs e)
        {
            //Sube la asiustencia a sql
        }

        private void button1BListaFalta_Click(object sender, EventArgs e)
        {
            //Sube la falta a sql
        }

        private void buttonCalificacion1B_Click(object sender, EventArgs e)
        {
            //select a la tabla de Calificaciones 1B
        }

        private void button1BCalificacionGuardar_Click(object sender, EventArgs e)
        {
            //Guarda la calificacion en sql (agregar try catch para aceptar solo numeros)

            //limpia los textbox
            textBox1BU1.Clear();
            textBox1BU2.Clear();
            textBox1BU3.Clear();
        }

        private void button1BCalificacionCancelar_Click(object sender, EventArgs e)
        {
            //limpia los textbox
            textBox1BU1.Clear();
            textBox1BU2.Clear();
            textBox1BU3.Clear();
        }

        private void button1BMessage_Click(object sender, EventArgs e)
        {
            //abre donde se ven los mensajes 1B
        }

        private void button1BMessageSend_Click(object sender, EventArgs e)
        {
            //Envia el mensaje

            //limpia el textbox de mensajes
            textBox1BMessage.Clear();
        }

        private void button1BMessageCancelar_Click(object sender, EventArgs e)
        {
            //limpia el textbox de mensajes
            textBox1BMessage.Clear();
        }

        private void buttonRegistros1B_Click(object sender, EventArgs e)
        {
            //abre la tabla de registros (correos y contrasenias) en sql
        }

        private void button1BRegistrosGuardar_Click(object sender, EventArgs e)
        {
            //hace el insert en la tabla de registros 1B (hacer try catch para los textbox)

            //limpia los textbox
            textBox1BCorreo.Clear();
            textBox1BContra.Clear();
        }

        private void button1BRegistrosEliminar_Click(object sender, EventArgs e)
        {
            //al hacer check en la fila del datagriedview, elimina ese registro

            //limpia los textbox
            textBox1BCorreo.Clear();
            textBox1BContra.Clear();
        }
    }
}
