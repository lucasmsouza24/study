arquivo = float(input("Tamanho do arquivo (MB):"))
velocidade = float(input("Velocidade do download (Mbps)"))
peso_arquivo = arquivo * 8
tempo = peso_arquivo / velocidade
print(f"Tempo aproximado de download: {tempo:.2f} segundos")
