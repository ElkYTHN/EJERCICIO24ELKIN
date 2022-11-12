using EJERCICIO22ELKIN.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO22ELKIN.Controllers
{
    public class dbvideo
    {

        readonly SQLiteAsyncConnection dbase;

        public dbvideo(string pathdb)
        {
            dbase = new SQLiteAsyncConnection(pathdb);
            dbase.CreateTableAsync<videorecord>().Wait();
        }
        public Task<List<videorecord>> listarvid()
        {
            return dbase.Table<videorecord>().ToListAsync();
        }
        public Task<videorecord> listar(int pid)
        {
            return dbase.Table<videorecord>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }
        public Task<int> Guardar(videorecord video)
        {
            if (video.id != 0)
            {
                return dbase.UpdateAsync(video);
            }
            else
            {
                return dbase.InsertAsync(video);
            }

        }

        public Task<int> eliminar(videorecord videos)
        {
            return dbase.DeleteAsync(videos);
        }
    }
}
