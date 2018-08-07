using MelhorPrecoSempreIT.Models;
using System;
using System.Linq;

namespace MelhorPrecoSempreIT.Services
{
    public class UsuariosDAL
    {
        public static bool Login(string usuario, string senha)
        {
            try
            {
                using (RestaurantesDBContext entities = new RestaurantesDBContext())
                    return entities.Usuarios.Any(user => user.LoginUsuario.Equals(usuario, StringComparison.OrdinalIgnoreCase) && user.SenhaUsuario.Equals(senha));
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException("Ocorreu um problema ao processar sua solicitação: " + ex.Message);
            }
        }

    }
}