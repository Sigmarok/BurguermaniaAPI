﻿// <auto-generated />
using BurguermaniaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BurguermaniaAPI.Migrations
{
    [DbContext(typeof(BurguermaniaDbContext))]
    partial class BurguermaniaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BurguermaniaAPI.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path_Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Herbívoro e saboroso",
                            Name = "vegan",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Fitness e saudáveis",
                            Name = "fitness",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Felicidade em forma de hambúrguer",
                            Name = "infarto",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg"
                        });
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("StatusId")
                        .HasColumnType("integer");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProducts");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Base_Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Full_Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Path_Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Base_Description = "Pão integral, hambúrguer de grão-de-bico, alface, tomate, picles, pasta de abacate e molho tahine.",
                            CategoryId = 1,
                            Full_Description = "uma escolha deliciosa para quem ama frescor e leveza. O hambúrguer de grão-de-bico é temperado de forma sutil, trazendo uma textura macia e um sabor delicado. A pasta de abacate adiciona cremosidade, enquanto o molho tahine oferece um toque levemente cítrico. Os vegetais frescos equilibram o prato, proporcionando crocância e suculência em cada mordida.",
                            Name = "Green Delight",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 35f
                        },
                        new
                        {
                            Id = 2,
                            Base_Description = "Pão de batata, hambúrguer de lentilha com curry, cebola caramelizada, rúcula, tomate seco e molho de manga com gengibre.",
                            CategoryId = 1,
                            Full_Description = "Uma explosão de sabores exóticos, com o hambúrguer de lentilha absorvendo a intensidade do curry e do gengibre. A cebola caramelizada traz um toque adocicado, enquanto o molho de manga equilibra com frescor e leve acidez. Este hambúrguer é uma verdadeira jornada culinária que combina texturas e aromas únicos.",
                            Name = "Curry Veggie Smash",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 40f
                        },
                        new
                        {
                            Id = 3,
                            Base_Description = "Pão sem glúten, hambúrguer de feijão preto defumado, couve crispy, queijo vegano, cebola marinada e molho barbecue.",
                            CategoryId = 1,
                            Full_Description = "Com sabor profundo e marcante, este hambúrguer é um deleite para os amantes de pratos defumados. O feijão preto é robusto e bem temperado, enquanto a couve crispy adiciona uma textura surpreendente. O molho barbecue vegano realça ainda mais o sabor com seu equilíbrio entre doce e picante.",
                            Name = "Fumaça Verde",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 45f
                        },
                        new
                        {
                            Id = 4,
                            Base_Description = "Pão integral, hambúrguer de frango, alface, tomate e cream cheese light.",
                            CategoryId = 2,
                            Full_Description = "Uma refeição nutritiva e saborosa, o hambúrguer de frango é grelhado e temperado com ervas, resultando em uma carne suculenta e leve. O cream cheese light adiciona um toque cremoso sem comprometer a leveza do prato. Perfeito para quem busca energia e sabor sem abrir mão de uma dieta saudável.",
                            Name = "Fit Chicken Smash",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 35f
                        },
                        new
                        {
                            Id = 5,
                            Base_Description = "Pão de espinafre, hambúrguer de frango e brócolis, abacaxi grelhado, queijo cottage e mostarda dijon.",
                            CategoryId = 2,
                            Full_Description = "Este hambúrguer combina saúde e sofisticação. O hambúrguer é rico em proteínas e fibras, enquanto o abacaxi grelhado traz um sabor tropical que complementa o queijo cottage. A mostarda dijon finaliza com um toque picante, tornando-o uma escolha deliciosa e equilibrada.",
                            Name = "Power Green",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 40f
                        },
                        new
                        {
                            Id = 6,
                            Base_Description = "Hambúrguer de carne magra, alface, tomate, cebola e molho de iogurte com ervas.",
                            CategoryId = 2,
                            Full_Description = "Uma opção leve e saudável, com o hambúrguer de carne magra grelhada garantindo sabor e suculência. As folhas de alface frescas substituem o pão, tornando-o ideal para dietas low-carb. O molho de iogurte com ervas confere um toque refrescante, elevando a experiência gastronômica.",
                            Name = "Low-Carb Smash",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 45f
                        },
                        new
                        {
                            Id = 7,
                            Base_Description = "Pão brioche, hambúrguer duplo, cheddar, cebola crispy, bacon e molho barbecue.",
                            CategoryId = 3,
                            Full_Description = "Um hambúrguer indulgente que combina camadas generosas de carne suculenta com bacon crocante e queijo cheddar derretido. A cebola crispy oferece crocância, enquanto o molho barbecue traz um toque defumado e agridoce. Uma explosão de sabores para os amantes de hambúrgueres robustos.",
                            Name = "Mega Bacon Blast",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 35f
                        },
                        new
                        {
                            Id = 8,
                            Base_Description = "Pão brioche, hambúrguer, cheddar, muçarela, gorgonzola e maionese trufada.",
                            CategoryId = 3,
                            Full_Description = "Para os apaixonados por queijo, este hambúrguer é um sonho. Com três tipos de queijo cuidadosamente combinados, cada mordida traz cremosidade e intensidade de sabor. A carne suculenta é envolvida pela maionese trufada, criando uma experiência rica e irresistível.",
                            Name = "Triple Cheese Heaven",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 40f
                        },
                        new
                        {
                            Id = 9,
                            Base_Description = "Pão australiano, hambúrguer de costela suína, coleslaw, cheddar e bacon.",
                            CategoryId = 3,
                            Full_Description = "Inspirado no churrasco americano, este hambúrguer é uma celebração de sabores. O hambúrguer de costela desfiada é macio e bem temperado, enquanto o coleslaw traz frescor e crocância. O cheddar derretido e o bacon crocante adicionam camadas extras de sabor, resultando em uma experiência única e marcante.",
                            Name = "BBQ Monster Smash",
                            Path_Image = "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg",
                            Price = 45f
                        });
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Pendente"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Confirmado"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Em preparo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "A caminho do cliente"
                        });
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.UserOrder", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("UserOrders");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Order", b =>
                {
                    b.HasOne("BurguermaniaAPI.Models.Status", "Status")
                        .WithMany("Orders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Status");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.OrderProduct", b =>
                {
                    b.HasOne("BurguermaniaAPI.Models.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurguermaniaAPI.Models.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Product", b =>
                {
                    b.HasOne("BurguermaniaAPI.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.UserOrder", b =>
                {
                    b.HasOne("BurguermaniaAPI.Models.Order", "Order")
                        .WithMany("UserOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurguermaniaAPI.Models.User", "User")
                        .WithMany("UserOrders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Order", b =>
                {
                    b.Navigation("OrderProducts");

                    b.Navigation("UserOrders");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Product", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BurguermaniaAPI.Models.User", b =>
                {
                    b.Navigation("UserOrders");
                });
#pragma warning restore 612, 618
        }
    }
}
