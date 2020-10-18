// valores booleanos

let amilive = true;
let amidead = false;

console.log(amilive, amidead);

// javascript é estranho...
// vários valores podem ser convertidos para true ou false, utilizando o operador de negação (!)

let name = "Lucas";
let name2 = "";
console.log(!!name);
console.log(!!name2);

//true
console.log("verdadeiros...");
console.log(!!3);
console.log(!!-1);
console.log(!!' ');
console.log(!!'texto');
console.log(!![]);
console.log(!!{});
console.log(!!Infinity);
console.log(!!(name = true));

//false
console.log("falsos...");
console.log(!!0);
console.log(!!'');
console.log(!!null);
console.log(!!NaN);
console.log(!!undefined);
console.log(!!(name = false));

// utilizando a estranheza para definir valor padrão:

let nome1 = 'Lucas';
let nome2 = '';

console.log(`
Nome 1: ${nome1 || 'Desconhecido'}
Nome 2: ${nome2 || 'Desconhecido'}`);
