// estratégia 1
function soma1(a, b, c) {
    a = a || 1;
    b = b || 1;
    c = c || 1;
}

// estratégia 2, 3 e 4
function soma2(a, b, c){
    a = a !== undefined ? a : 1;
    b = 1 in arguments ? b : 1;
    c = isNaN(c) ? 1 : c;
    return a + b + c;
}

// Valor padrão do ES2015
function soma3(a = 1, b = 1, c = 1) {
    return a + b + c;
}