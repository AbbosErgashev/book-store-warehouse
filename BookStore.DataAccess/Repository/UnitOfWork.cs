using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepository;

namespace BookStore.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDBContext _db;
        public ICategoryRepository Category { get; private set; }

        public ICompanyRepository Company { get; private set; }

        public IProductRepository Product { get; private set; }

        public IShoppingCartRepository ShoppingCart { get; private set; }

        public IApplicationUserRepository ApplicationUser { get; private set; }
        public UnitOfWork(ApplicationDBContext db)
        {
            _db = db;
            Category = new CategoryRepository(db);
            Company = new CompanyRepository(db);
            Product = new ProductRepository(db);
            ShoppingCart = new ShoppingCartRepository(db);
            ApplicationUser = new ApplicationUserRepository(db);
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
