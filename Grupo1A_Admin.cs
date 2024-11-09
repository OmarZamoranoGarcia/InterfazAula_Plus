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
    public partial class Grupo1A_Admin : Form
    {     
        public Grupo1A_Admin()
        {
            InitializeComponent();                    
        }

        private void button1ALista_Click(object sender, EventArgs e)
        {          
            //select a la tabla de Lista de asistencia 1A

        }
        private void button1AListaAsistencia_Click(object sender, EventArgs e)
        {
            //Sube la asiustencia a sql

        }
        private void button1AListaFalta_Click(object sender, EventArgs e)
        {
            //Sube la falta a sql

        }

        private void buttonCalificacion1A_Click(object sender, EventArgs e)
        {         
            //select a la tabla de Calificacones 1A

        }

        private void buttonRegistros1A_Click(object sender, EventArgs e)
        {         
            //select a la tabla de correos y contrasenias

        }
        private void button1ARegistrosGuardar_Click(object sender, EventArgs e)
        {
            //hace el insert en la tabla de registros 1A (hacer try catch para los textbox)

            //limpia textbox
            textBox1ACorreo.Clear();
            textBox1AContra.Clear();
        }
        private void button1ARegistrosEliminar_Click(object sender, EventArgs e)
        {
            //al hacer check en la fila del datagriedview, elimina ese registro

            //limpia textbox
            textBox1ACorreo.Clear();
            textBox1AContra.Clear();
        }

        private void button1ACalificacionCancelar_Click(object sender, EventArgs e)
        {         
            //limpia textbox
            textBox1AU1.Clear();
            textBox1AU2.Clear();
            textBox1AU3.Clear();
        }

        private void button1ACalificacionGuardar_Click(object sender, EventArgs e)
        {
            //codigo para subir calificaciones a sql

            //limpia textbox
            textBox1AU1.Clear();
            textBox1AU2.Clear();
            textBox1AU3.Clear();
        }     

        private void button1AMessage_Click(object sender, EventArgs e)
        {
            //abre donde se ven los mensajes 1A
        }

        private void button1AMessageSend_Click(object sender, EventArgs e)
        {
            //Envia el mensaje

            //limpia el textbox
            textBox1AMessage.Clear();
        }

        private void button1AMessageCancelar_Click(object sender, EventArgs e)
        {
            //limpia el textbox de mensajes
            textBox1AMessage.Clear();
        }      
    }
}