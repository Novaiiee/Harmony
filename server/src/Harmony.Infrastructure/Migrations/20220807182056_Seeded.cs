using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace Harmony.Infrastructure.Migrations
{
    public partial class Seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "JournalEntries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MoodId",
                table: "JournalEntries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "JournalEntries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "JournalEntries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Feelings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Activities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ActivityJournalEntry",
                columns: table => new
                {
                    ActivitiesId = table.Column<string>(type: "text", nullable: false),
                    JournalEntriesId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityJournalEntry", x => new { x.ActivitiesId, x.JournalEntriesId });
                    table.ForeignKey(
                        name: "FK_ActivityJournalEntry_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityJournalEntry_JournalEntries_JournalEntriesId",
                        column: x => x.JournalEntriesId,
                        principalTable: "JournalEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeelingJournalEntry",
                columns: table => new
                {
                    FeelingsId = table.Column<string>(type: "text", nullable: false),
                    JournalEntriesId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelingJournalEntry", x => new { x.FeelingsId, x.JournalEntriesId });
                    table.ForeignKey(
                        name: "FK_FeelingJournalEntry_Feelings_FeelingsId",
                        column: x => x.FeelingsId,
                        principalTable: "Feelings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeelingJournalEntry_JournalEntries_JournalEntriesId",
                        column: x => x.JournalEntriesId,
                        principalTable: "JournalEntries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Moods",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false, defaultValue: "00000000-0000-0000-0000-000000000000"),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L)),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moods", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "16bde70d-2750-4736-9042-defbb3886238", "Friends" },
                    { "3e22b535-1037-473b-97a0-972e559abc28", "Reading" },
                    { "5d1a6c66-26e3-442c-889c-4508e4f3b2c7", "Being With Family" },
                    { "65b3c00c-8781-49f0-a694-9d2a427f2f51", "Eating Healthy" },
                    { "6e0d9512-44e2-4918-bc0c-96a78d945d76", "Sports" },
                    { "714a919c-7109-4adf-ae14-7467a25ce6db", "Being with Friends" },
                    { "971ee79e-fb0c-4e2c-a9f3-3f5e24754ad4", "Exercising" },
                    { "9b4326f4-903f-4802-b463-f6eae2b8546a", "Shopping" },
                    { "a5923265-4983-4624-9c79-88a74f373d0d", "Relaxing" },
                    { "cf45459c-1169-495d-a2cc-4e89dccf9e2d", "Watching Movies" },
                    { "d0364dc1-812f-4158-8458-7a1fc945db35", "Cleaning" },
                    { "f2bcc66e-50b2-405c-92dc-9c4a56c70d47", "Gaming" },
                    { "f5001776-824d-42d4-b090-34b76cde980c", "Going on a Date" }
                });

            migrationBuilder.InsertData(
                table: "Feelings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "046c5fc9-9646-4807-801a-6a52e15f8985", "Angry" },
                    { "0705f1aa-59b4-4235-a737-637c6a7f5a06", "Bored" },
                    { "0a2bc7a7-c5de-44b9-93a4-a57728e6d9e1", "Anxious" },
                    { "166831c0-43a5-4810-ae5a-4b1ce0441377", "Good" },
                    { "2eb3fa36-0ce7-42b4-a6dc-7b40b63d8a0a", "Awkward" },
                    { "6c921675-5f30-4d34-91e9-0fe6725d8da0", "Stressed" },
                    { "976f9451-6cf9-48d6-823c-b22a0aa88943", "Blessed" },
                    { "a41d6f33-1451-4918-b527-b4cde06ebf01", "Down" },
                    { "c088f5ed-b84b-4759-a0e5-fda6477448bf", "Confused" },
                    { "df303b09-2867-44e8-9193-fa891a563610", "Happy" }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2187b64d-3e63-4841-9743-e9abbf80130c", "Terrible" },
                    { "78f9ea9a-f403-480e-a2e5-c9abd27aa594", "Okay" },
                    { "8f3bc7e6-2514-48ee-b1e5-748513a6c070", "Bad" },
                    { "d239b2c6-d81f-41ff-a690-f1caf1f84bd1", "Good" },
                    { "f39d9c69-952f-4ce5-a646-1a48cbcef9c1", "Awesome" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_MoodId",
                table: "JournalEntries",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_UserId",
                table: "JournalEntries",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityJournalEntry_JournalEntriesId",
                table: "ActivityJournalEntry",
                column: "JournalEntriesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeelingJournalEntry_JournalEntriesId",
                table: "FeelingJournalEntry",
                column: "JournalEntriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntries_AspNetUsers_UserId",
                table: "JournalEntries",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JournalEntries_Moods_MoodId",
                table: "JournalEntries",
                column: "MoodId",
                principalTable: "Moods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntries_AspNetUsers_UserId",
                table: "JournalEntries");

            migrationBuilder.DropForeignKey(
                name: "FK_JournalEntries_Moods_MoodId",
                table: "JournalEntries");

            migrationBuilder.DropTable(
                name: "ActivityJournalEntry");

            migrationBuilder.DropTable(
                name: "FeelingJournalEntry");

            migrationBuilder.DropTable(
                name: "Moods");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntries_MoodId",
                table: "JournalEntries");

            migrationBuilder.DropIndex(
                name: "IX_JournalEntries_UserId",
                table: "JournalEntries");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "16bde70d-2750-4736-9042-defbb3886238");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "3e22b535-1037-473b-97a0-972e559abc28");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "5d1a6c66-26e3-442c-889c-4508e4f3b2c7");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "65b3c00c-8781-49f0-a694-9d2a427f2f51");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "6e0d9512-44e2-4918-bc0c-96a78d945d76");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "714a919c-7109-4adf-ae14-7467a25ce6db");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "971ee79e-fb0c-4e2c-a9f3-3f5e24754ad4");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "9b4326f4-903f-4802-b463-f6eae2b8546a");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "a5923265-4983-4624-9c79-88a74f373d0d");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "cf45459c-1169-495d-a2cc-4e89dccf9e2d");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "d0364dc1-812f-4158-8458-7a1fc945db35");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "f2bcc66e-50b2-405c-92dc-9c4a56c70d47");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "f5001776-824d-42d4-b090-34b76cde980c");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "046c5fc9-9646-4807-801a-6a52e15f8985");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "0705f1aa-59b4-4235-a737-637c6a7f5a06");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "0a2bc7a7-c5de-44b9-93a4-a57728e6d9e1");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "166831c0-43a5-4810-ae5a-4b1ce0441377");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "2eb3fa36-0ce7-42b4-a6dc-7b40b63d8a0a");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "6c921675-5f30-4d34-91e9-0fe6725d8da0");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "976f9451-6cf9-48d6-823c-b22a0aa88943");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "a41d6f33-1451-4918-b527-b4cde06ebf01");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "c088f5ed-b84b-4759-a0e5-fda6477448bf");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "df303b09-2867-44e8-9193-fa891a563610");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "MoodId",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Feelings");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Activities");
        }
    }
}
