﻿using System.Data.Entity;
using WorldVision.Domain.Entities.User;

namespace WorldVision.BussinesLogic.DBModel
{
    class UserContext : DbContext
    {
        public UserContext() : 
            base("name=catalinBaza") // connectionstring name define in your web.config
        {
        }

        public virtual DbSet<UDbTable> Users { get; set; }
    }
}
