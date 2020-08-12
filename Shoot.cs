using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float coolDown = 1f;
    float lastFireTime = 0 ;
    public int defaultAmmo = 120 ;
    public int magSize= 30 ;
    public int currentAmmo;
    public int currentMagAmmo;
    public Camera camera;
    public int range;
    [Header("Gun Damage On Hit")]
    public int damage;
    public GameObject bloodPrefab;
    public GameObject decalPrefab;
    public ParticleSystem muzzleParticle;
    
    int minAngle = -1 ; 
    int maxAngle = 1 ;
    

    // Start is called before the first frame update
    void Start()
    {
        currentAmmo = defaultAmmo - magSize;
        currentMagAmmo = magSize ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
        if (Input.GetMouseButton(0))
        {
            if (CanFire())
            {
                Fire();
            }
            Fire();
        }
    }

    private void Reload()
    {
        if (currentAmmo == 0 || currentMagAmmo == magSize)
        {
            return;
        }
        if (currentAmmo < magSize)
        {
            currentMagAmmo = currentMagAmmo + currentAmmo;
            currentAmmo = 0 ;
        }
        else
        {
        currentAmmo -= magSize - currentMagAmmo ;
        currentMagAmmo = magSize ;
        }
       
       
    }
    private bool CanFire()

    {   

        if (currentMagAmmo > 0 && lastFireTime + coolDown < Time.time)
        {
            lastFireTime = Time.time + coolDown ; 
            return true;
        }
        
        return false;
    }
    
    private void Fire ()
    {   
        muzzleParticle.Emit(3);
        currentMagAmmo -= 1 ;
        Debug.Log("Kalan Mermim:"+ currentMagAmmo);
        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position,camera.transform.forward,out hit,10 ))
        {
            if(hit.transform.tag == "Zombie")
            {
                hit.transform.GetComponent<ZombieHealth>().Hit(damage);
                GenerateBloodEffect(hit);

            }

            else
            {
                GenarateHitEffect(hit);

            }
        }
        transform.localEulerAngles = new Vector3 (Random.Range(minAngle,maxAngle),Random.Range(minAngle,maxAngle),Random.Range(minAngle,maxAngle));
    
    
    }


    private void GenarateHitEffect(RaycastHit hit)
    {
        //TODO : Mermi izi oluştur.
        GameObject hitObject = Instantiate(decalPrefab, hit.point, Quaternion.identity);
        hitObject.transform.rotation = Quaternion.FromToRotation(decalPrefab.transform.forward * -1 ,hit.normal);


    }

    private void GenerateBloodEffect(RaycastHit hit)
    {
        GameObject bloodObject = Instantiate (bloodPrefab,hit.point,hit.transform.rotation);


        //bloodPrefab.transform.position = hit.point;

        //bloodPrefab.SetActive(true);

        Debug.Log ("Kan efekti oluşturuldu");
    }
}