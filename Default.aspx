<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      
        <asp:Panel ID="paneldisp" runat="server">
        
          <b>Enter number:</b>
          <asp:textbox id="txt1" runat="server" width="50px" />
          <asp:RegularExpressionValidator ID="regexpval1" ControlToValidate="txt1" ValidationExpression="\d+" Display="dynamic" ErrorMessage="Error: Enter only positive, whole numbers" runat="server" EnableClientScript="true" ></asp:RegularExpressionValidator>
                
          <asp:Button ID="btn1" runat="server" Text="Display" OnClick ="disp_values" />
                 
        </asp:Panel>  
        <asp:panel id="panel2" runat ="server" visible="false" >
                                       
                     <asp:Label ID="Label4" runat="server" Text="S3.1.1 All numbers: "></asp:Label>
                       <asp:Label ID="label2" runat="server">
                     </asp:Label>
                     <br />  <br />
                     <asp:Label ID="Label5" runat="server" Text="S3.1.2 All Odd numbers: "></asp:Label>
                       <asp:Label ID="label3" runat="server">
                     </asp:Label>
                    <br />  <br />
                     <asp:Label ID="Label6" runat="server" Text="S3.1.3 All Even numbers: "></asp:Label>
                       <asp:Label ID="label7" runat="server">
                     </asp:Label>
                      <br />  <br />
                     <asp:Label ID="head1" runat="server" Text="S3.1.5 All Fibonacci numbers: "></asp:Label>
                     <asp:Label ID="label1" runat="server" Text="">
                     </asp:Label>
           </asp:panel>   


    </div>
    </form>
</body>
</html>
