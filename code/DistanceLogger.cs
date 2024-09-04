using Sandbox;

public sealed class DistanceLogger : Component
{
	[Property] public GameObject Point1 {get;set;}
	[Property] public GameObject Point2 {get;set;}
	protected override void OnUpdate()
	{
		Log.Info(Vector3.DistanceBetween(Point1.Transform.Position,Point2.Transform.Position));
	}
}
