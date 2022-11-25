using IngestionLib.EntityFramework.DALModels;
using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.Interface;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.Repository
{
    public class StateRepository : RepositoryBase<State>, IStateRepository
    {
        public StateRepository(SportsEventDBContext context) : base(context)
        {
            this.dbSet = context.Set<State>();
        }
    }
}
