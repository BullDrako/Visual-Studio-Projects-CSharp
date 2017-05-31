using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JuegoDados.Model;
using System.Threading;


namespace JuegoDados
{
    public partial class Form1 : Form
    {

        bool iniciada = false;
        player jugador1 = new player("Nombre", 0);
        player jugador2 = new player("Nombre", 0);
        player jugador3 = new player("Nombre", 0);
        player jugador4 = new player("Nombre", 0);
        int turno, sturno;
        int tiro;
        int ronda;

        public Form1()
        {
            InitializeComponent();
            player3box.ReadOnly = true;
            player4box.ReadOnly = true;
            total1.ReadOnly = true;
            total2.ReadOnly = true;
            total3.ReadOnly = true;
            total4.ReadOnly = true;
            scoredadop1.ReadOnly = true;
            scoredadop2.ReadOnly = true;
            scoredadop3.ReadOnly = true;
            scoredadop4.ReadOnly = true;
            
            textBox15.ReadOnly = true;
            
        }
        public void juego()
        {
            /*          Idea inicial:
             * Pulsas el boton nuevo juego, se crea el dado
             * Se obtiene el valor escrito en cada una de las layers de los jugadores
             * Se pone el contador a 0 de cada player
             * Se resetea todo como al inicio, pero no se puede cambiar el nombre del jugador.
             * Para cambiar nombre del jugador, cambiar antes de iniciar partida o al finalizar una partida.
            */
            if (this.player1box.Text == String.Empty)
            {
                jugador1.setNombre("Jugador 1");
            }
            else
            {
                jugador1.setNombre(this.player1box.Text);
            }
            if (this.player2box.Text == String.Empty)
            {
                jugador2.setNombre("Jugador 2");
            }
            else
            {
                jugador2.setNombre(this.player2box.Text);
            }
            if (this.player3box.Text == String.Empty)
            {
                jugador3.setNombre("Robot3");
            }
            else
            {
                jugador3.setNombre(this.player3box.Text);
            }
            if (this.player4box.Text == String.Empty)
            {
                jugador4.setNombre("Robot4");
            }
            else
            {
                jugador4.setNombre(this.player4box.Text);
            }

            this.player1box.ReadOnly = true;
            this.player2box.ReadOnly = true;

            jugador1.setPuntaje(0);
            jugador2.setPuntaje(0);
            jugador3.setPuntaje(0);
            jugador4.setPuntaje(0);

            total1.Text = "0";
            total2.Text = "0";
            total3.Text = "0";
            total4.Text = "0";

            
            textBox15.Text = "0";

            scoredadop1.Text = String.Empty;
            scoredadop2.Text = String.Empty;
            scoredadop3.Text = String.Empty;
            scoredadop4.Text = String.Empty;

            iniciada = true;
            turno = 1;

            ronda = Convert.ToInt16(this.rondas.Text);

            if (ronda < 1) { ronda = 1; }

            this.rondas.Text = ronda.ToString();

            textBox15.Text = jugador1.getNombre();

            sturno = 1;

            //BOX 5 cuadro para el dado
            this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.KuUolRB;            
            //FIN BOX 5

        }
        public void mostrardado(int cara)
        {
            if (cara == 1)
            {
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara1;

            }
            if (cara == 2)
            {
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara2;
            }
            if (cara == 3)
            {
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara3;
            }
            if (cara == 4)
            {
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara4;
            }
            if (cara == 5)
            {                
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara5;                
            }
            if (cara == 6)
            {                
                this.Box5.BackgroundImage = global::JuegoDados.Properties.Resources.cara6;                
            }


        }

