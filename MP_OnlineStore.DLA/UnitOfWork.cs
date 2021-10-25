using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MP_OnlineStore.DAL.Entities;
using MP_OnlineStore.DAL.Interfaces;
using MP_OnlineStore.DAL.Interfaces.Repositories;
using MP_OnlineStore.DAL.Repositories;

namespace MP_OnlineStore.DAL
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private NorthwindContext _dbContext;
        private IRepository<Category> _CategoriesRepository;
        private IRepository<AlphabeticalListOfProduct> _AlphabeticalListOfProductsRepository;
        private IRepository<CategorySalesFor1997> _CategorySalesFor1997sRepository;
        private IRepository<CurrentProductList> _CurrentProductListsRepository;
        private IRepository<Customer> _CustomersRepository;
        private IRepository<CustomerAndSuppliersByCity> _CustomerAndSuppliersByCitiesRepository;
        private IRepository<CustomerCustomerDemo> _CustomerCustomerDemosRepository;
        private IRepository<CustomerDemographic> _CustomerDemographicsRepository;
        private IRepository<Employee> _EmployeesRepository;
        private IRepository<EmployeeTerritory> _EmployeeTerritoriesRepository;
        private IRepository<Invoice> _InvoicesRepository;
        private IRepository<Order> _OrdersRepository;
        private IRepository<OrderDetail> _OrderDetailsRepository;
        private IRepository<OrderDetailsExtended> _OrderDetailsExtendedsRepository;
        private IRepository<OrderSubtotal> _OrderSubtotalsRepository;
        private IRepository<OrdersQry> _OrdersQriesRepository;
        private IRepository<Product> _ProductsRepository;
        private IRepository<ProductSalesFor1997> _ProductSalesFor1997sRepository;
        private IRepository<ProductsAboveAveragePrice> _ProductsAboveAveragePricesRepository;
        private IRepository<ProductsByCategory> _ProductsByCategoriesRepository;
        private IRepository<QuarterlyOrder> _QuarterlyOrdersRepository;
        private IRepository<Region> _RegionsRepository;
        private IRepository<SalesByCategory> _SalesByCategoriesRepository;
        private IRepository<SalesTotalsByAmount> _SalesTotalsByAmountsRepository;
        private IRepository<Shipper> _ShippersRepository;
        private IRepository<SummaryOfSalesByQuarter> _SummaryOfSalesByQuartersRepository;
        private IRepository<SummaryOfSalesByYear> _SummaryOfSalesByYearsRepository;
        private IRepository<Supplier> _SuppliersRepository;
        private IRepository<Territory> _TerritoriesRepository;

        private bool _disposed;

        public UnitOfWork(NorthwindContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IRepository<Category> CategoriesRepository =>
            _CategoriesRepository ??= new GenericRepository<Category>(_dbContext.Categories);

        public IRepository<AlphabeticalListOfProduct> AlphabeticalListOfProductsRepository =>
            _AlphabeticalListOfProductsRepository ??= new GenericRepository<AlphabeticalListOfProduct>(_dbContext.AlphabeticalListOfProducts);

        public IRepository<CategorySalesFor1997> CategorySalesFor1997sRepository =>
            _CategorySalesFor1997sRepository ??= new GenericRepository<CategorySalesFor1997>(_dbContext.CategorySalesFor1997s);

        public IRepository<CurrentProductList> CurrentProductListsRepository =>
            _CurrentProductListsRepository ??= new GenericRepository<CurrentProductList>(_dbContext.CurrentProductLists);

        public IRepository<Customer> CustomersRepository =>
            _CustomersRepository ??= new GenericRepository<Customer>(_dbContext.Customers);

        public IRepository<CustomerAndSuppliersByCity> CustomerAndSuppliersByCitiesRepository =>
            _CustomerAndSuppliersByCitiesRepository ??= new GenericRepository<CustomerAndSuppliersByCity>(_dbContext.CustomerAndSuppliersByCities);

        public IRepository<CustomerCustomerDemo> CustomerCustomerDemosRepository =>
            _CustomerCustomerDemosRepository ??= new GenericRepository<CustomerCustomerDemo>(_dbContext.CustomerCustomerDemos);

        public IRepository<CustomerDemographic> CustomerDemographicsRepository =>
            _CustomerDemographicsRepository ??= new GenericRepository<CustomerDemographic>(_dbContext.CustomerDemographics);

        public IRepository<Employee> EmployeesRepository =>
            _EmployeesRepository ??= new GenericRepository<Employee>(_dbContext.Employees);

        public IRepository<EmployeeTerritory> EmployeeTerritoriesRepository =>
            _EmployeeTerritoriesRepository ??= new GenericRepository<EmployeeTerritory>(_dbContext.EmployeeTerritories);

        public IRepository<Invoice> InvoicesRepository =>
            _InvoicesRepository ??= new GenericRepository<Invoice>(_dbContext.Invoices);

        public IRepository<Order> OrdersRepository =>
            _OrdersRepository ??= new GenericRepository<Order>(_dbContext.Orders);

        public IRepository<OrderDetail> OrderDetailsRepository =>
            _OrderDetailsRepository ??= new GenericRepository<OrderDetail>(_dbContext.OrderDetails);

        public IRepository<OrderDetailsExtended> OrderDetailsExtendedsRepository => 
            _OrderDetailsExtendedsRepository ??= new GenericRepository<OrderDetailsExtended>(_dbContext.OrderDetailsExtendeds);

        public IRepository<OrderSubtotal> OrderSubtotalsRepository => 
            _OrderSubtotalsRepository ??= new GenericRepository<OrderSubtotal>(_dbContext.OrderSubtotals);

        public IRepository<OrdersQry> OrdersQriesRepository => 
            _OrdersQriesRepository ??= new GenericRepository<OrdersQry>(_dbContext.OrdersQries);

        public IRepository<Product> ProductsRepository => 
            _ProductsRepository ??= new GenericRepository<Product>(_dbContext.Products);

        public IRepository<ProductSalesFor1997> ProductSalesFor1997sRepository =>
            _ProductSalesFor1997sRepository ??= new GenericRepository<ProductSalesFor1997>(_dbContext.ProductSalesFor1997s);

        public IRepository<ProductsAboveAveragePrice> ProductsAboveAveragePricesRepository =>
            _ProductsAboveAveragePricesRepository ??= new GenericRepository<ProductsAboveAveragePrice>(_dbContext.ProductsAboveAveragePrices);

        public IRepository<ProductsByCategory> ProductsByCategoriesRepository => 
            _ProductsByCategoriesRepository ??= new GenericRepository<ProductsByCategory>(_dbContext.ProductsByCategories);

        public IRepository<QuarterlyOrder> QuarterlyOrdersRepository =>
            _QuarterlyOrdersRepository ??= new GenericRepository<QuarterlyOrder>(_dbContext.QuarterlyOrders);

        public IRepository<Region> RegionsRepository => 
            _RegionsRepository ??= new GenericRepository<Region>(_dbContext.Regions);

        public IRepository<SalesByCategory> SalesByCategoriesRepository => 
            _SalesByCategoriesRepository ??= new GenericRepository<SalesByCategory>(_dbContext.SalesByCategories);

        public IRepository<SalesTotalsByAmount> SalesTotalsByAmountsRepository => 
            _SalesTotalsByAmountsRepository ??= new GenericRepository<SalesTotalsByAmount>(_dbContext.SalesTotalsByAmounts);

        public IRepository<Shipper> ShippersRepository => 
            _ShippersRepository ??= new GenericRepository<Shipper>(_dbContext.Shippers);

        public IRepository<SummaryOfSalesByQuarter> SummaryOfSalesByQuartersRepository => 
            _SummaryOfSalesByQuartersRepository ??= new GenericRepository<SummaryOfSalesByQuarter>(_dbContext.SummaryOfSalesByQuarters);

        public IRepository<SummaryOfSalesByYear> SummaryOfSalesByYearsRepository => 
            _SummaryOfSalesByYearsRepository ??= new GenericRepository<SummaryOfSalesByYear>(_dbContext.SummaryOfSalesByYears);

        public IRepository<Supplier> SuppliersRepository => 
            _SuppliersRepository ??= new GenericRepository<Supplier>(_dbContext.Suppliers);

        public IRepository<Territory> TerritoriesRepository => 
            _TerritoriesRepository ??= new GenericRepository<Territory>(_dbContext.Territories);

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        private void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing)
            {
                _dbContext.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
