// operador rest/spread 
// ...
// usar rest como parametro de uma função para juntar parametros em lista

// spread em objeto
const funcionario = {nome: "maria", salario: 12348.90};
const clone_funcionario = {...funcionario}; 

console.log(funcionario, clone_funcionario);

// spread em array
const teachers = ["John", "Marcos", "Sid"]
const people = ["Lucas", ...teachers]

console.log(people);

// spread em parametro de funcao
function chamada(...alunos){
    return alunos
}
console.log(chamada('joao', 'luqinha', 'diegola', 'krebão da massa'));