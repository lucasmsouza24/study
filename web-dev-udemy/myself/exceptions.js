// estudando exceptions

//funcao que trata erros
const tratarErro = function(erro){
	console.log(erro instanceof ReferenceError)
	console.log(erro.name);
	console.log(erro.message);
	console.log("Nome do arquivo: " + erro.fileName)
	console.log("Linha: " + erro.lineNumber)
}

function imprimirNomeGritado(obj) {
	//tentativa de execução de um bloco de código
	try {
		console.log(obj.toUpperCase() + "!!!");
	} 

	//bloco executado apenas se ocorrer um erro na execução do bloco try
	catch(e){
		//captura erros, ótimo para chamar funções que tratam erros
		tratarErro(e);
	}
	//Bloco sempre executado, independente de falhas nos blocos anteriores (ótimo para fechar conexões com db, arquivos, etc)
	finally {
		console.log("Fim da funcao!")
	}
}

try {
	imprimirNomeGritado(12);
}
catch (e) {
	tratarErro(e);
}
finally {
	console.log("fim do programa")
}