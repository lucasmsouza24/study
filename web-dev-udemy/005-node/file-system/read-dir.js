const fs = require('fs')

// async (danger but recommended)
fs.readdir(__dirname, (err, files) => {
    if (err) console.log(err)
    files.forEach((item) => console.log(item))
})

// sync
const files = fs.readdirSync(__dirname)
files.forEach(item => console.log(item))