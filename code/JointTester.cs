using Sandbox;
using Sandbox.Physics;

public sealed class JointTester : Component
{
	Sandbox.Physics.FixedJoint joint;
	[Property] public Rigidbody object1;
	[Property] public Rigidbody object2;
	protected override void OnStart()
	{
		var p1 = new PhysicsPoint(object1.PhysicsBody,object1.Transform.Position);
		var p2 = new PhysicsPoint(object2.PhysicsBody,object1.Transform.Position);
		
		joint = PhysicsJoint.CreateFixed(p1,p2);
		joint.SpringLinear = new PhysicsSpring(100, 5);
		joint.SpringAngular = new PhysicsSpring(100, 5);
	}
}
