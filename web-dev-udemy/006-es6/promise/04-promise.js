function waitFor(time = 2000) {
    return new Promise(function (resolve) {
        setTimeout(function () {
            console.log('Timeout')
            resolve('Vishh')
        }, time)
    })
}

waitFor(3000).then()