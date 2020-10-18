// middleware é um padrão que visa pequenas funcoes especialistas
// o foco é tornar tarefas reutilizadas
// a maioria das funcoes chama uma outra funcao

const passo0 = (contexto, next) => {
    contexto.valor1 = 'valor um'
    next()
}

const passo1 = (contexto, next) => {
    contexto.valor2 = 'valor dois'
    next()
}

const passo2 = (contexto) => {
    contexto.valor3 = 'valor três'
}

// funcao que encadeia a execucao das demais funcoes
const exec = (contexto, ...middlewares) => {
    const execPasso = index => {
        if (middlewares && index < middlewares.length) {
            middlewares[index](contexto, () => execPasso(index + 1))
        }
    }
    execPasso(0)
}

obj1 = {}
exec(obj1, passo0, passo1, passo2)
console.log(obj1)