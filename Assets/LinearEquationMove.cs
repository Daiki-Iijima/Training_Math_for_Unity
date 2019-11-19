using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearEquationMove : MonoBehaviour
{
    [SerializeField]
    private Transform pos1;
    [SerializeField]
    private Transform pos2;

    private float diff;

    private GameObject obj;
    float _y = 0;
    float _x = 0;

    public float Speed;
    // Start is called before the first frame update
    void Start()
    {


        obj = Instantiate(pos1.gameObject);

        _x = pos1.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        diff = (pos1.position.y - pos2.position.y) / (pos1.position.x - pos2.position.x);

        if (pos1.position.x - pos2.position.x < 0)
        {
            if (_x <= pos2.position.x)
            {
                _x += Speed / 100;
                obj.transform.position = new Vector2(_x, (diff * _x) - (diff * pos2.position.x) + pos2.position.y);
            }
            else
            {
                obj.transform.position = pos2.position;
            }
        }
        else if (pos1.position.x - pos2.position.x > 0)
        {
            if (_x >= pos2.position.x)
            {
                _x -= Speed / 100;
                obj.transform.position = new Vector2(_x, (diff * _x) - (diff * pos2.position.x) + pos2.position.y);
            }
            else
            {
                obj.transform.position = pos2.position;
            }
        }
    }


}
