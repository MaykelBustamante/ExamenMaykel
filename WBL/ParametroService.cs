using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
     public interface IProveedorService
    {
        Task<DBEntity> Create(ParametroEntity entity);
        Task<DBEntity> Delete(ParametroEntity entity);
        Task<IEnumerable<ParametroEntity>> Get();
        Task<ParametroEntity> GetById(ParametroEntity entity);
        Task<DBEntity> Update(ParametroEntity entity);
    }
    class ParametroService
    {
    }
}
