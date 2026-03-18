
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class VehiculoBase
    {
        [Required(ErrorMessage ="La propiedad placa es requerida")]
        [RegularExpression(@"^[A-Za-z]{3}-[0-9]{3}", ErrorMessage = "La placa debe tener el formato ABC-123")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "La propiedad color es requerida")]
        [StringLength(30, ErrorMessage = "El color no puede tener más de 30 caracteres y menos de 4", MinimumLength =4)]
        public string Color { get; set; }

        [Required(ErrorMessage = "La propiedad año es requerida")]
        [RegularExpression(@"^(19|20)\d\d", ErrorMessage = "El formato del año no es válido")]
        [DisplayName("Año")]
        public int Anio { get; set; }

        [Required(ErrorMessage = "La propiedad precio es requerida")]
        public Decimal Precio { get; set; }

        [Required(ErrorMessage = "La correo placa es requerida")]
        [EmailAddress(ErrorMessage = "El formato del correo no es válido")]
        [DisplayName("Correo del Propietario")]
        public string CorreoPropietario { get; set; }

        [Required(ErrorMessage = "La propiedad teléfono es requerida")]
        [Phone(ErrorMessage = "El formato del teléfono no es válido")]
        [DisplayName("Teléfono del Propietario")]
        public string TelefonoPropietario { get; set; }
    }
    public class VehiculoRequest : VehiculoBase
    {
        public Guid IdModelo { get; set; }
    }

    public class VehiculoResponse:VehiculoBase
    {
        public Guid Id { get; set; }
        public string? Modelo { get; set; }
        public string? Marca { get; set; }
    }


    public class VehiculoDetalle : VehiculoResponse
    {
        public bool RevisionValida { get; set; }
        public bool RegistroValido { get; set; }
    }
}
