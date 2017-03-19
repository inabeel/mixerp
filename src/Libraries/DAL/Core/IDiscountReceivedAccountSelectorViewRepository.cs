// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Schemas.Core.Data
{
    public interface IDiscountReceivedAccountSelectorViewRepository
    {
        /// <summary>
        /// Performs count on IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the number of IDiscountReceivedAccountSelectorViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "DiscountReceivedAccountSelectorView" class from IDiscountReceivedAccountSelectorViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "DiscountReceivedAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DiscountReceivedAccountSelectorView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IDiscountReceivedAccountSelectorViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "DiscountReceivedAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DiscountReceivedAccountSelectorView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "DiscountReceivedAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DiscountReceivedAccountSelectorView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "DiscountReceivedAccountSelectorView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "DiscountReceivedAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DiscountReceivedAccountSelectorView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "DiscountReceivedAccountSelectorView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IDiscountReceivedAccountSelectorViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "DiscountReceivedAccountSelectorView" class.</returns>
        IEnumerable<MixERP.Net.Entities.Core.DiscountReceivedAccountSelectorView> GetFiltered(long pageNumber, string filterName);


    }
}