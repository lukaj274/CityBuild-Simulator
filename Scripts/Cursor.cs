using System;
using Godot;
using System.Collections.Generic;

namespace CivicLearn2;

public partial class Cursor : Area2D
{
	public static Vector2 ScreenPos;
	public static bool IsActive { get; private set; } = true;
	
	[Export]
	public PackedScene SelectedBuilding { get; set; }
	
	[Export]
	public TileMapLayer GroundMap { get; set; }

	private List<Node2D> _newScenes = new();
	
	public override void _Process(double delta)
	{
		// Get Mouse Position
		ScreenPos = GetViewport().GetMousePosition();
		
		GlobalPosition = ScreenPos;

		// [OLD CODE] Instantiate the selected scene
		if (Input.IsMouseButtonPressed(MouseButton.Left))
		{
			// Variable to keep track of how many newScenes there are
			/*
			int i = 0;
			
			// Location Variable
			Vector2 screenPos = new Vector2(ScreenPos.X, ScreenPos.Y);
			
			// Add a new scene
			_newScenes.Add((Node2D)SelectedBuilding.Instantiate());
			_newScenes[i].GlobalPosition = screenPos;
			AddChild(_newScenes[i]);
			
			// Increment i and print length to console
			i++;
			GD.Print(i);
			*/
		}
	}
	
	public void ToggleActive()
	{
		IsActive = !IsActive;
		Visible = !Visible;
	}
}
