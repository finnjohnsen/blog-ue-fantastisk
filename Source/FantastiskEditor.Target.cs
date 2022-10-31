using UnrealBuildTool;
//using System.Collections.Generic;

public class UECleanEditorTarget : TargetRules
{
	public UECleanEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor; // <-- Dette er det viktige
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "UECleanCore" } );
	}
};
