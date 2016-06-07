<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityAddUI.aspx.cs" Inherits="EditorPractice.CityAddUI" ValidateRequest="false" %>

<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8">
    <title></title>

    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />
</head>
<body>



    <form runat="server">
        <div class="form-group">
            <label class="sr-only">City Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="cityNameTextBox"></asp:TextBox>
        </div>
        <br />
        <section>
            <textarea id="edit" runat="server"></textarea>


            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <asp:Button ID="calcleButton" runat="server" Text="Cencle" OnClick="calcleButton_Click" />
        </section>

        <div class="form-group">
            <label class="sr-only">No.of dwallors</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="noOfDwallorsTextBox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="sr-only">Location</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="locationTextBox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="sr-only">Weather</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="weatherTextBox"></asp:TextBox>
        </div>
        <div class="form-group">
            <label class="sr-only">Country</label>
            <asp:DropDownList ID="countryDropDownList" runat="server"></asp:DropDownList>
        </div>

        <br />
        <asp:GridView ID="showCityGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CityName" HeaderText="Name" />
                <asp:BoundField DataField="NoOfDwellers" HeaderText="No.of Dwellors" />
                <asp:BoundField DataField="CountryName" HeaderText="Country" />

            </Columns>
        </asp:GridView>
    </form>



    <script src="../Scripts/jquery-2.2.2.js"></script>
    <script src="../froala_editor_1.2.7/js/froala_editor.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/tables.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/lists.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/colors.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/media_manager.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_family.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/font_size.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/block_styles.min.js"></script>
    <script src="../froala_editor_1.2.7/js/plugins/video.min.js"></script>
    <script>
        $(function () {
            $('#edit').editable({ inlineMode: false, height: 200, alwaysBlank: true })
        });
    </script>
</body>
</html>
