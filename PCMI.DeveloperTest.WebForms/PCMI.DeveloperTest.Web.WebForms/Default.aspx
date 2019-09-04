<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Main.master" CodeBehind="Default.aspx.cs" Inherits="PCMI_DeveloperTest_Web_WebForms._Default" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
<script>
        var customerFullName = '';
        function handleRowClick(s, e) {
            s.GetRowValues(e.visibleIndex, 'Customer.FirstName;Customer.LastName', function (value) {
                customerFullName = value[0] + " " + value[1];
            });
        }

        function showCustomer() {
            alert(customerFullName);
        }
    </script>
<dx:ASPxGridView ID="gridContracts" runat="server" AutoGenerateColumns="false" ClientInstanceName="gridContracts" KeyFieldName="Id" Width="100%">
     <ClientSideEvents RowClick="handleRowClick" />
    <SettingsBehavior AllowFocusedRow="true" AllowSelectSingleRowOnly="true" />
    <Columns>
        <dx:GridViewDataTextColumn FieldName="Id" Caption="Id" Visible="false">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Number" Caption="Number">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Customer.FirstName" Caption="Customer First Name">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Customer.LastName" Caption="Customer Last Name">
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="Price" Caption="Price">
             <PropertiesTextEdit DisplayFormatString="c"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
        <dx:GridViewDataTextColumn FieldName="PriceWithATX" Caption="Price With ATX">
             <PropertiesTextEdit DisplayFormatString="c" Style-HorizontalAlign="Left"></PropertiesTextEdit>
        </dx:GridViewDataTextColumn>
    </Columns>
    <Settings ShowFooter="true"  />    
     <Templates>  
        <FooterRow>    
            <div style="text-align:center">
                <dx:ASPxButton ID="btnShowCustomer" runat="server" Text="Show Customer Name" AutoPostBack="False"><ClientSideEvents Click="showCustomer" /></dx:ASPxButton>
             </div>
          </FooterRow>   
    </Templates>  
</dx:ASPxGridView>
</asp:Content>