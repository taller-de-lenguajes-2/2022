using System.ComponentModel.DataAnnotations;


namespace ViewModels
{
    public class CrearTurnoViewModel
    {
        [Required][StringLength(100)][Display(Name="Nombre Cliente")]
        public string NombreCliente { get; set;}

        [Phone]
        public string NumeroTelefono { get; set;}
        
        [Required]
        public string DNI { get; set;}
    }
    
}