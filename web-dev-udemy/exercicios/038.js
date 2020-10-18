const myFunc = (min=0, max=100) => {

    // ordering params
    if (min > max) {
        let temp
        temp = min
        min = max
        max = temp
    }

    // log odds values between min and max
    for (let i = min; i <= max; i++) {
        if (i % 2 !== 0) {
            console.log(i)
        }
    }
}

myFunc(12, 3)