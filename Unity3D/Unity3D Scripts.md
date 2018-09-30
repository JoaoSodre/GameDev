# Unity3D

> Esta lista possui apenas algumas anotações sobre o conhecimento de scripts do unity.

<!-- `this.[...]` = Refere-se ao objeto que o script está attached to. <br>
[Como Desabilitar Componentes](https://unity3d.com/learn/tutorials/topics/scripting/enabling-and-disabling-components?playlist=17117)
<br><br> -->

### Messages do MonoBehaviour

> Nota: Quando estiver programando no unity, é obrigatório começar o algoritmo dentro de um desses messages para o código funcionar

`Start ()` = Apenas irá ser chamado uma vez quando o script for **ativado**. [(Diferença entre Awake e Start)](https://unity3d.com/learn/tutorials/topics/scripting/awake-and-start?playlist=17117)<br>
`Update ()` = Será chamado a cada frame [(Diferença entre Update e FixedUpdate)](https://unity3d.com/learn/tutorials/topics/scripting/update-and-fixedupdate?playlist=17117). See Also [LateUpdate ( )](https://docs.unity3d.com/ScriptReference/MonoBehaviour.LateUpdate.html) <br>
[Colisões ( )](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/Scripts/ScriptsExamples.md#colis%C3%B5es) = Quando a box de um objeto intersecta com a box de outro objeto.<br> <br>

### Methods e Propeties

> [O que são Classes, Propeties e Methods? (Orientação Objeto)]()

`transform.position`**[Vector3]** = Irá pegar as cordenadas do objeto (x, y, z).<br>
`Input. GetKey, GetKeyDown ou GetKeyUp`**[bool]** = Retorna **sempre** quando estiver **seguranda**, **uma vez** quando for pressionada ou **uma vez** quando soltada, respectivamente. <br>
`casa001.SetActive(true/false)`**[bool]** = Habilita ou desabilita o GameObject. <br>
`Destroy(casa001)` = Deleta o objeto da hierarquia.<br>
<!-- Mathf.Lerp, Mathf.SmoothStep, Mathf.SmoothDamp -->
