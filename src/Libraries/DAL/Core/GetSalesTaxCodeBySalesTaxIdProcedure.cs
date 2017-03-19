// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Core;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Core.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "core.get_sales_tax_code_by_sales_tax_id(_sales_tax_id integer)" on the database.
    /// </summary>
    public class GetSalesTaxCodeBySalesTaxIdProcedure : DbAccess, IGetSalesTaxCodeBySalesTaxIdRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "core";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "get_sales_tax_code_by_sales_tax_id";
        /// <summary>
        /// Login id of application user accessing this PostgreSQL function.
        /// </summary>
        public long _LoginId { get; set; }
        /// <summary>
        /// User id of application user accessing this table.
        /// </summary>
        public int _UserId { get; set; }
        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string _Catalog { get; set; }

        /// <summary>
        /// Maps to "_sales_tax_id" argument of the function "core.get_sales_tax_code_by_sales_tax_id".
        /// </summary>
        public int SalesTaxId { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_sales_tax_code_by_sales_tax_id(_sales_tax_id integer)" on the database.
        /// </summary>
        public GetSalesTaxCodeBySalesTaxIdProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "core.get_sales_tax_code_by_sales_tax_id(_sales_tax_id integer)" on the database.
        /// </summary>
        /// <param name="salesTaxId">Enter argument value for "_sales_tax_id" parameter of the function "core.get_sales_tax_code_by_sales_tax_id".</param>
        public GetSalesTaxCodeBySalesTaxIdProcedure(int salesTaxId)
        {
            this.SalesTaxId = salesTaxId;
        }
        /// <summary>
        /// Prepares and executes the function "core.get_sales_tax_code_by_sales_tax_id".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public string Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"GetSalesTaxCodeBySalesTaxIdProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM core.get_sales_tax_code_by_sales_tax_id(@SalesTaxId);";

            query = query.ReplaceWholeWord("@SalesTaxId", "@0::integer");


            List<object> parameters = new List<object>();
            parameters.Add(this.SalesTaxId);

            return Factory.Scalar<string>(this._Catalog, query, parameters.ToArray());
        }


    }
}