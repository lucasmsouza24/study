const fs = require('fs');

// const read = new Promise(function (resolve) {
//     fs.readFile('C:/_projetos/study/web-dev-udemy/006-es6/promise/dados.txt', 'utf-8', function (err, data) {
//         if (err) {
//             resolve(err)
//         }
//         resolve(data) 
//     })
// })

// read.then(console.log)

// let content = '_'

const file = new Promise(function(resolve) {
    fs.readFile('C:/_projetos/study/web-dev-udemy/006-es6/promise/dados.txt', 'utf-8', function (err, data) {
        if (err) {
            return err
        } else {
            resolve(data.toString())
        }
    })
})

file.then( data => {
    content = data
})

// setTimeout(function (){
//     console.log(content)
// }, 1000)