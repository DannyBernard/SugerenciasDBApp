﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CSugerencia.aspx.cs" Inherits="RegistroconAzure.Consulta.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	 <div class="panel panel-primary">
        <div class="panel-heading">Consulta de Sugerencias</div>
        <div class="panel-body">

            <div >
                <div class="col-md-2">
                    <asp:DropDownList ID="BuscarPorDropDownList" runat="server" CssClass="form-control input-sm" >
                        <asp:ListItem>Todos</asp:ListItem>
                        <asp:ListItem>SugerenciaId</asp:ListItem>
                        <asp:ListItem>Descripcion</asp:ListItem>
                         <asp:ListItem>Fecha</asp:ListItem>
                    </asp:DropDownList>
                </div>

                  <%--Criterio--%>
                <div class="col-md-6">
                    <asp:TextBox ID="FiltroTextBox" runat="server" CssClass="form-control input-sm"></asp:TextBox>
                </div>
                <div class="col-md-4">
                    <asp:Button ID="BuscarButton" runat="server" CssClass="btn btn-success input-sm" Text="Buscar" OnClick="BuscarButton_Click"  />
                </div>
            </div>
                 <%--Selercionar solo por fecha--%>
                    <div class="input-group mb-3">
                        <div class="input-group-prepend">
                            <asp:CheckBox AutoPostBack="true" Checked="true"  ID="fechaCheckBox" runat="server" Text="Filtrar solo por fecha" />
                        </div>
                    </div>

            <%--Rango fecha--%>
            <div class="form-row justify-content-center">
                <div class="form-group col-md-2">
                    <asp:Label Text="Desde" runat="server" />
                    <asp:TextBox ID="DesdeTextBox" CssClass="form-control input-group" TextMode="Date" runat="server" />
                </div>
                <div class="form-group col-md-2">
                    <asp:Label Text="Hasta" runat="server" />
                    <asp:TextBox ID="HastaTextBox" CssClass="form-control input-group" TextMode="Date" runat="server" />
                </div>
            </div>
         
            <%--GRID--%>
            <div class="col-md-12">
                <asp:GridView ID="DatosGridView"
                    runat="server"
                    CssClass="table table-condensed table-bordered table-responsive"
                    CellPadding="4" ForeColor="#333333" GridLines="None">

                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:HyperLinkField ControlStyle-ForeColor="blue"
                            DataNavigateUrlFields="SugerenciaId"
                           
                            DataNavigateUrlFormatString="~Registros/RegistrosSugerencias.aspx?Id={0}"
                            Text="Editar"></asp:HyperLinkField>
                    </Columns>
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <RowStyle BackColor="#EFF3FB" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
