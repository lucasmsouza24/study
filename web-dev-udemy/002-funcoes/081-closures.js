// closure é o escopo criado quando uma função é declarada
// esse escopo permite a função acessar e manipular variáveis externas à função

// contexto lexico em ação

const x = 'Global'

const fora = function () {
	const x = 'Local'
	function dentro() {
		return x
	}
	return dentro
}

const myFunc = fora();
console.log(myFunc());