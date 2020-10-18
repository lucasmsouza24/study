# ex08
#variáveis
print("Valor a pagar:")
valor_pagar = int(input()) 
print("Valor pago:")
valor_pago = int(input()) 
troco = valor_pago - valor_pagar
notas_50 = 0
notas_20 = 0
notas_10 = 0
notas_5 = 0
notas_2 = 0
notas_1 = 0

while troco >= 50:
    notas_50 = notas_50 + 1
    troco = troco - 50

while troco >= 20:
    notas_20 = notas_20 + 1
    troco = troco - 20

while troco >= 10:
    notas_10 = notas_10 + 1
    troco = troco - 10

while troco >= 5:
    notas_5 = notas_5 + 1
    troco = troco - 5

while troco >= 2:
    notas_2 = notas_2 + 1
    troco = troco - 2

while troco >= 1:
    notas_1 = notas_1 + 1
    troco = troco - 1
print(f'notas de 50: {notas_50}\nnotas de 20: {notas_20}\n'
      f'notas de 10: {notas_10}\nnotas de 5: {notas_5}\n'
      f'notas de 2: {notas_2}\nnotas de 1: {notas_1}\n')
