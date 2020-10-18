// referenciando pai do objeto

const avo = {attr1: 'A'}
const pai = {__proto__: avo, attr2: 'B'}
const filho = {__proto__: pai, attr3: 'C'}

Object.prototype.attr0 = 'Z' // não faça isso em casa

console.log(Object.prototype);


// carro
 const carro = {
     velAtual: 0,
     velMax: 200,
     acelerarMais(delta) {
         if (this.velAtual + delta <= this.velMax) {
             this.velAtual += delta
         } else {
             this.velAtual = this.velMax
         }
     }
 }

 const ferrari = {
     modelo: 'F40',
     velMax: 324
 }

 const volvo = {
     modelo = 'V40',
     status() {
         return `${this.modelo}: ${super.status()}`
     }
 }