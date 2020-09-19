using System;

namespace TeduShop.Data.Infrastucture
{
    public interface IDbFactory : IDisposable
    {
        TeduShopDbContext Init();
    }
}