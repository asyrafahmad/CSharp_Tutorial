using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpCheatSheet.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contentDetails",
                columns: table => new
                {
                    videoId = table.Column<string>(nullable: false),
                    videoPublishedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contentDetails", x => x.videoId);
                });

            migrationBuilder.CreateTable(
                name: "pageInfo",
                columns: table => new
                {
                    totalResults = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    resultsPerPage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pageInfo", x => x.totalResults);
                });

            migrationBuilder.CreateTable(
                name: "snippet",
                columns: table => new
                {
                    publishedAt = table.Column<DateTime>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_snippet", x => x.title);
                });

            migrationBuilder.CreateTable(
                name: "YoutubeAPIViewModels",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Tumbnail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoutubeAPIViewModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoResults",
                columns: table => new
                {
                    kind = table.Column<string>(nullable: false),
                    etag = table.Column<string>(nullable: true),
                    pageInfototalResults = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoResults", x => x.kind);
                    table.ForeignKey(
                        name: "FK_VideoResults_pageInfo_pageInfototalResults",
                        column: x => x.pageInfototalResults,
                        principalTable: "pageInfo",
                        principalColumn: "totalResults",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "YoutubeResults",
                columns: table => new
                {
                    kind = table.Column<string>(nullable: false),
                    etag = table.Column<string>(nullable: true),
                    nextPageToken = table.Column<string>(nullable: true),
                    pageInfototalResults = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YoutubeResults", x => x.kind);
                    table.ForeignKey(
                        name: "FK_YoutubeResults_pageInfo_pageInfototalResults",
                        column: x => x.pageInfototalResults,
                        principalTable: "pageInfo",
                        principalColumn: "totalResults",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "videoItems",
                columns: table => new
                {
                    kind = table.Column<string>(nullable: true),
                    etag = table.Column<string>(nullable: true),
                    id = table.Column<string>(nullable: false),
                    snippettitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videoItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_videoItems_VideoResults_kind",
                        column: x => x.kind,
                        principalTable: "VideoResults",
                        principalColumn: "kind",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_videoItems_snippet_snippettitle",
                        column: x => x.snippettitle,
                        principalTable: "snippet",
                        principalColumn: "title",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "resultItems",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    kind = table.Column<string>(nullable: true),
                    etag = table.Column<string>(nullable: true),
                    contentDetailsvideoId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resultItems", x => x.id);
                    table.ForeignKey(
                        name: "FK_resultItems_contentDetails_contentDetailsvideoId",
                        column: x => x.contentDetailsvideoId,
                        principalTable: "contentDetails",
                        principalColumn: "videoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_resultItems_YoutubeResults_kind",
                        column: x => x.kind,
                        principalTable: "YoutubeResults",
                        principalColumn: "kind",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resultItems_contentDetailsvideoId",
                table: "resultItems",
                column: "contentDetailsvideoId");

            migrationBuilder.CreateIndex(
                name: "IX_resultItems_kind",
                table: "resultItems",
                column: "kind");

            migrationBuilder.CreateIndex(
                name: "IX_videoItems_kind",
                table: "videoItems",
                column: "kind");

            migrationBuilder.CreateIndex(
                name: "IX_videoItems_snippettitle",
                table: "videoItems",
                column: "snippettitle");

            migrationBuilder.CreateIndex(
                name: "IX_VideoResults_pageInfototalResults",
                table: "VideoResults",
                column: "pageInfototalResults");

            migrationBuilder.CreateIndex(
                name: "IX_YoutubeResults_pageInfototalResults",
                table: "YoutubeResults",
                column: "pageInfototalResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resultItems");

            migrationBuilder.DropTable(
                name: "videoItems");

            migrationBuilder.DropTable(
                name: "YoutubeAPIViewModels");

            migrationBuilder.DropTable(
                name: "contentDetails");

            migrationBuilder.DropTable(
                name: "YoutubeResults");

            migrationBuilder.DropTable(
                name: "VideoResults");

            migrationBuilder.DropTable(
                name: "snippet");

            migrationBuilder.DropTable(
                name: "pageInfo");
        }
    }
}
