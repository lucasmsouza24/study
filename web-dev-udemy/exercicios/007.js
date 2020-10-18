// formula de bhaskara

const bha = (a, b, c) => {
    let delta = b * b - (4 * a * c)
    if (delta < 0) {
        return "Delta é negativo"
    } else {
        let x1 = (-b + Math.sqrt(delta)) / 2 * a
        let x2 = (-b - Math.sqrt(delta)) / 2 * a
        return [x1, x2]
    }
}

console.log(bha(1, -1, -6))