'''lista = [1, 2, 3, 5, 3]

num = int(input("Digite um número: ")) 
resultado = 0 

for c in :
    if c == num:
        resultado = resultado + 1

if resultado == 0:
    print("O número nao está na lista")
else:
    print("O número está na lista!")

print(resultado)
'''


import random
'''
matriz = [[],[],[],[]]
for l in range(0, 7):
    for c in range(0, 4):
        matriz[l][c] = random.randint(0,28)
'''

matriz = []
for l in range(0, 7):
    linha = []
    for c in range(0, 4):
        linha.append('')

    matriz.append(linha)

for c in matriz:
    print(c)
