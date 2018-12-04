<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/jquery.signalR-2.2.2.js"></script>
    <script type="text/javascript">
      
        var conn = $.connection("/myconnection");
        conn.logging = true;
        conn.start({transport:"longPolling"}).done(function (data) {//{transport:"longPolling|serverSentEvents|webSocket"}指定连接类型 默认为signalR 自己选择（择优）

        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
