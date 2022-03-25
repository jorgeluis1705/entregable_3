using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;

using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

using System.Xml.Linq;

namespace MiPagina
{
    public class Actividad3 : Page
    {
        public Estadisticas estadisticas = new Estadisticas();
        public Label ASPxLabel2;
        public Label lblmessage;


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
                        <td> 

                            <select class='custom-select' id='ddlColors' name='Fruit'     >
                                <option value='0'>0</option>
                                <option value='1'>1</option>
                                <option value='2'>2</option>
                                <option value='3'>3</option>
                                <option value='4'>4</option>
                                <option value='5'>5</option>
                                <option value='6' selected>6</option>
                                <option value='7'>7</option>
                                <option value='8'>8</option>
                                <option value='9'>9</option>
                                <option value='10'>10</option>
                            </select>
                        </td>
                    </tr>
                ";
                i++;

            }

            tabla += @"   </tbody>  </table>  ";
            ASPxLabel2.Text += tabla;
        }
        public void btnclick_Click(object sender, EventArgs e)
        {
            var califiaciones = Request.Form["Fruit"];
            string[] arrayValues = califiaciones.Split(',');

            Response.Write("<br/>");
            int index = 0;
            foreach (var calif in arrayValues)
            {
                estadisticas.alumnos[index].Calificacion = int.Parse(calif);
                Response.Write(estadisticas.alumnos[index].Calificacion + " " + estadisticas.alumnos[index].Nombre + "<br/>");

                index += 1;
            }



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
            set { nombre = value; }
        }
        public String Boleta
        {
            get { return boleta; }
            set { boleta = value; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
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