# Unity3D

É necessário usar either `private` ou `public` antes de uma variável, e [depois declarar qual o tipo dela](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/C%23-Memo.md#alguns-tipos-de-vari%C3%A1veis). 

### Métodos do Unity

[Colisões](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/Unity-Memo.md#colis%C3%B5es)<br>
`Start ()` = Só vai serchamado **UMA VEZ** quando o código for ativado.<br>
`Update ()` = Será chamado a cada frame (Exemplo: Jogo a 60fps, ele vai ser chamado 60 vezes).<br>
`FixedUpdate ()` = Exatamente igual ao `Update()`, porém será chamado em *_tempos iguais_*.

### _Alguns_ Códigos Unity

`transform.position`**[Vector3]** = Irá pegar as cordenadas do objeto (x, y, z)<br>
`Time.deltaTime`**[float]** = Calcula quanto que é 1 segundo baseado nos frame rates.<br>
`if (Imput.GetKey("A")) {...}` = Se a tecla A for pressionada...<br>
`Destroy(casa001)` = Deleta o objeto casa001( **[GameObject]** ) do mundo.<br><br>
**É SEMPRE Recomendável usar Time.deltaTime no Update() ou FixedUpdate() devido a frame rates de diferentes computadores**<br><br>

Exemplo de Algoritmo:
<pre>
void FixedUpdate()
{
    Vector3 pos = transform.position;
    pos.z = pos.z + (1.0f * Time.deltaTime);
    transform.position = pos;      
}
</pre>
<br>
O Objeto irá pra direção Z uma unidade (1.0f) por segundo.<br>

**Nota:** `pos.z += (1.0f * Time.deltaTime);` também funcionaria nesse caso.

### Colisões
`OnCollisionStay()` = <br>
`OnCollisionEnter()` = <br>
`OnCollisionExit()` = <br><br>
`OnTriggerEnter()` = <br>
`OnTriggerStay()` = <br>
`OnTriggerExit()` = <br>
