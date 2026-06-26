using Godot;
using System;

public partial class CupWater : TextureButton
{
	//[Export] public NodePath LabelPath;
	//private Label water_label;
	private int water_amount;
	
	public override void _Ready()
	{
		//water_label = GetNode<Label>($"../../WaterLabel");
		Pressed += ButtonPressed;
	}
	
	private void ButtonPressed()
	{
		//A cup icon will fill with water. Currently using placeholder.
		water_amount += 8;
		//water_label.Text = "Water today: " + water_amount;
		
		GD.Print("Water cup has been pressed.");
	}
}
