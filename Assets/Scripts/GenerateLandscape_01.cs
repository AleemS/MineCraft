using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLandscape_01 : MonoBehaviour {

    public int worldSizeW = 64;
    public int worldSizeH = 64;

    public GameObject prefabGrass;
    // Use this for initialization
    void Start () {
        int y = 0;
        for(int z = 0; z < worldSizeH; z++){
            for ( int x = 0; x< worldSizeW; x++)
            {
                Vector3 pos = new Vector3(x, y, z);
                Instantiate(prefabGrass, pos, Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
