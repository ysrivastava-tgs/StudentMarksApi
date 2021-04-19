using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class BaseRepository<T> : IBaseRepository<T> where T: MarksModel
    {
        private readonly AppDbContext _context;

        public BaseRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task Delete(string id,string subjId)
        {
            /*var employeeModel = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(employeeModel);
            await _context.SaveChangesAsync();*/
            var list =  _context.Set<T>().Where(m => m.Subjid == subjId && m.StudId == id).ToList();
            list[0].Marks = 0;
            _context.Update(list[0]);
            await  _context.SaveChangesAsync();
            
        }

        public async Task<IEnumerable<T>> Get(string studid)
        {
            return await _context.Set<T>().Where(m => m.StudId == studid).ToListAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._context.Set<T>().ToListAsync();
        }

        public async Task Insert(string studId, string subjId, int marks)
        {
            //   _context.Set<T>().Add(entity);
            var a = new MarksModel();
           // a..Id = "dghsafvagab502";
            a.Marks = marks;
            a.StudId = studId;
            a.Subjid = subjId;
            _context.Add(a);
            await _context.SaveChangesAsync();
        }

        public async Task Update(string studid, string subjid, int marks)
        {
            var list = _context.Set<T>().Where(m => m.Subjid == subjid && m.StudId == studid).ToList();
            list[0].Marks = marks;
            _context.Update(list[0]);
            await _context.SaveChangesAsync();
        }
    }
}
