using System.Text.Json.Nodes;
using Sandbox;

public sealed class ObjectStorer : Component
{
	[Property] public GameObject Object {get;set;}
	JsonObject Stored;
	[Property] public bool Spawn {get;set;}
	protected override void OnUpdate()
	{
		if(Object != null)
		{
			Stored = Object.Serialize();
			Object.DestroyImmediate();
			Object = null;
		}

		if(Spawn)
		{
			GameObject newObject = new();
			newObject.Deserialize( Stored );
			Spawn = false;
		}
	}
}
