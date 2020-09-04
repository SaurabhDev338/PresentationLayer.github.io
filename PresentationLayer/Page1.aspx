<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="PresentationLayer.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration form</title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
</head>
<body style="background-image:linear-gradient(rgba(0,0,0,0.5), rgba(0,0,0,0.5)),url(images/friend.jpg);background-color:transparent;background-repeat:round;background-attachment:fixed">
    <div style="margin-left:500px;margin-right:90px">
    <div style="margin-top:50px" class="col-sm-6 col-md-6 col-xs-12" >
        <div>
    <h1 style="color:white">&nbsp &nbsp &nbsp Registration Form</h1>
            </div><br />
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="lbl_name" style="color:white;font-size:20px" Text="Name:"></asp:Label>
            <asp:TextBox ID="txt_name" runat="server"  CssClass="form-control form-control-sm" placeholder="Enter Your Name" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_address" style="color:white;font-size:20px" Text="Address:"></asp:Label>
            <asp:TextBox ID="txt_address" runat="server"  Height="100px"  CssClass="form-control form-control-sm" placeholder="Enter Your Address" TextMode="MultiLine" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_mobile" style="color:white;font-size:20px" Text="Mobile:"></asp:Label>
            <asp:TextBox ID="txt_mobile" runat="server"  CssClass="form-control form-control-sm" placeholder="Enter Your Mobile Number" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_Email" style="color:white;font-size:20px" Text="Email:"></asp:Label>
            <asp:TextBox ID="txt_email" runat="server"  CssClass="form-control form-control-sm" placeholder="Enter Your Email" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_Collage" style="color:white;font-size:20px" Text="Collage Name:"></asp:Label>
            <asp:TextBox ID="txt_collage" runat="server" CssClass="form-control form-control-sm" placeholder="Enter Your Collage Name" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_gender" style="color:white;font-size:20px" Text="Gender:" ></asp:Label>&nbsp 
            <asp:RadioButtonList ID="RadioBtn_gender" runat="server" style="color:white;font-size:20px">
                <asp:ListItem value="0">Male</asp:ListItem>
                <asp:ListItem value="1">Female</asp:ListItem>
            </asp:RadioButtonList>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_Branch" style="color:white;font-size:20px" Text="Branch:"></asp:Label>
            <asp:TextBox ID="txt_Branch" runat="server"  CssClass="form-control form-control-sm" placeholder="Enter Your Branch Name" ></asp:TextBox>
        </div><br />
        <div>
            <asp:Label runat="server" ID="lbl_skills" style="color:white;font-size:20px" Text="Skills:"></asp:Label>
            <asp:TextBox ID="txt_skills" runat="server"  CssClass="form-control form-control-sm" placeholder="Enter Your Skills"></asp:TextBox>
        </div><br /> 
        <div style="margin-left:150px;margin-right:100px">
        <asp:Button ID="btn_save" runat="server" Text="Submit" CssClass="btn btn-danger" OnClick="btn_save_Click" />&nbsp &nbsp &nbsp        
        <asp:Button ID="Btn_Update" runat="server" Text="Update" CssClass="btn btn-danger" OnClick="Btn_Update_Click"/>
         </div>
        <div>
            <asp:GridView ID="gdvregis" runat="server" AutoGenerateColumns="False" OnRowDeleting="gdvregis_RowDeleting"  OnRowCommand="gdvregis_RowCommand" >
                <Columns>
                    <asp:BoundField HeaderText="NAME" DataField="Name"/>
                    <asp:BoundField HeaderText="ADDRESS" DataField="Address"/>
                    <asp:BoundField HeaderText="CONTACT NUMBER" DataField="Mobile"/>
                    <asp:TemplateField HeaderText="VIEW">
                        <ItemTemplate>
                        <asp:LinkButton runat="server" ID="lnk_view" Text="View" CommandName="View" CommandArgument='<% #Eval("ID") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                      <asp:LinkButton runat="server" ID="lnk_delete" Text="Delete" CommandName="Delete"  CommandArgument='<% #Eval("ID") %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
        </div>
       </div>
</body>
</html>
