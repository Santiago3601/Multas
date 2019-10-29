using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int multaR, velocidadR = 0, cuadrante = 0, totalMultaC1 = 0, totalMultaC2 = 0, totalMultaC3 = 0, totalMultaC4 = 0, totalC1 = 0, totalC2 = 0, totalC3 = 0, totalC4 = 0, promedioC1 = 0, promedioC2 = 0, promedioC3 = 0, promedioC4 = 0;

        private void dataListaDeMultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            velocidadR = int.Parse(inputVelocidad.Text);

            int idCuadrante = 0;
            if (velocidadR > 80)
            {
                multaR = (velocidadR - 80) * int.Parse(lblMultaValor.Text);

                dataListaDeMultas.Rows.Add(inputPlaca.Text, inputVelocidad.Text + "km/h", multaR);
                idCuadrante = selSeleccionarCuadrante.SelectedIndex;
                switch (idCuadrante)
                {
                    case 0:
                        totalC1++;
                        totalMultaC1 += multaR;
                        promedioC1 = totalMultaC1 / totalC1;

                    break;
                    case 1:
                        totalC2++;
                        totalMultaC2 += multaR;
                        promedioC2 = totalMultaC2 / totalC2;

                    break;
                    case 2:
                        totalC3++;
                        totalMultaC3 += multaR;
                        promedioC3 = totalMultaC3 / totalC3;

                    break;
                    case 3:
                        totalC4++;
                        totalMultaC4 += multaR;
                        promedioC4 = totalMultaC4 / totalC4;

                    break;

                }
                llenarCajas();
            }
            else
            {
                MessageBox.Show("El limite de velocidad ingresado es menor a 80km/h");
            }
        }
  
        public void llenarCajas()
        {
            inputTotalC1.Text = totalC1.ToString();
            inputMultaPromedioC1.Text = promedioC1.ToString();
            inputTotalMultasC1.Text = totalMultaC1.ToString();
            
            inputTotalC2.Text = totalC2.ToString();
            inputMultaPromedioC2.Text = promedioC2.ToString();
            inputTotalMultasC2.Text = totalMultaC2.ToString();

            inputTotalC3.Text = totalC3.ToString();
            inputMultaPromedioC3.Text = promedioC3.ToString();
            inputTotalMultasC3.Text = totalMultaC3.ToString();

            inputTotalC4.Text = totalC4.ToString();
            inputMultaPromedioC4.Text = promedioC4.ToString();
            inputTotalMultasC4.Text = totalMultaC4.ToString();
        }
    }
}
