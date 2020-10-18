// criando um forEach manualmente

Array.prototype.forEach2 = function (callback) {
    for (let i = 0; i < this.length; i++) {
        callback(this[i], i, this)
    }
}

const aprovados = ['Aghata', 'Isabella', 'Giovanna', 'Ana']
aprovados.forEach2(nome => console.log(nome))