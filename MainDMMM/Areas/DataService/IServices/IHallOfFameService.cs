using MainDMMM.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MainDMMM.Areas.Data.IServices
{
    interface IHallOfFameService
    {
        Task Create(HallOfFame model, HttpPostedFileBase upload);
        Task<HallOfFame> Get(int? id);

        Task Edit(HallOfFame models, HttpPostedFileBase upload);
        Task Delete(int? id);
        Task<List<HallOfFame>> List();
    }
}
