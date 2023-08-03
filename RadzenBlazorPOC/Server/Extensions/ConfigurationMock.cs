using RadzenBlazorPOC.Shared;

namespace RadzenBlazorPOC.Server.Extensions
{
    public static class ConfigurationMock
    {
        public static List<Configuration> GetConfigurations()
        {
            return new List<Configuration>()
            {
                new Configuration()
                {
                    Id = 1,
                    IdGroupConfiguration = 1,
                    Field = "ImagenPiePagina",
                    Name = "Imagen pie de página",
                    Description = "Elija la imágen",
                    IdSelectionType = 4,
                    Options = string.Empty,
                    Order = 7,
                },
                new Configuration()
                {
                    Id = 2,
                    IdGroupConfiguration = 1,
                    Field = "LogoMostrar",
                    Name = "Mostrar logo",
                    Description = "Desea que aparezca el logo?",
                    IdSelectionType = 2,
                    Options = string.Empty,
                    Order = 8,
                },
                new Configuration()
                {
                    Id = 3,
                    IdGroupConfiguration = 1,
                    Field = "TituloOrientacion",
                    Name = "Orientación del título",
                    Description = "Elija la orientación del título",
                    IdSelectionType = 3,
                    Options = "[\"Izquierda\", \"Abajo\"]",
                    Order = 9,
                },
                new Configuration()
                {
                    Id = 4,
                    IdGroupConfiguration = 1,
                    Field = "Letratamano",
                    Name = "Tamaño de la letra",
                    Description = "Elija el tamaño de la letra",
                    IdSelectionType = 3,
                    Options = "[\"10\", \"15\"]",
                    Order = 12,
                },
                new Configuration()
                {
                    Id = 5,
                    IdGroupConfiguration = 1,
                    Field = "Titulotamano",
                    Name = "Tamaño del título",
                    Description = "Elija el tamaño del título",
                    IdSelectionType = 3,
                    Options = "[\"20\", \"10\"]",
                    Order = 10,
                }
            };
        }

        public static List<ConfigurationGroup> GetConfigurationGroups()
        {
            return new List<ConfigurationGroup>()
            {
                new ConfigurationGroup()
                {
                    Id = 1,
                    Name = "AlertasEmail",
                    Description = "Alertas correo electrónico",
                    Order = 2
                },
                new ConfigurationGroup()
                {
                    Id = 2,
                    Name = "Region",
                    Description = "Región",
                    Order = 1
                },
                new ConfigurationGroup()
                {
                    Id = 1,
                    Name = "Apariencia",
                    Description = "Apariencia",
                    Order = 3
                },
                new ConfigurationGroup()
                {
                    Id = 1,
                    Name = "Fuentes",
                    Description = "Fuentes",
                    Order = 4
                },
                new ConfigurationGroup()
                {
                    Id = 1,
                    Name = "DashboardUsuario",
                    Description = "Dashboard Usuario",
                    Order = 5
                }
            };
        }

        public static List<Theme> GetConfigurationTheme()
        {
            return new List<Theme>()
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
    }
}
