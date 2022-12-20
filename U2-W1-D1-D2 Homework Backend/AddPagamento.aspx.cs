using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U2_W1_D1_D2_Homework_Backend
{
    public partial class AddPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (StipendioAcconto.Checked)
            {
                StipAcc.Text = "Stipendio";
            }
            else
            {
                StipAcc.Text = "Acconto";
            }
        }

        protected void CheckStipendio(object sender, EventArgs e)
        {
            if (StipendioAcconto.Checked)
            {
                StipAcc.Text = "Stipendio";
            }
            else
            {
                StipAcc.Text = "Acconto";
            }
        }

        protected void AggiungiStipendio(object sender, EventArgs e)
        {           
            int iddip = Convert.ToInt32(Request.QueryString["IDDipendente"]);
            string DataPagamento = PeriodoPagamento.Value;    
            double Pagamento = Convert.ToInt32(TotalePagamento.Value);    
            bool StipendioChecked = StipendioAcconto.Checked;       

            SqlConnection con = new SqlConnection();
            con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringAziendaEdile"].ToString();
            con.Open();

            SqlCommand command = new SqlCommand();

            command.Parameters.AddWithValue("@PeriodoPagamento", DataPagamento);
            command.Parameters.AddWithValue("@TotalePagamento", Pagamento);
            command.Parameters.AddWithValue("@StipendioAcconto", StipendioChecked);
            command.Parameters.AddWithValue("@IDDipendente", iddip);

            command.CommandText = "Insert into Pagamenti values (@PeriodoPagamento, @TotalePagamento, @StipendioAcconto, @IDDipendente)";

            command.Connection = con;
            int row = command.ExecuteNonQuery();
            try
            {
                if (row > 0)
                {
                    Error.ForeColor = Color.Green;
                    Error.Text = "Inserimento Effettuato";
                }
            }
            catch (Exception ex)
            {
                Error.ForeColor = Color.Red;
                Error.Text = $"{ex}";
            }
            finally
            {
                TotalePagamento.Value = "";
                StipendioAcconto.Checked = false;
                PeriodoPagamento.Value = "";
            }
        }
    }
}