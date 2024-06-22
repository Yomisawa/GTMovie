public class Movie(string title, string description, Image coverImage = null)
{
    public string Title { get; set; } = title;
    public string Description { get; set; } = description;
    public Image CoverImage { get; set; } = coverImage;
}
