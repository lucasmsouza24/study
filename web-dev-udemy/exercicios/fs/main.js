let fs = require('fs');

fs.readFile('C:/_projetos/study/web-dev-udemy/exercicios/fs/dados.txt', 'utf-8', function (err, data) {
    if (err) {
        return console.log(err)
    }
    console.log(data)
})