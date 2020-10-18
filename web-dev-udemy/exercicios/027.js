const criancas = (height1, tax1, height2, tax2) => {
    if (height1 != height2) {
        if (height1 > height2 && tax1 < tax2) {
            ultrapassagem(height2, tax2, height1, tax1)
        } else if (height2 > height1 && tax2 < tax1 ){
            ultrapassagem(height1, tax1, height2, tax2) 
        } else {
            console.log("Não haverá ultrapassgem")
        }
    } else {console.log("Tamanhos iguais")}
}

const ultrapassagem = (c1, tax1, c2, tax2) => {
    let anos_passados = 0
    while(c1 < c2) {
        c1 += tax1
        c2 += tax2
        anos_passados++
    }
    console.log(`Ultrapassagem em ${anos_passados} anos.`)
}

criancas(1.6, 0.02, 1.8, 0.01)