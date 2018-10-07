# C#
* [Tutorials Teache - C# (Parecido com W3Schools)](http://www.tutorialsteacher.com/csharp/csharp-tutorials)
* [Dotnetperls (Exemplos e exercícios de c#)](https://www.dotnetperls.com/)

### Alguns Tipos de Variáveis

Tipos de Var | Significado | Exemplo
------------ | ----------- | --------
string | Texto | "Cidade"
int | Número inteiro **sem**<br> Casas Decimais | 50
float | Número com Casas Decimais | 50.0
bool | Verdadeiro ou Falso | Lâmpada Acesa?
Vector3<br>(Unity3D) | Vetor em 3 Dimensões | (0, 10, 5) `x, y, z`
GameObject<br>(Unity3D) | Objeto na Cena | Casa001

### Collections
Hash Array
### Loopings

o `break` é usado para encerar o looping vai para } // if [a==1]{break;}<br>
o `continue` é usado para

while = enquanto tal condição, execute o bloco.<br>
do..while = faça a operação primeiro e depois entra no looping.<br>
for = já determina a quantidade de repetições.<br>
foreach = varre um array.

<!-- do while, for e foreach(array)  https://unity3d.com/learn/tutorials/topics/scripting/loops?playlist=17117  -->

# Syntaxes

### Variáveis

> É necessário usar either `private` ou `public` antes de uma variável, e [depois declarar qual o tipo dela](https://github.com/JoaoSodre/GameDev/blob/master/Unity3D/C%23%20e%20Unity%20(C%C3%B3digos).md#alguns-tipos-de-vari%C3%A1veis) quando estiver usando **Unity Engine**.

`(Tipo de Variável) + (Nome da Variável) = (Valor) ;`<br>
`(Tipo de Variável) + (Nome da Variável) ;`<br>
`(Tipo de Variável) + (Nome da Variável) , (Nome de outra Variável) , ... ;` <br><br>

Exemplos: <br>`bool running = true;`<br> `int idade = 30;`<br> `public float A1, A2, A3;`<br><br>

### Collections
Hash Array
### Loopings


### Coroutines

Uma Co-Rotina é basicamente uma função com intervalos de **tempo** definidos.<br>
EX:<br>
<pre>
doThing1();
[Wait 5 seconds];
doThing2();
</pre>

Nesse caso o `[Wait 5 seconds]` seria a co-rotina

# Orientação Objeto
