using MicroRabbit.Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Data.Context
{
    public class TransferDBContext : DbContext
    {
        public DbSet<TransferLog> TransferLogs { get; set; }
        public TransferDBContext(DbContextOptions options) : base(options)
        {

        }
    }
}
