using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy => policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod());
});
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseCors("AllowFrontend");
app.UseHttpsRedirection();

app.MapGet("/api/bowlers", () =>
{
    var databasePath = Path.GetFullPath(Path.Combine(app.Environment.ContentRootPath, "..", "..", "db", "BowlingLeague.sqlite"));
    var connectionString = $"Data Source={databasePath}";
    var bowlers = new List<BowlerDto>();

    using var connection = new SqliteConnection(connectionString);
    connection.Open();

    using var command = connection.CreateCommand();
    command.CommandText =
        """
        SELECT
            b.BowlerFirstName,
            b.BowlerMiddleInit,
            b.BowlerLastName,
            t.TeamName,
            b.BowlerAddress,
            b.BowlerCity,
            b.BowlerState,
            b.BowlerZip,
            b.BowlerPhoneNumber
        FROM Bowlers b
        INNER JOIN Teams t ON b.TeamID = t.TeamID
        WHERE t.TeamName IN ('Marlins', 'Sharks')
        ORDER BY t.TeamName, b.BowlerLastName, b.BowlerFirstName
        """;

    using var reader = command.ExecuteReader();

    while (reader.Read())
    {
        bowlers.Add(new BowlerDto(
            reader["BowlerFirstName"]?.ToString() ?? string.Empty,
            reader["BowlerMiddleInit"]?.ToString() ?? string.Empty,
            reader["BowlerLastName"]?.ToString() ?? string.Empty,
            reader["TeamName"]?.ToString() ?? string.Empty,
            reader["BowlerAddress"]?.ToString() ?? string.Empty,
            reader["BowlerCity"]?.ToString() ?? string.Empty,
            reader["BowlerState"]?.ToString() ?? string.Empty,
            reader["BowlerZip"]?.ToString() ?? string.Empty,
            reader["BowlerPhoneNumber"]?.ToString() ?? string.Empty
        ));
    }

    return Results.Ok(bowlers);
});

app.Run();

record BowlerDto(
    string FirstName,
    string MiddleInit,
    string LastName,
    string TeamName,
    string Address,
    string City,
    string State,
    string Zip,
    string PhoneNumber
);
