using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceBlazorNETCore.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Cloud Atlas is the third novel by British author David Mitchell. Published in 2004, it won the British Book Awards Literary Fiction award and the Richard & Judy Book of the Year award. It was short-listed for the Booker Prize, Nebula Award for Best Novel, and Arthur C. Clarke Award, among other accolades. Unusually, it received awards from both the general literary community and the speculative fiction community.", "https://upload.wikimedia.org/wikipedia/en/3/38/Cloud_atlas.jpg", 9.99m, "Cloud Atlas" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Wool initially follows the story of Holston, the Silo's sheriff. All residents of the Silo have been taught that the outside world is toxic and deadly, and anyone who expresses any desire to go outside is sent to clean the external sensors. Those who are sent outdoors this way inevitably clean the sensors as instructed, but they also inevitably die a few minutes later", "https://upload.wikimedia.org/wikipedia/commons/1/1b/Hugh_C_Howey_Wool_Omnibus.jpg", 5.99m, "Wool" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Foundation is a science fiction novel by American writer Isaac Asimov. It is the first published in his Foundation Trilogy (later expanded into the Foundation series). Foundation is a cycle of five interrelated short stories, first published as a single book by Gnome Press in 1951. Collectively they tell the early story of the Foundation, an institute founded by psychohistorian Hari Seldon to preserve the best of galactic civilization after the collapse of the Galactic Empire.", "https://upload.wikimedia.org/wikipedia/en/2/25/Foundation_gnome.jpg", 7.99m, "Foundation" });
        }

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
        }
    }
}
