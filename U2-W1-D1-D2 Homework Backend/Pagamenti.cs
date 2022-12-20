using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace U2_W1_D1_D2_Homework_Backend
{
    public class Pagamenti
    {
        public int IDPagamento { get; set; }
        public string PeriodoPagamento { get; set; }
        public double TotalePagamento { get; set; }
        public bool StipendioAcconto { get; set; }
        public Dipendenti IDDipendente { get; set; }

        public static List<Pagamenti> ListaPagamenti = new List<Pagamenti>();

        public static List<Pagamenti> GetPagamenti(int id)
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringAziendaEdile"].ToString();
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = $"Select * from Pagamenti inner join Dipendenti on Pagamenti.IDDipendente = Dipendenti.IDDipendente where Pagamenti.IDDipendente = {id} order by PeriodoPagamento desc";
                command.Connection = con;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pagamenti pag = new Pagamenti();
                        pag.IDPagamento = Convert.ToInt32(reader["IDPagamento"]);
                        pag.PeriodoPagamento = reader["PeriodoPagamento"].ToString();
                        pag.TotalePagamento = Convert.ToDouble(reader["TotalePagamento"]);
                        pag.StipendioAcconto = Convert.ToBoolean(reader["StipendioAcconto"]);
                        Dipendenti dip = new Dipendenti();  
                        dip.Nome = reader["Nome"].ToString();
                        dip.Cognome = reader["Cognome"].ToString();
                        dip.Mansione = reader["Mansione"].ToString();
                        pag.IDDipendente = dip;
                        ListaPagamenti.Add(pag);
                    }
                }
            }
            catch (Exception ex)
            {
                con.Close();
            }
            con.Close();

            return ListaPagamenti;
        }
    }
}