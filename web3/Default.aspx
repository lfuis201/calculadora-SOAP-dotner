<%@ Page Language="C#" Inherits="web3.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Default</title>
</head>
<body>
	<form id="form1" runat="server">
		<asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
	</form>
        
    <form id="form2" runat="server">
        <a href="web3.asmx">calculadora</a>     
    </form>
</body>
</html>
