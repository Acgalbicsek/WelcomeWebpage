
using System.ComponentModel.DataAnnotations;

namespace WelcomeWebpage.Models;
public class InfoSection
{
    public int Id { get; set; }

    [Required, StringLength(80)]
    public string Slug { get; set; } = "";   // e.g. "about-the-house"

    [Required, StringLength(150)]
    public string Title { get; set; } = "";

    public string? Content { get; set; }

    public int SortOrder { get; set; } = 0;
    public bool IsVisible { get; set; } = true;

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}
