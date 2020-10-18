// fruta param should to be a fruit string
let analiseFruta = (fruta) => {
    switch(fruta){
        case "maçã":
            return "Não vendemos essa fruta aqui"
        case "kiwi":
            return "Estamos com escassez de kiwis"
        case "melancia":
            return "Aqui está, são 3 reais o quilo"
        default:
            return "Fruta desconhecida"
    }
}

console.log(analiseFruta("pêssego"))