#ex 05

print("Nome do piloto:")
nome = input()

print("Distância percorrida (km):")
delta_s = float(input())

print("Tempo para percorrer percurso (h):")
delta_t = float(input())

vm = delta_s / delta_t

print("A velocidade média do", nome, "foi", vm, "km/h")
