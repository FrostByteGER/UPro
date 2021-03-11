// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;

public class Pro : ModuleRules
{
	public Pro(ReadOnlyTargetRules TargetRules) : base(TargetRules)
	{
		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "Paper2D" });
	}
}
