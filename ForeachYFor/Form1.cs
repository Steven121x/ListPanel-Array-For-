using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace ForeachYFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Miembros()
        {
            Miembros[] MiembrosS = new Miembros[5];
            MiembrosS[0] = new Miembros("Juan", 40);
            MiembrosS[1] = new Miembros("Pedro", 18);
            MiembrosS[2] = new Miembros("Edu", 20);
            MiembrosS[3] = new Miembros("Eloy", 23);
            MiembrosS[4] = new Miembros("Evan", 25);
            //NOTA:
            //Hacer limite de ver Array
            string VariablePendiente;
            
            for (int i = 0; i < MiembrosS.Length; i++)
            {
                if (listBox1.Items.ToString() != MiembrosS[i].getMembers())
                {
                    listBox1.Items.Add(MiembrosS[i].getMembers());
                }
                else
                {

                    MessageBox.Show("Ya hay texto en la listbox");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Miembros();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Added.Text.ToString());
        }

        private void Play_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer PL = new SpeechSynthesizer();
            PL.Volume = trackBar1.Value;
            PL.Rate = trackBar2.Value;
            PL.Speak(Added.Text.ToString());                                                                                                                              
        }
    }


    class Miembros
    {
        public Miembros(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        private string nombre;
        private int edad;

        public string getMembers()
        {
            return "Nombre: " + nombre + " | Edad: " + edad;
        }

    }
}
