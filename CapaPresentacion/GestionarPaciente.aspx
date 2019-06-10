﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="GestionarPaciente.aspx.cs" Inherits="CapaPresentacion.frmGestionarPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentBody" runat="server">
    <section class="content-header">
        <h1 style="text-align:center">REGISTRO DE PACIENTES</h1
           
    </section>
   <section class="content">
       <div class ="row">
           <div class="col-md-6">
               <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>DOCUMENTO DE IDENTIDAD</label>
                            <asp:TextBox ID="txtNroDocumento" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>

                         <div class="form-group">

                            <label>NOMBRES</label>
                            <asp:TextBox ID="txtNombres" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>

                          <div class="form-group">

                            <label>APELLIDO PATERNO</label>
                            <asp:TextBox ID="txtApPaterno" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>


                          <div class="form-group">

                            <label>APELLIDO MATERNO</label>
                            <asp:TextBox ID="txtApaterno" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>


                    </div>
                   



               </div>
           </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">

                        <div class="form-group">
                            <label>SEXO</label>
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                                <asp:ListItem>Masculino</asp:ListItem>
                                <asp:ListItem>Femenino</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <div class="form-group">
                            <label>EDAD</label>
                     
                            <asp:TextBox ID="txtEdad" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>


                        <div class="form-group">
                            <label>TELÉFONO</label>
                    
                            <asp:TextBox ID="txtTelefono" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                            
                        <div class="form-group">
                            <label>DIRECCIÓN</label>
                     
                            <asp:TextBox ID="txtDireccion" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>



                    
                    </div>
               </div>
           </div>

       </div>

       <div class="row">
           <div align="center">
               <table>
                   <tr>
                       <td>
                           <asp:Button ID="btnRegistrar" runat="server" CssClass="btn btn-primary" Width="200" Text="Registrar"/>
                       </td>

                       <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>

                        <td>
                           <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger"  Width="200" Text="Cancelar"/>
                       </td>
                   </tr>
               </table>
           </div>
       </div>

   </section>
</asp:Content>