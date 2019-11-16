using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StormyCommerce.Core.Entities.Customer;
using StormyCommerce.Infraestructure.Data;

namespace StormyCommerce.Module.Customer.Data
{
    public class CustomStormyUserStore : IUserStore<StormyCustomer>
    {
        private readonly StormyDbContext dbContext;
        public CustomStormyUserStore(StormyDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task<IdentityResult> CreateAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            dbContext.Add(user);
            var result = await dbContext.SaveChangesAsync();
            return result > 0 ? IdentityResult.Success : IdentityResult.Failed();
        }

        public Task<IdentityResult> DeleteAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<StormyCustomer> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<StormyCustomer> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetNormalizedUserNameAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserIdAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetUserNameAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(StormyCustomer user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task SetUserNameAsync(StormyCustomer user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(StormyCustomer user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // Para detectar chamadas redundantes

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: descartar estado gerenciado (objetos gerenciados).
                }

                // TODO: liberar recursos não gerenciados (objetos não gerenciados) e substituir um finalizador abaixo.
                // TODO: definir campos grandes como nulos.

                disposedValue = true;
            }
        }

        // TODO: substituir um finalizador somente se Dispose(bool disposing) acima tiver o código para liberar recursos não gerenciados.
        // ~StormyUserStore()
        // {
        //   // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
        //   Dispose(false);
        // }

        // Código adicionado para implementar corretamente o padrão descartável.
        public void Dispose()
        {
            // Não altere este código. Coloque o código de limpeza em Dispose(bool disposing) acima.
            Dispose(true);
            // TODO: remover marca de comentário da linha a seguir se o finalizador for substituído acima.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
