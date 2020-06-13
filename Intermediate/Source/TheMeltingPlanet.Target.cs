using UnrealBuildTool;

public class TheMeltingPlanetTarget : TargetRules
{
	public TheMeltingPlanetTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TheMeltingPlanet");
	}
}
