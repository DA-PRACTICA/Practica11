<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cookies2.aspx.cs" Inherits="Practica11_Ejercicio2.Cookies1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="background-color: aqua">
         <br />
        <br />
        <h1>Cookie 2</h1>
        <br />
        <br />
    </div>
    <div style="background-color:khaki">
        <br />
        <h3>Elija los cursos que lleva en su semestre</h3>
        <br />
    </div>
    
    <asp:CheckBox ID="PC" runat="server" Text="Pensamiento Computacional" />
    <br />
    <asp:CheckBox ID="LP2" runat="server" Text="Lenguajes de Programación II" />
    <br />
    <asp:CheckBox ID="LP3" runat="server" Text="Lenguajes de Programación III" />
    <br />
    <asp:CheckBox ID="CR2" runat="server" Text="Computación en Red II" />
    <br />
    <asp:CheckBox ID="TM" runat="server" Text="Tecnologías Móviles" />
    <br />
    <asp:CheckBox ID="GP" runat="server" Text="Gestión de Proyectos" />
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit"/>
    <div style="background-color:khaki">
        <br />
        <h3>Los cursos que lleva en su semestre son: </h3>
        <br />
    </div>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>

    </p>
    </form>
</body>
</html>
