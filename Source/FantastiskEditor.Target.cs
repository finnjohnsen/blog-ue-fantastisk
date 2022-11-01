using UnrealBuildTool;

public class FantastiskEditorTarget : TargetRules
{
	public FantastiskEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor; // <-- Dette er det viktige
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "FantastiskMain" } );
	}
};
