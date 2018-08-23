public float speed = 30;
void FixedUpdate(){
  
  // Retorna 1 ou -1 se eu tiver apertando w ou setinha pra cima
  float vertPress = Input.GetAxisRaw ("Vertical");
  
  // Pega o resultado e multiplica pela speed
  GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, vertPress) * speed;
}
