using Godot;
using System;

public partial class StartButton : TextureButton
{
	[Export] public PackedScene MainScene { get; set; }
	[Export] public AudioStreamPlayer2D SoundPlayer { get; set; }
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void OnStartButtonPressed()
	{
		GetTree().ChangeSceneToPacked(MainScene);
		SoundPlayer.Play();
	}
}
