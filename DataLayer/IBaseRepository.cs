using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface IBaseRepository<T> where T : BaseModel
    {
        Task<IEnumerable<T>> GetAll();
        Task<IEnumerable<T>> Get(string id);
        Task Insert(string studid, string subjid,int marks);
        Task Update(string studid, string subjid, int marks);
        Task Delete(string id,string subjid);
    }
}
