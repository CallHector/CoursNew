using UnrealBuildTool;

public class RueMedievaleTarget : TargetRules
{
	public RueMedievaleTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("RueMedievale");
	}
}
