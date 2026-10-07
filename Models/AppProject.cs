namespace PortfolioSite.Models;

public record AppProject(
    string Title,
    string Icon,
    string? AppStoreUrl = null,
    string? GooglePlayUrl = null,
    bool IsPublished = true,
    bool UsesReactNative = false);
