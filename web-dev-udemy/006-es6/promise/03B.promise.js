// simplest version of 03-promise.js code

const firstItemOrCharac = item => item[0]
const toLower = string => string.toLowerCase()

new Promise(function (resolve) {
    resolve(
        ['Ana', 'Bia', 'Carlos', 'Daniel']
    )
}).then(firstItemOrCharac)
  .then(firstItemOrCharac)
  .then(toLower)
  .then(console.log)