using Microsoft.EntityFrameworkCore;
using BurguermaniaAPI.Models;

namespace BurguermaniaAPI.Data
{
    public class BurguermaniaDbContext : DbContext
    {
        public BurguermaniaDbContext(DbContextOptions<BurguermaniaDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserOrder> UserOrders { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações de relacionamentos e chaves primárias
            modelBuilder.Entity<UserOrder>()
                .HasKey(uo => new { uo.UserId, uo.OrderId });

            modelBuilder.Entity<OrderProduct>()
                .HasKey(op => new { op.OrderId, op.ProductId });

            // Configurações adicionais de relacionamentos
            modelBuilder.Entity<UserOrder>()
                .HasOne(uo => uo.User)
                .WithMany(u => u.UserOrders)
                .HasForeignKey(uo => uo.UserId);

            modelBuilder.Entity<UserOrder>()
                .HasOne(uo => uo.Order)
                .WithMany(o => o.UserOrders)
                .HasForeignKey(uo => uo.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(op => op.ProductId);

            base.OnModelCreating(modelBuilder);

    // Seed das Categorias
    modelBuilder.Entity<Category>().HasData(
        new Category { Id = 1, Name = "vegan", Description = "Herbívoro e saboroso", Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" },
        new Category { Id = 2, Name = "fitness", Description = "Fitness e saudáveis", Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" },
        new Category { Id = 3, Name = "infarto", Description = "Felicidade em forma de hambúrguer", Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" }
    );

    // Seed dos Produtos
    modelBuilder.Entity<Product>().HasData(
        // Vegan
        new Product
        {
            Id = 1,
            Name = "Green Delight",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 35,
            Base_Description = "Pão integral, hambúrguer de grão-de-bico, alface, tomate, picles, pasta de abacate e molho tahine.",
            Full_Description = "uma escolha deliciosa para quem ama frescor e leveza. O hambúrguer de grão-de-bico é temperado de forma sutil, trazendo uma textura macia e um sabor delicado. A pasta de abacate adiciona cremosidade, enquanto o molho tahine oferece um toque levemente cítrico. Os vegetais frescos equilibram o prato, proporcionando crocância e suculência em cada mordida.",
            CategoryId = 1
        },
        new Product
        {
            Id = 2,
            Name = "Curry Veggie Smash",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 40,
            Base_Description = "Pão de batata, hambúrguer de lentilha com curry, cebola caramelizada, rúcula, tomate seco e molho de manga com gengibre.",
            Full_Description = "Uma explosão de sabores exóticos, com o hambúrguer de lentilha absorvendo a intensidade do curry e do gengibre. A cebola caramelizada traz um toque adocicado, enquanto o molho de manga equilibra com frescor e leve acidez. Este hambúrguer é uma verdadeira jornada culinária que combina texturas e aromas únicos.",
            CategoryId = 1
        },
        new Product
        {
            Id = 3,
            Name = "Fumaça Verde",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 45,
            Base_Description = "Pão sem glúten, hambúrguer de feijão preto defumado, couve crispy, queijo vegano, cebola marinada e molho barbecue.",
            Full_Description = "Com sabor profundo e marcante, este hambúrguer é um deleite para os amantes de pratos defumados. O feijão preto é robusto e bem temperado, enquanto a couve crispy adiciona uma textura surpreendente. O molho barbecue vegano realça ainda mais o sabor com seu equilíbrio entre doce e picante.",
            CategoryId = 1
        },
        // Fitness
        new Product
        {
            Id = 4,
            Name = "Fit Chicken Smash",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 35,
            Base_Description = "Pão integral, hambúrguer de frango, alface, tomate e cream cheese light.",
            Full_Description = "Uma refeição nutritiva e saborosa, o hambúrguer de frango é grelhado e temperado com ervas, resultando em uma carne suculenta e leve. O cream cheese light adiciona um toque cremoso sem comprometer a leveza do prato. Perfeito para quem busca energia e sabor sem abrir mão de uma dieta saudável.",
            CategoryId = 2
        },
        new Product
        {
            Id = 5,
            Name = "Power Green",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 40,
            Base_Description = "Pão de espinafre, hambúrguer de frango e brócolis, abacaxi grelhado, queijo cottage e mostarda dijon.",
            Full_Description = "Este hambúrguer combina saúde e sofisticação. O hambúrguer é rico em proteínas e fibras, enquanto o abacaxi grelhado traz um sabor tropical que complementa o queijo cottage. A mostarda dijon finaliza com um toque picante, tornando-o uma escolha deliciosa e equilibrada.",
            CategoryId = 2
        },
        new Product
        {
            Id = 6,
            Name = "Low-Carb Smash",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 45,
            Base_Description = "Hambúrguer de carne magra, alface, tomate, cebola e molho de iogurte com ervas.",
            Full_Description = "Uma opção leve e saudável, com o hambúrguer de carne magra grelhada garantindo sabor e suculência. As folhas de alface frescas substituem o pão, tornando-o ideal para dietas low-carb. O molho de iogurte com ervas confere um toque refrescante, elevando a experiência gastronômica.",
            CategoryId = 2
        },
        // Infarto
        new Product
        {
            Id = 7,
            Name = "Mega Bacon Blast",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 35,
            Base_Description = "Pão brioche, hambúrguer duplo, cheddar, cebola crispy, bacon e molho barbecue.",
            Full_Description = "Um hambúrguer indulgente que combina camadas generosas de carne suculenta com bacon crocante e queijo cheddar derretido. A cebola crispy oferece crocância, enquanto o molho barbecue traz um toque defumado e agridoce. Uma explosão de sabores para os amantes de hambúrgueres robustos.",
            CategoryId = 3
        },
        new Product
        {
            Id = 8,
            Name = "Triple Cheese Heaven",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 40,
            Base_Description = "Pão brioche, hambúrguer, cheddar, muçarela, gorgonzola e maionese trufada.",
            Full_Description = "Para os apaixonados por queijo, este hambúrguer é um sonho. Com três tipos de queijo cuidadosamente combinados, cada mordida traz cremosidade e intensidade de sabor. A carne suculenta é envolvida pela maionese trufada, criando uma experiência rica e irresistível.",
            CategoryId = 3
        },
        new Product
        {
            Id = 9,
            Name = "BBQ Monster Smash",
            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
            Price = 45,
            Base_Description = "Pão australiano, hambúrguer de costela suína, coleslaw, cheddar e bacon.",
            Full_Description = "Inspirado no churrasco americano, este hambúrguer é uma celebração de sabores. O hambúrguer de costela desfiada é macio e bem temperado, enquanto o coleslaw traz frescor e crocância. O cheddar derretido e o bacon crocante adicionam camadas extras de sabor, resultando em uma experiência única e marcante.",
            CategoryId = 3
        }
    );
        }
    }
}
