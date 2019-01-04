namespace Challenge.Backend.Models
{
    using Challenge.Domain.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<Challenge.Common.Models.User> Users { get; set; }
    }
}