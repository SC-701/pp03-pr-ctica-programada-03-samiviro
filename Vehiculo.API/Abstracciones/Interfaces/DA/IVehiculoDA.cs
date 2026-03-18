using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface IVehiculoDA
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();
        Task<VehiculoResponse> Obtener(Guid id);
        Task<Guid>  Agregar(VehiculoRequest vehiculo);
        Task<Guid>  Actualizar(Guid id, VehiculoRequest vehiculo);
        Task<Guid>  Eliminar(Guid id);
    }

}
