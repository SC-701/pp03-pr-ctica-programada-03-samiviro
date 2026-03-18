using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace Abstracciones.Interfaces.API
{
    public interface IVehiculoController
    {
        Task<IActionResult> Obtener();

        Task<IActionResult> ObtenerPorID(Guid Id);

        Task<IActionResult> Agregar(VehiculoRequest vehiculo);

        Task<IActionResult> Actualizar(Guid Id, VehiculoRequest vehiculo);

        Task<IActionResult> Eliminar(Guid Id);
    }
}
