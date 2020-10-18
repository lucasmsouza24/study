# ex 04

#variáveis

print("Nome do vendedor:")
nome_vend = input()

print("Salário fixo:")
salario_fixo = float(input())

print("Total de vendas:")
total_vendas = float(input())

print("Comissão (%):")
comissao_percent = float(input())

# valor ganho na comissão
comissao = total_vendas * (comissao_percent/100)

# salário total
salario_total = salario_fixo + comissao

print("Salário total:", salario_total)
