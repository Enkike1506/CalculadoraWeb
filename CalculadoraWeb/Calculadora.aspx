<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="CalculadoraWeb.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Calculadora Web</title>
    <style>
        body{
            background-color: lightsalmon;
            background-image:url();
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> CALCULADORA WEB </h1>
            <h2> Mi primera calculadora </h2>

            <label> Numero 1:
            <br />
            <asp:TextBox ID="tvalor1" type="number" runat="server" Width="240px"></asp:TextBox>
            <br />
            <br />
            Numero 2: 
            <br />
            <asp:TextBox ID="tvalor2" type="number" runat="server" Width="240px"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lresultado" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Height="61px" OnClick="Button1_Click" Text="Calcular" Width="161px" />
            <br />
            <br />
            <asp:CheckBox ID="csuma" Text="Suma" runat="server" />
            <br />
            <asp:CheckBox ID="cresta" Text="Resta" runat="server" />
            <br />
            <asp:CheckBox ID="cmultipicacion" Text="Multiplicación" runat="server" />
            <br />
            <asp:CheckBox ID="cdivision" Text="División" runat="server" />
            <br />
            <br />
            <asp:RadioButton ID="rsuma" Text="Suma" runat="server" GroupName="operacion"/>
            <br />
            <asp:RadioButton ID="rresta" Text="Resta" runat="server" GroupName="operacion"/>
            <br />
            <asp:RadioButton ID="rmultiplicacion" Text="Multiplicación" runat="server" GroupName="operacion"/>
            <br />
            <asp:RadioButton ID="rdivision" Text="División" runat="server" GroupName="operacion"/>
            <br />
            <br />
            <asp:DropDownList ID="dlista" runat="server" Width="143px">
                <asp:ListItem>Suma</asp:ListItem>
                <asp:ListItem>Resta</asp:ListItem>
                <asp:ListItem>Multiplicación</asp:ListItem>
                <asp:ListItem>División</asp:ListItem>
            </asp:DropDownList>
            </label>
        </div>
    </form>
</body>
</html>
