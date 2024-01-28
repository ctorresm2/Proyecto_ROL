using Proyecto_ROL.Models;

namespace Proyecto_ROL.Data
{
    public class DA_Logica
    {
        public List<Usuario> ListaUsuarios() {

            return new List<Usuario>
            {
                new Usuario{Nombre="jose",Correo="administrado@gmail.com",Clave="123", Roles= new string[]{"Administrador"} },
                new Usuario{Nombre="maria",Correo="supervisor@gmail.com",Clave="123", Roles= new string[]{"Supervisor"} },
                new Usuario{Nombre="juan",Correo="empleado@gmail.com",Clave="123", Roles= new string[]{"Empleado"} },
                new Usuario{Nombre="oscar",Correo="superempleado@gmail.com",Clave="123", Roles= new string[]{"Supervisor ","Empleado"} }

            };
        }

        public Usuario ValidarUsuario (string _correo, string _clave) { 
            return ListaUsuarios().Where(item => item.Correo == _correo && item.Clave == _clave).FirstOrDefault();
        
        }

    }
}
