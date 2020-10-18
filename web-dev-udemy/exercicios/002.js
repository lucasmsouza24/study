const isTriangulo = function(a, b, c) {
    let condicoes = 0;
    if (Math.abs(b - c) < a && a < b + c){
        condicoes++;
    }
    if (Math.abs(a - c) < b && b < a + c){
        condicoes++;
    }
    if (Math.abs(a - b) < c && c < a + b) {
        condicoes++;
    }
    if (condicoes == 3) {
        return true;
    } else {
        return false;
    }
}

const typeofTriangulo = function(a, b, c){
    if (isTriangulo(a, b, c)) {
        if (a == b && b == c) {
            return "equilatero";
        }
        else if (a == b || b == c || c == a){
            return "isoceles";
        }
        else {
            return "escaleno";
        }
    }
}

console.log(typeofTriangulo(2, 2, 2))
console.log(typeofTriangulo(2, 3, 3))
console.log(typeofTriangulo(2, 3, 4))