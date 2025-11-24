using Godot;
using System;

namespace CivicLearn2;

public partial class Hud : Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public void OnButtonPressed()
	{
		GetParent().GetNode<Cursor>("Cursor").ToggleActive();
		GD.Print("Button pressed");
		ToggleMenu();
		GetNode<Control>("Labels").Visible = !GetNode<Control>("Labels").Visible;

		GetNode<Button>("ChangeBuildingButton").Text = Cursor.IsActive ? "Change Selected Building" : "Close";
	}

	private void ToggleMenu()
	{
		GetNode<Control>("Popup").Visible = !GetNode<Control>("Popup").Visible;
		GetNode<Control>("Labels").Visible = !GetNode<Control>("Labels").Visible;
	}

	public override void _UnhandledInput(InputEvent @event)
	{
		// When escape key is pressed
		if (Input.IsKeyPressed(Key.Escape))
		{
			if (IsActive())
			{
				OnButtonPressed();
			}
		}
	}

	private bool IsActive()
	{
		Control popup = GetNode<Control>("Popup");
		Control labels = GetNode<Control>("Labels");
		if (popup.Visible && labels.Visible) return true;
		return false;
	}
}