# Maritime-Pack-2.0
The offical continuation of the late Maritime Pack mod for Kerbal Space Program

Once again you can easily transport hundreds of tons of cargo, dozens of Kerbals or rovers to distant shores.  
Go yachting on Eve's Explodium Sea, support multiple bases on Laythe by water or experience history and take a 
Paddle-wheel cruise up Kerbin's rivers.  Looking for the ultimate pilot challenge? Try landing on the CVE. 

The ocean is your frontier and to conquer it you only need imagination... and the Maritime Pack 2.0.

## Modules

1. intakeWater - Module to manage ballast water

```
	MODULE
	{
		name = intakeWater
		ResourceName = BallastWater
		flowRate = 5.0
	}
	
	//Required:
	
	RESOURCE
	{
		name = BallastWater
		amount = 0
		maxAmount = 60 //can be any amount
	}
	
```
2. propultionIntake - Takes in IntakeLqd to power the clipper engines.  This will keep IntakeLqd at its maximum amount.

```
	MODULE
	{
		name = propulsionIntake
		ResourceName = IntakeLqd
	}
	
	//Required:
	
	RESOURCE
	{
		name = BallastWater
		amount = 2
		maxAmount = 2 //can be any amount
	}
	
```
	
