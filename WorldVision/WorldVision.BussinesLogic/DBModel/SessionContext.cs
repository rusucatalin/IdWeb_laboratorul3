﻿using System.Data.Entity;
using WorldVision.Domain.Entities.User;

namespace WorldVision.BussinesLogic.DBModel
{
    public class SessionContext : DbContext
    {
        public SessionContext() : base("name=catalinBaza")
        {
        }

        public virtual DbSet<Session> Sessions { get; set; }
    }
}
