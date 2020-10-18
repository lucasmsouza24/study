# ex 03

#variáveis
print("Nome do funcionário:")
nome_func = input()
print("Horas trabalhadas")
horas_trab = float(input())
print("Valor que recebe por hora:")
valor_hora = float(input())
print("Quantidade de filhos")
quant_filhos = int(input())

# Salário (horas trabalhadas * valor da hora)
salario = horas_trab * valor_hora

# Aumento adicional por filho (3% do salário) * quantidade de filhos

aumento = salario * 0.03 * quant_filhos

# salario bruto (salário + aumento)

salario_final = salario + aumento 
 
print("Salario final:", salario_final)
