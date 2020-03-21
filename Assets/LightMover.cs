using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMover : MonoBehaviour {
    public GameObject[] Lights;
    public Material[] renderers;

    void Start()
    {

    }

    public void MoveLights(Vector2 move)
    {
        foreach (var light in Lights)
        {
            float move_x;
            float move_z;
            if(move.y > 0.5)
            {
                move_x = move.y * 90f;
            }
            else
            {
                move_x = move.y * -90f;
            }
            light.transform.rotation = Quaternion.Euler(0, move.y * 180, move.x*180);
        }
    }

    public void LightsRed(float value)
    {
        foreach (var light in renderers)
        {
            light.color = new Color(value, light.color.g, light.color.b, 1); 
        }
    }
    public void LightsGreen(float value)
    {
        foreach (var light in renderers)
        {
            light.color = new Color(light.color.r, value, light.color.b, 1);
        }
    }
    public void LightsBlue(float value)
    {
        foreach (var light in renderers)
        {
            light.color = new Color(light.color.r,light.color.g , value, 1);
        }
    }
    public void LightsWidth(float value)
    {
        foreach (var light in renderers)
        {
            light.SetFloat("_ConeWidth",value-0.5f);
        }
    }
}
