const axios = require('axios')
const url = "http://files.cod3r.com.br/curso-js/funcionarios.json"

axios.get(url).then(response => {
    const funcionarios = response.data
    const womans = funcionarios.filter(element => element.genero === 'F')
    const chineses = womans.filter(element => element.pais === 'China')
    const sal_min = chineses.reduce((acc, crr) => {
        if (crr.salario < acc.salario) acc.salario = crr.salario
        return acc
    })
    console.log(sal_min)
})
