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
    public class Navigation_infoRepository : RepositoryBase<navigation_info>, INavigation_infoRepository
    {
        public Navigation_infoRepository(SportsEventDBContext context) : base(context)
        {
            this.dbSet = context.Set<navigation_info>();
        }
    }
}
