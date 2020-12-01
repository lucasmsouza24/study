// callback hell
setTimeout(function() {
    console.log('Timeout...')

    setInterval(function() {
        console.log('Interval 1')

        setInterval(function() {
            console.log('Interval 2')
        }, 1000)
    }, 3000)
}, 2000)