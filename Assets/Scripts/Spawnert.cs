using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnert : MonoBehaviour
{
    public static Spawnert instance;
    public GameObject spawnedobject;
    private int varx;
    private int varz;
    public int count = 0;
    public List<GameObject> spawnobjects = new List<GameObject>();
    void Start()
    {
        Spawned();
        instance = this;
        
    }

    
    void Update()
    {
       
        
    }
    public void Spawned()
    {

        for (int i = count; i < 5; i++) //objeleri spawn etmek iöin for döngüsü 
        {
            varx = Random.Range(-3, 3); //her objeye random position vermek için random deðerler.
            varz = Random.Range(-7, 8);
            Vector3 vec = new Vector3(varx, 0.6f, varz);
            GameObject spawn = Instantiate(spawnedobject, vec, Quaternion.identity);
            for (int j = 0; j < spawnobjects.Count; j++)
            {
                if (vec == spawnobjects[j].transform.position) //ayný pozisyon var mý diye kontrol edelim.
                {
                    Destroy(spawn);
                    spawn = Instantiate(spawnedobject, vec, Quaternion.identity);

                }
            }
            spawn.transform.parent = this.gameObject.transform;
            spawnobjects.Add(spawn);

            count++;
        }
    }
    public IEnumerator Spawns() //objeler toplandýkça yeniden spawnlayalým
    {
        float randoms = Random.Range(1f, 3f);
        float randomss = Random.Range(0.3f, 1f);
      if (count <= 4)
        {
            yield return new WaitForSeconds(randoms);
            yield return new WaitForSeconds(randomss);
            Spawned();
        }
    }
}
