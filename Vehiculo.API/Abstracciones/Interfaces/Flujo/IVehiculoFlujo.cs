using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Interfaces.Flujo
{
    public interface IVehiculoFlujo
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();

        Task<VehiculoDetalle> ObtenerPorID(Guid Id);

        Task<Guid> Agregar(VehiculoRequest vehiculo);

        Task<Guid> Actualizar(Guid Id, VehiculoRequest vehiculo);

        Task<Guid> Eliminar(Guid Id);
    }
}
