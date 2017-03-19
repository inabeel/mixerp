// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IFiscalYearScrudViewRepository
    {
        /// <summary>
        /// Performs count on IFiscalYearScrudViewRepository.
        /// </summary>
        /// <returns>Returns the number of IFiscalYearScrudViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "FiscalYearScrudView" class from IFiscalYearScrudViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "FiscalYearScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearScrudView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IFiscalYearScrudViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IFiscalYearScrudViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IFiscalYearScrudViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "FiscalYearScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearScrudView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IFiscalYearScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "FiscalYearScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearScrudView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IFiscalYearScrudViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "FiscalYearScrudView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IFiscalYearScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "FiscalYearScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearScrudView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IFiscalYearScrudViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "FiscalYearScrudView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IFiscalYearScrudViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "FiscalYearScrudView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.FiscalYearScrudView> GetFiltered(long pageNumber, string filterName);


    }
}