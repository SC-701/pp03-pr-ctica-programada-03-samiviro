using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.DA
{
    public interface IVehiculoDA
    {
        Task<IEnumerable<VehiculoResponse>> Obtener();

        Task<VehiculoDetalle> ObtenerPorID(Guid Id);

        Task<Guid> Agregar(VehiculoRequest vehiculo);

        Task<Guid> Actualizar(Guid Id, VehiculoRequest vehiculo);

        Task<Guid> Eliminar(Guid Id);

    }
}
