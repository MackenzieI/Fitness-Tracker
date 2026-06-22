using Godot;
using System;

public partial class IButton : Button
{
	public override void _Ready()
	{
		Pressed += ButtonPressed;
	}
	
	private void ButtonPressed()
	{
		GD.Print("I Button has been pressed.");
		GetTree().ChangeSceneToFile("res://Input Info.tscn");
	}
}
