<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="login.aspx.vb" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet"  href="../Asset/Lib/css/bootstrap.min.css"/>
</head>
<body>
    <div class="container-flud">
       <div class="row">

       </div>
        <div class="row">
            <div class ="col-4">

                </div>
             <div class ="col-4">
               <form id="form1" runat="server" style="margin-left:500px">
                   <div class="col-8" style="margin-left:200px">
                       <img src="../Asset/Image/logo.png" style="align-items"/>
                   </div>
                   <div class="mt-3" style="margin-right:300px" >
                       <label for class="user-name">  user name</label>
                        <input type="text" placeholder="enter user name..." autocomplete="off" class="form-control" style="padding:4px,4px,4px,4px"/>
                    </div>
                   <div class="mt-3" style="margin-right:300px">
                       <label for class="user-name">  Pass word</label>
                        <input type="text" placeholder="enter pass word..." autocomplete="off" class="form-control" size="13"/>
                    </div>
                   <div class="col-3-grid" style="margin-left:200px ; margin-top:10px">

                       <asp:Button text="Login" runat="server" class="btnLogin" style="color:red;padding:1000px,1000px"/>
                   </div>
               </form>
              </div>
             <div class ="col-4">

                </div>
        </div>
    </div>
        <div>
        </div>
    </form>
</body>
</html>
