using System;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace MiPagina
{
    public class Actividad3 : Page
    {
        public Estadisticas estadisticas = new Estadisticas();
        public Label ASPxLabel2;
        protected void Page_Init(object sender, EventArgs e)
        {
            String tabla = @"<table class='table table-striped table-dark'>
        <thead>
            <tr>
              <th scope='col'>#</th>
              <th scope='col'>Boleta</th>
              <th scope='col'>Nombre</th>
              <th scope='col'>Calificacion</th>
            </tr>
        </thead>

          <tbody>
 ";
            var i = 0;
            foreach (Alumno alumno in estadisticas.alumnos)
            {
                tabla += @"
                    <tr>
                        <th scope='row'>" + (i + 1) + @"</th>
                        <td>" + alumno.Boleta + @"</td>
                        <td>" + alumno.Nombre + @"</td>
                        <td>@fat</td>
                    </tr>
                ";
                i++;

            }

            tabla += "   </tbody>  </table>";
            ASPxLabel2.Text += tabla;
        }
        public void btnclick_Click(object sender, EventArgs e)
        {


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
        public List<Alumno> alumnos = new List<Alumno>();

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