void FixedUpdate()
{
    Vector3 pos = transform.position;
    pos.z = pos.z + (1.0f * Time.deltaTime);
    transform.position = pos;      
}



or


void FixedUpdate()
{
    Vector3 pos = transform.position;
    pos.z += (1.0f * Time.deltaTime);
    transform.position = pos;      
}
