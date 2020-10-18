// destructuring em arrays

let array1 = [1, 2, 3, 4, 5];

const [a] = array1;
const [, b] = array1;

console.log(a, b);

// aplicando o destructing em uma matriz
let matriz = [[1, 2], [3, 4]];

const [[c]] = matriz;
const [[, d]] = matriz;
const [[], [e]] = matriz;
const [[], [, f]] = matriz;

console.log(c, d, e, f);
