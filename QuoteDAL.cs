using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using vendor.ckycg.api.DAL;

namespace ProtSavingApi.DAL
{
    public class QuoteDAL
    {
        public bool CreateUpdateQuote(Quote quote, string action)
        {
            bool isQuoteCreated;
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("QuoteNo", typeof(int));
                dt.Columns.Add("ProdTyp", typeof(int));
                dt.Columns.Add("CreatedOn", typeof(DateTime));
                dt.Columns.Add("CreatedBy", typeof(string));
                dt.Columns.Add("Status", typeof(string));
                dt.Rows.Add(
                    quote.QuoteNo, quote.ProdTyp, quote.CreatedOn, quote.CreatedBy, quote.Status);

                SqlParameter paramQuote = new SqlParameter();
                paramQuote.SqlDbType = SqlDbType.Structured;
                paramQuote.TypeName = "ProtSaving.udtQuote";
                paramQuote.Value = dt;
                paramQuote.ParameterName = "@QuoteTable";

                SqlParameter[] parameters = new SqlParameter[] {
                    paramQuote,
                    new SqlParameter("@DML",action)
                    };

                SqlHelper.ExecuteNonQuery(DBObjects.AJTIssuanceDB, CommandType.StoredProcedure, DBObjects.UspCUDQuote, parameters);
                isQuoteCreated = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return isQuoteCreated;
        }
    }
}