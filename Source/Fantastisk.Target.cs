using UnrealBuildTool;

public class UECleanTarget : TargetRules
{
	public UECleanTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game; // <-- Dette er det viktige
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "UECleanCore" } );
	}
};
