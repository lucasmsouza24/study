from random import randint

# construção de matrizes 1, 2 e 3
matriz1 = list()
matriz2 = list()
matriz3 = list()

for l in range(0, 7):
    linha1 = []
    linha2 = []
    linha3 = []
    for c in range(0, 4):
        linha1.append(randint(0, 10))
        linha2.append(randint(0, 10))
        linha3.append(linha1[c] + linha2[c])
    matriz1.append(linha1)
    matriz2.append(linha2)
    matriz3.append(linha3)

# Exibição de matrizes
print("     Matriz 1")
for c in matriz1:
    print(c)

print("-" * 20)

print("     Matriz 2")
for c in matriz2:
    print(c)

print("-" * 20)

print("     Matriz 3")
for c in matriz3:
    print(c)
