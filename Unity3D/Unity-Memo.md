# Unity3D

### Métodos Unity

`Start ()` = Só vai serchamado **UMA VEZ** quando o código for ativado.<br>
`Update ()` = Será chamado a cada frame (Exemplo: Jogo a 60fps, ele vai ser chamado 60 vezes).<br>
`FixedUpdate ()` = Exatamente igual ao `Update()`, porém será chamado em *_tempos iguais_*.


### _Alguns_ Códigos Unity

`Vector3 A1 = transform.position` -> Irá pegar as cordenadas do objeto (x, y, z) e colocar na variável `A1`<br>
`Time.deltaTime` = Calcula quanto que é 1 segundo baseado nos frame rates.<br><br>
**É SEMPRE Recomendável usar Time.deltaTime no Update() ou FixedUpdate() devido a frame rates de diferentes computadores**<br><br>

Exemplo de Algoritmo:
<pre>
void Update()
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
`OnCollisionEnter()`
