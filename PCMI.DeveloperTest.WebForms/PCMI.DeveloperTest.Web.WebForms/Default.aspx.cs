using PCMI.DeveloperTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PCMI_DeveloperTest_Web_WebForms
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var contracts = new Contracts();

            gridContracts.DataSource = contracts.GetAllContracts();
            gridContracts.DataBind();
        }
    }
}