using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

#nullable disable

namespace Harmony.Infrastructure.Migrations
{
    public partial class ReflectionRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityJournalEntry");

            migrationBuilder.DropTable(
                name: "FeelingJournalEntry");

            migrationBuilder.DropTable(
                name: "JournalEntries");

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

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "2187b64d-3e63-4841-9743-e9abbf80130c");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "78f9ea9a-f403-480e-a2e5-c9abd27aa594");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "8f3bc7e6-2514-48ee-b1e5-748513a6c070");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "d239b2c6-d81f-41ff-a690-f1caf1f84bd1");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "f39d9c69-952f-4ce5-a646-1a48cbcef9c1");

            migrationBuilder.CreateTable(
                name: "Reflections",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false, defaultValue: "00000000-0000-0000-0000-000000000000"),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    MoodId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L)),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reflections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reflections_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reflections_Moods_MoodId",
                        column: x => x.MoodId,
                        principalTable: "Moods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityReflectionEntry",
                columns: table => new
                {
                    ActivitiesId = table.Column<string>(type: "text", nullable: false),
                    ReflectionsId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityReflectionEntry", x => new { x.ActivitiesId, x.ReflectionsId });
                    table.ForeignKey(
                        name: "FK_ActivityReflectionEntry_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityReflectionEntry_Reflections_ReflectionsId",
                        column: x => x.ReflectionsId,
                        principalTable: "Reflections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeelingReflectionEntry",
                columns: table => new
                {
                    FeelingsId = table.Column<string>(type: "text", nullable: false),
                    ReflectionsId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeelingReflectionEntry", x => new { x.FeelingsId, x.ReflectionsId });
                    table.ForeignKey(
                        name: "FK_FeelingReflectionEntry_Feelings_FeelingsId",
                        column: x => x.FeelingsId,
                        principalTable: "Feelings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeelingReflectionEntry_Reflections_ReflectionsId",
                        column: x => x.ReflectionsId,
                        principalTable: "Reflections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "2f806854-cacd-455f-821f-9610bb351385", "Relaxing" },
                    { "37a5e59e-460f-4591-9a5b-6f8b824528a2", "Friends" },
                    { "5ee06913-23ac-4e03-94de-e52db08fa155", "Sports" },
                    { "6cbbd09d-723f-4b67-9827-9e16218476b6", "Exercising" },
                    { "6deeb318-ee5b-47e6-b2a9-f3531864eb6a", "Cleaning" },
                    { "8f53575f-c8ef-48f6-b1b8-d1a6b7c4d03d", "Gaming" },
                    { "99a3bc29-1692-4d45-bc66-efd1374d7710", "Shopping" },
                    { "a0dfde6a-fe59-4b02-a18c-7e55cf958be8", "Reading" },
                    { "b8b4a4b3-fd26-4984-b189-71d84808e310", "Going on a Date" },
                    { "ca3b44b0-8ae3-4077-a39c-5d781a915f10", "Being with Friends" },
                    { "ed7f68b5-deec-49ed-88a3-f3c1cfff0a39", "Being With Family" },
                    { "ed9403f8-4774-445a-b5fb-048c2909973e", "Watching Movies" },
                    { "ffdb0d10-0793-411f-bc68-96eb5d4fa331", "Eating Healthy" }
                });

            migrationBuilder.InsertData(
                table: "Feelings",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "0e209ce8-7dd2-4c76-a4e1-e2ca432286f7", "Anxious" },
                    { "3fc58222-76d1-4151-8723-2b572f69b527", "Stressed" },
                    { "43f04171-111b-493e-86de-6bde784fac2c", "Down" },
                    { "4582e565-8b4d-4524-96d5-e66e7126941a", "Confused" },
                    { "a1ee71dc-c95f-498e-a95f-fa9032d72e87", "Angry" },
                    { "b6a729f6-47ec-4cff-83fb-487df556229d", "Good" },
                    { "b720b75e-b0c7-4d1d-975b-1d5f4c310c00", "Bored" },
                    { "d5fa2510-a448-45b4-bd2b-a8db9dab8e64", "Happy" },
                    { "e7ddd299-26ea-4b90-afb3-ba969e2f8817", "Awkward" },
                    { "fe995b5a-96a1-4caa-986d-8474d830795a", "Blessed" }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "000d7d7b-fcc2-4b15-bfa8-73b75a70cdaf", "Bad" },
                    { "1999caa5-0e76-40ee-a98f-679cd5b6f7e7", "Terrible" },
                    { "5a7455c4-f555-4252-9aa2-7ba1f03c1977", "Awesome" },
                    { "7312d931-b262-483c-ad36-548d93c5d701", "Good" },
                    { "9f7db83e-427c-4d58-9c9f-58c8bfbc80bd", "Okay" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityReflectionEntry_ReflectionsId",
                table: "ActivityReflectionEntry",
                column: "ReflectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_FeelingReflectionEntry_ReflectionsId",
                table: "FeelingReflectionEntry",
                column: "ReflectionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Reflections_MoodId",
                table: "Reflections",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Reflections_UserId",
                table: "Reflections",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityReflectionEntry");

            migrationBuilder.DropTable(
                name: "FeelingReflectionEntry");

            migrationBuilder.DropTable(
                name: "Reflections");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "2f806854-cacd-455f-821f-9610bb351385");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "37a5e59e-460f-4591-9a5b-6f8b824528a2");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "5ee06913-23ac-4e03-94de-e52db08fa155");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "6cbbd09d-723f-4b67-9827-9e16218476b6");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "6deeb318-ee5b-47e6-b2a9-f3531864eb6a");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "8f53575f-c8ef-48f6-b1b8-d1a6b7c4d03d");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "99a3bc29-1692-4d45-bc66-efd1374d7710");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "a0dfde6a-fe59-4b02-a18c-7e55cf958be8");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "b8b4a4b3-fd26-4984-b189-71d84808e310");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "ca3b44b0-8ae3-4077-a39c-5d781a915f10");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "ed7f68b5-deec-49ed-88a3-f3c1cfff0a39");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "ed9403f8-4774-445a-b5fb-048c2909973e");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: "ffdb0d10-0793-411f-bc68-96eb5d4fa331");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "0e209ce8-7dd2-4c76-a4e1-e2ca432286f7");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "3fc58222-76d1-4151-8723-2b572f69b527");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "43f04171-111b-493e-86de-6bde784fac2c");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "4582e565-8b4d-4524-96d5-e66e7126941a");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "a1ee71dc-c95f-498e-a95f-fa9032d72e87");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "b6a729f6-47ec-4cff-83fb-487df556229d");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "b720b75e-b0c7-4d1d-975b-1d5f4c310c00");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "d5fa2510-a448-45b4-bd2b-a8db9dab8e64");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "e7ddd299-26ea-4b90-afb3-ba969e2f8817");

            migrationBuilder.DeleteData(
                table: "Feelings",
                keyColumn: "Id",
                keyValue: "fe995b5a-96a1-4caa-986d-8474d830795a");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "000d7d7b-fcc2-4b15-bfa8-73b75a70cdaf");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "1999caa5-0e76-40ee-a98f-679cd5b6f7e7");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "5a7455c4-f555-4252-9aa2-7ba1f03c1977");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "7312d931-b262-483c-ad36-548d93c5d701");

            migrationBuilder.DeleteData(
                table: "Moods",
                keyColumn: "Id",
                keyValue: "9f7db83e-427c-4d58-9c9f-58c8bfbc80bd");

            migrationBuilder.CreateTable(
                name: "JournalEntries",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false, defaultValue: "00000000-0000-0000-0000-000000000000"),
                    MoodId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L)),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UpdatedAt = table.Column<Instant>(type: "timestamp with time zone", nullable: false, defaultValue: NodaTime.Instant.FromUnixTimeTicks(0L))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JournalEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JournalEntries_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JournalEntries_Moods_MoodId",
                        column: x => x.MoodId,
                        principalTable: "Moods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "16bde70d-2750-4736-9042-defbb3886238", NodaTime.Instant.FromUnixTimeTicks(0L), "Friends", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "3e22b535-1037-473b-97a0-972e559abc28", NodaTime.Instant.FromUnixTimeTicks(0L), "Reading", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "5d1a6c66-26e3-442c-889c-4508e4f3b2c7", NodaTime.Instant.FromUnixTimeTicks(0L), "Being With Family", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "65b3c00c-8781-49f0-a694-9d2a427f2f51", NodaTime.Instant.FromUnixTimeTicks(0L), "Eating Healthy", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "6e0d9512-44e2-4918-bc0c-96a78d945d76", NodaTime.Instant.FromUnixTimeTicks(0L), "Sports", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "714a919c-7109-4adf-ae14-7467a25ce6db", NodaTime.Instant.FromUnixTimeTicks(0L), "Being with Friends", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "971ee79e-fb0c-4e2c-a9f3-3f5e24754ad4", NodaTime.Instant.FromUnixTimeTicks(0L), "Exercising", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "9b4326f4-903f-4802-b463-f6eae2b8546a", NodaTime.Instant.FromUnixTimeTicks(0L), "Shopping", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "a5923265-4983-4624-9c79-88a74f373d0d", NodaTime.Instant.FromUnixTimeTicks(0L), "Relaxing", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "cf45459c-1169-495d-a2cc-4e89dccf9e2d", NodaTime.Instant.FromUnixTimeTicks(0L), "Watching Movies", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "d0364dc1-812f-4158-8458-7a1fc945db35", NodaTime.Instant.FromUnixTimeTicks(0L), "Cleaning", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "f2bcc66e-50b2-405c-92dc-9c4a56c70d47", NodaTime.Instant.FromUnixTimeTicks(0L), "Gaming", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "f5001776-824d-42d4-b090-34b76cde980c", NodaTime.Instant.FromUnixTimeTicks(0L), "Going on a Date", NodaTime.Instant.FromUnixTimeTicks(0L) }
                });

            migrationBuilder.InsertData(
                table: "Feelings",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "046c5fc9-9646-4807-801a-6a52e15f8985", NodaTime.Instant.FromUnixTimeTicks(0L), "Angry", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "0705f1aa-59b4-4235-a737-637c6a7f5a06", NodaTime.Instant.FromUnixTimeTicks(0L), "Bored", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "0a2bc7a7-c5de-44b9-93a4-a57728e6d9e1", NodaTime.Instant.FromUnixTimeTicks(0L), "Anxious", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "166831c0-43a5-4810-ae5a-4b1ce0441377", NodaTime.Instant.FromUnixTimeTicks(0L), "Good", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "2eb3fa36-0ce7-42b4-a6dc-7b40b63d8a0a", NodaTime.Instant.FromUnixTimeTicks(0L), "Awkward", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "6c921675-5f30-4d34-91e9-0fe6725d8da0", NodaTime.Instant.FromUnixTimeTicks(0L), "Stressed", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "976f9451-6cf9-48d6-823c-b22a0aa88943", NodaTime.Instant.FromUnixTimeTicks(0L), "Blessed", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "a41d6f33-1451-4918-b527-b4cde06ebf01", NodaTime.Instant.FromUnixTimeTicks(0L), "Down", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "c088f5ed-b84b-4759-a0e5-fda6477448bf", NodaTime.Instant.FromUnixTimeTicks(0L), "Confused", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "df303b09-2867-44e8-9193-fa891a563610", NodaTime.Instant.FromUnixTimeTicks(0L), "Happy", NodaTime.Instant.FromUnixTimeTicks(0L) }
                });

            migrationBuilder.InsertData(
                table: "Moods",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "2187b64d-3e63-4841-9743-e9abbf80130c", NodaTime.Instant.FromUnixTimeTicks(0L), "Terrible", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "78f9ea9a-f403-480e-a2e5-c9abd27aa594", NodaTime.Instant.FromUnixTimeTicks(0L), "Okay", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "8f3bc7e6-2514-48ee-b1e5-748513a6c070", NodaTime.Instant.FromUnixTimeTicks(0L), "Bad", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "d239b2c6-d81f-41ff-a690-f1caf1f84bd1", NodaTime.Instant.FromUnixTimeTicks(0L), "Good", NodaTime.Instant.FromUnixTimeTicks(0L) },
                    { "f39d9c69-952f-4ce5-a646-1a48cbcef9c1", NodaTime.Instant.FromUnixTimeTicks(0L), "Awesome", NodaTime.Instant.FromUnixTimeTicks(0L) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityJournalEntry_JournalEntriesId",
                table: "ActivityJournalEntry",
                column: "JournalEntriesId");

            migrationBuilder.CreateIndex(
                name: "IX_FeelingJournalEntry_JournalEntriesId",
                table: "FeelingJournalEntry",
                column: "JournalEntriesId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_MoodId",
                table: "JournalEntries",
                column: "MoodId");

            migrationBuilder.CreateIndex(
                name: "IX_JournalEntries_UserId",
                table: "JournalEntries",
                column: "UserId");
        }
    }
}
