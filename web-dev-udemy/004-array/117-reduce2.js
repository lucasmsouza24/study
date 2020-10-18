const alunos = [
    { nome: 'João', nota: 7.3, bolsista: false},
    { nome: 'Maria', nota: 9.2, bolsista: true},
    { nome: 'Pedro', nota: 9.8, bolsista: false},
    { nome: 'Ana', nota: 8.7, bolsista: true},
]

// Desafio 1: Todos os alunos são bolsistas?

const d1 = alunos.map(element => element['bolsista']).reduce((acc, crr) => acc && crr)
console.log(d1)

// Desafio 2: Algum aluno é bolsista?

const d2 = alunos.map(element => element['bolsista']).reduce((acc, crr) => acc || crr)
console.log(d2)