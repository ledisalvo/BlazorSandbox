namespace RadzenBlazorPOC.Shared.Services.Interfaces
{
    public interface IThemeService
    {
        List<Theme> GetThemes();
        void SetTheme(Theme theme);
        Theme SelectedTheme { get; set; }

        event Action Notify;
    }
}
