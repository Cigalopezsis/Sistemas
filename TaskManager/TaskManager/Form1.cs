using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ObtenerProcesos()
        {
            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
                ListadeProcesos.Items.Add(proc.ProcessName);
            }
        }

        //Botón para obtener las propiedades del proceso.

        private void btnPropiedades_Click(object sender, EventArgs e)
        {

            Process[] task = Process.GetProcesses();
            foreach (Process proc in task)
            {
               if (ListadeProcesos.SelectedItem.ToString() == proc.ProcessName)
                {
                    string temp = string.Empty;
                    temp += "Id Proceso: " + proc.Id.ToString();
                    MessageBox.Show(temp);
                    break;
                }
            }

        }

        private void btnObtenerProceso_Click(object sender, EventArgs e)
        {
            ObtenerProcesos();
        }
    }
}
