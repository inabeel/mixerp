/********************************************************************************
Copyright (C) MixERP Inc. (http://mixof.org).

This file is part of MixERP.

MixERP is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, version 2 of the License.


MixERP is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with MixERP.  If not, see <http://www.gnu.org/licenses/>.
***********************************************************************************/
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MixERP.Net.DbFactory;
using MixERP.Net.Framework;
using Npgsql;
using PetaPoco;
using Serilog;

namespace MixERP.Net.Schemas.Transactions.Data
{
    /// <summary>
    /// Provides simplified data access features to perform SCRUD operation on the database table "transactions.customer_receipts".
    /// </summary>
    public class CustomerReceipt : DbAccess
    {
        /// <summary>
        /// The schema of this table. Returns literal "transactions".
        /// </summary>
	    public override string ObjectNamespace => "transactions";

        /// <summary>
        /// The schema unqualified name of this table. Returns literal "customer_receipts".
        /// </summary>
	    public override string ObjectName => "customer_receipts";

        /// <summary>
        /// Login id of application user accessing this table.
        /// </summary>
		public long LoginId { get; set; }

        /// <summary>
        /// The name of the database on which queries are being executed to.
        /// </summary>
        public string Catalog { get; set; }

		/// <summary>
		/// Performs SQL count on the table "transactions.customer_receipts".
		/// </summary>
		/// <returns>Returns the number of rows of the table "transactions.customer_receipts".</returns>
		public long Count()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return 0;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to count entity \"CustomerReceipt\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT COUNT(*) FROM transactions.customer_receipts;";
			return Factory.Scalar<long>(this.Catalog, sql);
		}

		/// <summary>
		/// Executes a select query on the table "transactions.customer_receipts" with a where filter on the column "receipt_id" to return a single instance of the "CustomerReceipt" class. 
		/// </summary>
		/// <param name="receiptId">The column "receipt_id" parameter used on where filter.</param>
		/// <returns>Returns a non-live, non-mapped instance of "CustomerReceipt" class mapped to the database row.</returns>
		public MixERP.Net.Entities.Transactions.CustomerReceipt Get(long receiptId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the get entity \"CustomerReceipt\" filtered by \"ReceiptId\" with value {ReceiptId} was denied to the user with Login ID {LoginId}", receiptId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.customer_receipts WHERE receipt_id=@0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.CustomerReceipt>(this.Catalog, sql, receiptId).FirstOrDefault();
		}

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding the row collection of transactions.customer_receipts.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for the table transactions.customer_receipts</returns>
		public IEnumerable<DisplayField> GetDisplayFields()
		{
			List<DisplayField> displayFields = new List<DisplayField>();

			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return displayFields;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to get display field for entity \"CustomerReceipt\" was denied to the user with Login ID {LoginId}", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT receipt_id AS key, currency_code as value FROM transactions.customer_receipts;";
			using (NpgsqlCommand command = new NpgsqlCommand(sql))
			{
				using (DataTable table = DbOperation.GetDataTable(this.Catalog, command))
				{
					if (table?.Rows == null || table.Rows.Count == 0)
					{
						return displayFields;
					}

					foreach (DataRow row in table.Rows)
					{
						if (row != null)
						{
							DisplayField displayField = new DisplayField
							{
								Key = row["key"].ToString(),
								Value = row["value"].ToString()
							};

							displayFields.Add(displayField);
						}
					}
				}
			}

			return displayFields;
		}

		/// <summary>
		/// Inserts the instance of CustomerReceipt class on the database table "transactions.customer_receipts".
		/// </summary>
		/// <param name="customerReceipt">The instance of "CustomerReceipt" class to insert.</param>
		public void Add(MixERP.Net.Entities.Transactions.CustomerReceipt customerReceipt)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Create, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to add entity \"CustomerReceipt\" was denied to the user with Login ID {LoginId}. {CustomerReceipt}", this.LoginId, customerReceipt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Insert(this.Catalog, customerReceipt);
		}

		/// <summary>
		/// Updates the row of the table "transactions.customer_receipts" with an instance of "CustomerReceipt" class against the primary key value.
		/// </summary>
		/// <param name="customerReceipt">The instance of "CustomerReceipt" class to update.</param>
		/// <param name="receiptId">The value of the column "receipt_id" which will be updated.</param>
		public void Update(MixERP.Net.Entities.Transactions.CustomerReceipt customerReceipt, long receiptId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Edit, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to edit entity \"CustomerReceipt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}. {CustomerReceipt}", receiptId, this.LoginId, customerReceipt);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			Factory.Update(this.Catalog, customerReceipt, receiptId);
		}

		/// <summary>
		/// Deletes the row of the table "transactions.customer_receipts" against the primary key value.
		/// </summary>
		/// <param name="receiptId">The value of the column "receipt_id" which will be deleted.</param>
		public void Delete(long receiptId)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Delete, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to delete entity \"CustomerReceipt\" with Primary Key {PrimaryKey} was denied to the user with Login ID {LoginId}.", receiptId, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "DELETE FROM transactions.customer_receipts WHERE receipt_id=@0;";
			Factory.NonQuery(this.Catalog, sql, receiptId);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.customer_receipts" producing a paged result of 25.
		/// </summary>
		/// <returns>Returns the first page of collection of "CustomerReceipt" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPagedResult()
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to the first page of the entity \"CustomerReceipt\" was denied to the user with Login ID {LoginId}.", this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			const string sql = "SELECT * FROM transactions.customer_receipts ORDER BY receipt_id LIMIT 25 OFFSET 0;";
			return Factory.Get<MixERP.Net.Entities.Transactions.CustomerReceipt>(this.Catalog, sql);
		}

		/// <summary>
		/// Performs a select statement on table "transactions.customer_receipts" producing a paged result of 25.
		/// </summary>
		/// <param name="pageNumber">Enter the page number to produce the paged result.</param>
		/// <returns>Returns collection of "CustomerReceipt" class.</returns>
		public IEnumerable<MixERP.Net.Entities.Transactions.CustomerReceipt> GetPagedResult(long pageNumber)
		{
			if(string.IsNullOrWhiteSpace(this.Catalog))
			{
				return null;
			}

            if (!this.SkipValidation)
            {
                if (!this.Validated)
                {
                    this.Validate(AccessTypeEnum.Read, this.LoginId, false);
                }
                if (!this.HasAccess)
                {
                    Log.Information("Access to Page #{Page} of the entity \"CustomerReceipt\" was denied to the user with Login ID {LoginId}.", pageNumber, this.LoginId);
                    throw new UnauthorizedException("Access is denied.");
                }
            }
	
			long offset = (pageNumber -1) * 25;
			const string sql = "SELECT * FROM transactions.customer_receipts ORDER BY receipt_id LIMIT 25 OFFSET @0;";
				
			return Factory.Get<MixERP.Net.Entities.Transactions.CustomerReceipt>(this.Catalog, sql, offset);
		}
	}
}