namespace Keilor_Jimenez_Proyecto_part_2
{
    public partial class Proyecto_Keilor_Jimenez : Form
    {
        float a = 0, b = 0, total = 0;
        float numero;
        int ope = 0, limite = 11;
        char operador;
        int modo = 0, vidasRestantes = 3, jugadorActual = 1, puntosJugador1 = 0, puntosJugador2 = 0, turnosJugados = 0, maxTurnos = 10;
        bool juegoActivo = false;

        public Proyecto_Keilor_Jimenez()
        {
            InitializeComponent();
        }

        private void seleccion_operacion()
        {
            a = Random.Shared.Next(1, limite);
            b = Random.Shared.Next(1, limite);
            ope = Random.Shared.Next(1, 5);
            switch (ope)
            {
                case 1:
                    operador = '+';
                    total = a + b;
                    break;
                case 2:
                    operador = '-';
                    total = a - b;
                    break;
                case 3:
                    operador = '*';
                    total = a * b;
                    break;
                case 4:
                    operador = '/';
                    total = a / b;
                    break;
                default:
                    operador = '?';
                    break;
            }

            num1.Text = a.ToString();
            num2.Text = b.ToString();
            op.Text = operador.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            seleccion_operacion();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (juegoActivo == false)
            {
                MessageBox.Show("Inicie una partida.");
                return;
            }

            if (string.IsNullOrWhiteSpace(Respuesta.Text))
            {
                MessageBox.Show("Por favor ingrese una respuesta.");
                return;
            }

            if (!float.TryParse(Respuesta.Text, out numero))
            {
                MessageBox.Show("Por favor ingrese solamente números.");
                return;
            }

            if (modo == 1)
            {
                if (numero.Equals(total))
                {
                    MessageBox.Show("Correcto");
                    resultado.BackColor = Color.Green;
                    aciertos.Text = (int.Parse(aciertos.Text) + 1).ToString();
                    dificultad_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                    resultado.BackColor = Color.Red;
                    errores.Text = (int.Parse(errores.Text) + 1).ToString();

                    vidasRestantes--;
                    vidas.Text = vidasRestantes.ToString();

                    if (vidasRestantes == 0)
                    {
                        MessageBox.Show("¡Juego terminado! Te quedaste sin vidas.");
                        juegoActivo = false;
                        return;
                    }
                }
            }

            else if (modo == 2)
            {
                if (numero.Equals(total))
                {
                    MessageBox.Show("Correcto");
                    resultado.BackColor = Color.Green;

                    if (jugadorActual == 1)
                    {
                        puntosJugador1++;
                        puntosj1.Text = puntosJugador1.ToString();
                    }
                    else
                    {
                        puntosJugador2++;
                        puntosj2.Text = puntosJugador2.ToString();
                    }

                    aciertos.Text = (int.Parse(aciertos.Text) + 1).ToString();
                    dificultad_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Incorrecto");
                    resultado.BackColor = Color.Red;
                    errores.Text = (int.Parse(errores.Text) + 1).ToString();

                    vidasRestantes--;
                    vidas.Text = vidasRestantes.ToString();

                    if (vidasRestantes == 0)
                    {
                        MessageBox.Show("¡Juego terminado! Te quedaste sin vidas.");
                        juegoActivo = false;
                        return;
                    }
                }

                turnosJugados++;

                if (turnosJugados == maxTurnos)
                {
                    finalizar_partida();
                    juegoActivo = false;
                    return;
                }

                if (jugadorActual == 1)
                {
                    jugadorActual = 2;
                }
                else
                {
                    jugadorActual = 1;
                }

                turno.Text = "Turno: Jugador " + jugadorActual;
            }

            Respuesta.Clear();
            seleccion_operacion();
        }

        private void dificultad_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(aciertos.Text);

            if (cantidad == 3)
            {
                limite = 21;
                MessageBox.Show("¡Felicidades! Nivel 2 desbloqueado.");
                dificultad.Text = "2";
            }
            else if (cantidad == 6)
            {
                limite = 51;
                MessageBox.Show("¡Felicidades! Nivel 3 desbloqueado.");
                dificultad.Text = "3";
            }
            else if (cantidad == 9)
            {
                limite = 101;
                MessageBox.Show("¡Felicidades! Nivel 4 desbloqueado.");
                dificultad.Text = "4";
            }
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            if (modojuego.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una modalidad de juego.");
                return;
            }

            modo = modojuego.SelectedIndex + 1;
            juegoActivo = true;

            aciertos.Text = "0";
            errores.Text = "0";
            dificultad.Text = "1";
            vidas.Text = "3";
            puntosj1.Text = "0";
            puntosj2.Text = "0";
            Respuesta.Clear();

            if (modo == 1)
            {
                turno.Text = "Modo individual";
            }
            else
            {
                turno.Text = "Turno: Jugador 1";
            }

            seleccion_operacion();
        }
        private void finalizar_partida()
        {
            if (puntosJugador1 > puntosJugador2)
            {
                MessageBox.Show("¡Ganó el Jugador 1!");
            }
            else if (puntosJugador2 > puntosJugador1)
            {
                MessageBox.Show("¡Ganó el Jugador 2!");
            }
            else
            {
                MessageBox.Show("¡La partida terminó en empate!");
            }
        }
    }
}
