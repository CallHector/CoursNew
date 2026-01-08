using UnrealBuildTool;

public class RueMedievaleEditorTarget : TargetRules
{
	public RueMedievaleEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("RueMedievale");
	}
}
