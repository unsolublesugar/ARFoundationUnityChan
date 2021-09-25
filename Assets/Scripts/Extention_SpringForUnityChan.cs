using UnityEngine;
using System.Collections;
using UnityChan;
 
public class Extention_SpringForUnityChan : MonoBehaviour {
    const float resizeMag = 0.1f; //!< Resize number
 
    void ChangeRadius_Spring(GameObject go){
        SpringCollider[] cs_sc = go.GetComponentsInChildren<SpringCollider>();
        Debug.Log ("Found SpringCollider="+cs_sc.Length);
        for(int i=0;i<cs_sc.Length;i++){
            cs_sc[i].radius = cs_sc[i].radius * resizeMag;
        }
        SpringBone[] cs_sb = go.GetComponentsInChildren<SpringBone>();
        Debug.Log ("Found SpringBone="+cs_sb.Length);
        for(int i=0;i<cs_sb.Length;i++){
            cs_sb[i].radius = cs_sb[i].radius * resizeMag;
        }
    }
 
    void Awake(){
        ChangeRadius_Spring(gameObject);
    }
}