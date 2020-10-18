# Exercício 017

from math import ceil
from math import floor

# Area a ser pintada
area_pintar = float(input("Área a ser pintada(m²): "))

# Litros de tinta necessários
litros_necessarios = area_pintar / 6

# Latas de tinta necessárias e seu gasto (R$ 80,00 por lata)
just1_latas = ceil(litros_necessarios / 18)
just1_gasto = just1_latas * 80

# Galões de tinta necessários e seu gasto (R$ 25,00)
just2_galoes = ceil(litros_necessarios / 3.6)
just2_gasto = just2_galoes * 25

# Galões e Latas compradas em conjunto
t_latas = floor(litros_necessarios / 18)
litros_restantes = litros_necessarios - (t_latas * 18)
t_galoes = ceil(litros_restantes / 3.6)
gasto_latas = t_latas * 80
gasto_galoes = t_galoes * 25
gasto_total = gasto_latas + gasto_galoes

# Exibição de resultados
print(f"Serão necessários {litros_necessarios} litros de tinta.\n")
print("Comprando apenas latas de 80 litros\n")
print(f"    Latas necessárias : {just1_latas}\n"
      f"    Valor gasto       : R$ {just1_gasto}\n")

print("Comprando apenas galões de 3.6 litros\n")
print(f"    Galões necessários : {just2_galoes}\n"
      f"    Valor gasto       : R$ {just2_gasto}\n")

print("Misturando latas e galões\n")
print(f"    Latas necessárias : {t_latas}\n"
      f"    Galões necessários: {t_galoes}\n"
      f"    Gasto latas       : R$ {gasto_latas}\n"
      f"    Gasto galoes      : R$ {gasto_galoes}\n"
      f"    Gasto total       : R$ {gasto_total}")

