namespace GameStoreProject.Dto;

public record class GameDTO(
    int Id,
    string Name,
    string Genre,
    float Price
);
