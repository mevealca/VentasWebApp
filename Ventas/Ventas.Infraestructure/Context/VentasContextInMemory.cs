using Microsoft.EntityFrameworkCore;

namespace Ventas.Infraestructure.Context
{
    public abstract class VentasContextInMemory 
    {
        protected DbContextOptions<VentasContext> CreateInMemoryDatabaseOptions()
        {
            return new DbContextOptionsBuilder<VentasContext>()
                       .UseInMemoryDatabase("VentasDb").Options;
        }
    }


}
