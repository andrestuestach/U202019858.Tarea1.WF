using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using U202019858.Tarea1.BE;

namespace U202019858.Tarea1.WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cb_lugar.SelectedIndex = 0;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (txt_descripcion.Text != ""  && cb_lugar.Text != "" &&  txt_hora.Text != "")
            {
                var reserva = new ReservaBE
                {
                    lugar = cb_lugar.Text,
                    descripcion = txt_descripcion.Text,
                    fecha=dtp_fecha.Value,
                    hora=int.Parse(txt_hora.Text)
                };


                dgv_tabla.Rows.Add(reserva.lugar,reserva.descripcion,reserva.fecha,reserva.hora);
                txt_descripcion.Text="";
                txt_hora.Text = "";
            }
            else
            {
                MessageBox.Show("Complete todos los campos");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