        public void tiradas()
        {
                                    
            if (iniciada == true)
            {
                
                this.rondas.ReadOnly = true;
                dado dado = new dado();
                Thread.Sleep(20);
                dado dado2 = new dado();
                Thread.Sleep(20);
                dado dado3 = new dado();
                Thread.Sleep(20);
                dado dado4 = new dado();
                Thread.Sleep(20);

                this.player1box.Text = jugador1.getNombre();
                this.player2box.Text = jugador2.getNombre();
                this.player3box.Text = jugador3.getNombre();
                this.player4box.Text = jugador4.getNombre();

                //Primero obtienes el numero de rondas que quedan
                ronda = Convert.ToInt16(this.rondas.Text);
                
                //Entramos en bucle hasta que las rondas se acaben.

                if (ronda > 0)
                { 
                    //Jugador 1 es humano
                    if (this.player2box.Text == "Robot2" )
                    {
                        if (turno == 1)
                        {
                            tiro = dado.getNumero();
                            Thread.Sleep(20);

                            this.scoredadop1.Text = tiro.ToString();
                            jugador1.setPuntaje(tiro);
                            this.mostrardado(tiro);

                            this.total1.Text = jugador1.getPuntaje().ToString();

                            sturno = 2;
                            

                        }
                        if (turno == 2)
                        {
                            tiro = dado2.getNumero();
                            Thread.Sleep(20);
                            this.scoredadop2.Text = tiro.ToString();
                            jugador2.setPuntaje(tiro);
                            this.mostrardado(tiro);
                            this.total2.Text = jugador2.getPuntaje().ToString();

                            sturno = 3;
                            turno = 3;
                            
                        } // cerrar if turno 2
                        
                    } // cerrar turno humano j1

                    //Jugador 1 y jugador 2 son humanos
                    else if (this.player2box.Text != "Robot2")
                    {
                        if (turno == 1)
                        {
                            tiro = dado.getNumero();
                            Thread.Sleep(20);
                            this.scoredadop1.Text = tiro.ToString();
                            jugador1.setPuntaje(tiro);
                            this.mostrardado(tiro);
                            this.total1.Text = jugador1.getPuntaje().ToString();

                            sturno = 2;
                            

                        }

                        if (turno == 2)
                        {
                            tiro = dado2.getNumero();
                            Thread.Sleep(20);
                            this.scoredadop2.Text = tiro.ToString();
                            jugador2.setPuntaje(tiro);
                            this.mostrardado(tiro);
                            this.total2.Text = jugador2.getPuntaje().ToString();

                            sturno = 3;                     

                        }

                    }// Cerrar turno 2 humanos
                
                    //Turno de la máquina
                    if (turno == 3 || turno == 4)
                    {
                        tiro = dado3.getNumero();
                        Thread.Sleep(20);
                        this.scoredadop3.Text = tiro.ToString();
                        jugador3.setPuntaje(tiro);
                        this.mostrardado(tiro);
                        this.total3.Text = jugador3.getPuntaje().ToString();
                        

                        tiro = dado4.getNumero();
                        Thread.Sleep(20);
                        this.scoredadop4.Text = tiro.ToString();
                        jugador4.setPuntaje(tiro);
                        this.mostrardado(tiro);
                        this.total4.Text = jugador4.getPuntaje().ToString();
                        
                        sturno = 1;
                        
                        ronda = ronda - 1;
                                                
                    }
                    //El final de los turnos, asignar una ronda menos y el turno del siguiente jugador
                
                        //Determinar si quedan rondas o declarar ganador
                    if (ronda > 0)
                    {
                        
                        this.rondas.Text = ronda.ToString();

                    }
                    else
                    {
                        iniciada = false;
                        this.rondas.ReadOnly = false;
                        this.player1box.ReadOnly = false;
                        this.player2box.ReadOnly = false;
                        this.rondas.Text = ronda.ToString();
                        //declarar ganador unico provisional

                        //Hay que añadir posibilidades like 1+2 win; 1+3 win; 1+4 win....
                        if (Convert.ToInt16(total1.Text) > Convert.ToInt16(total2.Text) && Convert.ToInt16(total1.Text) > Convert.ToInt16(total3.Text) && Convert.ToInt16(total1.Text) > Convert.ToInt16(total4.Text))
                        {
                            scoredadop1.Text = "Ganador!";
                            scoredadop2.Text = "Perdedor!";
                            scoredadop3.Text = "Perdedor!";
                            scoredadop4.Text = "Perdedor!";
                        }
                        else if (Convert.ToInt16(total2.Text) > Convert.ToInt16(total1.Text) && Convert.ToInt16(total2.Text) > Convert.ToInt16(total3.Text) && Convert.ToInt16(total2.Text) > Convert.ToInt16(total4.Text))
                        {
                            scoredadop2.Text = "Ganador!";
                            scoredadop1.Text = "Perdedor!";
                            scoredadop3.Text = "Perdedor!";
                            scoredadop4.Text = "Perdedor!";
                        }
                        else if (Convert.ToInt16(total3.Text) > Convert.ToInt16(total1.Text) && Convert.ToInt16(total3.Text) > Convert.ToInt16(total2.Text) && Convert.ToInt16(total3.Text) > Convert.ToInt16(total4.Text))
                        {
                            scoredadop2.Text = "Perdedor!";
                            scoredadop1.Text = "Perdedor!";
                            scoredadop3.Text = "Ganador!";
                            scoredadop4.Text = "Perdedor!";
                        }
                        else if (Convert.ToInt16(total4.Text) > Convert.ToInt16(total1.Text) && Convert.ToInt16(total4.Text) > Convert.ToInt16(total3.Text) && Convert.ToInt16(total4.Text) > Convert.ToInt16(total2.Text))
                        {
                            scoredadop2.Text = "Perdedor!";
                            scoredadop1.Text = "Perdedor!";
                            scoredadop3.Text = "Perdedor!";
                            scoredadop4.Text = "Ganador!";
                        }
                        else
                        {
                            scoredadop2.Text = "Hubo empate!";
                            scoredadop1.Text = "Hubo empate!";
                            scoredadop3.Text = "Hubo empate!";
                            scoredadop4.Text = "Hubo empate!";
                        }
                    }

                    
                    

                    turno = sturno;
                    
                    // Turno del siguiente jugador

                    if (turno==1){
                        textBox15.Text = jugador1.getNombre();

                    }
                    else if (turno == 2)
                    {
                        textBox15.Text = jugador2.getNombre();
                    }
                    else if (turno == 3)
                    {
                        textBox15.Text = jugador3.getNombre();
                    }
                    else if (turno == 4)
                    {
                        textBox15.Text = jugador4.getNombre();
                    }



                } //cierre del if de las partidas

            } // Si la partida esta iniciada este if se ejecuta

        } // cierre del dado

        private void scoredadop2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void player1box_TextChanged(object sender, EventArgs e)
        {

        }

        private void player2box_TextChanged(object sender, EventArgs e)
        {

        }

        private void player3box_TextChanged(object sender, EventArgs e)
        {

        }

        private void player4box_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void rondas_TextChanged(object sender, EventArgs e)
        {

        }

        private void total1_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoredadop1_TextChanged(object sender, EventArgs e)
        {

        }

        private void total2_TextChanged(object sender, EventArgs e)
        {

        }

        private void total3_TextChanged(object sender, EventArgs e)
        {

        }

        private void total4_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoredadop3_TextChanged(object sender, EventArgs e)
        {

        }

        private void scoredadop4_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void dadobutton_Click(object sender, EventArgs e)
        {
            this.tiradas();
        }

        private void juegobutton_Click(object sender, EventArgs e)
        {
            this.juego();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Box5_Click(object sender, EventArgs e)
        {

        }
    }
}
