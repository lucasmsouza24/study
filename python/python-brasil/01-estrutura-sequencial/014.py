# Exercício 014

weight_fish = float(input("Digite o peso do peixe: "))
if weight_fish <= 50:
    excess = 0
else:
    excess = weight_fish - 50

penalty = excess * 4

print(f"peso excedente: {excess}\n"
      f"Valor da multa: {penalty}")
