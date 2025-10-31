<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project_Calcultaor.aspx.cs" Inherits="calculator.Project_cal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding: 2% 10% 2% 10%; background-color: Background; text-transform: capitalize; text-align: center;">
            
            <div style="padding: 2% 5% 2% 5%; margin: 20px 210px 20px 210px; border-radius:80px ; background-color: #808080; font-size: medium; font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;">
                <h1>Calculator</h1>
                <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large" Height="65px" Width="455px"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btn1" runat="server" Text="1" Height="50px"  Width="100px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" OnClick="btn1_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn2" runat="server" Height="50px" Text="2" Width="100px" BackColor="White" BorderStyle="None" OnClick="btn2_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn3" runat="server" Text="3" Height="50px"  Width="100px" OnClick="btn3_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDel" runat="server" Text="Del" Height="50px"  Width="100px" BackColor="Red" BorderColor="White" OnClick="btnDel_Click" />
                <br />
                <br />
                <asp:Button ID="btn4" runat="server" Text="4" Height="50px"  Width="100px" OnClick="btn4_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn5" runat="server" Text="5" Height="50px"  Width="100px" OnClick="btn5_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn6" runat="server" Text="6" Height="50px"  Width="100px" OnClick="btn6_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnAdd" runat="server" Text="+"  Height="50px"  Width="100px" OnClick="btnAdd_Click"/>
                <br />
                <br />
                <asp:Button ID="btn7" runat="server" Text="7"  Height="50px"  Width="100px" OnClick="btn7_Click"/>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn8" runat="server" Text="8" Height="50px"  Width="100px" OnClick="btn8_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn9" runat="server" Text="9" Height="50px"  Width="100px" OnClick="btn9_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSub" runat="server" Text="-" Height="50px"  Width="100px" OnClick="btnSub_Click" />
                <br />
                <br />
                <asp:Button ID="btndot" runat="server" Text="." Height="50px"  Width="100px" OnClick="btndot_Click"/>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btn0" runat="server" Text="0" Height="50px"  Width="100px" OnClick="btn0_Click"/>
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnDiv" runat="server" Text="/" Height="50px"  Width="100px" OnClick="btnDiv_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnMul" runat="server" Text="*" Height="50px"  Width="100px" OnClick="btnMul_Click"/>
                <br />
                <br />
                <asp:Button ID="btnClear" runat="server" Text="Clear" Height="50px"  Width="210px" BackColor="Blue" BorderColor="White" OnClick="btnClear_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnRes" runat="server" Text="=" Height="50px"  Width="210px" BackColor="Lime" BorderColor="White" OnClick="btnRes_Click" />
                <br />
                <br />
            </div>

            <div id="graph" style="display:flex; align-items:center; justify-content:center ">

                <br />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="id" DataSourceID="SqlDataSource10" ForeColor="Black" GridLines="Vertical" Height="309px" Width="790px">
                    <AlternatingRowStyle BackColor="#CCCCCC" />
                    <Columns>
                        <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                        <asp:BoundField DataField="Operation" HeaderText="Operation" SortExpression="Operation" />
                        <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
                        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete">
                        <ControlStyle BackColor="Red" BorderColor="White" Font-Size="Large" ForeColor="White" />
                        </asp:ButtonField>
                    </Columns>
                    <FooterStyle BackColor="#CCCCCC" />
                    <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="Gray" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#383838" />
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:CalculatorConnectionString %>" DeleteCommand="DELETE FROM [History] WHERE [id] = @original_id AND (([Operation] = @original_Operation) OR ([Operation] IS NULL AND @original_Operation IS NULL)) AND (([Total] = @original_Total) OR ([Total] IS NULL AND @original_Total IS NULL))" InsertCommand="INSERT INTO [History] ([Operation], [Total]) VALUES (@Operation, @Total)" OldValuesParameterFormatString="original_{0}" ProviderName="<%$ ConnectionStrings:CalculatorConnectionString.ProviderName %>" SelectCommand="SELECT * FROM [History] ORDER BY [id] DESC" UpdateCommand="UPDATE [History] SET [Operation] = @Operation, [Total] = @Total WHERE [id] = @original_id AND (([Operation] = @original_Operation) OR ([Operation] IS NULL AND @original_Operation IS NULL)) AND (([Total] = @original_Total) OR ([Total] IS NULL AND @original_Total IS NULL))">
                    <DeleteParameters>
                        <asp:Parameter Name="original_id" Type="Int32" />
                        <asp:Parameter Name="original_Operation" Type="String" />
                        <asp:Parameter Name="original_Total" Type="String" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Operation" Type="String" />
                        <asp:Parameter Name="Total" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Operation" Type="String" />
                        <asp:Parameter Name="Total" Type="String" />
                        <asp:Parameter Name="original_id" Type="Int32" />
                        <asp:Parameter Name="original_Operation" Type="String" />
                        <asp:Parameter Name="original_Total" Type="String" />
                    </UpdateParameters>
                </asp:SqlDataSource>

            </div>
        </div>
    </form>
</body>
</html>
