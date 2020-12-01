// defining a promise
let p = new Promise(
    // the "resolve" function is returned when the promise is accept
    resolve => {
        resolve(['Ana', 'Bia', 'Carlos', 'Daniel']);
    }
);

function firstItem(array) {
    return array[0]
}

function firstLetter(string) {
    return string[0]
}

function lowerCase(charac) {
    return charac.toLowerCase()
}

// .then(arg => console.log(arg)) === .then(console.log)

p
    .then(arg => firstItem(arg)) // you can do it
    .then(firstLetter) // or it (simpliest)
    .then(lowerCase)
    .then(console.log)