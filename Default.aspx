<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Tic-Tac-Toe</h1>
        <p class="lead">Free to play Tic-Tac-Toe</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Play</h2>
            <p>
                <asp:Menu ID="Menu1" runat="server"></asp:Menu>
                <asp:Button ID="Button1" runat="server" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button2" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button3" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <br />
                <asp:Button ID="Button4" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button5" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button6" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <br />
                <asp:Button ID="Button7" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button8" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
                <asp:Button ID="Button9" runat="server" Text="" Font-Size="26pt" Height="75px" Width="75px" />
            </p>
            
        </div>
       
    </div>
</asp:Content>
