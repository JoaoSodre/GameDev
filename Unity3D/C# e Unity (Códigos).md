# C#
### Alguns Tipos de Variáveis

Tipos de Var | Significado | Exemplo
------------ | ----------- | --------
string | Texto | "Cidade"
int | Número inteiro sem<br> Casas Decimais | 50
float | Número com Casas Decimais | 50.0
double | Mesmo que float, Porém <br>com mais casas decimais | 3.1415
bool | Verdadeiro ou Falso | Lâmpada Acesa?
Vector3 | Vetor em 3 Dimensões | (0, 10, 5) `x, y, z`
GameObject | Objeto na Cena | Casa001

### Syntax

`(Tipo de Variável) + (Nome da Variável) = (Valor);`<br>
ou<br>
`(Tipo de Variável) + (Nome da Variável);`<br><br>

Exemplos: <br>`public float peso;` <br>`bool running = true;`<br> `int idade = 30;`<br><br>
<!-- protected + var = só pode ser acessada pelo própio algoritmo. --> 

<br><br><br>

# Unity3D

> É necessário usar either `private` ou `public` antes de uma variável, e [depois declarar qual o tipo dela](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/C%23-Memo.md#alguns-tipos-de-vari%C3%A1veis).

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
`OnCollisionStay()` = É Chamado **Todo** frame que o objeto estiver em colisão.<br>
`OnCollisionEnter()` = É Chamado quando um objeto **Entra** na colisão. <br>
`OnCollisionExit()` = É Chamado quando um objeto **Sai** da colisão. <br><br>
O Mesmo se Aplica no `OnTrigger`, porém ele só é ativado quando pelo _Trigger_ do Collider
