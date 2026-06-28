// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class LobsterReef : ModuleRules
{
	public LobsterReef(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"LobsterReef",
			"LobsterReef/Variant_Platforming",
			"LobsterReef/Variant_Platforming/Animation",
			"LobsterReef/Variant_Combat",
			"LobsterReef/Variant_Combat/AI",
			"LobsterReef/Variant_Combat/Animation",
			"LobsterReef/Variant_Combat/Gameplay",
			"LobsterReef/Variant_Combat/Interfaces",
			"LobsterReef/Variant_Combat/UI",
			"LobsterReef/Variant_SideScrolling",
			"LobsterReef/Variant_SideScrolling/AI",
			"LobsterReef/Variant_SideScrolling/Gameplay",
			"LobsterReef/Variant_SideScrolling/Interfaces",
			"LobsterReef/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
