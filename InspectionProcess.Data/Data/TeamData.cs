using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectionProcess.Data
{
    public class TeamData : EntityData<Team>
    {
        public Team Get(int teamId)
        {
            InspectionProcessEntities context = CreateContext();

            return context.Teams.FirstOrDefault(a => a.TeamId == teamId);
        }

        public void Delete(int teamId)
        {
            Team team = Get(teamId);

            if (team == null)
                return;

            Delete(team);
        }

        public int GetMaxId()
        {
            InspectionProcessEntities context = CreateContext();

            var query = from x in context.Teams
                        orderby x.TeamId descending
                        select x.TeamId;

            return query.FirstOrDefault();
        }

    }
}
