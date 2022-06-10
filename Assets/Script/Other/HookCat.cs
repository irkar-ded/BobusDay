using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MoreMountains.CorgiEngine
{
public class HookCat : MonoBehaviour
{
    public CorgiController Gravity;
    public float Spead;
    public Rigidbody2D rigidbody;
    public GameObject Grab;
    bool IsFly;
    public LineRenderer lineRenderer;
    //FMOD Sounds
    FMOD.Studio.EventInstance HookKat_Inst;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer.positionCount = 0;    
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 direction = (Grab.transform.position - transform.position).normalized;
       if(transform.position.x == Grab.transform.position.x){
          IsFly = false;
          Gravity.enabled = true;
       }
       if(IsFly == false){
            if(Input.GetMouseButtonDown(1)){
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(ray, out hit, 100.0f))
                {
                   if (hit.transform != null){
                      if(hit.transform.gameObject.tag == "Tag")
                      {
                        Grab = hit.transform.gameObject;
                        lineRenderer.positionCount = 2;
                        IsFly = true;
                        Debug.Log("Work");
                        
                        //FMOD Sounds
                        HookKat_Inst = FMODUnity.RuntimeManager.CreateInstance("event:/Character/Weapon/Hook-kat");
                        FMODUnity.RuntimeManager.AttachInstanceToGameObject(HookKat_Inst, gameObject.GetComponent<Transform>(), gameObject.GetComponent<Rigidbody2D>());
                        HookKat_Inst.start();
                        HookKat_Inst.release();
                      }
                   }
                }
            }
            Gravity.enabled = true;
       }
       if(IsFly == true)
       {
          if(lineRenderer.positionCount <= 0)return;
          lineRenderer.SetPosition(0,transform.position);
          lineRenderer.SetPosition(1,Grab.transform.position);
          //rigidbody.MovePosition(transform.position + direction * Spead * Time.deltaTime);
          transform.Translate(direction * Spead * Time.deltaTime, Space.World);
          Gravity.enabled = false;
       }
      if(Input.GetMouseButtonUp(1)){
         lineRenderer.positionCount = 0;
         IsFly = false;
         Debug.Log("Work");
      }
    }                            
}
}
