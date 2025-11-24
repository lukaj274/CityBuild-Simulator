using Godot;
using System;

namespace CivicLearn2;

public partial class TilePaint : TileMapLayer
{
	private const int SourceId = 0;
	
	[Export]
	public Vector2I AtlasCoords {get; set;} = new Vector2I(3, 25);

	private Vector2 _localPosition;
	private Vector2I _cell;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		_localPosition = ToLocal(Cursor.ScreenPos);
		_cell = LocalToMap(_localPosition);
		Cursor.ScreenPos = _cell;
	}

	public override void _Input(InputEvent @event)
	{
		if (Input.IsMouseButtonPressed(MouseButton.Left))
		{
			if (Cursor.IsActive)
			{
				// SetCell(_cell, 0, AtlasCoords);
			}
		}
	}
}
