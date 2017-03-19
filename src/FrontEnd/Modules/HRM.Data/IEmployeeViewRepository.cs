// ReSharper disable All
using System.Collections.Generic;
using System.Dynamic;
using PetaPoco;

namespace MixERP.Net.Core.Modules.HRM.Data
{
    public interface IEmployeeViewRepository
    {
        /// <summary>
        /// Performs count on IEmployeeViewRepository.
        /// </summary>
        /// <returns>Returns the number of IEmployeeViewRepository.</returns>
        long Count();

        /// <summary>
        /// Return all instances of the "EmployeeView" class from IEmployeeViewRepository. 
        /// </summary>
        /// <returns>Returns a non-live, non-mapped instances of "EmployeeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeView> Get();

        /// <summary>
        /// Displayfields provide a minimal name/value context for data binding IEmployeeViewRepository.
        /// </summary>
        /// <returns>Returns an enumerable name and value collection for IEmployeeViewRepository.</returns>
        IEnumerable<DisplayField> GetDisplayFields();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeViewRepository.
        /// </summary>
        /// <returns>Returns the first page of collection of "EmployeeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeView> GetPaginatedResult();

        /// <summary>
        /// Produces a paginated result of 10 items from IEmployeeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result.</param>
        /// <returns>Returns collection of "EmployeeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeView> GetPaginatedResult(long pageNumber);

        List<EntityParser.Filter> GetFilters(string catalog, string filterName);

        /// <summary>
        /// Performs a filtered count on IEmployeeViewRepository.
        /// </summary>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns number of rows of "EmployeeView" class using the filter.</returns>
        long CountWhere(List<EntityParser.Filter> filters);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filters from IEmployeeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filters">The list of filter conditions.</param>
        /// <returns>Returns collection of "EmployeeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeView> GetWhere(long pageNumber, List<EntityParser.Filter> filters);

        /// <summary>
        /// Performs a filtered count on IEmployeeViewRepository.
        /// </summary>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns number of rows of "EmployeeView" class using the filter.</returns>
        long CountFiltered(string filterName);

        /// <summary>
        /// Produces a paginated result of 10 items using the supplied filter name from IEmployeeViewRepository.
        /// </summary>
        /// <param name="pageNumber">Enter the page number to produce the paginated result. If you provide a negative number, the result will not be paginated.</param>
        /// <param name="filterName">The named filter.</param>
        /// <returns>Returns collection of "EmployeeView" class.</returns>
        IEnumerable<MixERP.Net.Entities.HRM.EmployeeView> GetFiltered(long pageNumber, string filterName);


    }
}