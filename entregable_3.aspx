<%@Page Language="C#" src="pagina.aspx.cs" Inherits="MiPagina.Actividad3" %>

<!DOCTYPE html>
<html lang="en">
  <head runat="server">
    <title>Covevaluacion 3 Jorge Luis Peña Real</title>
    <link
      rel="stylesheet"
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
    <script runat="server"></script>
  </head>

  <body>
    <h1 class="text-danger text-center">Hola</h1>

    <form runat="server">
      <asp:Button
        ID="btnclick"
        runat="server"
        Text="Click"
        onclick="btnclick_Click"
        class="btn btn-primary"
      />
      <asp:Label
        ID="ASPxLabel2"
        runat="server"
        Text="Color"
        ClientInstanceName="label"
      />
    </form>
    <div class="container" ID="DVD" runat="server"></div>
  </body>
</html>
