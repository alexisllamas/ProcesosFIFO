using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas_j3j3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdIniciar_Click(object sender, EventArgs e)
        {
            iniciarSimulación20();
            iniciarSimulación40();
        }

        private void iniciarSimulación20()
        {
            short prob = 20;
            int ciclosVacios = 0;
            int procesosMaximos = 0;
            Random ran = new Random();
            Queue cola = new Queue();

            for (int i = 0; i < 200; i++)
            {
                if (ran.Next(1, 101) <= prob)
                    cola.Enqueue(new Proceso());

                if (cola.Count > 0)
                {
                    Proceso hola = (Proceso)cola.Peek();
                    hola.Ciclos--;

                    if (hola.Ciclos < 1)
                        cola.Dequeue();

                    if (cola.Count > procesosMaximos)
                        procesosMaximos = cola.Count;
                }
                else
                    ciclosVacios++;

            }
            txtProPen.Text = cola.Count.ToString();

            int ciclosPendientes = 0; 
            foreach (Proceso pro in cola)
                ciclosPendientes += pro.Ciclos;

            txtCiclPen.Text = ciclosPendientes.ToString();
            txtCiclosVacios.Text = ciclosVacios.ToString();
            txtNumProMax.Text = procesosMaximos.ToString();

        }

        private void iniciarSimulación40()
        {
            short prob = 40;
            int ciclosVacios = 0;
            int procesosMaximos = 0;
            Random ran = new Random();
            Queue cola = new Queue();

            for (int i = 0; i < 200; i++)
            {
                int num = ran.Next(1, 101);

                if (num <= prob)
                    cola.Enqueue(new Proceso());

                if (cola.Count > 0)
                {
                    Proceso hola = (Proceso)cola.Peek();
                    hola.Ciclos--;

                    if (hola.Ciclos < 1)
                        cola.Dequeue();
                    if (cola.Count > procesosMaximos)
                        procesosMaximos = cola.Count;
                }
                else
                    ciclosVacios++;
            }
            txtProPen40.Text = cola.Count.ToString();

            int ciclosPendientes = 0;
            foreach (Proceso pro in cola)
                ciclosPendientes += pro.Ciclos;

            txtCicPen40.Text = ciclosPendientes.ToString();
            txtCiclosVacios40.Text = ciclosVacios.ToString();
            txtNumPro40.Text = procesosMaximos.ToString();
        }
    }
}
