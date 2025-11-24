using Godot;
using System;

public partial class School : Node2D
{
	private static int _counter = 0;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_counter++;
		StatsManager.Money -= 100;
		StatsManager.Education += 10;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override string ToString()
	{
		return $"School #{_counter}";
	}
}
