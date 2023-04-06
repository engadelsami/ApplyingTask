using AlexonDemo.Interfaces;
using AlexonDemo.Repository.Models;

namespace AlexonDemo.Repository
{
    public class ComplainRepository:IComplain
    {
        private AlexonDemoDBDbContext _context;

        public ComplainRepository(AlexonDemoDBDbContext db)
        {
            _context = db;
        }
        public List<Complain> GetAllComplains()
        {

            var allComplains = _context.Complains.ToList();
            return allComplains;
        }




    }
}
