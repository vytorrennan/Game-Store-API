using System.ComponentModel.DataAnnotations;

namespace GameStore.api.Dtos;

public record class GenreDto(
    [Required] int Id,
    [Required][StringLength(50)] string Name
);