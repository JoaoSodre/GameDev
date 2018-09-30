private GameObject target;

void Start()
{
    // Encontra um Gameobject pelo nome na hierarquia e retorna ele
    target = GameObject.Find("FPSController");
}

void Update() 
{
   // Cria um varíavel (Vector3) e atribui os valores x e y (O que faz ele olhar para os lados) do target, porém trava a posição do y nele mesmo o que faz o objeto não olhar para cima nem para baixo (Ele sempre fica na horizontal).
   
   // Criar uma variável pública e colocar no lugar do "transform.position.y" e testar depois, há várias situações que da pra fazer com esse atributo.
   
   Vector3 targetPosition = new Vector3(target.transform.position.x, 
                                        transform.position.y, 
                                        target.transform.position.z) ;
   
   // Olha para a posição do Vector3 criado acima
   transform.LookAt(targetPosition);
}
