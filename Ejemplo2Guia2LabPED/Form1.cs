using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejemplo2Guia2LabPED
{
    public partial class Form1 : Form
    {
        public Button boton1; //declaramos un elemento llamado boton1 de tipo Button

        public Form1()
        {
            boton1 = new Button(); //se creara el objeto en el formulario
            boton1.Size = new Size(80, 40); //utilizando la estructura Size se le da dimension de 80x40
            boton1.Location = new Point(30, 30); //la ubicacion inicial, el extremo superior izquierdo comienza en el pixel X=30 y Y=30, recuerde que el origen es la esquina superior izquierda
            boton1.Text = "Presione aqui"; //asignamos un valor a su propiedad Text

            this.Controls.Add(boton1); //se agrega al listado de controles del formulario
            boton1.Click += new EventHandler(boton1_Click); //al pulsar el objeto se le asigna el evento boton1_Click
        }

        private void boton1_Click(object sender, EventArgs e) //Evento click del boton1
        {
            MessageBox.Show("Se ha creado un boton por codigo"); //mostrará un mensaje generico
        }
    }
}
