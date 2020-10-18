# Lucas Mesquita

matriz = []

print("Matriz 7x4")
print("Digite número inteiro para a posição:")

# Construção de matriz vazia para análise
for l in range(0, 7, 1):
    linha = []
    for c in range(0, 4, 1):
        linha.append('')
    matriz.append(linha)

# Adicionando valores à matriz
for l in range(0, 7, 1):
    for c in range(0, 4, 1):
#       descobrindo se o número escolhido existe na matriz
        num_existe = 1
        while num_existe != 0:
            num_existe = 0
            print("Posição [",l,"][",c,"]")
#           Entrada de valor para análise
            num = int(input())
            for al in range(0, 7, 1):
                for ac in range(0, 4, 1):
                    if num == matriz[al][ac]:
                        num_existe = num_existe + 1
#           Condição para o número poder entrar na matriz
            if num_existe == 0:
                matriz[l][c] = num
#           Calculando o menor número
                if l == 0:
                    if c == 0:
                        menor = num
                else:
                    if num < menor:
                        menor = num
            else:
                print("valor já existente na matriz. Digite outro número.")

# Exibição de resultados
for c in range(0, 7, 1):
    print(matriz[c]) 

print("Menor valor na matriz:", menor)

