<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Display_Calculator.aspx.cs" Inherits="calculator.Display_Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color: lightslategray">
 
            <p>&nbsp;</p>
               <div style="margin-right: 25vw; margin-left:30vw; background-color: #C0C0C0" >
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   
                   <h3 style="text-align:center">Calculator</h3>
                  
                   &nbsp;&nbsp;&nbsp;
                  
                   <asp:TextBox ID="TextBox1" runat="server" Height="65px" Width="515px"></asp:TextBox>
                   <br />
                   <br />
&nbsp;&nbsp;
                   <asp:Button ID="btn7" runat="server"  Text="7" Height="45px" Width="114px" OnClick="btn7_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn8" runat="server" Height="45px" Text="8" Width="114px" OnClick="btn8_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn9" runat="server" Height="45px" Text="9" Width="114px" OnClick="btn9_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnDel" runat="server" Height="45px" Text="DEL" Width="114px" OnClick="Button4_Click1" BackColor="#FF3300" />
                   <br />
                   <br />
                   &nbsp;&nbsp;&nbsp;<asp:Button ID="btn4" runat="server" Text="4" Height="45px" Width="114px" OnClick="btn4_Click"/>
                   &nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn5" runat="server" OnClick="btn5_Click" Text="5" Height="45px" Width="114px"/>
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn6" runat="server" Height="45px" Text="6" Width="114px" OnClick="btn6_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnAdd" runat="server" Text="+"  Height="45px" Width="114px" OnClick="btnAdd_Click"/>
                   <br />
                   <br />
&nbsp;&nbsp;
                   <asp:Button ID="btn1" runat="server" Text="1"  Height="45px" Width="114px" OnClick="btn1_Click"/>
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn2" runat="server" Text="2" Height="45px" Width="114px" OnClick="btn2_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn3" runat="server" Text="3"  Height="45px" Width="114px" OnClick="btn3_Click1"/>
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnSub" runat="server" Text="-" Height="45px" Width="114px" OnClick="btnSub_Click"/>
                   <br />
                   <br />

&nbsp;&nbsp;
                   <asp:Button ID="btnDot" runat="server" Text="." Height="45px" Width="114px" OnClick="btnDot_Click" />
                   &nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btn0" runat="server" Text="0" Height="45px" Width="114px" OnClick="btn0_Click"/>
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnDiv" runat="server" Height="45px" Text="/" Width="114px" OnClick="btnDiv_Click" />
&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnMul" runat="server" Text="x" Height="45px" Width="114px" OnClick="btnMul_Click" />
                   <br />
                   <br />
&nbsp;&nbsp;
                   <asp:Button ID="btnClear" runat="server" Text="Clear" Width="242px" Height="52px" BackColor="#0066FF" OnClick="btnClear_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="btnEquel" runat="server" Text="=" Width="242px" Height="52px" BackColor="#33CC33" OnClick="btnEquel_Click" />
                   <br />
                   <br />
               </div>
            
            <p>&nbsp;</p>
               <p>&nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
       
    </form>
    
</body>
</html>
