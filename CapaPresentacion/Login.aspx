<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CapaPresentacion.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Acceso al Sistema de Clinica</title>
    <!-- Latest compiled and minified CSS -->
<link  href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" rel="stylesheet" />
<link  href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.1.0/css/font-awesome.min.css"  type="text/css" rel="stylesheet" />

<link href="css/AdminLTE.css" type="text/css" rel="stylesheet"/>

</head>
<body class="bg-black">

    <div class="form-box" id="login-box">
        <div class="header">Iniciar Sesion</div>

        <form id="form1" runat="server">
            <div class="media-body bg-gray" >

                    <div style="margin-top:20px;">

                         <div class="form-group" style="padding:0px 10px 0px 10px">
                          <asp:TextBox ID="txtUsuario" CssClass="form-control"  placeholder="Ingrese Usuario..." runat="server"></asp:TextBox>
                       </div>

                       <div class="form-group" style="padding:0px 10px 0px 10px">
                          <asp:TextBox ID="txtPassword" CssClass="form-control"  placeholder="Ingrese Clave..." runat="server"></asp:TextBox>
                       </div>

                        <div class="footer">
                           <asp:Button ID="btnIngresar" runat="server" Text="Iniciar Sesion" CssClass="btn btn-primary" OnClick="btnIngresar_Click"/>
                        </div>



                    </div>
                       
                   
                </div>
               
                
            </div>
          
        </form>

    </div>

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
         
</body>
</html>
