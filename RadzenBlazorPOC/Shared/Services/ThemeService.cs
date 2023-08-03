using RadzenBlazorPOC.Shared.Services.Interfaces;

namespace RadzenBlazorPOC.Shared.Services
{
    public class ThemeService : IThemeService
    {
        public ThemeService()
        {
            Themes = new List<Theme>()
            {
                new Theme()
                {
                    ThemeID = 1,
                    Name = "Material",
                    Description = "Material Theme",
                    Href = "_content/Radzen.Blazor/css/material-base.css",
                    IsActive = false,
                },
                new Theme()
                {
                    ThemeID = 2,
                    Name = "Default",
                    Description = "Default Theme",
                    Href = "_content/Radzen.Blazor/css/default-base.css",
                    IsActive = false,
                },
                new Theme()
                {
                    ThemeID = 3,
                    Name = "Dark",
                    Description = "Dark Theme",
                    Href = "_content/Radzen.Blazor/css/dark-base.css",
                    IsActive = false,
                },
                new Theme()
                {
                    ThemeID = 4,
                    Name = "Humanistic",
                    Description = "Humanistic Theme",
                    Href = "_content/Radzen.Blazor/css/humanistic-base.css",
                    IsActive = true,
                },
                new Theme()
                {
                    ThemeID = 5,
                    Name = "Software",
                    Description = "Software Theme",
                    Href = "_content/Radzen.Blazor/css/software-base.css",
                    IsActive = false,
                },
                new Theme()
                {
                    ThemeID = 6,
                    Name = "Standard",
                    Description = "Standard Theme",
                    Href = "_content/Radzen.Blazor/css/standard-base.css",
                    IsActive = false,
                },
            };
        }
        public List<Theme> Themes { get; set; }
        public Theme SelectedTheme { get; set; }
        public List<Theme> GetThemes() { return Themes; }

        public void SetTheme(Theme theme) 
        { 
            SelectedTheme = theme;
            Notify?.Invoke();
        }

        public event Action Notify;
    }
}
