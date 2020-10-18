# Exercício 004

soma = 0
for c in range(1,5):
    nota_temp = float(input(f'Digite a nota da {c}º prova:'))
    soma += nota_temp

media = soma /4
print("Sua média é", media)
