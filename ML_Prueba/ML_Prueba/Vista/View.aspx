﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ML_Prueba.Vista.View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 357px">
    <form id="form1" runat="server">
        <div style="height: 22px; margin-left: 100px">
        </div>
        <div style="height: 31px; margin-left: 100px; margin-bottom: 0px">
            Contenido de la tabla:<asp:Button ID="btnNew" runat="server" BackColor="#FF3300" BorderStyle="Outset" OnClick="Button1_Click" style="margin-left: 384px" Text="Nuevo Registro" />
        </div>
        <div style="margin-left: 100px">
            <asp:GridView ID="grilla" runat="server" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" Height="269px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="615px" OnRowDeleting="grilla_RowDeleting" OnRowEditing="grilla_RowEditing" OnRowUpdating="grilla_RowUpdating">
             
            </asp:GridView>
        </div>
    </form>
</body>
</html>
