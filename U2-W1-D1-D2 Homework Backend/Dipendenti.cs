using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace U2_W1_D1_D2_Homework_Backend
{
    public class Dipendenti
    {
        public int IDDipendente { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Indirizzo { get; set; }
        public string CodiceFiscale { get; set; }
        public bool Coniugato { get; set; }
        public int NumeroFigli { get; set; }
        public string Mansione { get; set; }

        public static List<Dipendenti> ListaDipendenti = new List<Dipendenti>();

        public static List<Dipendenti> GetDipendenti()
        {
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnStringAziendaEdile"].ToString();
                con.Open();

                SqlCommand command = new SqlCommand();
                command.CommandText = $"Select * from Dipendenti";
                command.Connection = con;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Dipendenti dip = new Dipendenti();
                        dip.IDDipendente = Convert.ToInt32(reader["IDDipendente"]);
                        dip.Nome = reader["Nome"].ToString();
                        dip.Cognome = reader["Cognome"].ToString();
                        dip.Indirizzo = reader["Indirizzo"].ToString();
                        dip.CodiceFiscale = reader["CodiceFiscale"].ToString();
                        dip.Coniugato = Convert.ToBoolean(reader["Coniugato"]);
                        dip.NumeroFigli = Convert.ToInt32(reader["NumeroFigli"]);
                        dip.Mansione = reader["Mansione"].ToString();

                        ListaDipendenti.Add(dip);
                    }
                }
            }
            catch (Exception ex) 
            {
                con.Close();
            }
            con.Close();

            return ListaDipendenti;
        }
    }
}