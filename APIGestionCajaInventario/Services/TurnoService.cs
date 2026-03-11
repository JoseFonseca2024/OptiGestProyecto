using APIGestionCajaInventario.DAO;
using APIGestionCajaInventario.Dto.Turnos;

namespace APIGestionCajaInventario.Services
{
    public class TurnoService
    {
        private readonly TurnoDAO _turnoDAO;

        public TurnoService(TurnoDAO turnoDAO)
        {
            _turnoDAO = turnoDAO;
        }

        public async Task<int> AbrirTurnoAsync(TurnoCreateDto dto)
        {
            return await _turnoDAO.AbrirTurnoAsync(dto.CajaID, dto.UsuarioID, dto.MontoInicial);
        }
    }
}
