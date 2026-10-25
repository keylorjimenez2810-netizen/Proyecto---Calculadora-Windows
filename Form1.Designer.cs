namespace Keilor_Jimenez_Proyecto_part_2
{
    partial class Proyecto_Keilor_Jimenez
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label9 = new Label();
            inicio = new Button();
            label8 = new Label();
            Aceptar = new Button();
            puntosj2 = new Label();
            Respuesta = new TextBox();
            label7 = new Label();
            num1 = new Label();
            puntosj1 = new Label();
            resultado = new Label();
            turno = new Label();
            num2 = new Label();
            label3 = new Label();
            dificultad = new Label();
            label2 = new Label();
            op = new Label();
            vidas = new Label();
            modojuego = new ComboBox();
            label1 = new Label();
            aciertos = new Label();
            errores = new Label();
            label5 = new Label();
            label6 = new Label();
            n1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(inicio);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Aceptar);
            panel1.Controls.Add(puntosj2);
            panel1.Controls.Add(Respuesta);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(num1);
            panel1.Controls.Add(puntosj1);
            panel1.Controls.Add(resultado);
            panel1.Controls.Add(turno);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dificultad);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(op);
            panel1.Controls.Add(vidas);
            panel1.Controls.Add(modojuego);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(aciertos);
            panel1.Controls.Add(errores);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(48, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 333);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(532, 245);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 21;
            label9.Text = "Puntos J2";
            // 
            // inicio
            // 
            inicio.Location = new Point(16, 58);
            inicio.Name = "inicio";
            inicio.Size = new Size(93, 23);
            inicio.TabIndex = 16;
            inicio.Text = "Iniciar";
            inicio.UseVisualStyleBackColor = true;
            inicio.Click += inicio_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(465, 245);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 20;
            label8.Text = "Puntos J1";
            // 
            // Aceptar
            // 
            Aceptar.Location = new Point(16, 294);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(75, 23);
            Aceptar.TabIndex = 8;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            Aceptar.Click += Aceptar_Click;
            // 
            // puntosj2
            // 
            puntosj2.AutoSize = true;
            puntosj2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puntosj2.Location = new Point(536, 272);
            puntosj2.Name = "puntosj2";
            puntosj2.Size = new Size(13, 15);
            puntosj2.TabIndex = 18;
            puntosj2.Text = "0";
            // 
            // Respuesta
            // 
            Respuesta.Location = new Point(16, 249);
            Respuesta.Name = "Respuesta";
            Respuesta.Size = new Size(100, 23);
            Respuesta.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(465, 192);
            label7.Name = "label7";
            label7.Size = new Size(92, 15);
            label7.TabIndex = 19;
            label7.Text = "Modo de Juego";
            // 
            // num1
            // 
            num1.BorderStyle = BorderStyle.FixedSingle;
            num1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num1.Location = new Point(16, 187);
            num1.Name = "num1";
            num1.Size = new Size(57, 39);
            num1.TabIndex = 6;
            num1.Text = "0";
            // 
            // puntosj1
            // 
            puntosj1.AutoSize = true;
            puntosj1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puntosj1.Location = new Point(465, 272);
            puntosj1.Name = "puntosj1";
            puntosj1.Size = new Size(13, 15);
            puntosj1.TabIndex = 17;
            puntosj1.Text = "0";
            // 
            // resultado
            // 
            resultado.BorderStyle = BorderStyle.FixedSingle;
            resultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultado.Location = new Point(293, 187);
            resultado.Name = "resultado";
            resultado.Size = new Size(57, 39);
            resultado.TabIndex = 4;
            resultado.Text = "= ?";
            resultado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turno
            // 
            turno.AutoSize = true;
            turno.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            turno.Location = new Point(465, 218);
            turno.Name = "turno";
            turno.Size = new Size(13, 15);
            turno.TabIndex = 16;
            turno.Text = "0";
            // 
            // num2
            // 
            num2.BorderStyle = BorderStyle.FixedSingle;
            num2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            num2.Location = new Point(198, 187);
            num2.Name = "num2";
            num2.Size = new Size(57, 39);
            num2.TabIndex = 3;
            num2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(465, 23);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 16;
            label3.Text = "Vidas Restantes";
            // 
            // dificultad
            // 
            dificultad.Location = new Point(465, 159);
            dificultad.Name = "dificultad";
            dificultad.Size = new Size(35, 23);
            dificultad.TabIndex = 14;
            dificultad.Text = "1";
            dificultad.Click += dificultad_Click;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 116);
            label2.Name = "label2";
            label2.Size = new Size(334, 45);
            label2.TabIndex = 2;
            label2.Text = "Digite La operacion:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // op
            // 
            op.BorderStyle = BorderStyle.FixedSingle;
            op.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            op.Location = new Point(99, 187);
            op.Name = "op";
            op.Size = new Size(58, 39);
            op.TabIndex = 1;
            // 
            // vidas
            // 
            vidas.AutoSize = true;
            vidas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vidas.Location = new Point(465, 47);
            vidas.Name = "vidas";
            vidas.Size = new Size(13, 15);
            vidas.TabIndex = 15;
            vidas.Text = "0";
            // 
            // modojuego
            // 
            modojuego.FormattingEnabled = true;
            modojuego.Items.AddRange(new object[] { "1", "2" });
            modojuego.Location = new Point(16, 15);
            modojuego.Name = "modojuego";
            modojuego.Size = new Size(160, 23);
            modojuego.TabIndex = 15;
            modojuego.Text = "Cantidad de Jugadores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(465, 136);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 13;
            label1.Text = "Nivel de Dificultad";
            // 
            // aciertos
            // 
            aciertos.Location = new Point(532, 102);
            aciertos.Name = "aciertos";
            aciertos.Size = new Size(30, 23);
            aciertos.TabIndex = 8;
            aciertos.Text = "0";
            // 
            // errores
            // 
            errores.Location = new Point(465, 102);
            errores.Name = "errores";
            errores.Size = new Size(35, 23);
            errores.TabIndex = 10;
            errores.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(465, 76);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 6;
            label5.Text = "Errores";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(532, 76);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 11;
            label6.Text = "Aciertos";
            // 
            // n1
            // 
            n1.BorderStyle = BorderStyle.FixedSingle;
            n1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            n1.Location = new Point(48, 23);
            n1.Name = "n1";
            n1.Size = new Size(608, 33);
            n1.TabIndex = 5;
            n1.Text = "Proyecto - Juego Arimetica";
            n1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Proyecto_Keilor_Jimenez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(671, 429);
            Controls.Add(n1);
            Controls.Add(panel1);
            Name = "Proyecto_Keilor_Jimenez";
            Text = "Juego de Arimetica";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label aciertos;
        private Label n1;
        private Label label2;
        private Label op;
        private Label resultado;
        private Label num2;
        private Label label5;
        private Label num1;
        private Button Aceptar;
        private TextBox Respuesta;
        private Label label6;
        private Label errores;
        private Label label1;
        private Label dificultad;
        private ComboBox modojuego;
        private Button inicio;
        private Label puntosj2;
        private Label vidas;
        private Label turno;
        private Label puntosj1;
        private Label label3;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
