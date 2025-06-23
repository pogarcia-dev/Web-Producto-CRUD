using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyProductoCRUD.Data.Interfaces {
    internal interface ICRUD<T, ID> {
        ID Registrar(T entidad);        // C – Create
        T BuscarPorId(ID id);           // R - Read
        IEnumerable<T> ListarTodo();    // R - Read All
        bool Actualizar(T entidad);     // U - Update
        bool Eliminar(ID id);           // D - Delete
    }
}
