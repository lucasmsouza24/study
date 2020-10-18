function area(altura, largura){
    const area = altura * largura;
    if (area > 20) {
        console.log(`Valor acima do permitido: ${area}m²`);
    } else {
        return area;
    }
}

console.log(area(2, 4))
console.log(area(2))
console.log(area())
console.log(area(2, 3, 4, 5, 6, 7))
console.log(area(10, 10))