using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Хоризонти.Migrations
{
    /// <inheritdoc />
    public partial class Ph : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "57f63071-d529-4561-9793-655b5d1672f2", "AQAAAAIAAYagAAAAEKlfEiECzXg4wdsZSQEFhlYAxJrG0uQ1Ya6vSp5/G/iXB6JyUYIzpVRoE5g6E48nhw==", "/images/planinaM.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "197c1182-f55f-472c-a21c-9ecb643f3c36", "AQAAAAIAAYagAAAAEO9nZkxysYqPAPkcOIZnOa74N09a/SxjFDpZlvbJ7KuOm+JOsyvpeWRfQ5lfwfwjHA==", "/images/jenaE.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "5dbd4465-97f9-43ad-9de2-41ebc3477911", "AQAAAAIAAYagAAAAED/uLyCS/HmnWyOln1oojM02EMWEjkNQN25fVoWmyv/01oM4vXS5sWWwC2f8C/V1+g==", "/images/svetilishtaM.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "859e0c9e-0a28-4172-b126-eb3b7d218b36", "AQAAAAIAAYagAAAAEPiRXZqtLxm2f63ZO3MgoNr4DpKJaXRggOT+RO/glbL25isdi4OpvucgqPxkmz7+Ng==", "/images/vurhh.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "6f2e7382-723c-4002-8233-0abbbef0497d", "AQAAAAIAAYagAAAAEIaXHlPNWPbMuWM0bs1xSykiQof5DvB4JWgmRljzPbZls8HabqVTPBbP1ejthN0nRA==", "/images/planinaM.png" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8c174177-4f16-4b4b-8ba8-5d3975459850", "AQAAAAIAAYagAAAAENRg1VmHGWm7gp5QYw5RjzkMlup//AIHXrFwEOK2fqiLWwWGcElGLyEUZN0eLZkzVQ==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "678c1ddd-8636-423b-88a5-870c6b7d32d7", "AQAAAAIAAYagAAAAEAedJYu6UPTJa0TqobaeRLvswXrvnmazqJkCPZ/mSFOnYpYGrCQDtaiDLjbh2Es4uQ==", "https://thispersondoesnotexist.com/" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22222222-2222-2222-2222-222222222222",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "7a82aa5c-dd90-4070-ac9e-f2ac77cb44ea", "AQAAAAIAAYagAAAAEKMM3k/uYXOVUgKpVQqiGmOtvWd2bQQMh/eH7c6b4mWNLxcjoosqaGQbK8qurMVZJg==", "https://thispersondoesnotexist.com/" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33333333-3333-3333-3333-333333333333",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "27a43dda-b322-4f3b-a566-26532df3b880", "AQAAAAIAAYagAAAAEFOLwKpGmm3gfyJuM5ZccahEaORF98w9GCpNVIgyTqZjZ/kCZ70jlOYmtRF4lwiDEw==", "https://thispersondoesnotexist.com/" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "44444444-4444-4444-4444-444444444444",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "916a79f8-542a-4545-85c4-f6291e91f726", "AQAAAAIAAYagAAAAEFZUJ55P7Dixiy1wG0D0fECyZgJWKZKhqpWLtDJm91nVaG4RV5eu0MKpuNok45+2WQ==", "https://thispersondoesnotexist.com/" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55555555-5555-5555-5555-555555555555",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfileImageUrl" },
                values: new object[] { "3bb3afc1-3a0e-4bbe-b412-a557abc1b1e2", "AQAAAAIAAYagAAAAECjJzLlPOBTjNGD/IItSGtM2U4I0J7jFl5UyGH+6WFhEhjL4MmZtF/p6ZLjq0Dmp3g==", "https://thispersondoesnotexist.com/" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7699db7d-964f-4782-8209-d76562e0fece",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "22e168f3-2b16-4984-90ba-bdacc7e2e30e", "AQAAAAIAAYagAAAAED6a8pHqLB6Zo9HzDOOaNCjXJylKBH4EGiqLhqgBG5D6mJ5R0bW9yg4aa5RRtJ5cmg==" });
        }
    }
}
