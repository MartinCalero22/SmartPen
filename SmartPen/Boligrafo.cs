using System;
using System.Collections.Generic;
using System.Text;

namespace SmartPen
{
    internal class Boligrafo
    {
        // Atributos
        public int capacidadTintaMaxima;
        public int grosorPunta;
        public string color;
        public int cantidadTinta;

        //Constructor

        public Boligrafo(string color, int grosorPunta)
        {
            this.capacidadTintaMaxima = 100;
            this.cantidadTinta = 80;
            this.color = color;
            this.grosorPunta = grosorPunta;
        }

        //Metodo

        public string Escribir(string texto)
        {
            int tintaGastada;
            if (this.grosorPunta > 10)
            {
                tintaGastada = texto.Length * 2;

            }
            else
            {
                tintaGastada = texto.Length;
            }    

            if (this.cantidadTinta >= tintaGastada)
            {
                this.cantidadTinta = this.cantidadTinta - tintaGastada;
                return texto;
            }
            else
            {
                return "ERROR!!! No alcanza la tinta.";
            }

        }

        public string RecargarTinta(int tinta)
        {
            while (tinta <= 0 || this.cantidadTinta + tinta > this.capacidadTintaMaxima)
            {
                if (tinta <= 0)
                {
                    Console.WriteLine("Error!!! Tiene que ingresar un valor positivo a recargar.");
                }
                else
                {
                    Console.WriteLine("Error!!! La cantidad seleccionada supera la capacidad maxima. (100)");
                }

                Console.WriteLine("Ingrese nuevamente la cantidad de tinta a recargar: ");

                tinta = int.Parse(Console.ReadLine());
            }

            this.cantidadTinta = this.cantidadTinta + tinta;

            return "Lapicera Recargada";

        }

        public string INFO()
        {
            return $"La capacidad es de: {capacidadTintaMaxima}, la cantidad actual es: {cantidadTinta}, el color de su Bolifrago es {color}, su grosor es {grosorPunta}";
        }



    }
}
