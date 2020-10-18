# Exemplo

# Troco

troco_fixo = 9
troco = 9

notas_de_5 = 0
notas_de_2 = 0
notas_de_1 = 0

# Notas necessárias de 5

while troco >= 5:
    notas_de_5 = notas_de_5 + 1
    troco = troco - 5

# Notas necessárias de 2

while troco >= 2:
    notas_de_2 = notas_de_2 + 1
    troco = troco - 2

# Notas necessárias de 1

while troco >= 1:
    notas_de_1 = notas_de_5 + 1
    troco = troco - 1

print("Troco:", troco_fixo)
print("Notas de 5:", notas_de_5)
print("Notas de 2:", notas_de_2)
print("Notas de 1:", notas_de_1)
