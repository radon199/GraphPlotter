using UnrealBuildTool;

public class GraphPlotter : ModuleRules
{
    public GraphPlotter(ReadOnlyTargetRules Target) : base(Target)
    {
        MinFilesUsingPrecompiledHeaderOverride = 1;
        bUseUnity = false;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
        PrivateDependencyModuleNames.AddRange(new string[] { });

        PublicIncludePaths.AddRange(new string[] { "GraphPlotter/Public" });
        PrivateIncludePaths.AddRange(new string[] { "GraphPlotter/Private", "GraphPlotter/Utils" });

    }
}