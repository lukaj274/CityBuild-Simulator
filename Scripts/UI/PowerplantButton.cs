using Godot;
using System;

public partial class PowerplantButton : Button
{
	// Private Member to keep track of building manager
	[Export] private Buildings buildings;
	
	public override void _Pressed()
	{
		buildings.SelectPowerPlant();
	}
}
