using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.Interfaces.DA;
using Abstracciones.Modelos;

namespace DA
{
    public class VehiculoDA : IVehiculoDA
    {
        public Task<Guid> Actualizar(Guid id, VehiculoRequest vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Agregar(VehiculoRequest vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<Guid> Eliminar(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VehiculoResponse>> Obtener()
        {
            throw new NotImplementedException();
        }

        public Task<VehiculoResponse> Obtener(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
