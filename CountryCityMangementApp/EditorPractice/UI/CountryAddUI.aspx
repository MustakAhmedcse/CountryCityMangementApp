<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryAddUI.aspx.cs" Inherits="EditorPractice.Index" ValidateRequest="false" %>


<!DOCTYPE html>

<html>
<head>
    <meta charset="UTF-8">
    <title></title>
    <%-- <link href="../Content/bootstrap.css" rel="stylesheet" />--%>
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_editor.css" rel="stylesheet" />
    <link href="../froala_editor_1.2.7/css/froala_style.css" rel="stylesheet" />
    <link href="../Content/style.css" rel="stylesheet" />
</head>
<body>


    <form runat="server">
        <div class="form-group">
            <label class="sr-only">Country Name</label>
            <asp:TextBox runat="server" CssClass="form-control" ID="countryNameTextBox" placeholder="Country Name"></asp:TextBox>

        </div>
        <br />
        <section>
            <label class="sr-only">About</label>
            <textarea id="edit" runat="server"></textarea>


            <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
            <asp:Button ID="calcleButton" runat="server" Text="Cencle" OnClick="calcleButton_Click" />
        </section>
        <br />
        <asp:GridView ID="showCountryGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="SL#">
                    <ItemTemplate>
                        <%# Container.DataItemIndex + 1 %>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="About" HeaderText="About Country" HtmlEncode="False" />
            </Columns>
        </asp:GridView>


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
                $('#edit').editable({ inlineMode: false, height: 120, width: 760, alwaysBlank: true })
            });
        </script>

    </form>



</body>
</html>
