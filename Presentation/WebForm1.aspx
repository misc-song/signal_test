<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Presentation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="Scripts/jquery-3.3.1.min.js"></script>
    <script src="Scripts/jquery.signalR-2.2.2.js"></script>
    <script type="text/javascript">
        var conn= $.connection("/myconn");
        conn.start().done(function(){
            
        })
        conn.received(function (data) {
            console.debug(data);
        });
        //conn.send(function (data) {
        //     console.debug(data);
        //});
    </script>


</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
