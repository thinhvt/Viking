using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking.Data.Models.Entities.Repositories;

namespace Viking.Data.Models.Entities.Services
{
    public interface ITeamService
    {
        List<tbl_Team> getAllTeams();
        void add(tbl_Team item);
        void delete(int id);
        void update(tbl_Team item);
    }
    public class TeamService
    {
        TeamRepository rep = new TeamRepository();

        public List<tbl_Team> getAllTeams()
        {
            return rep.getAll();
        }
        public void add(tbl_Team item)
        {
            rep.add(item);
        }

        public void delete(int id)
        {
            rep.delete(id);
        }

        public void update(tbl_Team item)
        {
            rep.update(item);
        }
    }
}
