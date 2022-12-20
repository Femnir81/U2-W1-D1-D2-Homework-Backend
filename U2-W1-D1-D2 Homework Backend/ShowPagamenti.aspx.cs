using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U2_W1_D1_D2_Homework_Backend
{
    public partial class ShowPagamenti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["iddipendente"]);
            if (!IsPostBack)
            {
                Pagamenti.GetPagamenti(id).Clear();
                Pagamenti.GetPagamenti(id);
            }
            GrigliaPagamenti.DataSource = Pagamenti.ListaPagamenti;
            GrigliaPagamenti.DataBind();
        }
    }
}