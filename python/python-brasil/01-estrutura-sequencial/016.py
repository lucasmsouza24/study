# Exercício 016

from math import ceil 

# Area a ser pintada
area_pintar = float(input("Área a ser pintada(m²): "))

# Litros de tinta necessários
litros_necessarios = area_pintar / 3

# Latas de tinta necessárias 
latas = ceil(litros_necessarios / 18)

# Valor gasto (cada lata custa R$ 80,00)
gasto = latas * 80

print(f"Litros necessários: {litros_necessarios}\n"
      f"Latas necessárias : {latas}\n"
      f"Valor gasto       : R$ {float(gasto)}")
