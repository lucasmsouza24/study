// modelo param should to be a string
let analiseCarro = (modelo) => {
    switch (modelo){
        case "hatch":
            return "Compra efetuada com sucesso"
        case "sedan": case "motocicleta": case "caminhonete":
            return "Tem certeza que não prefere este modelo?"
        default:
            return "Não trabalhamos com esse tipo de automóvel aqui!"
    }
}

console.log(analiseCarro("hatch"))