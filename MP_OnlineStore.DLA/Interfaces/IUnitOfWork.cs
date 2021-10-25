using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MP_OnlineStore.DAL.Entities;
using MP_OnlineStore.DAL.Interfaces.Repositories;

namespace MP_OnlineStore.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Category> CategoriesRepository { get; }
        IRepository<AlphabeticalListOfProduct> AlphabeticalListOfProductsRepository { get; }
        IRepository<CategorySalesFor1997> CategorySalesFor1997sRepository { get; }
        IRepository<CurrentProductList> CurrentProductListsRepository { get; }
        IRepository<Customer> CustomersRepository { get; }
        IRepository<CustomerAndSuppliersByCity> CustomerAndSuppliersByCitiesRepository { get; }
        IRepository<CustomerCustomerDemo> CustomerCustomerDemosRepository { get; }
        IRepository<CustomerDemographic> CustomerDemographicsRepository { get; }
        IRepository<Employee> EmployeesRepository { get; }
        IRepository<EmployeeTerritory> EmployeeTerritoriesRepository { get; }
        IRepository<Invoice> InvoicesRepository { get; }
        IRepository<Order> OrdersRepository { get; }
        IRepository<OrderDetail> OrderDetailsRepository { get; }
        IRepository<OrderDetailsExtended> OrderDetailsExtendedsRepository { get; }
        IRepository<OrderSubtotal> OrderSubtotalsRepository { get; }
        IRepository<OrdersQry> OrdersQriesRepository { get; }
        IRepository<Product> ProductsRepository { get; }
        IRepository<ProductSalesFor1997> ProductSalesFor1997sRepository { get; }
        IRepository<ProductsAboveAveragePrice> ProductsAboveAveragePricesRepository { get; }
        IRepository<ProductsByCategory> ProductsByCategoriesRepository { get; }
        IRepository<QuarterlyOrder> QuarterlyOrdersRepository { get; }
        IRepository<Region> RegionsRepository { get; }
        IRepository<SalesByCategory> SalesByCategoriesRepository { get; }
        IRepository<SalesTotalsByAmount> SalesTotalsByAmountsRepository { get; }
        IRepository<Shipper> ShippersRepository { get; }
        IRepository<SummaryOfSalesByQuarter> SummaryOfSalesByQuartersRepository { get; }
        IRepository<SummaryOfSalesByYear> SummaryOfSalesByYearsRepository { get; }
        IRepository<Supplier> SuppliersRepository { get; }
        IRepository<Territory> TerritoriesRepository { get; }
        Task SaveAsync();
    }
}