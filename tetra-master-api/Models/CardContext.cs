using Microsoft.EntityFrameworkCore;

namespace tetra_master_api.Models;

public class CardContext : DbContext
{
  public CardContext(DbContextOptions<CardContext> options)
  : base(options)
  {
  }

  public DbSet<Card> Cards { get; set; } = null!;
}