using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core.Service
{
    public class ProviderService :IProvider
    {
        public async Task<IQueryable<ProviderModel>> GetAll()
        {
            var provider = new List<ProviderModel>();

            provider.Add(new ProviderModel
            {
                CodigoProveedor = 1,
                RazonSocialProveedor = "Proveedor 1",
                CodigoPais = 1,
                DescripcionPais = "Descripción País 1",
                Ciudad = "Ciudad 1",
                Estado = "Estado 1",
                Direccion = "Dirección 1",
                Telefono = "123456789",
                CodigoEstadoProveedor = "Código Estado 1",
                DescripcionEstadoProveedor = "Descripción Estado 1",
                FechaEfectividad = DateTime.Now
            });

            provider.Add(new ProviderModel
            {
                CodigoProveedor = 2,
                RazonSocialProveedor = "Proveedor 2",
                CodigoPais = 2,
                DescripcionPais = "Descripción País 2",
                Ciudad = "Ciudad 2",
                Estado = "Estado 2",
                Direccion = "Dirección 2",
                Telefono = "987654321",
                CodigoEstadoProveedor = "Código Estado 2",
                DescripcionEstadoProveedor = "Descripción Estado 2",
                FechaEfectividad = DateTime.Now
            });

            // Agrega los demás registros de proveedores aquí...

            // Ejemplo con 10 registros en total
            for (int i = 3; i <= 10; i++)
            {
                provider.Add(new ProviderModel
                {
                    CodigoProveedor = i,
                    RazonSocialProveedor = $"Proveedor {i}",
                    CodigoPais = i,
                    DescripcionPais = $"Descripción País {i}",
                    Ciudad = $"Ciudad {i}",
                    Estado = $"Estado {i}",
                    Direccion = $"Dirección {i}",
                    Telefono = $"12345678{i}",
                    CodigoEstadoProveedor = $"Código Estado {i}",
                    DescripcionEstadoProveedor = $"Descripción Estado {i}",
                    FechaEfectividad = DateTime.Now
                });
            }

            return provider.AsQueryable();

        }
    }
}
