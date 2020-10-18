const fs = require('fs')

const path = __dirname + '/file.json'
// console.log(__dirname)

// sincrono ...

// uma string é retornada
const content = fs.readFileSync(path, 'utf-8')
console.log(typeof content)

// assincrono
// exige muito cuidado, de forma assincrona, o node começa a ler o arquivo enquanto continua executando o resto do script

fs.readFile(path, 'utf-8', (err, data) => {
    if (err) {
        console.log(err)
        return
    }
    console.log(data)
})