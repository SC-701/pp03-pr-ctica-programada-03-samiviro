using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Modelos;

namespace Flujo
{
    public class VehiculoFlujo : IVehiculoFlujo
    {
        private IVehiculoDA _vehiculoDA;

        public VehiculoFlujo(IVehiculoDA vehiculoDA)
        {
            _vehiculoDA = vehiculoDA;
        }

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
