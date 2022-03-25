<%@Page AutoEventWireup="true" Language="C#" src="pagina.aspx.cs"
Inherits="MiPagina.Actividad3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <title>Entregable 3 Jorge Luis Peña Real</title>
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
    <script runat="server"></script>
  </head>

  <body>
    <form runat="server">
      <asp:Label
        ID="ASPxLabel2"
        runat="server"
        Text=""
        ClientInstanceName="label"
      />

      <asp:Label ID="lblmessage" runat="server"></asp:Label>
      <asp:Button
        ID="btnclick"
        runat="server"
        Text="Calcular calificaciones"
        onclick="btnclick_Click"
        class="btn btn-primary"
      />
      <br />
      <br />
      <h1 class="text-black text-center">Estadisticas</h1>
      <asp:Label ID="lblResultados" runat="server"></asp:Label>
    </form>
  </body>
</html>
