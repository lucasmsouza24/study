const fs = require('fs')

content = 'Primeira linha\nsegunda linha, \núltima linha!'
// fs.writeFile(path + filename, string(content), callback(err))
fs.writeFile(__dirname + '/new.txt', content, err => console.log(err || 'Arquivo salvo com sucesso!'))

// criando um JSON file
// const obj = {
//     nome: "Lucas",
//     idade: 19,
//     feio: true
// }
// fs.writeFile(__dirname + '/file2.json', JSON.stringify(obj), err => console.log(err || 'Arquivo salvo!'))