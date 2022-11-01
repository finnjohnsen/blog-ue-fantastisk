using UnrealBuildTool;

public class FantastiskTarget : TargetRules
{
	public FantastiskTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game; // <-- Dette er det viktige
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "FantastiskMain" } );
	}
};
