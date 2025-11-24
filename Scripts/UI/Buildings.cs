using Godot;
using System;
using CivicLearn2;

public partial class Buildings : Node2D
{
	[Export] public TileMapLayer GroundMap;
	[Export] public Node2D BuildingsLayer;

	[Export] public PackedScene SchoolScene;
	[Export] public PackedScene PowerplantScene;

	private PackedScene _selectedBuilding = null;

	public override void _UnhandledInput(InputEvent @event)
	{
		if (@event is InputEventMouseButton mouseEvent && mouseEvent.Pressed)
		{
			// Left click
			if (mouseEvent.ButtonIndex == MouseButton.Left && _selectedBuilding != null)
			{
				PlaceBuilding(GetGlobalMousePosition());
			}

			// Right click to cancel
			if (mouseEvent.ButtonIndex == MouseButton.Right)
			{
				_selectedBuilding = null;
			}
		}
	}

	private void PlaceBuilding(Vector2 mousePos)
	{
		if (Cursor.IsActive)
		{
			Vector2I tilePos = GroundMap.LocalToMap(mousePos);
			Vector2 worldPos = GroundMap.MapToLocal(tilePos);

			// Optional: snap to tile center
			Vector2 cellSize = GroundMap.TileSet.TileSize;
			worldPos += cellSize / 2.0f;

			Node2D building = (Node2D)_selectedBuilding.Instantiate();
			building.Position = worldPos;
			BuildingsLayer.AddChild(building);

			GD.Print($"{_selectedBuilding} is placed at {worldPos}");
		}
	}

	// Called by UI buttons to set which building to place
	public void SelectSchool()
	{
		_selectedBuilding = SchoolScene;
		GD.Print("School is selected");
	}

	public void SelectPowerPlant()
	{
		_selectedBuilding = PowerplantScene;
		GD.Print("Power plant is selected");
	}
}
