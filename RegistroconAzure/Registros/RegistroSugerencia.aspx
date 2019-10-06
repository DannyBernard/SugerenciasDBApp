<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroSugerencia.aspx.cs" Inherits="RegistroconAzure.Registros.RegistroPersona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class=" justify-content-cente">
		<div class="panel panel-primary ">

			<div class="card-header text-uppercase text-center">Registro con Azure Para Sugerencias</div>
			<article class="card-body">

				  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<div class=" form-group col-md-2">

					<asp:Label ID="Label1" for="ID" CssClass="col-md-3 control-label input-sm" runat="server" Text="ID:"></asp:Label>
					<asp:TextBox ID="IDTextBox" CssClass="form-control input-sm" runat="server"></asp:TextBox>
					&nbsp;&nbsp;
							<div class="col-lg-1 p-0">
								<asp:Button ID="Button1" CssClass="btn btn-outline-info mt-4" runat="server" Text="Buscar" OnClick="Button1_Click" />

							</div>
				</div>
				<div class=" form-group col-md-3">
					<asp:Label ID="Label2" for="Nombre" CssClass="col-md-3 control-label input-sm" runat="server" Text="Fecha"></asp:Label>
					<div class="col=md-8">
						<asp:TextBox ID="FechaTextBox" type="date" CssClass="form-control input-sm" runat="server"></asp:TextBox>
					</div>
				</div>
				<div class=" form-group col-md-3">
					<asp:Label ID="Label3" for="Nombre" CssClass="col-md-3 control-label input-sm" runat="server" Text="Descripcion:"></asp:Label>
					<div class="col=md-8">
						<asp:TextBox ID="DescripcionTextBox" CssClass="form-control input-sm" TextMode="MultiLine" runat="server"></asp:TextBox>
						<br />
						<div class="text-center">
							<div class="form-group" style="display: inline-block">
								<asp:Button Text="Nuevo" class="btn btn-primary btn-sm" runat="server" ID="nuevoButton" OnClick="nuevoButton_Click" />
								<asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="guadarButton" OnClick="guadarButton_Click" />
								<asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="eliminarButton" OnClick="eliminarButton_Click" />
							</div>
						</div>
					</div>

				</div>
			</article>
		</div>

	</div>

</asp:Content>
