function getRandomNum(min, max, time) {
    if (min > max) [max, min] = [min, max]
    return new Promise(resolve => {
        setTimeout(function() {
            const factor = max - min + 1
            const random = parseInt(Math.random() * factor) + min
            resolve(random)
        }, time)
    })
}

function getVariuousNumbers() {
    return Promise.all([
        getRandomNum(1, 60, 4000),
        getRandomNum(1, 60, 500),
        getRandomNum(1, 60, 3000),
        getRandomNum(1, 60, 1000),
        getRandomNum(1, 60, 2000)
    ])
}

getVariuousNumbers().then(console.log)