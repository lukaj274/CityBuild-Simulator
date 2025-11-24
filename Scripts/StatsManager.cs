using System;
using Godot;

public partial class StatsManager : Node2D
{
	// Exported fields
	[Export] private RichTextLabel _timeLabel;
	[Export] private RichTextLabel _moneyLabel;
	
	// Public static fields
	public static float Money;
	public static float Education;
	public static float Power;
	public static double Time;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Set initial values
		Money = 1000f;
		Education = 0;
		Power = 0;
		Time = 0;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// Update the Time variable and the timeLabel in the game
		Time += delta;
		_timeLabel.Text = $"Time: {(int)Time}";
		
		_moneyLabel.Text = $"Money: {Money}";
	}
	
	
}
