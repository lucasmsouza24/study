# Exercício 015

# Salário por hora
salary_hour = float(input("Dinheiro ganho por hora: "))
# Horas trabalhadas por mês
hours_month = float(input("Horas trabalhadas por mês: "))

# Cálculo do salário bruto
gross_salary = salary_hour * hours_month

# Cálculo do INSS
inss = gross_salary * 0.08

# Cálculo do valor pago ao sindicato (0.05)
sindicate = gross_salary * 0.5

# Cálculo do imposto de renda (0.11)
ir = gross_salary * 0.11

# Cálculo dos descontos
discounts = inss + sindicate + ir

# Cálculo do salário liquido
net_salary = gross_salary - discounts

print(f"+ Salário Bruto:        {gross_salary} R$\n"
      f"- IR             (11%): {ir} R$\n"
      f"- INSS           (8%) : {inss} R$\n"
      f"- Sindicato      (5%) : {sindicate} R$\n"
      f"= Salário Liquido     : {net_salary} R$\n")
print(f'Todos os descontos: {discounts}')
