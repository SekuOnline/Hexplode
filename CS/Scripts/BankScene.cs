using Godot;
using System;
using System.Net.Mail;

public partial class BankScene : Node2D
{


	bool alert;
	Node2D alertSprite;
		
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Connect signals to slots by: 
		// 1. creating a variable for the node emitting the signal
		// 2. Adding the event handler to the event as shown in the second line below.
		// You can let the IDE create the event handler function, so that all the params are correctly created.
		var collision = GetNode<Area2D>("Area2D");
		collision.InputEvent += OnSpriteClicked;

		alertSprite = GetNode<Node2D>("AlertSprite");
		setAlert(true);

		GD.Print("Bank Scene Ready!");
	}

    private void OnSpriteClicked(Node _viewport, InputEvent @event, long _shapeIdx)
    {
		if (@event is InputEventMouseButton)
		{
			
			if (@event.IsPressed())
			{
				GD.Print("Bank Pressed!");
				// GD.Print(((InputEventMouseButton)@event).ButtonIndex);

				//reset alert once selected
				setAlert(false);
			}
			
    	}
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}


	public void setAlert(bool alert){
		this.alert = alert;
		GD.Print("Alert set to "+alert.ToString());
		if (alert == true){
			GetNode<Node2D>("AlertSprite").Visible = true;
		}
		else{
			GetNode<Node2D>("AlertSprite").Visible = false;
		}
	}
	
}
