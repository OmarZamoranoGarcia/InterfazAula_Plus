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
    public partial class AlumnoPadre : Form
    {
        public AlumnoPadre()
        {
            InitializeComponent();
        }      
        
        //debes hacer un metodo debe reciba el nombre del alumno o padre que ingrese, obvio del sql
        //y que lo devuelva como string al texto del label (labelBienvenido)       

        private void buttonListaAlumnoPadre_Click(object sender, EventArgs e)
        {
            //select a la tabla de listas
        }

        private void buttonCalificacionAlumnoPadre_Click(object sender, EventArgs e)
        {
            //select a la tabla de calificaciones
        }

        private void buttonMessageAlumnoPadre_Click(object sender, EventArgs e)
        {
            //select a donde se ven los mensajes
        }
    }
}
