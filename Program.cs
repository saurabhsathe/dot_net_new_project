using GameStoreProject.Dto;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


List<GameDTO> games =[
    new (1,"GTA 5","MMORPG",23.5F),
    new (2,"Witcher 3","MMORPG",13.5F),
    new (3,"Pacman","2D",1F),
    new (4,"CS GO","FPS",10.333F)

];


app.MapGet("/", () => "Hello World!");
app.MapGet("games", () => games);
app.MapGet("games/genre/{genre}", (string genre) => games.FindAll(game=>game.Genre.ToLower()==genre.ToLower()));
app.MapGet("games/id/{id}", (int id) => games.Find(game=>game.Id==id));


app.Run();
