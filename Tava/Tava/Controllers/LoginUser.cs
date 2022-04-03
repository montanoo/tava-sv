using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tava.Models;
using Tava.Views;

namespace Tava.Controllers
{
    class LoginUser
    {
        /* para darle uso a las estructuras de datos, añadiremos los usuarios a 
         listas simplemente enlazadas */

        // el método get info se encargará de obtener los valores
        public AdminList GetInfo()
        {
            var linkedUsers = new AdminList();
            // utilizamos el contexto generado por el Entity Framework para acceder a la bd.
            using (var db = new TavaContext())
            {
                // acá están almacenados absolutamente todos los usuarios que están en la bd.
                var users = db.Users;

                /* recorremos a los usuarios con "var",
                 pudimos usar la clase "user" que se creo al usar Entity Framework. */

                foreach (var user in users)
                {
                    linkedUsers.InsertTail(user);
                }
            }
            // retornamos esa lista.
            return linkedUsers;
        }

        public bool Login(string pUsername, string pPassword)
        {
            // leemos los datos con el método anterior.
            var valuesToWork = GetInfo();
            bool found = false; // bandera que me indicará si se encuentra un usuario que cumpla con las características.

            var currentUser = valuesToWork.Head;

            // recorremos la lista enlazada.
            while (currentUser != null)
            {
                // si encontramos una coincidencia, buscamos que rol tiene.
                if (currentUser.Data.Username == pUsername && currentUser.Data.Password == pPassword)
                {
                    found = true;
                }
                currentUser = currentUser.Next;
            }
            if (!found)
            {
                MessageBox.Show(
                    "No hemos encontrado tu usuario, asegurate de haber escrito tu usuario y contraseña correctamente");
            }

            return found;
        }
    }
}
