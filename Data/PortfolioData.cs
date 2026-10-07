using PortfolioSite.Models;

namespace PortfolioSite.Data;

public static class PortfolioData
{
    public const string Name = "Dan Shrout";
    public const string LinkedInUrl = "https://www.linkedin.com/in/dan-shrout/";
    public const string GitHubUrl = "https://github.com/Schraut";

    public const string Bio =
        "I'm a software engineer with over 10 years of experience specializing in mobile and web development. " +
        "My focus has been building production iOS, Android, and React Native apps — and I genuinely enjoy the craft. " +
        "I've spent a good portion of my career in startup environments, where moving fast and wearing multiple hats " +
        "comes with the territory. I've taken products from zero to production. I like staying sharp — picking up new " +
        "frameworks, languages, and tools is something I actively seek out, not just endure.";

    private const string Mzstatic = "https://is1-ssl.mzstatic.com/image/thumb/";

    public static readonly IReadOnlyList<Skill> Skills =
    [
        new("Expo", "images/expo-icon-symbol.png"),
        new("React Native", "images/react-logo.png"),
        new("TypeScript", "images/typescript-icon.png"),
        new("JavaScript", "images/javascript.png"),
        new("Node.js", "images/nodejs-icon.png"),
        new("Redux", "images/redux-icon.png"),
        new("iOS", "images/apple-icon.png"),
        new("Swift", "images/swift-icon.png"),
        new("Android", "images/android-icon.png"),
        new("Kotlin", "images/kotlin_icon.png"),
        new("Git", "images/git-icon.png"),
        new("Firebase", "images/firebase-icon.png"),
        new("Azure", "images/azure-icon.png"),
        new("Ruby", "images/ruby-icon.png"),
        new("PostgreSQL", "images/postgresql-icon.png"),
    ];

    public static readonly IReadOnlyList<AppProject> ReactNativeApps =
    [
        new("SEIS Tracker", Mzstatic + "Purple211/v4/27/1f/ab/271faba4-3530-cc24-d16d-19926c7b6d26/AppIcon-0-0-1x_U007epad-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/seis-tracker/id1437211511",
            "https://play.google.com/store/apps/details?id=com.cedrsystems.seistracker&hl=en_US", UsesReactNative: true),
        new("STAART", Mzstatic + "Purple211/v4/c2/a7/7c/c2a77c20-7250-bb32-8301-faf392879bfc/AppIcon-0-0-1x_U007epad-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/staart/id6660725255",
            "https://play.google.com/store/apps/details?id=com.codestack.staart&hl=en", UsesReactNative: true),
        new("Cal Career", Mzstatic + "Purple221/v4/ef/79/67/ef79679d-4101-4534-3de0-3d0594a414ea/AppIcon-0-0-1x_U007epad-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/california-career-center/id6504834313",
            "https://play.google.com/store/apps/details?id=com.codestack.californiacareercenter&hl=en_US", UsesReactNative: true),
        new("CA Dashboard", Mzstatic + "Purple211/v4/6f/90/77/6f9077a5-c95d-60c7-e9e0-e30471abafae/AppIcon-0-0-1x_U007epad-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/ca-dashboard/id1469947640",
            "https://play.google.com/store/apps/details?id=gov.ca.cde.CADashboard&hl=en_US", UsesReactNative: true),
        new("Strong Start", Mzstatic + "Purple126/v4/73/c3/3a/73c33a73-4051-cbf2-1695-2d8375acd812/AppIcon-1x_U007epad-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/strong-start/id1517861555",
            "https://play.google.com/store/apps/details?id=org.codestack.departmenttoolkit.strongstart&hl=en_US", UsesReactNative: true),
        new("CSC Live 2024", Mzstatic + "Purple211/v4/c8/41/60/c841607c-0ea3-644d-ef66-4640cddbd8e3/AppIcon-0-0-1x_U007epad-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/csc-live-2024/id6714479399",
            "https://play.google.com/store/apps/details?id=com.cedr.csclive2024", UsesReactNative: true),
        new("CSC Live 2023", Mzstatic + "Purple126/v4/a7/3f/fb/a73ffb31-520c-b987-46a7-5e5599d4c707/AppIcon-1x_U007emarketing-0-7-0-85-220.png/460x0w.webp",
            "https://apps.apple.com/us/app/csc-live-2023/id6467466603",
            "https://play.google.com/store/apps/details?id=com.cedr.csclive2023&hl=en_US", UsesReactNative: true),
        new("CSC Live 2022", Mzstatic + "Purple122/v4/46/ca/0b/46ca0b8b-e002-e271-6773-c98dbb1fed5b/AppIcon-0-0-1x_U007emarketing-0-0-0-7-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.png/460x0w.webp",
            "https://apps.apple.com/us/app/csc-live-2022/id1643022755",
            "https://play.google.com/store/apps/details?id=com.cedr.csclive2022&hl=en_US", UsesReactNative: true),
        new("CAC", "images/cac.png", IsPublished: false, UsesReactNative: true),
        new("CAPTAIN Cadre Annual Summit", "images/captain-cadre.png", IsPublished: false, UsesReactNative: true),
    ];

    public static readonly IReadOnlyList<AppProject> NativeApps =
    [
        new("Career Surfer", "images/career-surfer-icon.png",
            "https://apps.apple.com/us/app/career-surfer/id605800554",
            "https://play.google.com/store/apps/details?id=com.cedrsystems.careersurfer&hl=en_US"),
        new("Self Screening", "images/self-screening.png",
            "https://apps.apple.com/us/app/schools-self-screening/id1540141318",
            "https://play.google.com/store/apps/details?id=org.codestack.selfscreening&hl=en_US"),
        new("My Stuff CAP", "images/my-stuff-cap.png", IsPublished: false),
        new("My Stuff Job Central", "images/my-stuff-job-central.png", IsPublished: false),
    ];
}
