using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
public class BeamController : MonoBehaviour
{
    Vector3 headPos; // �r�[���̎n�[
    Vector3 endPos;
    List<BeamProto> beamProtos;

    private AsyncOperationHandle<GameObject> BeamHandle;
    private GameObject beamPrefab;

    // Start is called before the first frame update
    void Start()
    {
        // �񓯊���Prefab���擾
        BeamHandle = Addressables.LoadAssetAsync<GameObject>("Beam");

        beamPrefab = BeamHandle.WaitForCompletion();

        // Prefab����Q�[���I�u�W�F�N�g�̍쐬
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(beamPrefab, transform.position, transform.rotation);
        }
    }


    private void OnDestroy()
    {
        Addressables.Release(BeamHandle);
    }

    private void OnDrawGizmos()
    {
        //if (isHit) Gizmos.color = Color.red;
        //else Gizmos.color = Color.white;

        //Gizmos.DrawSphere(headPos + transform.forward * maxDistance, radius);
    }
}
