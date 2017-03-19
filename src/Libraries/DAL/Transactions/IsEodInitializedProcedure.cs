// ReSharper disable All
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using MixERP.Net.Framework.Extensions;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
using Npgsql;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Prepares, validates, and executes the function "transactions.is_eod_initialized(_office_id integer, _value_date date)" on the database.
    /// </summary>
    public class IsEodInitializedProcedure : DbAccess, IIsEodInitializedRepository
    {
        /// <summary>
        /// The schema of this PostgreSQL function.
        /// </summary>
        public override string _ObjectNamespace => "transactions";
        /// <summary>
        /// The schema unqualified name of this PostgreSQL function.
        /// </summary>
        public override string _ObjectName => "is_eod_initialized";
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
        /// Maps to "_office_id" argument of the function "transactions.is_eod_initialized".
        /// </summary>
        public int OfficeId { get; set; }
        /// <summary>
        /// Maps to "_value_date" argument of the function "transactions.is_eod_initialized".
        /// </summary>
        public DateTime ValueDate { get; set; }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.is_eod_initialized(_office_id integer, _value_date date)" on the database.
        /// </summary>
        public IsEodInitializedProcedure()
        {
        }

        /// <summary>
        /// Prepares, validates, and executes the function "transactions.is_eod_initialized(_office_id integer, _value_date date)" on the database.
        /// </summary>
        /// <param name="officeId">Enter argument value for "_office_id" parameter of the function "transactions.is_eod_initialized".</param>
        /// <param name="valueDate">Enter argument value for "_value_date" parameter of the function "transactions.is_eod_initialized".</param>
        public IsEodInitializedProcedure(int officeId, DateTime valueDate)
        {
            this.OfficeId = officeId;
            this.ValueDate = valueDate;
        }
        /// <summary>
        /// Prepares and executes the function "transactions.is_eod_initialized".
        /// </summary>
        /// <exception cref="UnauthorizedException">Thown when the application user does not have sufficient privilege to perform this action.</exception>
        public bool Execute()
        {
            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Execute, this._LoginId, this._Catalog, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the function \"IsEodInitializedProcedure\" was denied to the user with Login ID {LoginId}.", this._LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
            string query = "SELECT * FROM transactions.is_eod_initialized(@OfficeId, @ValueDate);";

            query = query.ReplaceWholeWord("@OfficeId", "@0::integer");
            query = query.ReplaceWholeWord("@ValueDate", "@1::date");


            List<object> parameters = new List<object>();
            parameters.Add(this.OfficeId);
            parameters.Add(this.ValueDate);

            return Factory.Scalar<bool>(this._Catalog, query, parameters.ToArray());
        }


    }
}