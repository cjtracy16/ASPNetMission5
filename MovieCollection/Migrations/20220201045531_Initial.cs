using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCollection.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    RatingId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RatingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.RatingId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<short>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    RatingId = table.Column<int>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieId);
                    table.ForeignKey(
                        name: "FK_Responses_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Responses_Rating_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Rating",
                        principalColumn: "RatingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 7, "TV-14" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 6, "NR" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 5, "UR" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 1, "G" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 3, "PG-13" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 2, "PG" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 8, "TV-PG" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 4, "R" });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "RatingId", "RatingName" },
                values: new object[] { 9, "TV-Y7" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 1, 3, "Boaz Yakin", false, "", "Conner's Favs #1", 2, "Remember the Titans", (short)2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 2, 6, "Michael Gracey", false, "", "Conner's Favs #2", 2, "Greatest Showman, The", (short)2017 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieId", "CategoryId", "Director", "Edited", "LentTo", "Notes", "RatingId", "Title", "Year" },
                values: new object[] { 3, 4, "Dan Scanlon", false, "", "Conner's Favs #3", 2, "Onward", (short)2000 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_CategoryId",
                table: "Responses",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_RatingId",
                table: "Responses",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Rating");
        }
    }
}
