using Sandbox;

public sealed class PrefabSpawner : Component
{
	[Property] public string File {get;set;} 
	[Button("Spawn")]public void SpawnPrefab()
	{
		GameObject spawned = new GameObject();
		spawned.SetPrefabSource(File);
		spawned.UpdateFromPrefab();
	}
}
