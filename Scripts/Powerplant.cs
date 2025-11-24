using Godot;

public partial class Powerplant : Node2D
{
	private static int _counter = 0;
	private static bool _hasBeenRun;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_counter++;
		StatsManager.Money -= 200;
		StatsManager.Power += 10;
		_hasBeenRun = false;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		int addedMoney = 0;
		
		if ((int)StatsManager.Time % 10 == 0 && !_hasBeenRun)
		{
			while (addedMoney != 100)
			{
				StatsManager.Money += StatsManager.Power;
				GD.Print("Money added.");
				addedMoney += (int)StatsManager.Power;
			}
			_hasBeenRun = true;
		}
		else if ((int)StatsManager.Time % 10 != 0)
		{
			_hasBeenRun = false;
		}
	}

	public override string ToString()
	{
		return $"Power Plant #{_counter}";
	}
}
