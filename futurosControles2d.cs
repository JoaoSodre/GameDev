public float speed = 80;

// Controles
void FixedUpdate()
{
    // Retorna 1 ou -1 se eu tiver apertando W ou Setinha pra cima
    float honzPress = Input.GetAxisRaw("Horizontal");
    float vertPress = Input.GetAxisRaw("Vertical");

    // Pega o resultado e multiplica pela speed
    GetComponent<Rigidbody2D>().velocity = new Vector2(honzPress, vertPress) * speed;
}
