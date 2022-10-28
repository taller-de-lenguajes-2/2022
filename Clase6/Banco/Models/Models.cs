namespace Banco.Models
{
    public class Banco
    {
        List<Turno> Turnos;
    }

    public class Turno
    {
        private int numero;
        private DateTime fechaYHora;
        private Cliente cliente;
        private bool tipoTurno;

        public DateTime FechaYHora { get => fechaYHora; set => fechaYHora = value; }
        public bool TipoTurno { get => TipoTurno; set => TipoTurno = value; }
        public int Numero { get => numero; set => numero = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }

    public abstract class Cliente
    {
        protected string nombre;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
        }


        public abstract string ObtenerNombre();
    }

    public class Persona : Cliente
    {
        private string apellido;
        private string dNI;

        public Persona(string nombre,string apellido, string dNI) : base(nombre)
        {           
            this.apellido = apellido;
            this.dNI = dNI; 
        }

        public override string ObtenerNombre()
        {
            return nombre +", "+ apellido;
        }
    }

    public class Empresa : Cliente
    {
        private string cUIT;

        public Empresa(string nombre, string cUIT) : base (nombre)
        {
            this.cUIT = cUIT;
        }

        public override string ObtenerNombre()
        {
            return nombre + ", " + cUIT;
        }

    }
}