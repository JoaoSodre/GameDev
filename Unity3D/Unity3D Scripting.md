# Unity3D

### Métodos do Unity

[Colisões ( )]() = Quando a box de um objeto intersecta com a box de outro objeto.<br>
`Start ()` = Apenas irá ser chamado **UMA VEZ** quando o script for ativado.<br>
`Update ()` = Será chamado a cada frame (Exemplo: Jogo a 60fps, ele vai ser chamado 60 vezes).<br>
`FixedUpdate ()` = Exatamente igual ao `Update()`, porém será chamado em *_tempos iguais_* (Usar co-rotina para definir os **intervalos** de tempos).<br><br>

### _Alguns_ Códigos Unity
[Como Desabilitar Componentes](https://unity3d.com/learn/tutorials/topics/scripting/enabling-and-disabling-components?playlist=17117)
<br><br>
`this.[...]` = Refere-se ao objeto que o script está attached to. <br><br>
`public GameObject casa001;` <br><br>
`transform.position`**[Vector3]** = Irá pegar as cordenadas do objeto (x, y, z).<br>
`Input. GetKey, GetKeyDown ou GetKeyUp`**[bool]** = Retorna **sempre** quando estiver **seguranda**, **uma vez** quando for pressionada ou **uma vez** quando soltada, respectivamente. <br>
`casa001.SetActive(true/false)`**[bool]** = Habilita ou desabilita o GameObject. <br>
`Destroy(casa001)` = Deleta o objeto da hierarquia.<br><br><br><br>
<!-- Mathf.Lerp, Mathf.SmoothStep, Mathf.SmoothDamp -->

**É SEMPRE Recomendável usar coroutines em alguns casos em vez de Time.deltaTime no Update(), FixedUpdate() ou LateUpdate()**
<br><br><br>
### Colisões
`OnCollisionStay()` = É Chamado **Todo** frame que o objeto estiver em colisão.<br>
`OnCollisionEnter()` = É Chamado quando um objeto **Entra** na colisão. <br>
`OnCollisionExit()` = É Chamado quando um objeto **Sai** da colisão. <br>
O Mesmo se Aplica no `OnTrigger`, porém ele só é ativado quando pelo _Trigger_ do Collider<br><br><br>
Exemplo: `void OnCollisionStay (Collision[Tipo de informação passada]  col[Nome da colisão]) {...}`
