using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazAula_
{
    public partial class MenuAdmin : Form
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

        public MenuAdmin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            ButtonWithOutBorders();
            panelGrupos.BackColor = Color.White;
            panelGrupos.Visible= false;
            panelContenedor.SendToBack();
            labelSaludo.SendToBack();
            panelContenedor.Visible = false;
            buttonMenuAdminSalir.AutoEllipsis = true;
            buttonMenuAdminSalir.BackColor = Color.Transparent;          
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);         
            RoundButton(buttonMenuAdminSalir, 20);          
        }

        private void ButtonWithOutBorders()
        {
            buttonGrupos.FlatStyle = FlatStyle.Flat;
            buttonGrupos.FlatAppearance.BorderSize = 0;
            buttonGrupo1A.FlatStyle = FlatStyle.Flat;
            buttonGrupo1A.FlatAppearance.BorderSize = 0;
            buttonGrupo1B.FlatStyle = FlatStyle.Flat;
            buttonGrupo1B.FlatAppearance.BorderSize = 0;
            buttonGrupo2A.FlatStyle = FlatStyle.Flat;
            buttonGrupo2A.FlatAppearance.BorderSize = 0;
            buttonGrupo2B.FlatStyle = FlatStyle.Flat;
            buttonGrupo2B.FlatAppearance.BorderSize = 0;          
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

        private void MouseEnterGrupos(object sender, EventArgs e)
        {         
            buttonGrupos.BackColor = Color.FromArgb(74, 17, 94);
        }
        private void MouseLeaveGrupos(object sender, EventArgs e)
        {
            buttonGrupos.BackColor = Color.Transparent;         
        }
        private void MouseEnterGrupo1A(object sender, EventArgs e)
        {
            buttonGrupo1A.BackColor = Color.FromArgb(74, 17, 94);
        }
        private void MouseLeaveGrupo1A(object sender, EventArgs e)
        {
            buttonGrupo1A.BackColor = Color.Transparent;
        }
        private void MouseEnterGrupo1B(object sender, EventArgs e)
        {
            buttonGrupo1B.BackColor = Color.FromArgb(74, 17, 94);
        }
        private void MouseLeaveGrupo1B(object sender, EventArgs e)
        {
            buttonGrupo1B.BackColor = Color.Transparent;
        }
        private void MouseEnterGrupo2A(object sender, EventArgs e)
        {
            buttonGrupo2A.BackColor = Color.FromArgb(74, 17, 94);
        }
        private void MouseLeaveGrupo2A(object sender, EventArgs e)
        {
            buttonGrupo2A.BackColor = Color.Transparent;
        }
        private void MouseEnterGrupo2B(object sender, EventArgs e)
        {
            buttonGrupo2B.BackColor = Color.FromArgb(74, 17, 94);
        }
        private void MouseLeaveGrupo2B(object sender, EventArgs e)
        {
            buttonGrupo2B.BackColor = Color.Transparent;
        }

        private void buttonGrupos_Click(object sender, EventArgs e)
        {
            if(panelGrupos.Visible==false)
            {
                panelGrupos.Visible=true;
            }
            else
            {
                panelGrupos.Visible = false;
            }
        }

        private void buttonGrupo1A_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelGrupos.Visible = false;
            string value=buttonGrupo1A.Tag.ToString();
            labelGrupoActivo.Text= value;
            panelContenedor.Visible = true;
            Grupo1A_Admin grupo1A = new Grupo1A_Admin();
            grupo1A.TopLevel = false;
            panelContenedor.Controls.Add(grupo1A);
            grupo1A.Show();
        }

        private void buttonGrupo1B_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelGrupos.Visible = false;
            string value = buttonGrupo1B.Tag.ToString();
            labelGrupoActivo.Text = value;
            panelContenedor.Visible = true;
            Grupo1B_Admin grupo1B = new Grupo1B_Admin();
            grupo1B.TopLevel = false;
            panelContenedor.Controls.Add(grupo1B);
            grupo1B.Show();
        }

        private void buttonGrupo2A_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelGrupos.Visible = false;
            string value = buttonGrupo2A.Tag.ToString();
            labelGrupoActivo.Text = value;
            panelContenedor.Visible = true;
        }

        private void buttonGrupo2B_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            panelGrupos.Visible = false;
            string value = buttonGrupo2B.Tag.ToString();
            labelGrupoActivo.Text = value;
            panelContenedor.Visible = true;
        }

        private void buttonMenuAdminSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMenuAdminSalir_MouseEnter(object sender, EventArgs e)
        {
            buttonMenuAdminSalir.BackColor = Color.White;
            buttonMenuAdminSalir.ForeColor = Color.Black;
        }

        private void buttonMenuAdminSalir_MouseLeave(object sender, EventArgs e)
        {
            buttonMenuAdminSalir.BackColor = Color.Transparent;
            buttonMenuAdminSalir.ForeColor = Color.White;
        }
    }
}
