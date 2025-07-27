using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HymnStocks.Models;

namespace HymnStocks.Data
{
    public class HymnStocksDBContext : DbContext
    {
        public HymnStocksDBContext (DbContextOptions<HymnStocksDBContext> options)
            : base(options)
        {
        }

        public DbSet<HymnStocks.Models.HymnInfo> HymnInfo { get; set; } = default!;
    }
}
