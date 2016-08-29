using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Imposto.Core.Domain
{
    public class SalvaPedido
    {
        public void SaveItem(NotaFiscal notaFiscal)
        {
            var Connection = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
            int NfId = 0;

            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("[dbo].[P_NOTA_FISCAL]", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pId", notaFiscal.Id);
                cmd.Parameters.AddWithValue("@pNumeroNotaFiscal", notaFiscal.NumeroNotaFiscal);
                cmd.Parameters.AddWithValue("@pSerie", notaFiscal.Serie);
                cmd.Parameters.AddWithValue("@pNomeCliente", notaFiscal.NomeCliente);
                cmd.Parameters.AddWithValue("@pEstadoDestino", notaFiscal.EstadoDestino);
                cmd.Parameters.AddWithValue("@pEstadoOrigem", notaFiscal.EstadoOrigem);

               var reader = cmd.ExecuteReader();

                if (reader.Read()) {
                  NfId = Convert.ToInt32(reader["ID"]);
                  reader.Close();
                }

                foreach (var item in notaFiscal.ItensDaNotaFiscal) 
                {
                    item.IdNotaFiscal = NfId;
                    cmd = new SqlCommand("[dbo].[P_NOTA_FISCAL_ITEM]", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@pId", item.Id);
                    cmd.Parameters.AddWithValue("@pIdNotaFiscal", item.IdNotaFiscal);
                    cmd.Parameters.AddWithValue("@pCfop", item.Cfop);
                    cmd.Parameters.AddWithValue("@pTipoIcms", item.TipoIcms);
                    cmd.Parameters.AddWithValue("@pBaseIcms", item.BaseIcms);
                    cmd.Parameters.AddWithValue("@pAliquotaIcms", item.AliquotaIcms);
                    cmd.Parameters.AddWithValue("@pValorIcms", item.ValorIcms);
                    //Exercício 3
                    cmd.Parameters.AddWithValue("@pBaseIpi", item.BaseIpi);
                    cmd.Parameters.AddWithValue("@pAliquotaIpi", item.AliquotaIpi);
                    cmd.Parameters.AddWithValue("@pValorIpi", item.ValorIpi);

                    cmd.Parameters.AddWithValue("@pNomeProduto", item.NomeProduto);
                    cmd.Parameters.AddWithValue("@pCodigoProduto", item.CodigoProduto);

                    cmd.ExecuteNonQuery();
                  }
                conn.Close();
            }
        }
    }
}
