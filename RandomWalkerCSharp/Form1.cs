using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWalkerCSharp
{
    public partial class Form1 : Form
    {
        Graphics canvas;    //  Creacion del Canvas
        int x = 0, y = 0, size = 50, direccion;
        Random rnd = new Random();  //  Variable de los números aleaotios
        Pen Lapiz = new Pen(Color.White);   //  Creación del lapiz

        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            draw.Start();   //  Inicia el Timer
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            draw.Stop();    //  Para el timer
        }

        private void draw_Tick(object sender, EventArgs e)
        {
            direccion = (int)rnd.Next(10);  //  Generación del numero aleatorio

            if (direccion < 5)
                canvas.DrawLine(Lapiz, x, y, x + size, y + size);   //  Figura "\"
            else
                canvas.DrawLine(Lapiz, x + size, y, x, y + size);   //  Figura "/"

            x = x + size;

            if (x >= this.Width)
            {
                y = y + size;
                x = 0;
            }

            if (y > this.Height)
                draw.Stop();

        }

        private void Setup()    //  Función de Configuración
        {
            canvas = pb1.CreateGraphics();
        }

    
        
    }
}
