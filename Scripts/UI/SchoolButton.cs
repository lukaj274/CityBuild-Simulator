using Godot;
using System;

public partial class SchoolButton : Button
{
	// Private Member to keep track of building manager
	[Export] private Buildings buildings;

	public override void _Pressed()
	{
		buildings.SelectSchool();
	}
}