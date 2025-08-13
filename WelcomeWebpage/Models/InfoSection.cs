
namespace WelcomeWebpage.Models;
public class InfoSection
{
    public int Id { get; set; }

    public string Title { get; set; }  

    public string Content { get; set; }

    public bool IsVisible { get; set; } = true;
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
}
