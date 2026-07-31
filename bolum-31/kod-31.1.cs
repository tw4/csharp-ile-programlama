// Kod 31.1 — EF Core 10 ile veri modeli
// DbContext, Varlıklar ve İlişkiler

public class Blog
{
    public int Id { get; set; }
    public required string Baslik { get; set; }
    public List<Yazi> Yazilar { get; set; } = [];
}

public class Yazi
{
    public int Id { get; set; }
    public required string Icerik { get; set; }
    public int BlogId { get; set; }
    public Blog? Blog { get; set; }
}

public class BlogContext(DbContextOptions<BlogContext> secenekler)
    : DbContext(secenekler)
{
    public DbSet<Blog> Bloglar => Set<Blog>();
    public DbSet<Yazi> Yazilar => Set<Yazi>();
}
