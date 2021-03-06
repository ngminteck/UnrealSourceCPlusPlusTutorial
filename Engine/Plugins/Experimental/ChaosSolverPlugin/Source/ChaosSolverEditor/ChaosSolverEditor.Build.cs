// Copyright Epic Games, Inc. All Rights Reserved.

namespace UnrealBuildTool.Rules
{
	public class ChaosSolverEditor : ModuleRules
	{
        public ChaosSolverEditor(ReadOnlyTargetRules Target) : base(Target)
		{
			PrivateIncludePaths.Add("ChaosSolverEditor/Private");
            PublicIncludePaths.Add(ModuleDirectory + "/Public");

			PublicDependencyModuleNames.AddRange(
				new string[]
				{
					"Core",
					"CoreUObject",
                    "Slate",
                    "SlateCore",
                    "Engine",
                    "UnrealEd",
                    "PropertyEditor",
                    "EditorStyle",
                    "RenderCore",
                    "RHI",
                    "ChaosSolverEngine",
                    "RawMesh",
                    "AssetTools",
                    "AssetRegistry",
					"ToolMenus",
				}
				);

			PrivateDefinitions.Add("CHAOS_INCLUDE_LEVEL_1=1");
		}
	}
}
