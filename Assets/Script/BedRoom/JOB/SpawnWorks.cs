using System.Collections;
using System;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Rendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Burst;

public class SpawnWorks : MonoBehaviour
{
    [SerializeField] private Material WorkMaterial;
    [SerializeField] private Mesh quadMesh;
    public GameObject _works;
    private EntityManager entityManager;
    private EntityQuery _query;
    // Start is called before the first frame update
    void Start()
    {
        entityManager = Infor.instance_Infor.entityManager;
        //SpawnUnitEntity();
        //SpawnWorkEntity();
        SpawnOBJ();
        

    }

    public void SpawnOBJ()
    {
        Debug.Log("Spawnn");
        Instantiate(_works,
                new Vector3(UnityEngine.Random.Range(-1.27f, 1.11f), UnityEngine.Random.Range(1.7f, -1f), -0.1f), Quaternion.identity);
    }

    private void SpawnWorkEntity()
    {
        SpawnWorkEntity(new float3(UnityEngine.Random.Range(-8, 8f), UnityEngine.Random.Range(-5, 5f), 0));
    }

    private void SpawnWorkEntity(float3 position)
    {
        Entity entity = entityManager.CreateEntity(
            typeof(Translation),
            typeof(LocalToWorld),
            typeof(RenderMesh),
            typeof(Scale),
            typeof(RenderBounds)
            );
        SetEntityComponentData(entity, position, quadMesh, WorkMaterial);
        entityManager.SetComponentData(entity, new Scale { Value = 1.5f });
    }
    private void SetEntityComponentData(Entity entity, float3 SpawnPoint, Mesh qMesh, Material Material)
    {
        entityManager.SetSharedComponentData<RenderMesh>(
            entity,
            new RenderMesh
            {
                material = Material,
                mesh = qMesh
            });
    }

    int i;
        // Update is called once per frame
    void Update()
    {
        
        if (Time.time > i)
        {
            i += 2;
            int k = UnityEngine.Random.Range(1, 2);
            for( int i=0; i<  k;i++)
            {
                SpawnOBJ();
            }
        }

    }
}
