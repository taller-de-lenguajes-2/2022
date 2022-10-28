
using Banco.Models;
using ViewModels;

public class MapperTurnoDiaViewModel
{
    public List<TurnoDiaViewModel> GetTurnoViewModel(List<Turno> turnos)
    {
        List<TurnoDiaViewModel> viewModels = new List<TurnoDiaViewModel>();
        foreach (var turno in turnos)
        {
            var turnoViewModel = new TurnoDiaViewModel();
            turnoViewModel.FechaYHora = turno.FechaYHora.ToShortDateString();
            turnoViewModel.NombreCliente = turno.Cliente.ObtenerNombre();
            turnoViewModel.NumeroDeTurno = turno.Numero;
            viewModels.Add(turnoViewModel);
        }
        return viewModels;
    }
}