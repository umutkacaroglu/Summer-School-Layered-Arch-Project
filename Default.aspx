<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server" style="border:5px thin double;">
        <div class="form-group" >

            <div>
                <asp:Label for="TextBox1" ID="Label1" runat="server" Text="Öğrenci Adı" style="font-family: 'Times New Roman', Times, serif; font-weight: bold; font-size: large"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox_Name" runat="server" CssClass="form-control" ></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox2" ID="Label2" runat="server" Text="Öğrenci Soyadı" style="font-family: 'Times New Roman', Times, serif; font-weight: bold; font-size: large"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox_Surname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox3" ID="Label3" runat="server" Text="Öğrenci Numara" style="font-family: 'Times New Roman', Times, serif; font-weight: bold; font-size: large"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox_Number" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox5" ID="Label5" runat="server" Text="Öğrenci Mail Adresi" style="font-family: 'Times New Roman', Times, serif; font-weight: bold; font-size: large"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox_Mail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextBox4" ID="Label4" runat="server" Text="Öğrenci Şifre" style="font-family: 'Times New Roman', Times, serif; font-weight: bold; font-size: large"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox_Password" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <asp:Button ID="Button1" runat="server" Text="Kaydet" OnClick="Button1_Click1" CssClass="btn btn-info" />
        </div>
    </form>
</asp:Content>

