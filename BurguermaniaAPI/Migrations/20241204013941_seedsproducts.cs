using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BurguermaniaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedsproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Path_Image" },
                values: new object[,]
                {
                    { 1, "Herbívoro e saboroso", "vegan", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" },
                    { 2, "Fitness e saudáveis", "fitness", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" },
                    { 3, "Felicidade em forma de hambúrguer", "infarto", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Base_Description", "CategoryId", "Full_Description", "Name", "Path_Image", "Price" },
                values: new object[,]
                {
                    { 1, "Pão integral, hambúrguer de grão-de-bico, alface, tomate, picles, pasta de abacate e molho tahine.", 1, "uma escolha deliciosa para quem ama frescor e leveza. O hambúrguer de grão-de-bico é temperado de forma sutil, trazendo uma textura macia e um sabor delicado. A pasta de abacate adiciona cremosidade, enquanto o molho tahine oferece um toque levemente cítrico. Os vegetais frescos equilibram o prato, proporcionando crocância e suculência em cada mordida.", "Green Delight", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 35f },
                    { 2, "Pão de batata, hambúrguer de lentilha com curry, cebola caramelizada, rúcula, tomate seco e molho de manga com gengibre.", 1, "Uma explosão de sabores exóticos, com o hambúrguer de lentilha absorvendo a intensidade do curry e do gengibre. A cebola caramelizada traz um toque adocicado, enquanto o molho de manga equilibra com frescor e leve acidez. Este hambúrguer é uma verdadeira jornada culinária que combina texturas e aromas únicos.", "Curry Veggie Smash", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 40f },
                    { 3, "Pão sem glúten, hambúrguer de feijão preto defumado, couve crispy, queijo vegano, cebola marinada e molho barbecue.", 1, "Com sabor profundo e marcante, este hambúrguer é um deleite para os amantes de pratos defumados. O feijão preto é robusto e bem temperado, enquanto a couve crispy adiciona uma textura surpreendente. O molho barbecue vegano realça ainda mais o sabor com seu equilíbrio entre doce e picante.", "Fumaça Verde", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 45f },
                    { 4, "Pão integral, hambúrguer de frango, alface, tomate e cream cheese light.", 2, "Uma refeição nutritiva e saborosa, o hambúrguer de frango é grelhado e temperado com ervas, resultando em uma carne suculenta e leve. O cream cheese light adiciona um toque cremoso sem comprometer a leveza do prato. Perfeito para quem busca energia e sabor sem abrir mão de uma dieta saudável.", "Fit Chicken Smash", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 35f },
                    { 5, "Pão de espinafre, hambúrguer de frango e brócolis, abacaxi grelhado, queijo cottage e mostarda dijon.", 2, "Este hambúrguer combina saúde e sofisticação. O hambúrguer é rico em proteínas e fibras, enquanto o abacaxi grelhado traz um sabor tropical que complementa o queijo cottage. A mostarda dijon finaliza com um toque picante, tornando-o uma escolha deliciosa e equilibrada.", "Power Green", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 40f },
                    { 6, "Hambúrguer de carne magra, alface, tomate, cebola e molho de iogurte com ervas.", 2, "Uma opção leve e saudável, com o hambúrguer de carne magra grelhada garantindo sabor e suculência. As folhas de alface frescas substituem o pão, tornando-o ideal para dietas low-carb. O molho de iogurte com ervas confere um toque refrescante, elevando a experiência gastronômica.", "Low-Carb Smash", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 45f },
                    { 7, "Pão brioche, hambúrguer duplo, cheddar, cebola crispy, bacon e molho barbecue.", 3, "Um hambúrguer indulgente que combina camadas generosas de carne suculenta com bacon crocante e queijo cheddar derretido. A cebola crispy oferece crocância, enquanto o molho barbecue traz um toque defumado e agridoce. Uma explosão de sabores para os amantes de hambúrgueres robustos.", "Mega Bacon Blast", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 35f },
                    { 8, "Pão brioche, hambúrguer, cheddar, muçarela, gorgonzola e maionese trufada.", 3, "Para os apaixonados por queijo, este hambúrguer é um sonho. Com três tipos de queijo cuidadosamente combinados, cada mordida traz cremosidade e intensidade de sabor. A carne suculenta é envolvida pela maionese trufada, criando uma experiência rica e irresistível.", "Triple Cheese Heaven", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 40f },
                    { 9, "Pão australiano, hambúrguer de costela suína, coleslaw, cheddar e bacon.", 3, "Inspirado no churrasco americano, este hambúrguer é uma celebração de sabores. O hambúrguer de costela desfiada é macio e bem temperado, enquanto o coleslaw traz frescor e crocância. O cheddar derretido e o bacon crocante adicionam camadas extras de sabor, resultando em uma experiência única e marcante.", "BBQ Monster Smash", "https://img.freepik.com/fotos-premium/hamburguer-artesanal-em-uma-mesa-de-madeira_337384-3224.jpg", 45f }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
