using Abstracciones.Interfaces.DA;
using Abstracciones.Interfaces.Flujo;
using Abstracciones.Interfaces.Reglas;
using Abstracciones.Modelos;

namespace Flujo
{
    public class VehiculoFlujo : IVehiculoFlujo
    {
        private readonly IVehiculoDA _vehiculoDA;
        private readonly IRegistroReglas _registroReglas;
        private readonly IRevisionReglas _revisionReglas;

        public VehiculoFlujo(IVehiculoDA vehiculoDA,
            IRegistroReglas registroReglas, IRevisionReglas revisionReglas)
        {
            _vehiculoDA = vehiculoDA;
            _registroReglas = registroReglas;
            _revisionReglas = revisionReglas;
        }

        public async Task<Guid> Actualizar(Guid Id, VehiculoRequest vehiculo)
        {
            return await _vehiculoDA.Actualizar(Id, vehiculo);
        }

        public async Task<Guid> Agregar(VehiculoRequest vehiculo)
        {
            return await _vehiculoDA.Agregar(vehiculo);
        }

        public async Task<Guid> Eliminar(Guid Id)
        {
            return await _vehiculoDA.Eliminar(Id);
        }

        public async Task<IEnumerable<VehiculoResponse>> Obtener()
        {
            return await _vehiculoDA.Obtener();
        }

        public async Task<VehiculoDetalle> ObtenerPorID(Guid Id)
        {
            var vehiculo = await _vehiculoDA.ObtenerPorID(Id);

            try
            {
                vehiculo.RegistroValido = await _registroReglas.VehiculoEstaRegistrado(
                    vehiculo.Placa, vehiculo.CorreoPropietario);
            }
            catch
            {
                vehiculo.RegistroValido = false;
            }

            try
            {
                vehiculo.RevisionValida = await _revisionReglas.RevisionEsValida(vehiculo.Placa);
            }
            catch
            {
                vehiculo.RevisionValida = false;
            }

            return vehiculo;
        }
    }
}
