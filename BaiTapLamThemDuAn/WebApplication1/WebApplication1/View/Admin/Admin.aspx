<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Admin.aspx.vb" Inherits="WebApplication1.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Asset/Lib/css/bootstrap.min.css" rel="stylesheet"/>
    <asp:ContentPlaceHolder ID="head" runat="server"></asp:ContentPlaceHolder>
</head>
<body>
    <div class="container-1">
        <div class="row">
            <div class="col-3">
                <div class="row">
                    <div class="col-2">
                        <img src="../../Asset/Image/product-1.jpg"/>
                    </div>
                    <div class="col-10">
                        <h4>BOOKS</h4>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <form id="form1" runat="server">
        
        <div>

            <asp:ContentPlaceHolder ID="conten1" runat="server"></asp:ContentPlaceHolder>
        </div>
    </form>
</body>
</html>
