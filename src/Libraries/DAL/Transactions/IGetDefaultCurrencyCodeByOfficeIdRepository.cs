// ReSharper disable All
using System;
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;
using MixERP.Net.Entities.Transactions;
namespace MixERP.Net.Schemas.Transactions.Data
{
    public interface IGetDefaultCurrencyCodeByOfficeIdRepository
    {

        int OfficeId { get; set; }

        /// <summary>
        /// Prepares and executes IGetDefaultCurrencyCodeByOfficeIdRepository.
        /// </summary>
        string Execute();
    }
}