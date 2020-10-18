const aprovados = ['Aghata', 'Isabella', 'Giovanna', 'Ana']
const idades = [19, 5, 67, 2, 30]

// forEach percorre um array e executa uma função para cara elemento
aprovados.forEach(nome => console.log(nome))

idades.forEach(idade => idade >= 18 ? console.log(idade, "maior") : console.log(idade, "menor"))