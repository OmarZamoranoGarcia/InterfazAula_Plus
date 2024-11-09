using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace InterfazAula_
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0x00A1;
        private const int HTCAPTION = 0x0002;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            }
        }

        public Login()
        {       
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            buttonClose.BackColor = Color.White;
        }

        private void RoundPanel(Panel panel, int borderRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                // Crear un rectángulo con bordes redondeados
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Esquina superior izquierda
                path.AddArc(panel.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Esquina superior derecha
                path.AddArc(panel.Width - borderRadius, panel.Height - borderRadius, borderRadius, borderRadius, 0, 90); // Esquina inferior derecha
                path.AddArc(0, panel.Height - borderRadius, borderRadius, borderRadius, 90, 90); // Esquina inferior izquierda
                path.CloseFigure();

                panel.Region = new Region(path); // Establecer la región del panel

                panelLogin.BackColor = Color.FromArgb(200, Color.Black);
                labelCorreo.BackColor = Color.FromArgb(1, Color.Black);
                labelContra.BackColor = Color.FromArgb(1, Color.Black);
                labelLogin.BackColor = Color.FromArgb(1, Color.Black);
                buttonClose.AutoEllipsis = true;
            }          
        }     

        private void RoundTextbox(TextBox textBox, int borderRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {             
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); 
                path.AddArc(textBox.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(textBox.Width - borderRadius, textBox.Height - borderRadius, borderRadius, borderRadius, 0, 90); 
                path.AddArc(0, textBox.Height - borderRadius, borderRadius, borderRadius, 90, 90); 
                path.CloseFigure();

                textBox.Region = new Region(path);            
            }
        }

        private void RoundForms(Form form, int borderRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(form.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(form.Width - borderRadius, form.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, form.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                form.Region = new Region(path);
            }
        }

        private void RoundButton(Button button, int borderRadius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {          
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(button.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(button.Width - borderRadius, button.Height - borderRadius, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, button.Height - borderRadius, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();
          
                button.Region = new Region(path);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Volver a aplicar la región redondeada al cambiar el tamaño del formulario
            RoundPanel(panelLogin, 70); // Ajusta el radio según lo que necesites
            RoundTextbox(textBoxCorreo,20); 
            RoundTextbox(textBoxContra, 20);
            RoundForms(this,40);
            RoundButton(buttonClose,20);
            RoundButton(buttonLogin, 20);
        }     

        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(9,3,64);
        }
        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton que cierra el forms
            this.Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //codigo para el boton de Ingresar

        }
    }   
}