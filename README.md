# Dan Shrout Portfolio — ASP.NET Core Blazor

A Blazor WebAssembly (.NET 10) port of the Expo / React Native portfolio site in the repo root.
It builds to static files, so it can be hosted anywhere (GitHub Pages, Firebase Hosting, Azure Static Web Apps).

## Structure

| Path | Purpose |
| --- | --- |
| `Pages/` | `Home`, `About`, `Work` routes (ported from `app/*.tsx`) |
| `Components/` | `SkillItem`, `PortfolioItem` (ported from `components/`) |
| `Layout/MainLayout.razor` | Header navigation (ported from `components/Header.tsx`) |
| `Data/PortfolioData.cs` | All content: bio, skills, app listings. Edit here to update the site |
| `wwwroot/` | `index.html`, `css/app.css`, images |

## Run

```bash
cd blazor-portfolio
dotnet run          # see Properties/launchSettings.json for the port
```

## Publish

```bash
dotnet publish -c Release -o dist
```

The static site is in `dist/wwwroot`. When hosting under a sub-path (e.g. a GitHub Pages project site at
`/portfolio-site-react-native-expo/`), change `<base href="/" />` in `wwwroot/index.html` to match.
