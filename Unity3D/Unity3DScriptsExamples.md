# Colisões
`OnCollisionStay()` = É Chamado **Todo** frame que o objeto estiver em colisão.<br>
`OnCollisionEnter()` = É Chamado quando um objeto **Entra** na colisão. <br>
`OnCollisionExit()` = É Chamado quando um objeto **Sai** da colisão. <br><br>
Exemplo: `void OnCollisionStay (Collision[Tipo de informação passada]  col[Nome da colisão]) {...}`<br><br>
A Mesma lógica se Aplica no `OnTrigger`, porém ele só é ativado quando pelo _Trigger_ do Collider

