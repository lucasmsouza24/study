const getMonthName = function(month_num){
	month_num--;
	let month_name = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Ago", "Sep", "Nov", "Dec"];

	if(month_name[month_num]){
		return month_name[month_num]
	} else {
		/*throw "InvalidMonthNo"*/
	}
}

function logMyErrors(error) {
	console.log(error.name)
	console.log(error.message)
}

/*try {
	console.log(getMonthName(-1))
}*/

try { // statements to try
  monthName = getMonthName(30); // função poderia lançar uma exceção
}
catch (e) {
  monthName = "unknown";
  logMyErrors(e); // passa a exceção para o manipulador de erro -> sua função local.
}