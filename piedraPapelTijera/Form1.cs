using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piedraPapelTijera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Random randomGenerator = new Random();

        Int32 winsPlayer = 0;
        Int32 winsComputer = 0;
        Int32 amountGames = 0;

        private void pbxComputadora_Click(object sender, EventArgs e)
        {

        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {

        if(amountGames != 3)
            {

                disableButtonsAndShowReplay();
                pbxJugador.Image = piedraPapelTijera.Properties.Resources.piedra;
                btnJugar.Visible = true;

                Int32 eleccionComputadora = randomGenerator.Next(1, 4);

                switch (eleccionComputadora) {

                    case 1:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.piedra;
                        lblResultado.ForeColor = Color.Yellow;
                        lblResultado.Text = "¡Empate!";
                        break;

                    case 2:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Papel;
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.Text = "¡Perdiste!";
                        winsComputer++;
                        break;

                    case 3:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Tijera;
                        lblResultado.ForeColor = Color.Green;
                        lblResultado.Text = "¡Ganaste!";
                        winsPlayer++;
                        break;
                
                }

                amountGames++;
                updateTexts();

            }
            else
            {
                handleResults();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(amountGames != 3)
            {

                disableButtonsAndShowReplay();
                pbxJugador.Image = piedraPapelTijera.Properties.Resources.Papel;
                btnJugar.Visible = true;


                Int32 eleccionComputadora = randomGenerator.Next(1, 4);

                switch (eleccionComputadora)
                {

                    case 1:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.piedra;
                        lblResultado.ForeColor = Color.Green;
                        lblResultado.Text = "¡Ganaste!";
                        winsPlayer++;
                        break;

                    case 2:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Papel;
                        lblResultado.ForeColor = Color.Yellow;
                        lblResultado.Text = "¡Empate!";
               
                        break;

                    case 3:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Tijera;
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.Text = "¡Perdiste!";
                        winsComputer++;
                    
                        break;

                }

                amountGames++;
                updateTexts();

            }
            else
            {
                handleResults();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(amountGames != 3)
            {

                disableButtonsAndShowReplay();
                pbxJugador.Image = piedraPapelTijera.Properties.Resources.Tijera;
                btnJugar.Visible = true;


                Int32 eleccionComputadora = randomGenerator.Next(1, 4);

                switch (eleccionComputadora)
                {

                    case 1:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.piedra;
                        lblResultado.ForeColor = Color.Red;
                        lblResultado.Text = "¡Perdiste!"; 
                        winsComputer++;
                        break;

                    case 2:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Papel;
                        lblResultado.ForeColor = Color.Green;
                        lblResultado.Text = "¡Ganaste!";
                        winsPlayer++;
                   
                        break;

                    case 3:
                        pbxComputadora.Image = piedraPapelTijera.Properties.Resources.Tijera;
                        lblResultado.ForeColor = Color.Yellow;
                        lblResultado.Text = "¡Empate!";
                    
                        break;

                }

                amountGames++;
                updateTexts();


            }
            else
            {
                handleResults();
            }
        }


        private void disableButtonsAndShowReplay()
        {
            btnJugar.Visible = true;
            btnPapel.Enabled = false;
            btnPiedra.Enabled = false;
            btnTijera.Enabled = false;
        }

        private void enableButtonsAndHideReplay()
        {
            btnJugar.Visible = false;
            btnPapel.Enabled = true;
            btnPiedra.Enabled = true;
            btnTijera.Enabled = true;
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if(amountGames != 3)
            {
                btnJugar.Text = "Siguiente ronda";
                enableButtonsAndHideReplay();
                pbxComputadora.Image = piedraPapelTijera.Properties.Resources.pc;
                pbxJugador.Image = piedraPapelTijera.Properties.Resources.profile;
                lblResultado.Text = "";
            }
            else
            {

                handleResults();
                resetPointsAndGameAmount();
            }
        }

        private void updateTexts()
        {
            lblPuntosJugador.Text = winsPlayer.ToString();
            lblPuntosComputadora.Text = winsComputer.ToString();
            lblCantidad.Text = amountGames.ToString();
        }

        private void handleResults()
        {
            if (winsPlayer > winsComputer)
            {
                lblResultado.Text = "Victora jugador";
                lblResultado.ForeColor = Color.Green;
            }
            else if (winsPlayer < winsComputer)
            {
                lblResultado.Text = "Victoria PC";
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                lblResultado.Text = "Empataron";
                lblResultado.ForeColor = Color.Yellow;
            }

            btnJugar.Text = "Jugar nuevo partido";
        }

        private void resetPointsAndGameAmount()
        {
            winsComputer = 0;
            winsPlayer = 0;
            amountGames = 0;
        }
    }
}
