using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U2_W1_D1_D2_Homework_Backend
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    Dipendenti.GetDipendenti().Clear();
                    Dipendenti.GetDipendenti();
                }
                GrigliaDipendente.DataSource = Dipendenti.ListaDipendenti;
                GrigliaDipendente.DataBind();
            }
            catch (Exception ex)
            {

            }
            
        }
    }
}