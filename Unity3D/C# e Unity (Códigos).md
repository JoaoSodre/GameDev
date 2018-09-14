# C#
### Alguns Tipos de Variáveis

Tipos de Var | Significado | Exemplo
------------ | ----------- | --------
string | Texto | "Cidade"
int | Número inteiro **sem**<br> Casas Decimais | 50
float | Número com Casas Decimais | 50.0
bool | Verdadeiro ou Falso | Lâmpada Acesa?
Vector3 | Vetor em 3 Dimensões | (0, 10, 5) `x, y, z`
GameObject | Objeto na Cena | Casa001

### Syntax

> É necessário usar either `private` ou `public` antes de uma variável, e [depois declarar qual o tipo dela](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/C%23%20e%20Unity%20(C%C3%B3digos).md#alguns-tipos-de-vari%C3%A1veis) quando estiver usando **Unity Engine**.

`(Tipo de Variável) + (Nome da Variável) = (Valor) ;`<br>
`(Tipo de Variável) + (Nome da Variável) ;`<br>
`(Tipo de Variável) + (Nome da Variável) , (Nome de outra Variável) , ... ;` <br><br>

Exemplos: <br>`bool running = true;`<br> `int idade = 30;`<br> `public float A1, A2, A3;`<br><br>
<!-- protected + var = só pode ser acessada pelo própio algoritmo. --> 

<br><br><br><br>





# Unity3D

### Métodos do Unity

[Colisões ( )](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/Unity-Memo.md#colis%C3%B5es)<br>
`Start ()` = Só vai serchamado **UMA VEZ** quando o código for ativado.<br>
`Update ()` = Será chamado a cada frame (Exemplo: Jogo a 60fps, ele vai ser chamado 60 vezes).<br>
`FixedUpdate ()` = Exatamente igual ao `Update()`, porém será chamado em *_tempos iguais_*.

### _Alguns_ Códigos Unity
[Como Desabilitar Componentes](https://unity3d.com/learn/tutorials/topics/scripting/enabling-and-disabling-components?playlist=17117)<br><br>
`public GameObject casa001;` <br>
`transform.position`**[Vector3]** = Irá pegar as cordenadas do objeto (x, y, z).<br>
`Time.deltaTime`**[float]** = Calcula quanto que é 1 segundo baseado nos frame rates.<br>
`if (Input.GetKey("A")) {...}` = Se a tecla A for pressionada...<br>
`casa001.SetActive(true/false)`**[bool]** = Habilita ou desabilita o GameObject. <br>
`Destroy(casa001)` = Deleta o objeto da hierarquia.<br><br>

**É SEMPRE Recomendável usar Time.deltaTime no Update(), FixedUpdate() ou LateUpdate() devido a frame rates de diferentes computadores**

### Colisões
`OnCollisionStay()` = É Chamado **Todo** frame que o objeto estiver em colisão.<br>
`OnCollisionEnter()` = É Chamado quando um objeto **Entra** na colisão. <br>
`OnCollisionExit()` = É Chamado quando um objeto **Sai** da colisão. <br>
O Mesmo se Aplica no `OnTrigger`, porém ele só é ativado quando pelo _Trigger_ do Collider<br><br>
Exemplo: `void OnCollisionStay (Collision[Tipo de informação passada]  col[Nome da colisão]) {...}`
