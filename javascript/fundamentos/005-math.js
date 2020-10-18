//Math.PI Constante de PI.
console.log(Math.PI) //Output: 3.141592653589793

//Math.pow(x, y) Potenciação de base x e expoente y.
console.log(Math.pow(2, 5)) //Output: 32

//Math.round(x) Retorna o valor inteiro mais próximo de x.
console.log(Math.round(4.6)) //Output: 5
console.log(Math.round(4.4)) //Output: 4

//Math.ceil(x) Retorna o número inteiro (para cima) mais próximo de x.
console.log('ceil')
console.log(Math.ceil(4.3)) //Output: 5

//Math.floor(x) Retorna o número inteiro (para baixo) mais próximo de x.
console.log(Math.floor(5.9)) //Output: 5

//Math.sqrt(x) Retorna a raiz quadrada de x.
console.log(Math.sqrt(81)) //Output: 9
console.log(Math.sqrt(64)) //Output: 8
console.log(Math.sqrt(49)) //Output: 7
console.log(Math.sqrt(36)) //Output: 6
console.log(Math.sqrt(25)) //Output: 5

//Math.abs(x) Retorna o valor absoluto (positivo) de x.
console.log(Math.abs(10)) //Output: 10
console.log(Math.abs(-10)) //Output: 10

//Math.sin(x) Retorna o seno (um valor entre -1 e 1) do ângulo x (dado em radianos).
//Se você deseja usar graus em vez de radianos, é necessário converter graus em radianos:
//Ângulo em radianos = ângulo em graus x PI / 180.
console.log(Math.sin(90 * Math.PI / 180)) //Output: 1

//Math.cos(x) Retorna o cosseno (um valor entre -1 e 1) do ângulo x (dado em radianos).
//Se você deseja usar graus em vez de radianos, é necessário converter graus em radianos:
//Ângulo em radianos = ângulo em graus x PI / 180.
console.log(90 * Math.PI / 180) //Output: 1.5707963267948966

//Math.tan(x) Retorna a tangente (um valor entre -1 e 1) do ângulo x (dado em radianos).
//Se você deseja usar graus em vez de radianos, é necessário converter graus em radianos:
//Ângulo em radianos = ângulo em graus x PI / 180.
console.log(Math.tan(45 * Math.PI / 180))

//Math.random() Retorna um valor entre 0 e 1 (Exclusivamente)
console.log(Math.random()) 

//Math.min(a, b, c, ..., n) Retorna o menor valor da lista de argumentos.
console.log(Math.min(5, 3, 7, 2)) //Output: 2

//Math.max(a, b, c, ..., n) Retorna o maior valor da lista de argumentos.
console.log(Math.max(5, 3, 7, 2)) //Output: 7 