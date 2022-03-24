using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace MiPagina
{
    public class Actividad3 : Page
    {
        public void btnclick_Click(object sender, EventArgs e)
        {


            string container = "<div>";


            container += "</div>";

        }
    }

    public class Alumno
    {
        private String boleta = "";
        private String nombre = "";
        private int calificacion = 0;

        public Alumno()
        {

        }
        public Alumno(String boleta, String nombre)
        {
            this.nombre = nombre;
            this.boleta = boleta;
        }
        public String Nombre
        {
            get { return nombre; }
            set { value = nombre; }
        }
        public String Boleta
        {
            get { return boleta; }
            set { value = boleta; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { value = calificacion; }
        }
    }
    public class Estadisticas
    {
        private List<Alumno> alumnos = new List<Alumno>();

        public Estadisticas()
        {
            this.alumnos.Add(new Alumno("2019602500", "a"));
            this.alumnos.Add(new Alumno("2019602500", "b"));
            this.alumnos.Add(new Alumno("2019602500", "c"));
            this.alumnos.Add(new Alumno("2019602500", "d"));
            this.alumnos.Add(new Alumno("2019602500", "e"));
            this.alumnos.Add(new Alumno("2019602500", "f"));
            this.alumnos.Add(new Alumno("2019602500", "g"));
            this.alumnos.Add(new Alumno("2019602500", "h"));
            this.alumnos.Add(new Alumno("2019602500", "i"));
            this.alumnos.Add(new Alumno("2019602500", "j"));
        }

    }

}