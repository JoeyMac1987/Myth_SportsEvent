﻿using IngestionLib.EntityFramework.DALModels;
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
    public class MetadataRepository : RepositoryBase<metadata>, IMetadataRepository
    {
        public MetadataRepository(SportsEventDBContext context) : base(context)
        {
            this.dbSet = context.Set<metadata>();
        }
    }
}