<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="ML_Prueba.Vista.Editar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body style="height: 293px; width: 675px; margin-left: 165px; margin-top: 57px">
    <form id="form2" runat="server">
        <div style="width: 444px; margin-left: 100px">
            <div>
            </div>
            Nombre:
            <asp:TextBox ID="txtNombre" runat="server" style="margin-left: 112px" Width="189px"></asp:TextBox>
        </div>
        <div style="width: 445px; margin-left: 100px">
            Tipo de documento:
            <asp:DropDownList ID="dpwCedula" runat="server" style="margin-left: 45px" Width="197px">
                <asp:ListItem>Cedula de Ciudadania</asp:ListItem>
                <asp:ListItem>Tarjeta de Identidad</asp:ListItem>
                <asp:ListItem>Cedula Extranjera</asp:ListItem>
                <asp:ListItem>NIT</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div style="width: 445px; margin-left: 100px">
            Número de documento:
            <asp:TextBox ID="txtCedula" runat="server" style="margin-left: 22px" Width="188px"></asp:TextBox>
        </div>
        <div>
            <div style="width: 446px; margin-left: 100px">
                Dirección de residencia:<asp:TextBox ID="txtDireccion" runat="server" style="margin-left: 25px" Width="188px"></asp:TextBox>
            </div>
            <div style="width: 444px; margin-left: 100px">
                Teléfono:<asp:TextBox ID="txtTelefono" runat="server" style="margin-left: 112px" Width="190px"></asp:TextBox>
            </div>
            <div style="width: 443px; margin-left: 100px">
                Correo:<asp:TextBox ID="txtCorreo" runat="server" style="margin-left: 121px" Width="188px"></asp:TextBox>
            </div>
            <div style="height: 133px">
                
                <asp:Button ID="btnEditar" runat="server" BackColor="#0099FF" BorderStyle="Outset" OnClick="btnEditar_Click" style="margin-left: 449px; margin-top: 32px" Text="Editar" Width="67px" />
                
            </div>
        </div>
    </form>
</body>
</html>
