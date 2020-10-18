console.log("a: " + a);
var a = 20;
console.log("a: " + a);

// (declarando uma variável através do comando var) 
// se existir qualquer tentativa de processamento sobre a variável antes que a mesma seja declarada
// um erro não será gerado, mas no momento do processo, a variável receberá o valor: undefined
// é como se (utilizando o var) a variável fosse declarada, mesmo sem valor, antes que o programa comece a rodar.

// esse efeito é chamado de hoisting e não ocorre com a declaração de variáveis através 
// do comando let